using AnhTesterHRM.bases;
using NUnit.Framework;

namespace AnhTesterHRM.tests
{
    class HomePageTest : BaseTest
    {
        HomePage homePage = new HomePage();
        LoginPage loginPage = new LoginPage();

        [SetUp]
        public void SetupBeforeTestHomePage()
        {
            loginPage.Login("admin01", "123456");
        }

        //Pass
        [Test]
        public void CheckHomeValueTest()
        {
            Assert.AreEqual("pass", homePage.CheckHomepageInfor("₫0.00", "0", "0", "0"));
        }

        //Pass
        [Test]
        public void CheckLeftBar()
        {
            Assert.AreEqual(5, homePage.CheckLeftBarClick());
        }

        //Fail, bug on Xpath
        [Test]
        public void CheckDropDown()
        {
            Assert.AreEqual("https://hrm.anhtester.com/erp/leave-list", homePage.CheckDropDown());
        }

        //Pass
        [Test]
        public void CheckHomeDropDownBtn()
        {
            Assert.IsNotNull(homePage.CheckDropDownMenu());
        }


        [Test]
        public void CheckViewDetailProject()
        {
            Assert.AreSame("View project detail successfully", homePage.CheckViewProjectDetail());
        }


        [Test]
        public void CheckDeleteProject()
        {
            Assert.AreSame("Delete project detail successfully", homePage.CheckDeleteProject());
        }

    }
}
