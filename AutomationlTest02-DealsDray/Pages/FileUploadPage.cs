using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationlTest02_DealsDray.Pages
{
    public class FileUploadPage
    {
        private readonly IWebDriver driver;
        public FileUploadPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement OrderTab => driver.FindElement(By.XPath("//span[text()='Order']"));
        IWebElement OrdersLink => driver.FindElement(By.LinkText("Orders"));
        IWebElement AddBulkOrders => driver.FindElement(By.XPath("//*[@id=\"root\"]/descendant::div[@class=\"breadcrumb\"]/following-sibling::div/descendant::button"));
        IWebElement ChooseFile => driver.FindElement(By.XPath("//*[@id='root']/descendant::div[contains(@class,'css-uodm64')]"));

        public void UploadFiles(string FilePath)
        {
            OrderTab.Click();
            OrdersLink.Click();
            AddBulkOrders.Click();
            Thread.Sleep(10);
            ChooseFile.Click();
            Thread.Sleep(20);
            //Approach using SendKeys
            ChooseFile.SendKeys(FilePath);

            //Approach using AutoIT
            //AutoItX3 autoIt = new AutoItX3();
            //autoIt.WinActivate("Open");
            //autoIt.Send(FilePath);
            //Thread.Sleep(10);
            //autoIt.Send("{ENTER}");
        }
    }
}
