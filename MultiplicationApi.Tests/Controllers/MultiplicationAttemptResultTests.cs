using Calculator.Services;
using CalculatorApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Moq;
using NFluent;
using NUnit.Framework;

namespace Tests.Controllers
{
    public class MultiplicationAttemptResultTests
    {
        private Mock<IMultiplicationService> multiplicationSvcMaker;
        private MultiplicationAttemptResultController controller;
        private readonly MultiplicationResultAttempt attempt;

        [SetUp]
        public void Setup()
        {
            multiplicationSvcMaker = new Mock<IMultiplicationService>();
            multiplicationSvcMaker.Setup(x=>x.CheckAttempt(It.IsAny<MultiplicationResultAttempt>())).Returns(true);
            this.controller = new MultiplicationAttemptResultController(multiplicationSvcMaker.Object);
        }

        [Test]
        public void givenRandomMultiRequestThenResponseTest()
        {
            // var expectedMultiplication = new Multiplication(20,30);
            //    var result = this.controller.GetMultiplicationResult(new MultiplicationResultAttempt(null,  null, 100));
            //Check.That(result).IsTrue()
            //multiplicationSvcMaker.Setup(x => x.CheckAttempt(It.IsAny<MultiplicationResultAttempt>())).Returns(true);
            //ActionResult<AttemptResponse> result = this.controller.GetMultiplicationResult(new MultiplicationResultAttempt(null,  null, 100));
            //Check.That(result.).IsTrue()
        }
    }
}