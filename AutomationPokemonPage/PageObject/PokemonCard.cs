using AutomationPokemonPage.Handler;
using OpenQA.Selenium;

namespace AutomationPokemonPage.PageObject {
    public class PokemonCard {
        protected IWebDriver Driver;

        protected By Pokemon = By.XPath("//div[@class='pokemon-info']/h5");
        public PokemonCard(IWebDriver driver, String pokemonName) {
            Driver = driver;
            if (!CheckPokemonName(pokemonName))
                throw new Exception("No se encontro el pokemon buscado");
        }

        public bool PokemonIsPresent() {
            return WaitHandler.ElementIsPresent(Driver, Pokemon);
        }

        public bool CheckPokemonName(String pokemonName) {
            if (Driver.FindElement(Pokemon).Text.Equals(pokemonName.ToLower(), StringComparison.CurrentCultureIgnoreCase)) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}