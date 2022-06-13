using OpenQA.Selenium;

namespace AnhTesterHRM.DriverManage
{
    public abstract class BDriverManager
    {
        public abstract IWebDriver GetDriver();
    }
}
