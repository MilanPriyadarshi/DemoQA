using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA.Driver1{
    class Driver{

       public static IWebDriver driver;
       [SetUp]
       public void intialize()
       {
            driver=new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/");
    
       }
       [TearDown]
       public void closing()
       {
        driver.Close();
       }

        
    }
}