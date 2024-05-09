using DemoQA.Driver1;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoQA.HomePage1
{
    class HomePage:Driver{
        public HomePage(IWebDriver _driver)
        {
            driver=_driver;
            PageFactory.InitElements(driver,this);
        }
        [FindsBy(How=How.XPath,Using ="//h5[text()='Elements']")]
        IWebElement elementsBtn;
        public void LauchElements()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver; js.ExecuteScript("arguments[0].scrollIntoView(true)", elementsBtn);
            elementsBtn.Click();
        }


    }
}