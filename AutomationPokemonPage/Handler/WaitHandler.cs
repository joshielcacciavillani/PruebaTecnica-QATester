using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPokemonPage.Handler {
    public class WaitHandler {
        public static bool ElementIsPresent(IWebDriver driver, By locator) {
            try {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                wait.Until(drv => drv.FindElement(locator));
                return true;
            }
            catch { }

            return false;
        }
    }
}
