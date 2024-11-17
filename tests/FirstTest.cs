using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumDotNet.Tests
{
    // Marking this class as a test fixture in NUnit
    [TestFixture]
    public class FirstTest
    {
        // Declare WebDriver for the test
        private IWebDriver driver;

        // This method runs before each test method (initial setup)
        [SetUp]
        public void Setup()
        {
            // Initialize ChromeDriver (make sure chromedriver is in your PATH or specify its location)
            driver = new ChromeDriver();
        }

        // This is a test method marked with NUnit's [Test] attribute
        [Test]
        public void OpenGoogleAndCheckTitle()
        {
            // Navigate to a URL
            driver.Navigate().GoToUrl("https://www.google.com");

            // Get the page title
            string title = driver.Title;

            // Assert that the title contains the word "Google"
             Assert.That(title.Contains("Google"), "Title does not contain 'Google'");
        }

        // This method runs after each test method (cleanup)
        [TearDown]
        public void TearDown()
        {
            // Close the browser and quit the driver
            driver.Quit();
        }
    }
}
