using Linkedin.ScreenShot;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoProj
{
    public class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ember24")]
        public IWebElement AccountSetting;

        [FindsBy(How = How.Id, Using = "ember38")]
        public IWebElement Logout;

        public void LogOut()
        {
            Thread.Sleep(5000);
            AccountSetting.Click();
            Thread.Sleep(5000);
            Logout.Click();
            Ilistiner ilistiner = new Ilistiner(driver);
            ilistiner.ScreenShot();
        }


    }
}
