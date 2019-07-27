namespace Test
{
    public class Assertion
    {
        private string actualMessage;

        public Assertion(string actualMessage)
        {
            this.actualMessage = actualMessage;
        }

        public bool EqualTo(string expectedMessage)
        {
            return expectedMessage == this.actualMessage;
        }
    }
}
