using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace $safeprojectname$
{
    public class BasePage
    {
        public static IWebDriver Driver { get; set; }
        public static string BaseURL { get; set; }

        public BasePage()
        {
            var testConfiguration = new TestConfiguration();

            if (testConfiguration.Browser == BrowserType.Firefox)
            {
                Driver = new FirefoxDriver();
            }
            else if (testConfiguration.Browser == BrowserType.Chrome)
            {
                Driver = new ChromeDriver(@"C:\Libraries\");
            }

            BaseURL = testConfiguration.BaseURL;
        }
    }
}
