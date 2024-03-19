using System.ComponentModel;
using ReactiveUI;

namespace Xamvvm.Maui.RxUI
{

    public interface IBasePageRxUI<TPageModel> : IBasePage<TPageModel>, IViewFor<TPageModel> where TPageModel : class, IBasePageModel, INotifyPropertyChanged
    {
    }


}