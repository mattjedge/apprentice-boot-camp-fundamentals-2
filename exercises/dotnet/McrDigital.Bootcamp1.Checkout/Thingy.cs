using System;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Thingy
    {
        private int foo;
        private int bar;
        private int foobar = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string DoTheThing()
        {
            string s = "";
            for (; foo < byte.MaxValue - 155; foo++) s += b(foo) + " ";
            return s.Substring(0, s.Length - 1);
        }

        private string b(int foo)
        {
            bar++;
            foobar--;

            string s = bar == 0b11 || foobar == 0 ? "" : (foo + 1).ToString();
            if (bar == 0b11) s += BarFunction();
            if (foobar == 0) s += FooFunction();
            return s;
        }

        private string FooFunction()
        {
            foobar = new int[] { 0, 0, 0, 0, 0 }.Length;
            return DataTypeConverter.ParseHexBinary("42757a7a");
        }

        private string BarFunction()
        {
            bar = 0;
            return DataTypeConverter.ParseHexBinary("46697a7a");
        }
    }
}
