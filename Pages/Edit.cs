using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace $safeprojectname$.Pages
{
    [TestClass]
    public class Edit : BasePage
    {
        [TestMethod]
        public void EditIssue()
        {
            Util.Login();

            Driver.Navigate().GoToUrl(BaseURL + "/view_all_bug_page.php");
            Driver.FindElement(By.XPath("(//img[@alt='Atualizar'])[2]")).Click();
            Driver.FindElement(By.Name("summary")).Clear();
            Driver.FindElement(By.Name("summary")).SendKeys("Teste 14");
            new SelectElement(Driver.FindElement(By.Name("reproducibility"))).SelectByText("não se tentou");
            Driver.FindElement(By.CssSelector("input.button")).Click();

            //TO DO: Assert.
        }
    }
}
