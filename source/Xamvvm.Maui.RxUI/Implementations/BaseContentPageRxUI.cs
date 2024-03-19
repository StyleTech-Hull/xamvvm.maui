using System.ComponentModel;
using ReactiveUI.Maui;

namespace Xamvvm.Maui.RxUI.Implementations
{
	public class BaseContentPageRxUI<TPageModel> : ReactiveContentPage<TPageModel>,  IBasePage<TPageModel> where TPageModel : class, IBasePageModel, INotifyPropertyChanged
	{
	}
}
