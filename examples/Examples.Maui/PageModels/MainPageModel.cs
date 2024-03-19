﻿using System.Windows.Input;
using Xamvvm;

namespace Examples.Maui.PageModels
{
	public class MainPageModel : BasePageModel
	{
		public MainPageModel()
		{
			WelcomeText = "Welcome to xamvvm!";

			DetailButtonCommand = BaseCommand.FromTask<string>((param) => DetailButtonCommandExecute(param));
			DemoListButtonCommand = BaseCommand.FromTask((param) => this.PushPageFromCacheAsync<DemoListViewPageModel>());

			MasterDetailButtonCommand = new BaseCommand(async (arg) =>
			{
				await this.PushPageFromCacheAsync<SampleFlyoutPageModel>();
			});

			NavigationViewButtonCommand = new BaseCommand(async (arg) =>
			{
				await this.PushPageFromCacheAsync<SampleNavigationViewPageModel>();
			});
		}

		async Task DetailButtonCommandExecute(string param)
		{
			var pageToPush = this.GetPageFromCache<DetailPageModel>();

			if (param == "red")
			{
				await this.PushPageAsync(pageToPush, (v) => v.Init("red", Colors.Red));
			}
			else if (param == "green")
			{
				await this.PushPageAsync(pageToPush, (v) => v.Init("green", Colors.Green));
			}
			else if (param == "blue")
			{
				await this.PushPageAsync(pageToPush, (v) => v.Init("blue", Colors.Blue));
			}
		}

		public string WelcomeText
		{
			get { return GetField<string>(); }
			set { SetField(value); }
		}

		public ICommand DetailButtonCommand
		{
			get { return GetField<ICommand>(); }
			set { SetField(value); }
		}

		public ICommand DemoListButtonCommand
		{
			get { return GetField<ICommand>(); }
			set { SetField(value); }
		}

		public ICommand MasterDetailButtonCommand
		{
			get { return GetField<ICommand>(); }
			set { SetField(value); }
		}

		public ICommand NavigationViewButtonCommand
		{
			get { return GetField<ICommand>(); }
			set { SetField(value); }
		}
	}
}
