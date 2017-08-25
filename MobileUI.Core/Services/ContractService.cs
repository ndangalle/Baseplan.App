using MobileUI.Core.Data;
using MobileUI.Core.Interfaces;
using MobileUI.Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileUI.Core.Services
{
    public class ContractService : IDataService
    {
        public async Task<ObservableCollection<Contract>> GetContracts()
        {
            var repo = new ContractRepository();
            var results = await repo.GetData();
            return results;
        }
    }
}
