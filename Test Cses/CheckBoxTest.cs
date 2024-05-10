using DemoQA.CheckBox1;
using DemoQA.Driver1;
using DemoQA.HomePage1;
using DemoQA.TextBox1;
namespace DemoQA.CheckBoxTest1
{
    class CheckBoxTest:Driver
    {
        [Test]
        public void TestTextBox()
        {
          CheckBox cb=new CheckBox(driver);
          cb.CheckBoxOperations();
        }
    }
}