namespace Xamvvm
{
	public class BaseMasterDetailPage<TPageModel> : FlyoutPage, IBasePage<TPageModel> where TPageModel : class, IBasePageModel
	{
	}
}
