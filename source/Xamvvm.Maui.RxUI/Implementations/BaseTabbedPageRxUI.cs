using System.ComponentModel;
using ReactiveUI.Maui;

namespace Xamvvm.Maui.RxUI.Implementations
{
    public class BaseTabbedPageRxUI<TPageModel> : ReactiveTabbedPage<TPageModel>, IBasePageRxUI<TPageModel> where TPageModel : class, IBasePageModel, INotifyPropertyChanged
    {
    }
}
