using System.ComponentModel;
using ReactiveUI.Maui;

namespace Xamvvm.Maui.RxUI.Implementations
{
	public class BaseMasterDetailPageRxUI<TPageModel> : ReactiveMasterDetailPage<TPageModel>,  IBasePageRxUI<TPageModel> where TPageModel : class, IBasePageModel, INotifyPropertyChanged
	{
	}
}
