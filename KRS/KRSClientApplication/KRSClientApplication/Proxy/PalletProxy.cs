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
    class PalletProxy
    {
        ResponseWriter responseWriter;
        ResponseReader responseReader;
        HttpClient httpClient;

        public PalletProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:9000");
            responseWriter = new ResponseWriter();
            responseReader = new ResponseReader();
        }

        public IEnumerable<Pallet> GetPallets()
        {
            var palletResponse = httpClient.GetAsync("/api/pallets/get").GetAwaiter().GetResult();
            var pallets = responseReader.ReadArrayAsync<Pallet>(palletResponse).GetAwaiter().GetResult();
            return pallets;
        }

        public IEnumerable<Pallet> GetPalletsWithStatus(string status)
        {
            var palletResponse = httpClient.GetAsync("/api/pallets/getwithstatus/" + status).GetAwaiter().GetResult();
            var pallets = responseReader.ReadArrayAsync<Pallet>(palletResponse).GetAwaiter().GetResult();
            return pallets;
        }

        public Pallet ChangePallets(Pallet pallet)
        {
            var context = responseWriter.WriteObject(pallet);
            var palletResponse = httpClient.PutAsync("/api/pallets/put", context).GetAwaiter().GetResult();
            var result = responseReader.ReadObjectAsync<Pallet>(palletResponse).GetAwaiter().GetResult();
            var code = palletResponse.StatusCode;
            if (code.ToString() == "200")
            {
                return result;
            }
            return null;
        }

        public async Task<Pallet> AddPallet(Pallet pallet)
        {
            var content = responseWriter.WriteObject(pallet);
            var response = await httpClient.PostAsync("/api/pallets/post", content);
            var code = response.StatusCode;
            var result = await responseReader.ReadObjectAsync<Pallet>(response);
            if (code == (HttpStatusCode)200)
            {
                return result;
            }
            return null;
        }
    }
}
