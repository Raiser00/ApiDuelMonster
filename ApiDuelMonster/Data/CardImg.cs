using System.Text.Json.Serialization;

namespace ApiDuelMonster.Data
{
	public class CardImg
	{
		[JsonPropertyName("image_url")]
		public string ImgUrl { get; set; }
		[JsonPropertyName("image_url_small")]
		public string ImgUrlSmall { get; set; }

	}
}
