using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using MobileUI.Core.Interfaces;
using MobileUI.Core.Services;
using MobileUI.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileUI.Core.Ioc
{
    public class Locator
    {
        private UnityContainer container;

        public Locator()
        {
            container = new UnityContainer();
            container.RegisterType<IDataService, ContractService>();
            container.RegisterType<ContractsPageViewModel>(new ContainerControlledLifetimeManager());

            var serviceLocator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => serviceLocator); 
        }

        public ContractsPageViewModel ViewModel
        {
            get
            {
                return container.Resolve<ContractsPageViewModel>();
            }
        }
    }
}
