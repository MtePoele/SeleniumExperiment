using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumExperiment
{
    public class Tests
    {
        // Suppressed warning here. Making it a concrete type has test explorer opening blank Chrome windows.
#pragma warning disable CA1859 // Use concrete types when possible for improved performance
        readonly IWebDriver driver;
#pragma warning restore CA1859 // Use concrete types when possible for improved performance

        public Tests()
        {
            driver = new ChromeDriver();
        }

        [Fact]
        public void Title_ShouldBe_AboutPairSoftInChrome()
        {
            driver.Navigate().GoToUrl("https://www.pairsoft.com/about-us/");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);

            Assert.Equal("About PairSoft", driver.Title);

            driver.Quit();
        }

        [Fact]
        public void ButtonText_ShouldBe_BecomeAPartner()
        {
            driver.Navigate().GoToUrl("https://www.pairsoft.com/resources/white-papers/");
            IWebElement becomeAPartnerButton = driver.FindElement(By.ClassName("alt-outline"));

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);

            Assert.Equal("Become a Partner", becomeAPartnerButton.Text);

            driver.Quit();
        }
    }
}