using System;
using FindMyBeer.Models;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace FindMyBeer.ViewModels
{
	public class BeerViewModel: BaseViewModel
	{
		public Beer Beer { get; private set; }
		public ICommand GetDetailsCommand { get; }

		public string Available => Beer?.Available?.Name;
		public string Glass => Beer?.Glass?.Name;

		public BeerViewModel(Beer beer)
		{
			Beer = beer;
			GetDetailsCommand = new Command(async () => await GetDetails());
		}

		async Task GetDetails()
		{
			PaginatedResponse<Beer> resultFromApi;
			try
			{
				resultFromApi = await ApiService.GetBeersByIds(Beer.Id);
			}
			catch (Exception)
			{
				return;
			}
			
			var beer = resultFromApi?.Data?.FirstOrDefault();

			if (beer == null)
			{
				return;
			}

			Beer = beer;
		}
	}
}
