using System;
using System.Reflection;
using System.Reflection.Emit;

namespace DynamicMethodUsingMSIL
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class DynamicMethodUsingMSIL
    {
        private delegate long MultiplyBy2Add1(int input);

        private delegate TReturn OneParameter<TReturn, TParameter0>(TParameter0 p0);

        public static DynamicMethod MulBy2AndAdd1()
        {
            var f = DynamicMethod("MultiplyBy2AndAdd1", typeof(int), new[] {typeof(int)},
                typeof(DynamicMethodUsingMSIL).Module);
            OneParameter<int, int> invokeSquareIt =
                (OneParameter<int, int>)
                f.CreateDelegate(typeof(OneParameter<int, int>));
        }
    }
}