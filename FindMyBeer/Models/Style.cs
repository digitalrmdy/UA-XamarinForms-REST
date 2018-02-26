using Newtonsoft.Json;

namespace FindMyBeer.Models
{
	public class Style
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("categoryId")]
		public long CategoryId { get; set; }

		[JsonProperty("category")]
		public Category Category { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("shortName")]
		public string ShortName { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("ibuMin")]
		public string IbuMin { get; set; }

		[JsonProperty("ibuMax")]
		public string IbuMax { get; set; }

		[JsonProperty("abvMin")]
		public string AbvMin { get; set; }

		[JsonProperty("abvMax")]
		public string AbvMax { get; set; }

		[JsonProperty("srmMin")]
		public string SrmMin { get; set; }

		[JsonProperty("srmMax")]
		public string SrmMax { get; set; }

		[JsonProperty("ogMin")]
		public string OgMin { get; set; }

		[JsonProperty("fgMin")]
		public string FgMin { get; set; }

		[JsonProperty("fgMax")]
		public string FgMax { get; set; }

		[JsonProperty("createDate")]
		public System.DateTimeOffset CreateDate { get; set; }

		[JsonProperty("updateDate")]
		public System.DateTimeOffset UpdateDate { get; set; }

		[JsonProperty("ogMax")]
		public string OgMax { get; set; }
	}
}