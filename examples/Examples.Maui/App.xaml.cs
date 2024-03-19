using Examples.Maui.PageModels;
using Xamvvm;
using Xamvvm.Maui.Extensions;
using Xamvvm.Maui.Factory;

namespace Examples.Maui
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var factory = new XamvvmMauiFactory(this);
			factory.RegisterNavigationPage<MainNavigationPageModel>(() => this.GetPageFromCache<MainPageModel>());
			XamvvmCore.SetCurrentFactory(factory);
			MainPage = this.GetPageFromCache<MainNavigationPageModel>() as NavigationPage;
		}
	}
}
