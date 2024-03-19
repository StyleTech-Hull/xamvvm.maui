using Examples.Maui.ViewModels;
using Xamvvm;

namespace Examples.Maui.Views;

public partial class SampleFirstView : ContentView, IBaseView<SampleFirstViewModel>
{
	public SampleFirstView()
	{
		InitializeComponent();
	}
}