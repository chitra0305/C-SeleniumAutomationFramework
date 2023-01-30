using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LearWebAutomation3001
{
    public class LoginApplitools
    {
        public IWebDriver driver;   
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demo.applitools.com/";
        }

        [Test]
        public void VerifyLogin()
        {
            driver.FindElement(By.Id("username")).SendKeys("ABCD");
            driver.FindElement(By.Id("password")).SendKeys("PASSWORD");
            driver.FindElement(By.Id("log-in")).Click();
            Assert.That(driver.FindElement(By.ClassName("logo-label")).Text, Is.EqualTo("ACME"));

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
;        }
    }
}