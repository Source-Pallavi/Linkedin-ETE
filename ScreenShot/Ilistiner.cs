using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Linkedin.ScreenShot
{
  public  class Ilistiner
    {
        static int i = 0;
        IWebDriver driver;
        public Ilistiner(IWebDriver driver)
        {
            this.driver = driver;
           PageFactory.InitElements(driver, this);
            i++;
        }
        public Ilistiner()
        {
        }//zero param constructor

        public void ScreenShot()
           {
               ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
               Screenshot screenshot = screenshotDriver.GetScreenshot();
          
            /*DateTime.Now;
        Convert.ToDateTime(dt).ToString("dd-MMM-yyyy");*/
            screenshot.SaveAsFile("C:\\Users\\rebel\\source\\repos\\Linkedin\\ScreenShot/" + i + "ScreenShot.png");
           }
         //Will be update per screenshot that we took

     /*   public void ScreenShot2()
        {
           ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\\Users\\rebel\\source", ScreenshotImageFormat.Jpeg);
            TakesScreenshotWithDate(driver, @"C:\\Users\\rebel\\source\\repos\\Linkedin\\ScreenShot/", "SS", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        private void TakesScreenshotWithDate(IWebDriver BrowserInstance, string Path, string FileName, System.Drawing.Imaging.ImageFormat Format)
        {
           //Updates the number of screenshots that we took during the execution

            StringBuilder TimeAndDate = new StringBuilder(DateTime.Now.ToString());
            TimeAndDate.Replace("/", "_");
            TimeAndDate.Replace(":", "_");
        }*/
       
    }
}
