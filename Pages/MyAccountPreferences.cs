using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Threading;

namespace $safeprojectname$.Pages
{
    [TestClass]
    public class MyAccountPreferences : BasePage
    {
        [TestMethod]
        public void Preferences()
        {
            Util.Login();

            SetLanguage("english");
            SetLanguage("portuguese_brazil");
            Driver.Navigate().GoToUrl(BaseURL + "/account_page.php");

            Assert.AreEqual("Minha Visão", Driver.FindElement(By.XPath("//a[contains(@href, '/my_view_page.php')]")).Text);
        }

        public void SetLanguage(string language)
        {
            Driver.Navigate().GoToUrl(BaseURL + "/account_page.php");
            Driver.Navigate().GoToUrl(BaseURL + "/account_prefs_page.php");
            new SelectElement(Driver.FindElement(By.Name("language"))).SelectByText(language);
            Driver.FindElement(By.XPath("//td[contains(@class,'center')]")).FindElement(By.TagName("input")).Click();
        }
    }
}
