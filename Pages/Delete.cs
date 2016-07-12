using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace $safeprojectname$.Pages
{
    [TestClass]
    public class Delete : BasePage
    {
        [TestMethod]
        public void DeleteIssue()
        {
            Util.Login();

            var testNumber = "0000079";

            Driver.FindElement(By.XPath("(//a[contains(text(), '" + testNumber + "')])")).Click();
            Driver.FindElement(By.XPath("//input[@value='Apagar']")).Click();
            Driver.FindElement(By.CssSelector("input.button")).Click();

            try
            {
                Driver.FindElement(By.XPath("(//a[contains(text(),'" + testNumber + "')])"));
                Assert.IsTrue(false);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
    }
}
