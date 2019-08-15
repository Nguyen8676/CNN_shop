using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebDriver_test3
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://localhost:54286/Nguoidung/Dangnhap ";
            driver.Manage().Window.Maximize();
           

            driver.FindElement(By.Id("TenDN")).SendKeys("Phi234");
            driver.FindElement(By.Id("Matkhau")).SendKeys("8676" + Keys.Enter);

            driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/div[1]/a[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div/div/div/a/div[1]/h4")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div/div[3]/div/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul[2]/li/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/table/tbody/tr[2]/td[8]/a")).Click();
        }
    }
}
