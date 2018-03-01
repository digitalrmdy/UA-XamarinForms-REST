using System;
using System.Collections.Generic;
using FindMyBeer.ViewModels;
using Xamarin.Forms;
using Style = FindMyBeer.Models.Style;

namespace FindMyBeer.Views
{
	public partial class StylesPage : ContentPage
	{
		public StylesPage()
		{
			InitializeComponent();
			BindingContext = new StylesViewModel();
		}

		void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (!(e.SelectedItem is Style style))
			{
				return;
			}

			((ListView)sender).SelectedItem = null;
			Navigation.PushAsync(new StylePage { BindingContext = new StyleViewModel(style) }, true);
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			StylesViewModel viewModel = BindingContext as StylesViewModel;
			if (viewModel != null && viewModel.Styles.Count == 0)
			{
				viewModel.ReloadStylesCommand.Execute(null);
			}
		}
	}
}
