using DemoQA.Driver1;
using DemoQA.HomePage1;
using DemoQA.PracticeForm1;
using DemoQA.TextBox1;
namespace DemoQA.FormTest
{
    class FormTest:Driver
    {
        [Test]
        public void TestForm()
        {
          PracticeForm pf=new PracticeForm(driver);
          pf.FormOperations("Milan","Priyadarshi","milan@gmail.com");
        }
    }
}