namespace SimpleJsonTests.DataContractTests
{
#if NUNIT
    using TestClass = NUnit.Framework.TestFixtureAttribute;
    using TestMethod = NUnit.Framework.TestAttribute;
    using TestCleanup = NUnit.Framework.TearDownAttribute;
    using TestInitialize = NUnit.Framework.SetUpAttribute;
    using ClassCleanup = NUnit.Framework.TestFixtureTearDownAttribute;
    using ClassInitialize = NUnit.Framework.TestFixtureSetUpAttribute;
    using NUnit.Framework;
#else
    using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

    using SimpleJson;

    public class PublicSettersSerializeTests
    {
        private DataContractPublicSetters _dataContractPublicSetters;

        public PublicSettersSerializeTests()
        {
            _dataContractPublicSetters = new DataContractPublicSetters();
        }

        [Test]
        public void SerializesCorrectly()
        {
            var result = SimpleJson.SerializeObject(_dataContractPublicSetters,
                                                    SimpleJson.DataContractJsonSerializerStrategy);

            Assert.AreEqual("{}", result);
        }
    }
}