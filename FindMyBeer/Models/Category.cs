using Newtonsoft.Json;

namespace FindMyBeer.Models
{
	public class Category
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("createDate")]
		public System.DateTimeOffset CreateDate { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("updateDate")]
		public System.DateTimeOffset? UpdateDate { get; set; }
	}
}