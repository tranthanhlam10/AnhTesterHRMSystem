using AnhTesterHRM.bases;
using AnhTesterHRM.utils;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace AnhTesterHRM.tests
{
    [TestFixture]
    class LoginTest : BaseTest
    {
        static ExcelReader excelReader = new ExcelReader("Resources/CsharpExcelReader.xlsx", "Sheet1");


        [Test]
        [TestCase("employee01", "123456")]
        [TestCase("leader01", "123456")]
        [TestCase("admin01", "123456")]
        [TestCase("client01", "123456")]
        public void LoginTestBasic(string userName, string passWord)
        {

            Assert.AreEqual("https://hrm.anhtester.com/erp/desk", LoginPage.GetInstance().Login(userName, passWord));
        }

        [Test]
        [Category("Login")]
        public void LogoutTest()
        {
            LoginPage.GetInstance().Login("admin01", "123456");
            Assert.AreNotEqual("Cant not logout this page", LoginPage.GetInstance().Logout());
        }


        [Test]
        public void LoginTestExcelFile()
        {
             Assert.AreEqual("https://hrm.anhtester.com/erp/desk", LoginPage.GetInstance().Login(excelReader.GetCellData(1), excelReader.GetCellData(2))); 
        }
    }
}
