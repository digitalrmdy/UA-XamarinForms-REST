using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FindMyBeer.Services;
using Refit;
using Xamarin.Forms;
using PropertyChanged;

namespace FindMyBeer
{
	[AddINotifyPropertyChangedInterface]
	public class BaseViewModel
	{		
		protected IBeerApi ApiService { get; }
		public bool IsLoading { get; set; }

		public BaseViewModel()
		{
			ApiService = RestService.For<IBeerApi>(Constants.BASE_URL);
		}
	}
}