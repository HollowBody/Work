using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KRSServerApplication.Models;

namespace KRSClientApplication.Proxy
{
    class SortingProxy
    {
        ResponseWriter responseWriter;
        ResponseReader responseReader;
        HttpClient httpClient;

        public SortingProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:9000");
            responseWriter = new ResponseWriter();
            responseReader = new ResponseReader();
        }

        public async Task<IEnumerable<SortingSelect>> GetAllSkins(string batchNumber)
        {
            var sortingSkinsInformationResponse = await httpClient.GetAsync("/api/sorting/getcurrentbatchesskins/" + batchNumber);
            var sorting = await responseReader.ReadArrayAsync<SortingSelect>(sortingSkinsInformationResponse);
            return sorting;
        }

        public IEnumerable<int> GetConfigurationTypeSkin(decimal weight, int idconfiguration)
        {
            var typeSkinResponse = httpClient.GetAsync("/api/sorting/getconfigurationtypeskin/" + weight + "," + idconfiguration).GetAwaiter().GetResult();
            var typeSkinNumber = responseReader.ReadArrayAsync<int>(typeSkinResponse).GetAwaiter().GetResult();
            return typeSkinNumber;
        }

        public async Task<IEnumerable<int>> GetTypeSkinPallet(int idTypeSkin)
        {
            var palletResponse = await httpClient.GetAsync("/api/sorting/gettypeskinpallet/" + idTypeSkin);
            var palletNumber = await responseReader.ReadArrayAsync<int>(palletResponse);
            return palletNumber;
        }

        public async Task<IEnumerable<int>> GetSchemeID(string batchNumber)
        {
            var schemeResponse = await httpClient.GetAsync("/api/sorting/getschemeid/" + batchNumber);
            var schemeNumbers = await responseReader.ReadArrayAsync<int>(schemeResponse);
            return schemeNumbers;
        }

        public async Task<IEnumerable<int>> GetEnabledTypeSkins(string IDScheme)
        {
            var enabledTypeSkinsResponse = await httpClient.GetAsync("/api/sorting/getenabledtypeskins/" + IDScheme);
            var enabledNumbers = await responseReader.ReadArrayAsync<int>(enabledTypeSkinsResponse);
            return enabledNumbers;
        }

        public async Task<IEnumerable<int>> GetPalletCountSkins(string IDPallet)
        {
            var palletCountSkinsResponse = await httpClient.GetAsync("/api/sorting/getpalletcountskins/" + IDPallet);
            var palletCountSkins = await responseReader.ReadArrayAsync<int>(palletCountSkinsResponse);
            return palletCountSkins;
        }

        public async Task<IEnumerable<int>> GetMaxCountSkins(string IDTypeSkin)
        {
            var maxCountSkinsResponse = await httpClient.GetAsync("/api/sorting/getmaxcountskins/" + IDTypeSkin);
            var maxCountSkins = await responseReader.ReadArrayAsync<int>(maxCountSkinsResponse);
            return maxCountSkins;
        }

        public async Task<IEnumerable<DateTime>> GetPalletOpeningDate(string IDPallet)
        {
            var palletOpeningDateResponse = await httpClient.GetAsync("/api/sorting/getpalletopeningdate/" + IDPallet);
            var palletOpeningDate = await responseReader.ReadArrayAsync<DateTime>(palletOpeningDateResponse);
            return palletOpeningDate;
        }


        public async Task<IEnumerable<int>> GetConfigurationID(string ConfigName)
        {
            var ConfigurationIDResponse = await httpClient.GetAsync("/api/sorting/getconfigurationid/" + ConfigName);
            var ConfigurationID = await responseReader.ReadArrayAsync<int>(ConfigurationIDResponse);
            return ConfigurationID;
        }

        public async Task<IEnumerable<Batch>> GetBatch(string batchNumber)
        {
            var batchResponse = await httpClient.GetAsync("/api/sorting/getbatch/" + batchNumber);
            var batch = await responseReader.ReadArrayAsync<Batch>(batchResponse);
            return batch;
        }

        public Batch ChangeBatch(Batch batch)
        {
            var context = responseWriter.WriteObject(batch);
            var batchResponse = httpClient.PutAsync("/api/batches/put", context).GetAwaiter().GetResult();
            var result = responseReader.ReadObjectAsync<Batch>(batchResponse).GetAwaiter().GetResult();
            var code = batchResponse.StatusCode;
            if (code.ToString() == "200")
            {
                return result;
            }
            return null;
        }
    }
}
