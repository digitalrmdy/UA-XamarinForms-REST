using Newtonsoft.Json;

namespace FindMyBeer.Models
{
	public class Glass
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("createDate")]
		public System.DateTimeOffset CreateDate { get; set; }
	}
}