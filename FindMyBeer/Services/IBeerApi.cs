using System.Collections.Generic;
using System.Threading.Tasks;
using FindMyBeer.Models;
using Refit;

namespace FindMyBeer.Services
{
	public interface IBeerApi
	{
		[Get("/beer/random")]
		Task<EntityResponse<Beer>> GetRandomBeer(string key = Constants.API_KEY);

		[Get("/styles")]
		Task<EntityResponse<List<Style>>> GetStyles(string key = Constants.API_KEY);

		[Get("/beers")]
		Task<PaginatedResponse<Beer>> GetBeersByStyle(long styleId, int p = 1, string key = Constants.API_KEY);

		[Get("/beers")]
		Task<PaginatedResponse<Beer>> GetBeersByIds(string ids, string key = Constants.API_KEY);
	}
}
