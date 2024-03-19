using Examples.Maui.ViewModels;
using Xamvvm;

namespace Examples.Maui.Views;

public partial class SampleSecondView : ContentView, IBaseView<SampleSecondViewModel>
{
	public SampleSecondView()
	{
		InitializeComponent();
	}
}