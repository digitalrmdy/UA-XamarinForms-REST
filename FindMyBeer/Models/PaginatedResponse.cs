using System.Collections.Generic;
using Newtonsoft.Json;

namespace FindMyBeer.Models
{
	public class PaginatedResponse<T>
	{
		[JsonProperty("currentPage")]
		public int CurrentPage { get; set; }

		[JsonProperty("numberOfPages")]
		public int NumberOfPages { get; set; }

		[JsonProperty("totalResults")]
		public int TotalResults { get; set; }

		[JsonProperty("data")]
		public List<T> Data { get; set; }

		[JsonProperty("status")]
		public Status Status { get; set; }
	}
}