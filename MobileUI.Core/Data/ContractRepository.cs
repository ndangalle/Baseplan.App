using MobileUI.Core.Interfaces;
using MobileUI.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace MobileUI.Core.Data
{
    public class ContractRepository : IRepository
    {
        public async Task<ObservableCollection<Contract>> GetData()
        {
            var url = string.Format("http://10.50.192.159:49621/bemapi/v1/HireContracts/UndeliveredLines/ByContractId?contractId={0}&deliveryDocketId={1}", 3257893, null);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var response = await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            var JsonResult = response.Content.ReadAsStringAsync().Result;
            var results = JsonConvert.DeserializeObject<ObservableCollection<Contract>>(JsonResult);
            return results;
        }
    }
}
