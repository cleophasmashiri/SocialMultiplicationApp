using Calculator.Services;
using Models;
using Moq;
using NFluent;
using NUnit.Framework;
using Services;

namespace Test
{

    public class MultiplicationServiceTests
    {
        private Mock<IRandomNumberService> randomSvc;
        private MultiplicationService multiplicationService;

        [SetUp]
        public void Setup()
        {
            randomSvc = new Mock<IRandomNumberService>();
            multiplicationService = new MultiplicationService(randomSvc.Object);
        }

        [Test]
        public void shouldGenerateRandAddSingletonomFactors()
        {

            randomSvc.SetupSequence(x => x.GenerateRandomNumber())
            .Returns(10)
            .Returns(2);

            multiplicationService.GenerateRandomFactors();
            Check.That(multiplicationService.FactorA).IsEqualTo(10);
            Check.That(multiplicationService.FactorB).IsEqualTo(2);
        }

        [Test]
        public void givenRandomFactorShouldReturnMultiplicationResult()
        {
            randomSvc.SetupSequence(x => x.GenerateRandomNumber())
         .Returns(10)
         .Returns(2);
            multiplicationService.GenerateRandomFactors();
            var multiplication = multiplicationService.GetMultiplicationResult();
            Check.That(multiplication.FactorA * multiplication.FactorB).IsEqualTo(20);
        }

        [Test]
        public void givenUserHasProvideCorrectAttemptShouldPass()
        {
            // given
            var multiplication = new Multiplication(40, 30);
            User user = new User("Paul");
            MultiplicationResultAttempt attempt = new MultiplicationResultAttempt(user, multiplication, 1200);

            // when 
            bool attemptResult = multiplicationService.CheckAttempt(attempt);

            // then 
            Check.That(attemptResult).IsTrue();
        }

        [Test]
        public void givenUserHasProvideCorrectAttemptShouldFail()
        {
            // given
            var multiplication = new Multiplication(40, 31);
            User user = new User("Paul");
            MultiplicationResultAttempt attempt = new MultiplicationResultAttempt(user, multiplication, 1200);

            // when 
            bool attemptResult = multiplicationService.CheckAttempt(attempt);

            // then 
            Check.That(attemptResult).IsFalse();
            
        }
    }
}