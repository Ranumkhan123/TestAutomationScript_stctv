using Docker.DotNet.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAutomation_subscribestctv.Pages
{
    public class KSA : CorePage
    {
        By plantype = By.XPath("//strong[@id='name-lite']");
        By countryname = By.XPath("//span[@id='country-name']");
        By monthlyprice = By.XPath("//div[@id='currency-lite']");
        By classicplantype = By.XPath("//strong[@id='name-classic']");
        By classicmonthlyprice = By.XPath("//div[@id='currency-classic']");
        By permiumplantype = By.XPath("//strong[@id='name-premium']");
        By permiummonthlyprice = By.XPath("//div[@id='currency-premium']");
        By litevideoquality = By.XPath("//div[normalize-space()='HD']");
        By classicvideoquality = By.XPath("//div[normalize-space()='Full HD']");
        By permiumvideoquality = By.XPath("//div[normalize-space()='4K UHD']");
        By permiumdeviceaccess = By.XPath("//div[normalize-space()='8']");
        By classicdeviceaccess = By.XPath("//div[normalize-space()='4']");
        By litedeviceaccess = By.XPath("//div[normalize-space()='4']");
        By literewind = By.XPath("//div[normalize-space()='1 Day']");
        By classicrewind = By.XPath("//div[normalize-space()='For 7 days']");
        By permiumrewind = By.XPath("//div[normalize-space()='For 14 days']");

        public void KSAPage(string URL)
        {

            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;

            //Actions Actions = new Actions(driver);

            driver.Manage().Window.Maximize();
            

            //URL
            driver.Url = URL;
            Console.WriteLine("URL: " + URL);
            Console.WriteLine();
            Thread.Sleep(1500);
            

            //TITLE 
            string title = driver.Title;
            Console.WriteLine("Title: " + title);
            Console.WriteLine();

            Console.WriteLine("KSA Subscription Packages");
            Console.WriteLine();
            Console.WriteLine();


            //Assert COUNTRY NAME

            string assertcountryname = CorePage.driver.FindElement(countryname).Text;
            Assert.AreEqual("KSA", assertcountryname);
            Console.WriteLine("Country Name is: " + assertcountryname);
            Console.WriteLine();


            //Assert LITE PLAN NAME
            Console.WriteLine("Choose Your Plan");

            string assertplan = CorePage.driver.FindElement(plantype).Text;
            Assert.AreEqual("LITE", assertplan);
            Console.WriteLine("Plan Name is: " + assertplan);

            //Assert LITE Monthly price

            string assertmonthlyprice = CorePage.driver.FindElement(monthlyprice).Text;
            Assert.AreEqual("15 SAR/month", assertmonthlyprice);
            Console.WriteLine("Monthly price is: " + assertmonthlyprice);

            //Assert LITE Video quality

            string assertlitevideoquality = CorePage.driver.FindElement(litevideoquality).Text;
            Assert.AreEqual("HD", assertlitevideoquality);
            Console.WriteLine("Video Quality is: " + assertlitevideoquality);

            //Assert LITE Device access
            string assertlitedeviceaccess = CorePage.driver.FindElement(litedeviceaccess).Text;
            Assert.AreEqual("4", assertlitedeviceaccess);
            Console.WriteLine("Device Access is: " + assertlitedeviceaccess);

            //SCROLL DOWN
            scroll.ExecuteScript("window.scrollBy(0,350)");


            //Assert LITE Rewind
            string assertliterewind = CorePage.driver.FindElement(literewind).Text;
            Assert.AreEqual("1 Day", assertliterewind);
            Console.WriteLine("Rewind Day is: " + assertliterewind);
            Console.WriteLine();

            //SCROLL UP
            scroll.ExecuteScript("window.scrollBy(400,0)");


            //Assert CLASSIC PLAN NAME
            Console.WriteLine("Choose Your Plan");

            string assertclassicplan = CorePage.driver.FindElement(classicplantype).Text;
            Assert.AreEqual("CLASSIC", assertclassicplan);
            Console.WriteLine("Plan Name is: " + assertclassicplan);


            //Assert CLASSIC Monthly price

            string assertclassicmonthlyprice = CorePage.driver.FindElement(classicmonthlyprice).Text;
            Assert.AreEqual("25 SAR/month", assertclassicmonthlyprice);
            Console.WriteLine("Monthly price is: " + assertclassicmonthlyprice);

            //Assert CLASSIC Video quality

            string assertclassicvideoquality = CorePage.driver.FindElement(classicvideoquality).Text;
            Assert.AreEqual("Full HD", assertclassicvideoquality);
            Console.WriteLine("Video Quality is: " + assertclassicvideoquality);

            //Assert CLASSIC Device access
            string assertclassicdeviceaccess = CorePage.driver.FindElement(classicdeviceaccess).Text;
            Assert.AreEqual("4", assertclassicdeviceaccess);
            Console.WriteLine("Device Access is: " + assertclassicdeviceaccess);

            //SCROLL DOWN
            scroll.ExecuteScript("window.scrollBy(0,350)");


            //Assert CLASSIC Rewind
            string assertclassicrewind = CorePage.driver.FindElement(classicrewind).Text;
            Assert.AreEqual("For 7 days", assertclassicrewind);
            Console.WriteLine("Rewind Day is: " + assertclassicrewind);
            Console.WriteLine();


            //SCROLL UP
            scroll.ExecuteScript("window.scrollBy(400,0)");

            //Assert PREMIUM PLAN NAME
            Console.WriteLine("Choose Your Plan");

            string assertpermiumplan = CorePage.driver.FindElement(permiumplantype).Text;
            Assert.AreEqual("PREMIUM", assertpermiumplan);
            Console.WriteLine("Plan Name is: " + assertpermiumplan);


            //Assert PREMIUM Monthly price

            string assertpermiummonthlyprice = CorePage.driver.FindElement(permiummonthlyprice).Text;
            Assert.AreEqual("60 SAR/month", assertpermiummonthlyprice);
            Console.WriteLine("Monthly price is: " + assertpermiummonthlyprice);


            //Assert PREMIUM Video quality

            string assertpermiumvideoquality = CorePage.driver.FindElement(permiumvideoquality).Text;
            Assert.AreEqual("4K UHD", assertpermiumvideoquality);
            Console.WriteLine("Video Quality is: " + assertpermiumvideoquality);

            //Assert PREMIUM Device access
            string assertpermiumvdeviceaccess = CorePage.driver.FindElement(permiumdeviceaccess).Text;
            Assert.AreEqual("8", assertpermiumvdeviceaccess);
            Console.WriteLine("Device Access is: " + assertpermiumvdeviceaccess);


            //SCROLL DOWN
            scroll.ExecuteScript("window.scrollBy(0,350)");


            //Assert PREMIUM Rewind
            string assertpremiumrewind = CorePage.driver.FindElement(permiumrewind).Text;
            Assert.AreEqual("For 14 days", assertpremiumrewind);
            Console.WriteLine("Rewind Day is: " + assertpremiumrewind);
            Console.WriteLine();




        }

    }
    }
