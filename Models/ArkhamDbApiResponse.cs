using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CardsDbApp.Models
{
	public class ArkhamDbApiResponse
	{
        [JsonPropertyName("code")]
        public int Code { get; set; }
		[JsonPropertyName("name")]
        public string Name { get; set; } = String.Empty;
        [JsonPropertyName("pack_name")]
        public string PackName { get; set; } = String.Empty;
        [JsonPropertyName("type_name")]
        public string TypeName { get; set; } = String.Empty;
        [JsonPropertyName("faction_name")]
        public string FactionName { get; set; } = String.Empty;
		[JsonPropertyName("cost")]
        public int Cost { get; set; }
        [JsonPropertyName("traits")]
        public String Traits { get; set; } = String.Empty;
        [JsonPropertyName("imagesrc")]
		public string ImageSrc { get; set; } = String.Empty;
	}
}