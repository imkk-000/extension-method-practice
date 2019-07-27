namespace BlackBox {
    public class MyBlackBoxClass {
        public string GetMessage() {
            return "Return this message from BlackBox.";
        }
    }
}

namespace Extensions {
    using System;
    using BlackBox;

    public static class ExtensionMethodClass {
        public static int GetNumber(this MyBlackBoxClass myBlackBoxClass) {
            return 191;
        }
    }

    class Program {
        static void Main(string[] args) {
            MyBlackBoxClass myBlackBoxClass = new MyBlackBoxClass();
            Console.WriteLine(myBlackBoxClass.GetMessage());
            Console.WriteLine(myBlackBoxClass.GetNumber());
        }
    }
}
