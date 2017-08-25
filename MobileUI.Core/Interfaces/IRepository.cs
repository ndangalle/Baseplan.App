using MobileUI.Core.Model;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MobileUI.Core.Interfaces
{
    public interface IRepository
    {
        Task<ObservableCollection<Contract>> GetData();
    }
}
