using System;
using FindMyBeer.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using FindMyBeer.Extensions;
using PropertyChanged;

namespace FindMyBeer.ViewModels
{
	public class StyleViewModel: BaseViewModel
	{
		readonly Models.Style _style;

		public ObservableCollection<Beer> Beers { get; }
		public ICommand ReloadBeersCommand { get; }
		public ICommand LoadMoreBeersCommand { get; }

		int LastLoadedPage { get; set; }
		int TotalPages { get; set; }

		public string Title => _style.Name;

		[DependsOn(nameof(LastLoadedPage), nameof(TotalPages))]
		public bool HasMorePages => LastLoadedPage < TotalPages;

		public StyleViewModel(Models.Style style)
		{
			_style = style;
			Beers = new ObservableCollection<Beer>();
			ReloadBeersCommand = new Command(async () => await ReloadBeers());
			LoadMoreBeersCommand = new Command(async () => await LoadMoreBeers());
		}

		Task ReloadBeers()
		{
			Beers.Clear();
			LastLoadedPage = 0;

			return LoadMoreBeers();
		}

		async Task LoadMoreBeers()
		{
			LastLoadedPage++;
			var resultFromApi = await ApiService.GetBeersByStyle(_style.Id, LastLoadedPage).SetIsLoading(this);
			if (resultFromApi.Status == Status.Failure)
			{
				return;
			}

			LastLoadedPage = resultFromApi.CurrentPage;
			TotalPages = resultFromApi.NumberOfPages;

			resultFromApi.Data.ForEach(b => Beers.Add(b));
		}
	}
}
