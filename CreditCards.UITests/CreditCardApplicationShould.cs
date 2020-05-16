using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CreditCards.UITests
{
    [Trait("Category", "Application")]
    public class CreditCardApplicationShould
    {
        private const string HomeUrl = "http://localhost:44108";
        private const string ApplyUrl = "http://localhost:44108/Apply";
        private const string applyTitle = "Credit Card Application - Credit Cards";

        [Fact]
        public void BeInitiatedFromHomePage_NewLowRate()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);
                DemoHelper.Pause();

                IWebElement applyLowRateElement = driver.FindElement(By.Name("ApplyLowRate"));
                applyLowRateElement.Click();

                Assert.Equal(ApplyUrl, driver.Url);
                Assert.Equal(applyTitle, driver.Title);
            }
        }

        [Fact]
        public void BeInitiatedFromHomePage_EasyApplication()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);
                DemoHelper.Pause();

                IWebElement easyApplyNow = driver.FindElement(By.LinkText("Easy: Apply Now!"));
                easyApplyNow.Click();

                Assert.Equal(ApplyUrl, driver.Url);
                Assert.Equal(applyTitle, driver.Title);
            }
        }
    }
}
