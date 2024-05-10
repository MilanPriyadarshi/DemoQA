using DemoQA.Driver1;
using DemoQA.HomePage1;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoQA.CheckBox1
{
    class CheckBox:Driver
    {
        public CheckBox(IWebDriver _driver)
        {
            driver=_driver;
            PageFactory.InitElements(driver,this);
        }
         [FindsBy(How=How.XPath,Using ="//span[text()='Check Box']")]
        IWebElement checkBoxBtn;
        [FindsBy(How=How.XPath,Using ="//*[@id='tree-node']/ol/li/span/button")]
        IWebElement expandBtn;
        [FindsBy(How=How.XPath,Using ="//span[text()='Desktop']")]
        IWebElement desktopBtn;
        [FindsBy(How=How.XPath,Using ="//span[text()='Documents']")]
        IWebElement documentsBtn;
        [FindsBy(How=How.XPath,Using ="//span[text()='Downloads']")]
        IWebElement downloadsBtn;
        public void CheckBoxOperations()
        {
            HomePage home=new HomePage(driver);
            home.LauchElements();
            IJavaScriptExecutor js=(IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)",checkBoxBtn);
            checkBoxBtn.Click();
            js.ExecuteScript("arguments[0].scrollIntoView(true)",expandBtn);
            expandBtn.Click();
            desktopBtn.Click();
            documentsBtn.Click();
            downloadsBtn.Click();

        }
    
    }
}