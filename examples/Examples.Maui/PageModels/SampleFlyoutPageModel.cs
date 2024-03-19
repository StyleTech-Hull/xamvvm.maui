using Xamvvm;

namespace Examples.Maui.PageModels
{
	public class SampleFlyoutPageModel : BasePageModel
	{
		public SampleFlyoutPageModel()
		{
		}

		public void SetDetail<TPageModel>(IBasePage<TPageModel> page) where TPageModel : class, IBasePageModel
		{
			var flyoutPage = this.GetCurrentPage() as FlyoutPage;
			flyoutPage.Detail = new NavigationPage(page as Page);
			flyoutPage.IsPresented = false;
		}
	}
}
