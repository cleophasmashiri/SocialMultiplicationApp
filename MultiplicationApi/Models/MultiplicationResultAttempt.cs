using System;

namespace Models
{
    public class MultiplicationResultAttempt
    {

        public MultiplicationResultAttempt(User user, Multiplication multiplication, int attempt)
        {
            this.User = user;
            this.Multiplication = multiplication;
            this.ResultAttempt = attempt;
        }

        public User User {get;}

        public Multiplication Multiplication {get;}

        public int ResultAttempt {get;set;}

    }
}