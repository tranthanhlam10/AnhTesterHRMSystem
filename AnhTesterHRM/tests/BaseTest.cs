using AnhTesterHRM.bases;
using AnhTesterHRM.utils;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace AnhTesterHRM.tests
{
    class BaseTest
    {
       
        ConfigSetting config = new ConfigSetting();
        BasePage page = new BasePage();
        public string ReadJson()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("utils/ConfigEnv.json");
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);
            return config.env;
        }

        [SetUp]
        public void SetUpTest()
        {                 
            page.SetupBrowser(ReadJson()); // change env and env2 to switch browser. .
        }

        [TearDown]
        public void TearDown()
        {
            page.TearDown();
        }
    }
}
