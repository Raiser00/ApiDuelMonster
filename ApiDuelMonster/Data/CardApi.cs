using System.Text.Json;

namespace ApiDuelMonster.Data
{
	public class CardApi
	{
		public Card CurrentCarte { get; set; }
		public List<Card> Favorites { get; set; } = new List<Card>();

		public async Task GetCarte()
		{
			try
			{
				HttpClient client = new HttpClient();
				string response = await client.GetStringAsync("https://db.ygoprodeck.com/api/v7/randomcard.php");

				JsonDocument jsonDocument = JsonDocument.Parse(response);
				JsonElement root = jsonDocument.RootElement;

				var options = new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = true // Pour ignorer la casse des propriétés lors de la désérialisation
				};

				CardInfo info = JsonSerializer.Deserialize<CardInfo>(root, options);
				List<CardImg> images = JsonSerializer.Deserialize<List<CardImg>>(root.GetProperty("card_images"));
				var carte = new Card
				{
					Id = info.Id,
					Name = info.Name,
					Desc = info.Desc,
					Race = info.Race,
					Type = info.Type,
					Image = images[0].ImgUrlSmall
				};

				if(carte != null)
				{
					CurrentCarte = carte;
				}
			}
			catch (HttpRequestException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public bool AddFavs()
		{
			if(!Favorites.Any(card => card.Id == CurrentCarte.Id))
			{
				Favorites.Add(CurrentCarte);
				return true;
			}
			return false;
		}

		public void AddQuantity(Card card)
		{
			card.Quantity++;
		}

		public void DelQuantity(Card card)
		{
			if (card.Quantity > 0)
			{
				card.Quantity--;
			}
		}

		public void RemoveFavs(Card card)
		{
			Favorites.Remove(card);
		}
	}
}
