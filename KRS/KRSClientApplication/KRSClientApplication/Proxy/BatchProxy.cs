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

    public class BatchProxy
    {
        ResponseWriter responseWriter;
        ResponseReader responseReader;
        HttpClient httpClient;

        public BatchProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:9000");
            responseWriter = new ResponseWriter();
            responseReader = new ResponseReader();
        }

        public IEnumerable<Batch> GetBatches()
        {
            var batchesResponse = httpClient.GetAsync("/api/batches/get").GetAwaiter().GetResult();
            var batches = responseReader.ReadArrayAsync<Batch>(batchesResponse).GetAwaiter().GetResult();
            return batches;
        }
        public IEnumerable<int> GetOpenBatches()
        {
            var batchResponse = httpClient.GetAsync("/api/sorting/getopenbatches").GetAwaiter().GetResult();
            var batchNumbers = responseReader.ReadArrayAsync<int>(batchResponse).GetAwaiter().GetResult();
            return batchNumbers;
        }

        public async Task<IEnumerable<DateTime>> GetBatchesOpeningDate(string IDbatch)
        {
            var batchOpeningDateResponse = await httpClient.GetAsync("/api/batches/getbatchopeningdate/" + IDbatch);
            var batchOpeningDate = await responseReader.ReadArrayAsync<DateTime>(batchOpeningDateResponse);
            return batchOpeningDate;
        }

        public async Task<IEnumerable<int>> GetBatchesDebitCount(string IDbatch)
        {
            var batchDebitCountResponse = await httpClient.GetAsync("/api/batches/getbatchdebitcount/" + IDbatch);
            var batchDebitCount = await responseReader.ReadArrayAsync<int>(batchDebitCountResponse);
            return batchDebitCount;
        }

        public async Task<IEnumerable<int>> GetBatchesProviderId(string IDbatch)
        {
            var batchProviderIDResponse = await httpClient.GetAsync("/api/batches/getbatchproviderid/" + IDbatch);
            var batchProviderID = await responseReader.ReadArrayAsync<int>(batchProviderIDResponse);
            return batchProviderID;
        }
        public async Task<IEnumerable<int>> GetOpenBatchesAsync()
        {
            var batchResponse = await httpClient.GetAsync("/api/sorting/getopenbatches");
            var batchNumbers = await responseReader.ReadArrayAsync<int>(batchResponse);
            return batchNumbers;
        }

        public Batch AddBatch(Batch batch)
        {
            var content = responseWriter.WriteObject(batch);
            var response = httpClient.PostAsync("/api/batches/post",content).GetAwaiter().GetResult();
            var code = response.StatusCode;
            var result = responseReader.ReadObjectAsync<Batch>(response).GetAwaiter().GetResult();
            if (code == (HttpStatusCode)200)
            {
                return result;
            }
            return null;
        }

    }
}
