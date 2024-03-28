using OpenQA.Selenium;

namespace AutomationPokemonPage.PageObject {
    public class PokedexPage {
        protected IWebDriver Driver;

        protected By SearchInput = By.Id("searchInput");
        protected By SearchButton = By.Id("search");
        protected By pokedex = By.ClassName("pokedex");

        public PokedexPage(IWebDriver driver) {
            Driver = driver;

            if (!Driver.FindElement(pokedex).Displayed)
                throw new Exception("No es la pagina de busqueda");
        }
        public void TypePokemonName(string pokemon) {
            Driver.FindElement(SearchInput).SendKeys(pokemon);
        }

        public void ClickSearchButton() {
            Driver.FindElement(SearchButton).Click();
        }

        public PokemonCard SearchPokemon(string pokemon) {
            TypePokemonName(pokemon);
            ClickSearchButton();
            return new PokemonCard(Driver, pokemon);
        }
    }
}
