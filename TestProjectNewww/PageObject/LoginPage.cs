using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectNewww.Utitlities;

namespace TestProjectNewww.PageObject
{
    class LoginPage
    {
        public LoginPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement AdminLogin => driver.FindElement(By.XPath("//input[@name='Submit']"));
        IWebElement Admin => driver.FindElement(By.CssSelector("#menu_admin_viewAdminModule > b"));
        IWebElement Qualifications => driver.FindElement(By.CssSelector("#menu_admin_Qualifications"));
        IWebElement Skills => driver.FindElement(By.CssSelector("#menu_admin_viewSkills"));
        IWebElement Add => driver.FindElement(By.CssSelector("#btnAdd"));
        IWebElement SkillsName => driver.FindElement(By.CssSelector("#skill_name"));
        IWebElement Description => driver.FindElement(By.CssSelector("I Enter Description"));
        IWebElement Save => driver.FindElement(By.CssSelector("#btnSave"));
        IWebElement Successfully => driver.FindElement(By.CssSelector("#recordsListTable > tbody > tr:nth-child(21) > td:nth-child(3)"));


        public void IEnterAdminLogin()
        {
            AdminLogin.Click();
        }
        
        public void ClickOnAdmin()
        {
            Admin.Click();
        }
        public void ClickOnQualifications()
        {
            Qualifications.Click();
        }
        public void ClickOnSkills()
        {
            Skills.Click();
        }
        public void ClickOnAdd()
        {
            Add.Click();
        }
        public void IEnterSkillName()
        {
            Skills.GetType();
        }
        public void IEnterDescription()
        {
            Description.GetType();
        }
        public void IClickOnSave()
        {
            Save.Click();
        }
        public void IConfirmSkillSuccessfully()
        {
            Successfully.Click();
        }
        public void INavigateToWebsite()
        {
            driver.Navigate().GoToUrl("url");
        }
    }
}  