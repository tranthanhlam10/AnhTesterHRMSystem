using AnhTesterHRM.bases;
using NUnit.Framework;


namespace AnhTesterHRM.tests
{
    class EmployeeTest : BaseTest
    {
        LoginPage loginPage = new LoginPage();
        EmployeePage employeePage = new EmployeePage();

        [SetUp]
        public void setup()
        {
            loginPage.Login("admin01", "123456");
        }

        //Pass
        [Test]
        public void testRoleNameOnEmTable()
        {
            Assert.AreEqual(2, employeePage.FindEmRole());
        }

        //Pass
        [Test]
        public void testCountTotalColsAndRow()
        {
            Assert.AreEqual(15, employeePage.CountTotalRowsAndCols());
        }

        //Pass
        [Test]
        public void testFindNameOuputInfo()
        {
            Assert.IsTrue(employeePage.InputNameOutputInfo("1234567555"));
        }

        [Test]
        public void testFindNameOuputInfoByList()
        {
            Assert.IsTrue(employeePage.InputInfoOutPutInfo("012345"));
        }
    }
}

