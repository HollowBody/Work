using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KRSServerApplication.Models;

namespace KRSClientApplication.Proxy
{
    public class SkinTypeProxy
    {
        ResponseWriter responseWriter;
        ResponseReader responseReader;
        HttpClient httpClient;

        public SkinTypeProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:9000");
            responseWriter = new ResponseWriter();
            responseReader = new ResponseReader();
        }

        public async Task<IEnumerable<SkinType>> GetSkinTypes()
        {
            var skinTypeResponse = await httpClient.GetAsync("/api/skintypes/get");
            var skinTypes = await responseReader.ReadArrayAsync<SkinType>(skinTypeResponse);
            return skinTypes;
        }
        public SkinType AddSkinType(SkinType skinType)
        {
            var content = responseWriter.WriteObject(skinType);
            var response = httpClient.PostAsync("/api/skintypes/post", content).GetAwaiter().GetResult();
            var code = response.StatusCode;
            var result = responseReader.ReadObjectAsync<SkinType>(response).GetAwaiter().GetResult();
            if (code == (HttpStatusCode)200)
            {
                return result;
            }
            return null;
        }
    }
}
