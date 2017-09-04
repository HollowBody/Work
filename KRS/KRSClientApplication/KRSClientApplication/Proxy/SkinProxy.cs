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
    class SkinProxy
    {
        ResponseWriter responseWriter;
        ResponseReader responseReader;
        HttpClient httpClient;

        public SkinProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:9000");
            responseWriter = new ResponseWriter();
            responseReader = new ResponseReader();
        }

        public IEnumerable<Skin> GetSkins()
        {
            var skinResponse = httpClient.GetAsync("/api/skins/get").GetAwaiter().GetResult();
            var skins = responseReader.ReadArrayAsync<Skin>(skinResponse).GetAwaiter().GetResult();
            return skins;
        }

        public async Task<Skin> GetSkin(string skinNumber)
        {
            var skinResponse = await httpClient.GetAsync("/api/skins/get/" + skinNumber);
            var skins = await responseReader.ReadObjectAsync<Skin>(skinResponse);
            return skins;
        }

        public Skin AddSkin(Skin skin)
        {
            var content = responseWriter.WriteObject(skin);
            var response = httpClient.PostAsync("/api/skins/post", content).GetAwaiter().GetResult();
            var code = response.StatusCode;
            var result = responseReader.ReadObjectAsync<Skin>(response).GetAwaiter().GetResult();
            if (code == (HttpStatusCode)200)
            {
                return result;
            }
            return null;
        }

        public async Task<Skin> GetLastSkin()
        {
            var skinResponse = await httpClient.GetAsync("/api/skins/getlast/");
            var skins = await responseReader.ReadObjectAsync<Skin>(skinResponse);
            return skins;
        }

        public async Task DeleteSkin(string IDSskin)
        {
            var skinResponse = await httpClient.DeleteAsync("/api/skins/delete/" + IDSskin);
        }
    }
}
