using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KRSServerApplication.Models;

namespace KRSClientApplication.Proxy
{
    public class SchemeProxy
    {
        ResponseWriter responseWriter;
        ResponseReader responseReader;
        HttpClient httpClient;

        public SchemeProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:9000");
            responseWriter = new ResponseWriter();
            responseReader = new ResponseReader();
        }

        public async Task<IEnumerable<SortingScheme>> GetSchemes()
        {
            var schemeResponse = await httpClient.GetAsync("/api/sortingschemes/get");
            var schemes = await responseReader.ReadArrayAsync<SortingScheme>(schemeResponse);
            return schemes;
        }
    }
}
