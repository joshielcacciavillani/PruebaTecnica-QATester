using AutomationPokemonPage.Handler;
using OpenQA.Selenium;

namespace AutomationPokemonPage.PageObject {
    public class PokemonCard {
        protected IWebDriver Driver;

        protected By Pokemon = By.CssSelector("span.pokemon-list--box__name.size-22");

        public PokemonCard(IWebDriver driver, String pokemonName) {
            Driver = driver;
            if (!CheckPokemonName(pokemonName))
                throw new Exception("No se encontro el pokemon buscado");
        }

        public bool PokemonIsPresent() {
            return WaitHandler.ElementIsPresent(Driver, Pokemon);
        }

        public bool CheckPokemonName(String pokemonName) {
            IWebElement pokemonElement = Driver.FindElement(Pokemon);
            string actualPokemonName = pokemonElement.Text.ToLower();

            if (actualPokemonName == pokemonName.ToLower()) {
                Console.WriteLine($"El pokemon es {pokemonName}");
                return true;
            }
            else {
                Console.WriteLine("No se encuentra el pokemon.");
                return false;
            }
        }
    }
}