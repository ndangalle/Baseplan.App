using MobileUI.Core.Ioc;
using MobileUI.View;

using Xamarin.Forms;

namespace MobileUI
{
    public partial class App : Application
	{
        public static Locator IOCLocator { get; set; }
        public App ()
		{
			InitializeComponent();

            var locator = new Locator();
            IOCLocator = locator;
            MainPage = new ContractsPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
