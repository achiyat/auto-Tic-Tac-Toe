using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace automation
{
    internal class testEmail : baseTest
    {
        public override IWebElement findElement()
        {
            return driver.FindElement(By.ClassName("btn-primary"));
            //return driver.FindElement(By.CssSelector("button[class='btn btn-primary w-100']"));
        }
    }
}
