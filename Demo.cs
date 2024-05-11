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
      //  [Test]
       public void Test1()
       {
         driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
         driver.Manage().Window.Maximize();
         driver.FindElement(By.XPath("//input[@id='firstName']")).SendKeys("Milan");
       }
       [TearDown]
       public void closing()
       {
        driver.Close();
       }

        
    }
}