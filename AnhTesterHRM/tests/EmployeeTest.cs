using AnhTesterHRM.bases;
using NUnit.Framework;


namespace AnhTesterHRM.tests
{
    class EmployeeTest : BaseTest
    {
       
        [SetUp]
        public void setup()
        {
            LoginPage.GetInstance().Login("admin01", "123456");
        }

        //Pass
        [Test]
        public void testRoleNameOnEmTable()
        {
            Assert.AreEqual(2, EmployeePage.GetInstance().FindEmRole());
        }

        //Pass
        [Test]
        public void testCountTotalColsAndRow()
        {
            Assert.AreEqual(15, EmployeePage.GetInstance().CountTotalRowsAndCols());
        }

        //Pass
        [Test]
        public void testFindNameOuputInfo()
        {
            Assert.IsTrue(EmployeePage.GetInstance().InputNameOutputInfo("1234567555"));
        }

        //Fail  
        [Test]
        public void testFindNameOuputInfoByList()
        {
            Assert.IsFalse(EmployeePage.GetInstance().InputInfoOutPutInfo("012345"));
        }
    }
}

