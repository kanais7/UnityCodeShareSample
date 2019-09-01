using System;
using Newtonsoft.Json;

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
            
            #if UNITY_2017_1_OR_NEWER
            Console.WriteLine("execute in unity");
            #endif
            
            #if NETCOREAPP
            Console.WriteLine("execute in .netcoreapp");
            #endif
        }
    }
}
