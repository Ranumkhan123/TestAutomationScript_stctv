using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestAutomation_subscribestctv.Pages;

namespace TestAutomation_subscribestctv
{
    [TestClass]
    public class TestCases
    {
        KSA ksa = new KSA();
        Kuwait kuwait = new Kuwait();
        Bahrain bahrain = new Bahrain();

        [TestMethod]
        public void KSATestCase()
        {

            CorePage.SeleniumInit();
            ksa.KSAPage("https://subscribe.stctv.com/sa-en");

            CorePage.driver.Close();
        }

        [TestMethod]
        public void KuwaitTestCase()
        {

            CorePage.SeleniumInit();
            kuwait.KuwaitPage("https://subscribe.stctv.com/sa-en");

            CorePage.driver.Close();
        }

        [TestMethod]
        public void BahrainTestCase()
        {

            CorePage.SeleniumInit();
            bahrain.BahrainPage("https://subscribe.stctv.com/sa-en");

            CorePage.driver.Close();
        }
    }
}
