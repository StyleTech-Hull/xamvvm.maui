using System.Windows.Input;
using Xamvvm;

namespace Examples.Maui.PageModels
{
	public class SampleFlyoutMenuPageModel : BasePageModel
	{
		public SampleFlyoutMenuPageModel()
		{
			Page1Command = new BaseCommand((arg) =>
			{
				var page = this.GetPageFromCache<DemoListViewPageModel>();

				var masterDetailPage = this.GetPageFromCache<SampleFlyoutPageModel>();
				masterDetailPage.GetPageModel().SetDetail(page);
			});

			Page2Command = new BaseCommand((arg) =>
			{
				var page = this.GetPageFromCache<DetailPageModel>();
				page.GetPageModel().Init("detail!", Colors.Red);

				var masterDetailPage = this.GetPageFromCache<SampleFlyoutPageModel>();
				masterDetailPage.GetPageModel().SetDetail(page);
			});
		}

		public ICommand Page1Command { get; set; }

		public ICommand Page2Command { get; set; }
	}
}
