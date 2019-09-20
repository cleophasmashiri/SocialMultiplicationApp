using System;

namespace Services {
    public class RandomNumberService : IRandomNumberService
    {
         private const int MIN_FACTOR = 1;
         private const int MAX_FACTOR = 1000;
        public int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(MIN_FACTOR, MAX_FACTOR);
        }
    }
}