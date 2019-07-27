namespace Extension
{
    using Test;
    using FizzBuzz;

    public static class FizzBuzzExtension
    {
        public static string WithSay(this FizzBuzz fizzBuzz, int inputNumber)
        {
            return fizzBuzz.Say(inputNumber);
        }

        public static Test Message(this string message)
        {
            return new Test(message);
        }
    }
}
