using System.Reflection;
using ReactiveUI;
using Xamvvm.Maui.Factory;

namespace Xamvvm.Maui.RxUI
{
	public class XamvvmMauiRxUiFactory : XamvvmMauiFactory
	{
		public XamvvmMauiRxUiFactory(Application appInstance, int maxPageCacheItems = 6, bool automaticAssembliesDiscovery = true, params Assembly[] additionalPagesAssemblies) : base(appInstance, maxPageCacheItems, automaticAssembliesDiscovery, additionalPagesAssemblies)
		{
		}

		public override void SetPageModel<TPageModel>(IBasePage<TPageModel> page, TPageModel newPageModel)
		{
			base.SetPageModel(page, newPageModel);

			var rxPage = page as IViewFor<TPageModel>;
			if (rxPage != null)
			{
			   rxPage.ViewModel = newPageModel;
			}
		}
	}
}
