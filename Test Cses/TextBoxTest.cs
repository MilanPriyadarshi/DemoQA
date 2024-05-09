using DemoQA.Driver1;
using DemoQA.HomePage1;
using DemoQA.TextBox1;
namespace DemoQA.TextBoxTest
{
    class TextBoxTest:Driver
    {
        [Test]
        public void TestTextBox()
        {
          TextBox tb=new TextBox(driver);
          tb.TextOperation("MilanPriyadarshi","milan@gmail.com","bhubaneswar","Gainga");  
        }
    }
}