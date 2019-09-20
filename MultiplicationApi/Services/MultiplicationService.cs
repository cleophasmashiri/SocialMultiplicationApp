using System;
using Models;
using Services;

namespace Calculator.Services {
    public class MultiplicationService: IMultiplicationService
    {
        public MultiplicationService(IRandomNumberService _randomNumberService) {
            randomService =_randomNumberService;
        }
        private int factorA;
        private int factorB;

        private IRandomNumberService randomService;

        public int FactorA { get{return factorA;} }

        public int FactorB { get {return factorB;} }

        public Multiplication GetMultiplicationResult()
        {
            return new Multiplication(factorA, factorB);
        }

        public void GenerateRandomFactors()
        {
            factorA = randomService.GenerateRandomNumber();
            factorB = randomService.GenerateRandomNumber();
        }

        public bool CheckAttempt(MultiplicationResultAttempt attempt)
        {
            return attempt.ResultAttempt == attempt.Multiplication.FactorA * attempt.Multiplication.FactorB;
        }

    }
}