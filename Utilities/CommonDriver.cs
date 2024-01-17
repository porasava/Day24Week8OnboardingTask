using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24Week8OnboardingTask.Utilities
{
    public class CommonDriver
    {
        //public static IWebDriver driver1;
        //public static IWebDriver driver2;

        public IWebDriver Driver { get; private set; }

        public CommonDriver()
        {
            Driver = new ChromeDriver();
        }

        public void QuitDriver()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver = null;
            }
        }
    }


}
