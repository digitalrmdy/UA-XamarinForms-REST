using System;
using System.Collections.Generic;
using System.Linq;
using FindMyBeer.Models;
using FindMyBeer.ViewModels;
using Xamarin.Forms;

namespace FindMyBeer.Views
{
	public partial class StylePage : ContentPage
	{
		public StylePage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			if (BindingContext is StyleViewModel styleViewModel && styleViewModel.Beers.Count == 0)
			{
				styleViewModel.ReloadBeersCommand.Execute(null);
			}
		}

		void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
		{
			if (!(BindingContext is StyleViewModel styleViewModel))
			{
				return;
			}

			var lastFive = styleViewModel.Beers.TakeLast(5);
			if (lastFive.Contains(e.Item) && !styleViewModel.IsLoading && styleViewModel.HasMorePages)
			{
				styleViewModel.LoadMoreBeersCommand.Execute(null);
			}
		}

		void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (!(e.SelectedItem is Beer beer))
			{
				return;
			}
			
			((ListView) sender).SelectedItem = null;
			Navigation.PushAsync(new BeerPage{BindingContext = new BeerViewModel(beer)}, true);
		}
	}
}
