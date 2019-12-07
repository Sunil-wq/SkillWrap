using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Utils
{
  public class LoginPage
    {
        public static void LoginStep()
        {
            Driver.NavigateUrl();
            Driver.TurnOnWait();
          
          
       
            

            //Enter Url
            Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();

            //Enter Username
            //Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[1]/form/div[1]/input")).SendKeys("hari7chandana@gmail.com");
            Driver.driver.FindElement(By.Name("email")).SendKeys("mvpstudio.qa@gmail.com");

            //Enter password
           // Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[1]/form/div[2]/input")).SendKeys("Test@123");
            Driver.driver.FindElement(By.Name("password")).SendKeys("SydneyQa2018");
            Driver.TurnOnWait();

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();

        }

    }
}
