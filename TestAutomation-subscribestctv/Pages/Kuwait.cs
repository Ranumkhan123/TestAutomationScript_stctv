using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAutomation_subscribestctv.Pages
{
    public class Kuwait : CorePage
    {
        By countryicon = By.XPath("//span[@id='country-name']");
        By selectcountry = By.XPath("//body/div[@id='wrapper']/div[@id='country-wrapper']/div[@id='country-selct']/a[@id='kw']/div[@id='kw-contry-flag']/img[1]");
        By countryname = By.XPath("//span[@id='country-name']");
        By liteplantype = By.XPath("//strong[@id='name-lite']");
        By litemonthlyprice = By.XPath("//div[@id='currency-lite']");
        By classicplantype = By.XPath("//strong[@id='name-classic']");
        By classicmonthlyprice = By.XPath("//div[@id='currency-classic']");
        By premiumplantype = By.XPath("//strong[@id='name-premium']");
        By premiummonthlyprice = By.XPath("//div[@id='currency-premium']");
        By litevideoquality = By.XPath("//div[normalize-space()='HD']");
        By classicvideoquality = By.XPath("//div[normalize-space()='Full HD']");
        By permiumvideoquality = By.XPath("//div[normalize-space()='4K UHD']");
        By permiumdeviceaccess = By.XPath("//div[normalize-space()='8']");
        By classicdeviceaccess = By.XPath("//div[normalize-space()='4']");
        By litedeviceaccess = By.XPath("//div[normalize-space()='4']");


        public void KuwaitPage(string URL)
        {

            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;

            //Actions Actions = new Actions(driver);

            driver.Manage().Window.Maximize();

            //URL
            driver.Url = URL;
            Console.WriteLine("URL: " + URL);
            Console.WriteLine();


            //TITLE 
            string title = driver.Title;
            Console.WriteLine("Title: " + title);
            Console.WriteLine();

            //CHANGE COUNTRY 
            driver.FindElement(countryicon).Click();
            driver.FindElement(selectcountry).Click();
            Thread.Sleep(2000);


            Console.WriteLine("Kuwait Subscription Packages");
            Console.WriteLine();
            Console.WriteLine();


            //Assert COUNTRY NAME

            string assertcountryname = CorePage.driver.FindElement(countryname).Text;
            Assert.AreEqual("Kuwait", assertcountryname);
            Console.WriteLine("Country Name is: " + assertcountryname);
            Console.WriteLine();


            //Assert LITE PLAN NAME
            Console.WriteLine("Choose Your Plan");

            string assertplan = CorePage.driver.FindElement(liteplantype).Text;
            Assert.AreEqual("LITE", assertplan);
            Console.WriteLine("Plan Name is: " + assertplan);

            //Assert LITE Monthly price

            string assertmonthlyprice = CorePage.driver.FindElement(litemonthlyprice).Text;
            Assert.AreEqual("1.2 KWD/month", assertmonthlyprice);
            Console.WriteLine("Monthly price is: " + assertmonthlyprice);

            //Assert LITE Video quality

            string assertlitevideoquality = CorePage.driver.FindElement(litevideoquality).Text;
            Assert.AreEqual("HD", assertlitevideoquality);
            Console.WriteLine("Video Quality is: " + assertlitevideoquality);

            //Assert LITE Device access
            string assertlitedeviceaccess = CorePage.driver.FindElement(litedeviceaccess).Text;
            Assert.AreEqual("4", assertlitedeviceaccess);
            Console.WriteLine("Device Access is: " + assertlitedeviceaccess);
            Console.WriteLine();
            Console.WriteLine();



            //Assert CLASSIC PLAN NAME
            Console.WriteLine("Choose Your Plan");

            string assertclassicplan = CorePage.driver.FindElement(classicplantype).Text;
            Assert.AreEqual("CLASSIC", assertclassicplan);
            Console.WriteLine("Plan Name is: " + assertclassicplan);

            //Assert CLASSIC Monthly price

            string assertclassicmonthlyprice = CorePage.driver.FindElement(classicmonthlyprice).Text;
            Assert.AreEqual("2.5 KWD/month", assertclassicmonthlyprice);
            Console.WriteLine("Monthly price is: " + assertclassicmonthlyprice);

            //Assert CLASSIC Video quality

            string assertclassicvideoquality = CorePage.driver.FindElement(classicvideoquality).Text;
            Assert.AreEqual("Full HD", assertclassicvideoquality);
            Console.WriteLine("Video Quality is: " + assertclassicvideoquality);

            //Assert CLASSIC Device access
            string assertclassicdeviceaccess = CorePage.driver.FindElement(classicdeviceaccess).Text;
            Assert.AreEqual("4", assertclassicdeviceaccess);
            Console.WriteLine("Device Access is: " + assertclassicdeviceaccess);
            Console.WriteLine();
            Console.WriteLine();


            //Assert PREMIUM PLAN NAME
            Console.WriteLine("Choose Your Plan");

            string assertpremiumplan = CorePage.driver.FindElement(premiumplantype).Text;
            Assert.AreEqual("PREMIUM", assertpremiumplan);
            Console.WriteLine("Plan Name is: " + assertpremiumplan);

            //Assert PREMIUM Monthly price

            string assertpermiummonthlyprice = CorePage.driver.FindElement(premiummonthlyprice).Text;
            Assert.AreEqual("4.8 KWD/month", assertpermiummonthlyprice);
            Console.WriteLine("Monthly price is: " + assertpermiummonthlyprice);

            //Assert PREMIUM Video quality

            string assertpermiumvideoquality = CorePage.driver.FindElement(permiumvideoquality).Text;
            Assert.AreEqual("4K UHD", assertpermiumvideoquality);
            Console.WriteLine("Video Quality is: " + assertpermiumvideoquality);

            //Assert PREMIUM Device access
            string assertpermiumvdeviceaccess = CorePage.driver.FindElement(permiumdeviceaccess).Text;
            Assert.AreEqual("8", assertpermiumvdeviceaccess);
            Console.WriteLine("Device Access is: " + assertpermiumvdeviceaccess);
            Console.WriteLine();
            Console.WriteLine();


            Thread.Sleep(1000);

        }

        }
}
