using System;

namespace Parameters
{
    class Pass
    {
        public static void Value(ref int param) // public=visibility modifier, static=indicates a class, void
        {
            Console.WriteLine($"1. In method value, param is {param}");
            param = 42;
            Console.WriteLine($"2. In method value, param is {param}");
        }
        public static void Reference(WrappedInt param)
        {
            Console.WriteLine($"3. In method reference, param is {param}");
            param.Number = 42;
            Console.WriteLine($"4. In method reference, param is {param}");

        }
    }
}
