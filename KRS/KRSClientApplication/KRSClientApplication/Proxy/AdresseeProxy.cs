using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KRSServerApplication.Models;

namespace KRSClientApplication.Proxy
{
    public class AdresseeProxy
    {
        ResponseWriter responseWriter;
        ResponseReader responseReader;
        HttpClient httpClient;

        public AdresseeProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:9000");
            responseWriter = new ResponseWriter();
            responseReader = new ResponseReader();
        }

        public async Task<IEnumerable<Adressee>> GetAdressees()
        {
            var adresseeResponse = await httpClient.GetAsync("/api/adressees/get");
            var adressees = await responseReader.ReadArrayAsync<Adressee>(adresseeResponse);
            return adressees;
        }
    }
}
