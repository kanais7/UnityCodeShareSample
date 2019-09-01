using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace UnityApp
{
    public class ConsoleRedirector : IDisposable
    {
        private readonly TextWriter previousOut = Console.Out;
        private readonly TextWriter previousError = Console.Error;

        public ConsoleRedirector()
        {
            Console.SetOut(new DebugLogWriter());
            Console.SetError(new DebugLogErrorWriter());
        }

        public void Dispose()
        {
            Console.SetOut(previousOut);
            Console.SetError(previousError);
        }
    }

    public class DebugLogWriter : TextWriter
    {
        public override void Write(string message) => Debug.Log(message);
        public override void WriteLine(string message) => Debug.Log(message);

        public override Encoding Encoding => Encoding.Default;
    }

    public class DebugLogErrorWriter : TextWriter
    {
        public override void Write(string message) => Debug.LogError(message);
        public override void WriteLine(string message) => Debug.LogError(message);

        public override Encoding Encoding => Encoding.Default;
    }
}
