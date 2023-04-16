using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation
{
    internal abstract class baseTest
    {
        protected IWebDriver driver;

        public void run(string email, string pasword)
        {
            string url = "https://tic-tac-toe-of-achiya.netlify.app/";
            using (driver = new ChromeDriver())
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

                // Go To Url
                try
                {
                    driver.Navigate().GoToUrl(url);
                    //wait.Until<int>((d) => { driver.Navigate().GoToUrl(url); return 0; });
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // Click Log In
                try
                {
                    IWebElement element = findElement();
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                int a = 0;
            }


        }

        public abstract IWebElement findElement();
    }


}
