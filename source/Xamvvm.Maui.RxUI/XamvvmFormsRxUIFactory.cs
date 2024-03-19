using System.Reflection;

namespace Xamvvm.Maui.RxUI
{
	public class XamvvmFormsRxUIFactory : XamvvmMauiRxUiFactory
	{
		/// <inheritdoc />
		public XamvvmFormsRxUIFactory(Application appInstance, int maxPageCacheItems = 6, bool automaticAssembliesDiscovery = true, params Assembly[] additionalPagesAssemblies) : base(appInstance, maxPageCacheItems, automaticAssembliesDiscovery, additionalPagesAssemblies)
		{
		}
	}
}
