using DemoQA.Driver1;
using DemoQA.HomePage1;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace DemoQA.Buttons1
{
    class Buttons:Driver
    {
        Actions act=new Actions(driver);
        public Buttons(IWebDriver _driver)
        {
            driver=_driver;
            PageFactory.InitElements(driver,this);
        }
        [FindsBy(How=How.XPath,Using ="//span[text()='Buttons']")]
        IWebElement buttonsBtn;
         [FindsBy(How=How.XPath,Using ="//button[@id='doubleClickBtn']")]
        IWebElement doubleClickBtn;
         [FindsBy(How=How.XPath,Using ="//button[@id='rightClickBtn']")]
        IWebElement rightClickBtn;
         [FindsBy(How=How.XPath,Using ="//button[text()='Click Me']")]
        IWebElement singleClickBtn;
        public void ButtonsOperations()
        {
             HomePage home=new HomePage(driver);
            home.LauchElements();
            IJavaScriptExecutor js=(IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)",buttonsBtn);
            buttonsBtn.Click();
            js.ExecuteScript("arguments[0].scrollIntoView(true)",doubleClickBtn);
            act.MoveToElement(doubleClickBtn).DoubleClick().Build().Perform();
            act.MoveToElement(rightClickBtn).ContextClick().Build().Perform();
            singleClickBtn.Click();
            

        }
    }
}