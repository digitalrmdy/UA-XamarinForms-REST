using Newtonsoft.Json;

namespace FindMyBeer.Models
{
	public class Srm
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("hex")]
		public string Hex { get; set; }
	}
}