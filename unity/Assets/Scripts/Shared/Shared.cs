using System;

namespace Shared
{
    public static class SharedClass
    {
        public static string GetText()
        {
            return "from shared!";
        }

        public static void DoSomething()
        {
            Console.WriteLine("do something");
        }
    }
}
