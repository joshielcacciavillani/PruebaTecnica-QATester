using AutomationPokemonPage.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomationPokemonPage.TestCase {
    [TestFixture]
    internal class PokemonTests {
        protected IWebDriver Driver;

        [SetUp]
        public void BeforeTest() {
            var options = new FirefoxOptions();
            Driver = new FirefoxDriver(options);
            //string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            //Driver = new ChromeDriver(path + @"\Drivers\");
            Driver.Navigate().GoToUrl("https://sg.portal-pokemon.com/play/pokedex");
        }

        [Test]
        public void SearchPokemon() {
            //TODO: sacar esta info del config
            PokedexPage pokedexPage = new(Driver);
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