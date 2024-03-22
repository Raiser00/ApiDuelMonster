using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiDuelMonster.Data;
using ApiDuelMonster.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace ApiDuelMonsterTest
{
	public class IntegrationTest
	{
		TestContext testContext = new TestContext();

		[Fact]
		public async Task TestGetCard()
		{
			//Arrange
			testContext.JSInterop.Mode = JSRuntimeMode.Loose;
			testContext.Services.AddSingleton<CardApi>();

			var cut = testContext.RenderComponent<ApiDuelMonster.Pages.Index>();

			//Act
			cut.Find("button").Click();
			await Task.Delay(2000);
			cut.Render();

			//Assert
			var paragraphCount = cut.FindAll("p").Count();
			Assert.True(paragraphCount > 2);
		}


	}
}
