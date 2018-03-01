using System;
using System.Collections.Generic;
using FindMyBeer.ViewModels;
using Xamarin.Forms;

namespace FindMyBeer.Views
{
	public partial class BeerPage : ContentPage
	{
		public BeerPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var vm = BindingContext as BeerViewModel;
			vm?.GetDetailsCommand.Execute(null);
		}
	}
}
