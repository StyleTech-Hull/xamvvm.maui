using Examples.Maui.RxUI.PageModels;
using Xamvvm;
using Xamvvm.Maui.RxUI;

namespace Examples.Maui.RxUI
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			var factory = new XamvvmFormsRxUIFactory(this);
			XamvvmCore.SetCurrentFactory(factory);

			MainPage = Xamvvm.Maui.Extensions.ApplicationExtensions.GetPageFromCache<DemoListViewPageModel>(this) as Page;
		}
	}
}
