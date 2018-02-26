using System;
using System.Collections.Generic;
using FindMyBeer.ViewModels;
using Xamarin.Forms;

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
			var style = e.SelectedItem as FindMyBeer.Models.Style;
			
			if (style == null)
			{
				return;
			}
			
			((ListView) sender).SelectedItem = null;
			Navigation.PushAsync(new StylePage{BindingContext = new StyleViewModel(style)}, true);
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			StylesViewModel viewModel = BindingContext as StylesViewModel;
			if(viewModel != null && viewModel.Styles.Count == 0)
			{
				viewModel.ReloadStylesCommand.Execute(null);
			}
		}
	}
}
