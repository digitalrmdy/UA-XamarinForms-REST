using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using FindMyBeer.Extensions;
using FindMyBeer.Models;
using Xamarin.Forms;
using Style = FindMyBeer.Models.Style;

namespace FindMyBeer.ViewModels
{
	public class StylesViewModel: BaseViewModel
	{
		public ObservableCollection<Style> Styles { get; }
		public ICommand ReloadStylesCommand { get; }
		
		public StylesViewModel()
		{
			Styles = new ObservableCollection<Style>();
			ReloadStylesCommand = new Command(async () => await ReloadStyles());
		}

		async Task ReloadStyles()
		{
			Styles.Clear();
			
			EntityResponse<List<Style>> resultFromApi;
			try
			{
				resultFromApi = await ApiService.GetStyles().SetIsLoading(this);
			}
			catch (Exception)
			{
				return;
			}
			
			if (resultFromApi.Status == Status.Failure)
			{
				return;
			}
			
			resultFromApi.Data.ForEach(s => Styles.Add(s));
		}
	}
}
