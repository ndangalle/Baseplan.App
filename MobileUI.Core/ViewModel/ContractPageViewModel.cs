using MobileUI.Core.Interfaces;
using MobileUI.Core.Model;
using MobileUI.Core.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MobileUI.Core.ViewModel
{
    public class ContractsPageViewModel : INotifyPropertyChanged
    {
        private IDataService dataService;
        public ContractsPageViewModel(IDataService dataService)
        {
            this.dataService = dataService;

            //dataService = new ContractService();
            GetContracts();
        }

        private async void GetContracts()
        {
            var results = await dataService.GetContracts();
            this.Contracts = results;
        }

        private ObservableCollection<Contract> contracts;
        public ObservableCollection<Contract> Contracts
        {
            get
            {
                return contracts;
            }

            set
            {
                contracts = value;
                NotifyPropertyChanged("Contracts");
            }
        }

        private Contract itemSelected;

        public Contract ItemSelected
        {
            get { return itemSelected; }
            set
            {
                itemSelected = value;
                NotifyPropertyChanged("ItemSelected");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
