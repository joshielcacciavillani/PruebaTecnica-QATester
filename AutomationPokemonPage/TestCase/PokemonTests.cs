using AutomationPokemonPage.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationPokemonPage.TestCase {
    [TestFixture]
    internal class PokemonTests {
        protected IWebDriver Driver;

        [SetUp]
        public void BeforeTest() {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            Driver = new ChromeDriver(path + @"\Drivers\");
            Driver.Navigate().GoToUrl("https://www.pokemon.com/es/pokedex/");
        }

        [Test]
        public void SearchPokemon() {
            //TODO: sacar esta info del config
            PokedexPage pokedexPage = new(Driver);
            _ = pokedexPage.SearchPokemon("charmander");
            pokedexPage.SearchPokemon("charmander");
        }

        [TearDown]
        public void AfterTest() {
            if (Driver != null) {
                Driver.Quit();
            }
        }
    }
}