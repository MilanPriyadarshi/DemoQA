using DemoQA.Driver1;
using DemoQA.HomePage1;

namespace LauchElements
{
    class LauchElements:Driver
    {
        // [Test]
        public void lauchElement()
        {
            HomePage hp=new HomePage(driver);
            hp.LauchElements();
        }
    }
}