using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KRSServerApplication.Models;

namespace KRSClientApplication.Proxy
{
    public class ProviderProxy
    {
        ResponseWriter responseWriter;
        ResponseReader responseReader;
        HttpClient httpClient;

        public ProviderProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:9000");
            responseWriter = new ResponseWriter();
            responseReader = new ResponseReader();
        }

        public async Task<IEnumerable<ProviderSelect>> GetSelectedProvider()
        {
            var providerSelectResponse = await httpClient.GetAsync("/api/registration/getproviders");
            var providers = await responseReader.ReadArrayAsync<ProviderSelect>(providerSelectResponse);
            return providers;
        }

        public async Task<IEnumerable<Provider>> GetAllProviders()
        {
            var providerResponse = await httpClient.GetAsync("/api/providers/getall");
            var allProviders = await responseReader.ReadArrayAsync<Provider>(providerResponse);
            return allProviders;
        }
    }
}
