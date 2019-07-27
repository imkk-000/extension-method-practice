namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Say(int number)
        {
            if (isFizzBuzz(number))
            {
                return "FizzBuzz";
            }
            if (isFizz(number))
            {
                return "Fizz";
            }
            if (isBuzz(number))
            {
                return "Buzz";
            }
            return number.ToString();
        }

        private bool isFizz(int number)
        {
            return number % 3 == 0;
        }

        private bool isBuzz(int number)
        {
            return number % 5 == 0;
        }

        private bool isFizzBuzz(int number)
        {
            return number % 15 == 0;
        }
    }
}
