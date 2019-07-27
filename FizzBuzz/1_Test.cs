namespace Test
{
    public class Test
    {
        public Assertion ShouldBe;

        public Test(string message)
        {
            ShouldBe = new Assertion(message);
        }
    }
}
