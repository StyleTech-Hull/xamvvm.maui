using System.ComponentModel;
using ReactiveUI.Maui;

namespace Xamvvm.Maui.RxUI.Implementations
{
    public class BaseNavigationPageRxUI<TPageModel> : ReactiveNavigationPage<TPageModel>, IBasePageRxUI<TPageModel> where TPageModel : class, IBasePageModel, INotifyPropertyChanged
    {
    }
}
