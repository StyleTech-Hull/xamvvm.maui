using Examples.Maui.PageModels;
using Xamvvm;

namespace Examples.Maui.Pages
{
	public class SampleFlyoutPage : FlyoutPage, IBasePage<SampleFlyoutPageModel>
	{
		public SampleFlyoutPage()
		{
			Flyout = this.GetPageFromCache<SampleFlyoutMenuPageModel>() as Page;
			Detail = new NavigationPage(this.GetPageFromCache<DetailPageModel>() as Page);
		}
	}
}
