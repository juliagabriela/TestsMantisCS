using OpenQA.Selenium;

namespace $safeprojectname$
{
    public class Util : BasePage
    {
        public static void Login()
        {
            Driver.Navigate().GoToUrl(BaseURL + "/login_page.php");
            Driver.FindElement(By.Name("username")).Clear();
            Driver.FindElement(By.Name("username")).SendKeys("julia.gomes");
            Driver.FindElement(By.Name("password")).Clear();
            Driver.FindElement(By.Name("password")).SendKeys("501040*");

            if (Driver.FindElement(By.Name("secure_session")).Selected)
            {
                Driver.FindElement(By.Name("secure_session")).Click();
            }

            Driver.FindElement(By.CssSelector("input.button")).Click();
        }
    }
}
