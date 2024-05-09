using System.Drawing;
using DemoQA.Driver1;
using DemoQA.HomePage1;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoQA.TextBox1
{
    class TextBox:Driver{
        public TextBox(IWebDriver _driver)
        {
            driver=_driver;
            PageFactory.InitElements(driver,this);

        }
        [FindsBy(How=How.XPath,Using ="//span[text()='Text Box']")]
        IWebElement textBtn;
        [FindsBy(How=How.Id,Using ="userName")]
        IWebElement fullName;
        [FindsBy(How=How.Id,Using ="userEmail")]
        IWebElement emailf;
        [FindsBy(How=How.Id,Using ="currentAddress")]
        IWebElement cAddress;
        [FindsBy(How=How.Id,Using ="permanentAddress")]
        IWebElement PAddress;
        [FindsBy(How=How.Id,Using ="submit")]
        IWebElement textSubmitBtn;
        public void TextOperation(string fname,string email,string cadd,string padd)
        {
            HomePage homePage=new HomePage(driver);
            homePage.LauchElements();
            IJavaScriptExecutor js=(IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)",textBtn);
            textBtn.Click();
            fullName.SendKeys(fname);
            emailf.SendKeys(email);
            cAddress.SendKeys(cadd);
            PAddress.SendKeys(padd);
            js.ExecuteScript("arguments[0].scrollIntoView(true)",textSubmitBtn);
            textSubmitBtn.Click();

        }

    }
}