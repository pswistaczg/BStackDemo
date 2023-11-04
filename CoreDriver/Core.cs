using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CoreDriver
{
    public class Core
    {
        private IWebDriver coreDriver;
        private IWebElement element; //current element to work with
        private ReadOnlyCollection<IWebElement> elements;
        public IWebDriver Driver
        {
            get { return coreDriver; }
            private set { }
        }
        public IWebElement Element
        {
            get { return element; }
            private set { }
        }
        public ReadOnlyCollection<IWebElement> Elements
        {
            get { return elements; }
            private set { }
        }
        public Core()
        {
            coreDriver = new ChromeDriver();//open browser
        }
        public void Quit()
        {
            coreDriver.Quit();
        }
        public void Navigate(string url)
        {
            coreDriver.Navigate().GoToUrl(url);
        }
        public void FindElement (By locator)
        {
            element = coreDriver.FindElement(locator);
        }
        public void FindElements(By locator)
        {
            elements = coreDriver.FindElements(locator);
        }
    }
}