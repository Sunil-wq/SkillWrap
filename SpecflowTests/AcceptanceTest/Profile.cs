using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    class Profile : Driver
    {
        IList<IWebElement> rowtable => driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr[1]/td[1]"));
        IList<IWebElement> rowtable1 => driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr[1]/td[1]"));
        IList<IWebElement> rowtable2 => driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
        public  void AddLanguage()
        {
            if (rowtable.Count < 4)
            {
                //Click on Add New button
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

                //Add Language
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys("spanish");

                //Click on Language Level
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();

                //Choose the language level
                IWebElement Lang = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[1];
                Lang.Click();

                //Click on Add button
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

            }


        }
        public void DisplayLanguage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                TurnOnWait();
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");
                TurnOnWait();
                String arg = "spanish";
                for (int j = 0; j < rowtable.Count; j++)
                {
                    if (rowtable[j].Text == arg)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                        return;
                    }

                }


                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
        public void UpdateLanguage()
        {
            String brg = "spanish";


            for (int j = 0; j < rowtable.Count; j++)
            {

                int i = j + 1;


                if (rowtable[j].Text == brg)
                {

                    TurnOnWait();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i")).Click();
                    TurnOnWait();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).Clear();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).SendKeys("koren");
                    IWebElement Arg = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select/option[3]"));
                    Arg.Click();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();

                }
            }
        }
        
        public void UpdateDisplayLanguage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                TurnOnWait();
                CommonMethods.test = CommonMethods.extent.StartTest("Update a Language");
                TurnOnWait();
                String arg = "koren";
                for (int j = 0; j < rowtable.Count; j++)
                {
                    if (rowtable[j].Text == arg)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, updated a Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                        return;
                    }

                }


                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
        public void DeleteLanguage()
        {
            String arg = "koren";
            for (int j = 0; j < rowtable.Count; j++)
            {
                int i = j + 1;
                if (rowtable[j].Text == arg)
                {
                    TurnOnWait();
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i")).Click();
                }
            }
        }
        public void NotDispaly()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                TurnOnWait();
                CommonMethods.test = CommonMethods.extent.StartTest("delete a Language");

                TurnOnWait();
                String arg = "koren";
                for (int j = 0; j < rowtable.Count; j++)
                {

                    if (rowtable[j].Text == arg)
                    {
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed, Delete Language not Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDeleted");
                        return;
                    }
                }
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Delete Language  Successfully");
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
        public void AddSkill()
        {
            if (rowtable1.Count < 4)
            {
                //Click on add new button
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
                //Add Skill
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("ISTQB");
                //Click on Skill Level
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();
                //Choose skill level
                IWebElement Nan = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
                Nan.Click();
                //Click add button
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

            }


        }
        public void DisplaySkill()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                TurnOnWait();
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Skill");
                TurnOnWait();
                String arg = "ISTQB";
                for (int j = 0; j < rowtable1.Count; j++)
                {
                    if (rowtable1[j].Text == arg)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");
                        return;
                    }

                }


                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
        public void UpdateSkill()
        {
            String brg = "ISTQB";


            for (int j = 0; j < rowtable1.Count; j++)
            {

                int i = j + 1;


                if (rowtable1[j].Text == brg)
                {

                    TurnOnWait();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i")).Click();
                    TurnOnWait();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).Clear();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).SendKeys("IISTQB");
                    IWebElement Arg = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select/option[3]"));
                    Arg.Click();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();
                    
                }
            }
        }

        public void UpdateDisplaySkill()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                TurnOnWait();
                CommonMethods.test = CommonMethods.extent.StartTest("Update a Skill");
                TurnOnWait();
                String arg = "IISTQB";
                for (int j = 0; j < rowtable1.Count; j++)
                {
                    if (rowtable1[j].Text == arg)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, updated a Skill Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");
                        return;
                    }

                }


                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
        public void DeleteSkill()
        {
            String arg = "IISTQB";
            for (int j = 0; j < rowtable1.Count; j++)
            {
                int i = j + 1;
                if (rowtable1[j].Text == arg)
                {
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i")).Click();
                }
            }
        }
        public void NotDispalySkill()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                TurnOnWait();
                CommonMethods.test = CommonMethods.extent.StartTest("delete a Skill");

                TurnOnWait();
                String arg = "IISTQB";
                for (int j = 0; j < rowtable1.Count; j++)
                {

                    if (rowtable1[j].Text == arg)
                    {
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed, Delete Skill not Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillDeleted");
                        return;
                    }
                }
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Delete Skill  Successfully");
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
        public void AddCertification()
        {
            if (rowtable2.Count < 4)
            {
                //Click on add new button
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();
                //Add certificate
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("SyssOps");
                //Certificate Obtained
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")).SendKeys("AWS");
                //Choose Year
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")).Click();
                //Enter Year
                IWebElement ali = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
                ali.Click();
                //Click Add
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();
            }


        }
        public void DisplayCertification()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                TurnOnWait();
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Certificate");
                TurnOnWait();
                String arg = "SyssOps";
                for (int j = 0; j < rowtable2.Count; j++)
                {
                    if (rowtable2[j].Text == arg)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Certificate Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificateAdded");
                        return;
                    }

                }


                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
        public void UpdateCertification()
        {
            String brg = "SyssOps";


            for (int j = 0; j < rowtable2.Count; j++)
            {

                int i = j + 1;


                if (rowtable2[j].Text == brg)
                {
                    TurnOnWait();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[4]/span[1]/i")).Click();
                    TurnOnWait();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[1]/input")).Clear();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[1]/input")).SendKeys("Devops");
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[2]/input")).Clear();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[2]/input")).SendKeys("ABS");
                    IWebElement Arg = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[3]/select/option[5]"));
                    Arg.Click();
                    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();
                    
                }
            }
        }

        public void UpdateDisplayCertification()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                TurnOnWait();
                CommonMethods.test = CommonMethods.extent.StartTest("Update a Certification");
                TurnOnWait();
                String arg = "Devops";
                for (int j = 0; j < rowtable2.Count; j++)
                {
                    if (rowtable2[j].Text == arg)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, updated a Certification Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificationAdded");
                        return;
                    }

                }


                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
        public void DeleteCertification()
        {
            String arg = "Devops";
            for (int j = 0; j < rowtable2.Count; j++)
            {
                int i = j + 1;
                if (rowtable2[j].Text == arg)
                {
                    TurnOnWait();
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + " ]/tr/td[4]/span[2]/i")).Click();
                }
            }
        }
        public void NotDispalyCertification()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                TurnOnWait();
                CommonMethods.test = CommonMethods.extent.StartTest("delete a Certification");

                TurnOnWait();
                String arg = "Devops";
                for (int j = 0; j < rowtable2.Count; j++)
                {

                    if (rowtable2[j].Text == arg)
                    {
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed, Delete Certification not Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificationDeleted");
                        return;
                    }
                }
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Delete Certification Successfully");
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}
    
