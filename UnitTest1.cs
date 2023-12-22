using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_NUnit_Project.BaseClass

namespace Selenium_NUnit_Project
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            
        }
    }
}
