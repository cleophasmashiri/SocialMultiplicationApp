using System.Collections.Generic;
using System.Linq;
using Moq;
using NFluent;
using NUnit.Framework;
using Services;

namespace Test
{

    public class RandomNumberServiceTests
    {
        private RandomNumberService randomSvc;

        [SetUp]
        public void Setup()
        {
            randomSvc = new RandomNumberService();
        }

        [Test]
        public void shouldGenerateRandomNumbers()
        {
            Check.That(randomSvc.GenerateRandomNumber()).IsNotEqualTo(randomSvc.GenerateRandomNumber());
        }

        [Test]
        public void shouldGenerateNumbersWithinLimits() {
            int factorGreaterThan = 0;
            int factorLessThan = 1000;
               List<int> factors = Enumerable.Range(factorGreaterThan, factorLessThan).Select(x => randomSvc.GenerateRandomNumber()).ToList();
            Check.That(factors).ContainsOnlyElementsThatMatch(x => {return x >factorGreaterThan && x < factorLessThan;});
        }
    }
}