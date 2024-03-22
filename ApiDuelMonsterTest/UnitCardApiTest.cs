using ApiDuelMonster.Data;

namespace ApiDuelMonsterTest
{
	public class UnitCardApiTest
	{
		[Fact]
		public void AddQuantityTest()
		{
			//Arrange
			CardApi cardApi = new CardApi();
			Card card = new Card();


			//Act
			cardApi.CurrentCarte = card;
			cardApi.AddFavs();
			cardApi.AddQuantity(cardApi.Favorites[0]);

			var result = cardApi.Favorites[0].Quantity;
			
			//Assert
			Assert.Equal(1, result);
		}

		
	}
}