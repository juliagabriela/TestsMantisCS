using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace $safeprojectname$.Pages
{
    [TestClass]
    public class Reminder : BasePage
    {
        [TestMethod]
        public void ReminderIssue()
        {
            Util.Login();

            Driver.FindElement(By.CssSelector("span.small > a[title=\"[atribuído] Teste 04\"]")).Click();
            Driver.FindElement(By.LinkText("Enviar um lembrete")).Click();
            new SelectElement(Driver.FindElement(By.Name("to[]"))).SelectByText("julia.gomes");
            Driver.FindElement(By.Name("body")).Clear();
            Driver.FindElement(By.Name("body")).SendKeys("Teste para e-mail jgag17@hotmail.com.");
            Driver.FindElement(By.CssSelector("input.button")).Click();

            //Foi checado recebimento do e-mail no endereço jgag17@hotmail.com
        }
    }
}
