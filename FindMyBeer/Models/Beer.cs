using System;
using Newtonsoft.Json;

namespace FindMyBeer.Models
{
	public class Beer
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("nameDisplay")]
		public string NameDisplay { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("abv")]
		public string Abv { get; set; }

		[JsonProperty("styleId")]
		public long StyleId { get; set; }

		[JsonProperty("isOrganic")]
		public string IsOrganic { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("statusDisplay")]
		public string StatusDisplay { get; set; }

		[JsonProperty("createDate")]
		public DateTimeOffset CreateDate { get; set; }

		[JsonProperty("updateDate")]
		public DateTimeOffset UpdateDate { get; set; }

		[JsonProperty("style")]
		public Style Style { get; set; }
		
		[JsonProperty("ibu")]
        public string Ibu { get; set; }

        [JsonProperty("glasswareId")]
        public long? GlasswareId { get; set; }

        [JsonProperty("srmId")]
        public long? SrmId { get; set; }

        [JsonProperty("availableId")]
        public long? AvailableId { get; set; }

        [JsonProperty("labels")]
        public Labels Labels { get; set; }

        [JsonProperty("servingTemperature")]
        public string ServingTemperature { get; set; }

        [JsonProperty("servingTemperatureDisplay")]
        public string ServingTemperatureDisplay { get; set; }

        [JsonProperty("glass")]
        public Glass Glass { get; set; }

        [JsonProperty("srm")]
        public Srm Srm { get; set; }

        [JsonProperty("available")]
        public Available Available { get; set; }

        [JsonProperty("foodPairings")]
        public string FoodPairings { get; set; }

        [JsonProperty("originalGravity")]
        public string OriginalGravity { get; set; }
	}
}