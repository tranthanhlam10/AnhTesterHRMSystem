using System.Threading;
using AnhTesterHRM.bases;
using AnhTesterHRM.utils;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace AnhTesterHRM.tests
{
    class BaseTest
    {
        BasePage basePage = new BasePage();
        ConfigSetting config = new ConfigSetting();

        [SetUp]
        public void SetUpTest()
        {
            //var browser = TestContext.Parameters.Get("Browser"); (1.you can use TextContext on Text Console Runner to Switch, but you must creat .Netcore project to install Nunit console).

            // 2.you can use Test Setting Arguments to handle switch browser, but is hard to setting ?
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("C:/AnhTesterHRM/AnhTesterHRM/utils/ConfigEnv.json");
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);
            Thread.Sleep(1000);
            basePage.SetupBrowser(config.env); // change env and env2 to switch browser. .
        }

        [TearDown]
        public void TearDown()
        {
            basePage.TearDown();
        }
    }
}
