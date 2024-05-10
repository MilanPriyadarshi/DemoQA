using DemoQA.Driver1;
using DemoQA.HomePage1;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoQA.PracticeForm1
{
    class PracticeForm:Driver{
        public PracticeForm(IWebDriver _driver)
        {
            driver=_driver;
            PageFactory.InitElements(driver,this);
        }
        [FindsBy(How=How.XPath,Using ="//span[text()='Practice Form']")]
        IWebElement pracformClick;
        [FindsBy(How=How.Id,Using ="firstName")]
        IWebElement fname;
        [FindsBy(How=How.Id,Using ="lastName")]
        IWebElement lname;
        [FindsBy(How=How.Id,Using ="userEmail")]
        IWebElement femail;
        public void FormOperations(string fullname,string lastname,string fullemail)
        {
            HomePage home= new HomePage(driver);
            home.LaunchForm();
            IJavaScriptExecutor js=(IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)",fname);
            fname.SendKeys(fullname);
            lname.SendKeys(lastname);
            femail.SendKeys(fullemail);
        }
    }
}