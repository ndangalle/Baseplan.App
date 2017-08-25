using MobileUI.Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileUI.Core.Interfaces
{
    public interface IDataService
    {
        Task<ObservableCollection<Contract>> GetContracts();
    }
}
