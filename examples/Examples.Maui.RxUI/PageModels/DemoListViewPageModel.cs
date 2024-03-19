using DynamicData;
using ReactiveUI;
using Xamvvm.Maui.RxUI.Implementations;

namespace Examples.Maui.RxUI.PageModels
{
	public class DemoListViewPageModel : BasePageModelRxUI
	{
		public DemoListViewPageModel()
		{
			var changeSet = ObservableChangeSet.Create<DogsItemViewModel>(list =>
			{
				list.Add(new DogsItemViewModel() { Name = "Rex", Race = "German Sheppard" });
				list.Add(new DogsItemViewModel() { Name = "Barney", Race = "Poodle" });
				list.Add(new DogsItemViewModel() { Name = "Jimmy", Race = "Beagle" });
				list.Add(new DogsItemViewModel() { Name = "Rob", Race = "Labrador" });
				return () => { };
			});

			DogViewModelList = new SourceList<DogsItemViewModel>(changeSet);
		}

		IObservableList<DogsItemViewModel> dogViewModelList;
		public IObservableList<DogsItemViewModel> DogViewModelList
		{
			get { return dogViewModelList; }
			set { this.RaiseAndSetIfChanged(ref dogViewModelList, value); }
		}
	}


	// Should be something that makes a bit of sense, so why not dogs
	public class DogsItemViewModel : ReactiveObject
	{
		private string name;
		private string race;

		public string Name
		{
			get { return name; }
			set { this.RaiseAndSetIfChanged(ref name, value); }
		}

		public string Race
		{
			get { return race; }
			set { this.RaiseAndSetIfChanged(ref race, value); }
		}
	}
}