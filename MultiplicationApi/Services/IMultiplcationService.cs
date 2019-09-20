using Models;

namespace Calculator.Services
{
    public interface IMultiplicationService
    {
        Multiplication GetMultiplicationResult();

        bool CheckAttempt(MultiplicationResultAttempt attempt);
    }
}