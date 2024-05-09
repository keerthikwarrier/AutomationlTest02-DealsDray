using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AutomationlTest02_DealsDray.Pages;

namespace AutomationlTest02_DealsDray
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            //Launching the Chrome Browser
            driver = new ChromeDriver();
            //Maximize the window size
            driver.Manage().Window.Maximize();
            //Navigate to the URL
            driver.Navigate().GoToUrl("https://demo.dealsdray.com/");
        }

        [Test]
        public void UploadFileTestCase()
        {
            LoginPage loginpage = new LoginPage(driver);
            loginpage.Login("prexo.mis@dealsdray.com", "prexo.mis@dealsdray.com");
            FileUploadPage FUPage = new FileUploadPage(driver);
            FUPage.UploadFiles(@"C:\Users\\Keert\OneDrive\Desktop\demo-data.xlsx");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}