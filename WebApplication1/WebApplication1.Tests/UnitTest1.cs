using System;
using NUnit.Framework;
using ServiceStack;
using ServiceStack.Testing;
using WebApplication1.ServiceModel;
using WebApplication1.ServiceInterface;

namespace WebApplication1.Tests
{
    [TestFixture]
    public class UnitTests
    {
        private readonly ServiceStackHost appHost;

        public UnitTests()
        {
            appHost = new BasicAppHost(typeof(MyServices).Assembly)
            {
                ConfigureContainer = container =>
                {
                    //Add your IoC dependencies here
                }
            }
            .Init();
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            appHost.Dispose();
        }

        [Test]
        public void Test_Method1()
        {
            var service = appHost.Container.Resolve<MyServices>();

            var response = (HelloResponse)service.Any(new Hello { Name = "World" });

            Assert.That(response.Result, Is.EqualTo("Hello, World!"));
        }

        [Test]
        public void Test_Method2()
        {
            var service = appHost.Container.Resolve<MyServices>();
            var request = new Plus() {A = 12, B = 7};
            var response = (PlusResponse) service.Any(request);

            Assert.That(response.Result, Is.EqualTo(request.A + request.B));
        }
    }
}
