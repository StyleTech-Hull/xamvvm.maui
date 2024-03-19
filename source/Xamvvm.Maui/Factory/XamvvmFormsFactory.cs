using System.Reflection;

namespace Xamvvm.Maui.Factory
{
	public class XamvvmFormsFactory : XamvvmMauiFactory
	{
		/// <inheritdoc />
		public XamvvmFormsFactory(Application appInstance, int maxPageCacheItems = 6, bool automaticAssembliesDiscovery = true, params Assembly[] additionalPagesAssemblies) : base(appInstance, maxPageCacheItems, automaticAssembliesDiscovery, additionalPagesAssemblies)
		{
		}
	}
}
