using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KRSServerApplication.Models;

namespace KRSClientApplication.Proxy
{
    public class ConfigurationProxy
    {
        ResponseWriter responseWriter;
        ResponseReader responseReader;
        HttpClient httpClient;

        public ConfigurationProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:9000");
            responseWriter = new ResponseWriter();
            responseReader = new ResponseReader();
        }

        public async Task<IEnumerable<Configuration>> GetConfigurations()
        {
            var configurationResponse = await httpClient.GetAsync("/api/configurations/get");
            var configurations = await responseReader.ReadArrayAsync<Configuration>(configurationResponse);
            return configurations;
        }
    }
}
