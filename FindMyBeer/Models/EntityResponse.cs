using Newtonsoft.Json;

namespace FindMyBeer.Models
{
	public class EntityResponse<T>
	{
		[JsonProperty("message")]
		public string Message { get; set; }
		
		[JsonProperty("errorMessage")]
		public string ErrorMessage { get; set; }

		[JsonProperty("data")]
		public T Data { get; set; }

		[JsonProperty("status")]
		public Status Status { get; set; }
	}
}