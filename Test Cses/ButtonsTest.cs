using DemoQA.Buttons1;
using DemoQA.Driver1;
using DemoQA.HomePage1;
using DemoQA.TextBox1;
namespace DemoQA.ButtonsTest
{
    class ButtonsTest:Driver
    {
        [Test]
        public void TestButtons()
        {
         Buttons btns= new Buttons(driver);
         btns.ButtonsOperations();  
        }
    }
}