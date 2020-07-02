using Linkedin.Credentials;
using Linkedin.ScreenShot;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoProj
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement Userid;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//button[@type = 'submit']")]
        public IWebElement SignIn;

        public void Login()
        {
            Credentials credentials = new Credentials();
            Userid.SendKeys(credentials.email);
            Password.SendKeys(credentials.password);
            SignIn.Click();
            Ilistiner ilistiner = new Ilistiner(driver);
            ilistiner.ScreenShot();
        }
    }
}
