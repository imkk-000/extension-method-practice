namespace Extension
{
    using System;
    using Given;

    class Program
    {
        static void Main(string[] args)
        {
            TestSampleData(1, "1");
            TestSampleData(3, "Fizz");
            TestSampleData(5, "Buzz");
            TestSampleData(15, "FizzBuzz");
        }

        static void TestSampleData(int inputNumber, string expectedMessage)
        {
            bool testResult =
                Given
                    .FizzBuzzClass.WithSay(inputNumber).Message()
                    .ShouldBe.EqualTo(expectedMessage)
                    ;
            Console.WriteLine("expect={0} input={1} result={2}", expectedMessage, inputNumber, testResult);
        }
    }
}
