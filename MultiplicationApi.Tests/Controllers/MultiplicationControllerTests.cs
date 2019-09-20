using Calculator.Services;
using CalculatorApi.Controllers;
using Models;
using Moq;
using NFluent;
using NUnit.Framework;

namespace Tests.Controllers
{
    public class MultiplicationControllerTests
    {
        private Mock<IMultiplicationService> multiplicationSvcMaker;
        private MultiplicationController controller;

        [SetUp]
        public void Setup()
        {
            this.multiplicationSvcMaker = new Mock<IMultiplicationService>();
            this.controller = new MultiplicationController(multiplicationSvcMaker.Object);
        }

        [Test]
        public void givenRandomMultiRequestThenResponseTest()
        {
            var expectedMultiplication = new Multiplication(20,30);
             multiplicationSvcMaker.Setup(x => x.GetMultiplicationResult()).Returns(expectedMultiplication);
            var actualMultiplication = this.controller.GetRandomMultiplication();
            Check.That(expectedMultiplication.FactorA).IsEqualTo(actualMultiplication.Value.FactorA);
        }
    }
}