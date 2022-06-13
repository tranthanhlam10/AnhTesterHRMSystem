using AnhTesterHRM.bases;
using NUnit.Framework;

namespace AnhTesterHRM.tests
{
    class HomePageTest : BaseTest
    {
       

        [SetUp]
        public void SetupBeforeTestHomePage()
        {
            LoginPage.GetInstance().Login("leader01", "123456");
        }

        //Pass
        [Test]
        public void CheckHomeValueTest()
        {
            Assert.IsTrue(HomePage.GetInstance().CheckHomepageInfor("₫0.00", "0", "0", "0"));
        }

        //Pass
        [Test]
        public void CheckLeftBar()
        {
            Assert.AreEqual(5, HomePage.GetInstance().CheckLeftBarClick());
        }

        //Fail, bug on Xpath
        [Test]
        public void CheckDropDown()
        {
            Assert.AreEqual("https://hrm.anhtester.com/erp/leave-list", HomePage.GetInstance().CheckDropDown());
        }

        //Pass
        [Test]
        public void CheckHomeDropDownBtn()
        {
            Assert.IsNotNull(HomePage.GetInstance().CheckDropDownMenu());
        }


        [Test]
        public void CheckViewDetailProject()
        {
            Assert.AreSame("View project detail successfully", HomePage.GetInstance().CheckViewProjectDetail());
        }


        [Test]
        public void CheckDeleteProject()
        {
            Assert.IsNotNull(HomePage.GetInstance().CheckDeleteProject());
        }

    }
}
