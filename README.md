# ![xamvvm](http://res.cloudinary.com/escamoteur/image/upload/c_scale,w_150/v1476723686/xamvvm2_ufjcqq.png) 
# Simple, fast and lightweight MVVM Framework for .Net Maui with fluent API

|  Xamvvm.Forms             |         Xamvvm.Forms.RxUI          |
|-------------------------------------:|:---------------------------------:|
|  [![NuGet][maui-img]][maui-link]   |  [![NuGet][rx-img]][rx-link]  |

## Background
This is a fork of https://github.com/xamvvm/xamvvm to provide .Net MAUI support.

Newer packages maybe better suited for fresh projects but this should help any existing Xamarin Forms projects in the transition to .Net MAUI.

## Features

- **Very Easy to use. Just mark your pages / models with empty interfaces `IBasePage<TPageModelType>` / `IBasePageModel`**
- **PageModel first oriented Navigation**
- **Automatic wiring of BindingContext (PageModels)**
- **Pages / PageModels caching** - more responsive UI experience!
- **You're not limited to any concrete implementation of Pages, PageModels**
- **Fluent style extensions methods to write less code**
- **Navigation inside `ContentView`**
- Helper classes with ready to use `INotifyPropertyChanged` implementation eg. `BasePageModel`
- Pages have override methods to respond / intercept navigation (eg. NavgationPushing, NavigationCanPush, etc.) 
- Strongly typed classes / methods / messaging
- Dependency free ICommand implementation prevents multiple execution when previous execution not finished yet



## Getting Started

## Initialize the Framework

You have to create an instance of a IBaseFactory implementation and set it as the current factory to use

```C#
var factory = new XamvvmMauiFactory(this);
XamvvmCore.SetCurrentFactory(factory);
```

That's all :-) 

The PageFactory will scan your assemblies at start up and link Pages and PageModels together according to the IBasePage definition on your Pages.
(You can also register your Pages manually if you want to. See Wiki)


## PageModel first navigation

All pushing and popping is always done from the PageModel and not from Pages

```C#
var pageToPush = this.GetPageFromCache<DetailPageModel>();
await this.PushPageAsync(pageToPush);

// OR even shorter way:
this.PushPageFromCache<DetailPageModel>();
```

You can pass an int action too that is executed on the Pagemodel before displaying the page

```C#
await this.PushPageAsync(pageToPush, (pm) => pm.Init("blue", Colors.Blue));

// OR even shorter way:
var pageToPush = this.GetPageFromCache<DetailPageModel>();
this.PushPageFromCache<DetailPageModel>((pm) => pm.Init("blue", Colors.Blue));
```

Popping is as easy

```C#
await this.PopPageAsync();
```


All a page has to do is derive from IBasePage<PageModelType> with the PageModelType this Page should be linked to.For the above example calls the used classes would like this.

```C#
public partial class DetailPage : ContentPage, IBasePage<DetailPageModel>
{
	public DetailPage()
	{
		InitializeComponent();
	}
}
```

```XML
<?xml version="1.0" encoding="UTF-8"?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui" xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" x:Class="Examples.DetailPage"
		Title="Detail Page">
	<ContentPage.Content>
		<Label Text="{Binding Text}" BackgroundColor="{Binding Color}" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
	</ContentPage.Content>
</ContentPage>

```

```C#
public class DetailPageModel : BasePageModel
{
	public void Init(string text, Color color)
	{
		Text = text;
		Color = color;
	}

	public Color Color
	{
		get { return GetField<Color>(); }
		set { SetField(value); }
	}

	public string Text
	{
		get { return GetField<string>(); }
		set { SetField(value); }
	}
}
```
<sub>You don't have to inherit from BasePageModel it's just an included convinience class</sub>


Please look into the [Wiki](https://github.com/StyleTech-Hull/xamvvm.maui/wiki) for Detailed Information

## Support
Limited support is provided but we welcome any PRs to correct any improvements or issues you have found

## Example project

https://github.com/StyleTech-Hull/xamvvm.maui/tree/development/examples

[maui-img]: https://img.shields.io/nuget/v/Xamvvm.Maui.svg
[maui-link]: https://www.nuget.org/packages/Xamvvm.Maui
[rx-img]: https://img.shields.io/nuget/v/Xamvvm.Maui.RxUI.svg
[rx-link]: https://www.nuget.org/packages/Xamvvm.Maui.RxUI

