using Microsoft.VisualStudio.TestPlatform.TestHost;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumExperiment
{
    public class Tests
    {
        IWebDriver driver;

        public Tests()
        {
            driver = new ChromeDriver();
        }

        [Fact]
        public void Title_ShouldBe_AboutPairSoftInChrome()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

            driver.Navigate().GoToUrl("https://www.pairsoft.com/about-us/");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

            Assert.Equal("About PairSoft", driver.Title);

            driver.Quit();
        }

        [Fact]
        public void ButtonText_ShouldBe_BecomeAPartner()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

            driver.Navigate().GoToUrl("https://www.pairsoft.com/resources/white-papers/");
            IWebElement becomeAPartnerButton = driver.FindElement(By.ClassName("alt-outline"));

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

            Assert.Equal("Become a Partner", becomeAPartnerButton.Text);

            driver.Quit();
        }
    }
}