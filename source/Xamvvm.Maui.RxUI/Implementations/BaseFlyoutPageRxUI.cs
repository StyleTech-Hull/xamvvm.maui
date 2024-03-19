using System.ComponentModel;
using ReactiveUI.Maui;

namespace Xamvvm.Maui.RxUI.Implementations;

public class BaseFlyoutPageRxUI<TPageModel> : ReactiveFlyoutPage<TPageModel>,  IBasePageRxUI<TPageModel> where TPageModel : class, IBasePageModel, INotifyPropertyChanged
{
}