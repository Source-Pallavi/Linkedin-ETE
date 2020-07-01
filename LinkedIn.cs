using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoProj
{
    [TestFixture]
    public class LinkedIn
    {
        IWebDriver driver;
        [OneTimeSetUp]        
        public void Initial()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.linkedin.com/login";
        }

        [Test]
        public void LoginTest()
        {
            LoginPage page = new LoginPage(driver);
            page.Login();
        }

        [Test]
        public void LogOutTest()
        {
            HomePage page = new HomePage(driver);
            page.LogOut();
        }
    }
}
