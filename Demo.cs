using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA.Demo{
    class Demo{

       public IWebDriver driver;
       [SetUp]
       public void intialize()
       {
            driver=new ChromeDriver();
    
       }
       public void Test1()
       {
         driver.Navigate().GoToUrl("https://www.google.com");
         driver.Manage().Window.Maximize();
       }
       [TearDown]
       public void closing()
       {
        driver.Close();
       }

        
    }
}