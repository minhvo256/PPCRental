using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace PPCRental.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class SearchSteps
    {
        public IWebDriver _driver = new ChromeDriver();
        [Given(@"I access to PPC Rental Website")]
        public void GivenIAccessToPPCRentalWebsite()
        {
            _driver.Url = "http://localhost:2884/HomePage/Index";
        }
        [When(@"I press search button")]
        public void WhenIPressSearchButton()
        {
            _driver.FindElement(By.XPath("//*[@id='topsearch-btn']")).Click();

        }
        [When(@"I search for projects by the keyword 'Top'")]
        public void WhenISearchForProjectsByTheKeywordTop()
        {
            _driver.FindElement(By.XPath("//*[@id='ha']")).SendKeys("Top");
        }

        [When(@"I press on search button")]
        public void WhenIPressOnSearchButton()
        {
            _driver.FindElement(By.XPath("//*[@id='he']")).Click();
        }

        [Then(@"the list of found projects should contain only: 'PIS Top Apartment'")]
        public void ThenTheListOfFoundProjectsShouldContainOnlyPISTopApartment()
        {
            _driver.FindElement(By.XPath("/html/body/main/main/section/div[2]/div/div/div/h1")).Text.CompareTo("top");
        }
    }
}

