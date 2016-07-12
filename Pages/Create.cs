using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace $safeprojectname$.Page
{
    [TestClass]
    public class Create : BasePage
    {
        [TestMethod]
        public void CreateIssue()
        {
            Util.Login();

            var testName = "Teste 14";

            Driver.Navigate().GoToUrl(BaseURL + "/bug_report_page.php");
            new SelectElement(Driver.FindElement(By.Name("category_id"))).SelectByText("[Todos os Projetos] General");
            new SelectElement(Driver.FindElement(By.Name("reproducibility"))).SelectByText("sempre");
            new SelectElement(Driver.FindElement(By.Name("severity"))).SelectByText("mínimo");
            new SelectElement(Driver.FindElement(By.Name("profile_id"))).SelectByText("PC Windows 7");
            new SelectElement(Driver.FindElement(By.Name("handler_id"))).SelectByText("julia.gomes");
            Driver.FindElement(By.Name("summary")).Clear();
            Driver.FindElement(By.Name("summary")).SendKeys(testName);
            Driver.FindElement(By.Name("description")).Clear();
            Driver.FindElement(By.Name("description")).SendKeys("Prosseguir com teste.");
            Driver.FindElement(By.CssSelector("input.button")).Click();

            try
            {
                Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                Driver.FindElement(By.XPath("(//td[contains(text(), '" + testName + "')])"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}
