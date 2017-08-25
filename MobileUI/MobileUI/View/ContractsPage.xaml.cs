
using MobileUI.Core.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileUI.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContractsPage : ContentPage
	{
        ContractsPageViewModel vm;

        public ContractsPage()
        {
            this.vm = App.IOCLocator.ViewModel;
            BindingContext = this.vm;
            InitializeComponent();
        }

        private void NewHireList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Message Alert1", vm.ItemSelected.description, "OK");
        }
    }
}