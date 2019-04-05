using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3SchoolSpecflow_Assignment1.Settings;
using W3SchoolSpecflow_Assignment1.ComponentHelper;

namespace W3SchoolSpecflow_Assignment1
{
    public class HomePage
    {
        #region Webelements

        [FindsBy(How = How.XPath, Using = "//*[@id='mySidenav']/div/a[1]")]
        private IWebElement LearnHTML;

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[4]/a")]
        private IWebElement TryItYourself;

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/button")]
        private IWebElement Run;


        #endregion

        public HomePage()
        {


            PageFactory.InitElements(ObjectRepository.Driver, this);


        }
        #region Actions
        public void W3SchoolsHomePage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Manage().Window.Maximize();
        }
        public void ClickLearnHTMLLink()
        {
            LearnHTML.Click();
            
        }

        public void ClickTryItYourSelfButton()
        {
           
            TryItYourself.Click();
        }
        public void ClickRunButton()
        {
            var currentWindow = ObjectRepository.Driver.CurrentWindowHandle;
            foreach (String winHandle in ObjectRepository.Driver.WindowHandles)
            {
                if (winHandle != currentWindow)
                {
                    ObjectRepository.Driver.SwitchTo().Window(winHandle);
                }
            }
            Run.Click();

            
        }

        #endregion
        #region NAvigation
        public void result()
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath("//*[@id='iframeResult']")));
        }

        #endregion


    }
}
