using System;
using System.IO;


namespace PartialDemo
{
     public partial class Calculation
    {
        public int sub(int a, int b)
        {
            return a - b;
            Divide(a, b);
        }
        public void Invoke(int a, int b)
        {
            Divide(a, b);
        }
        partial void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }


    }
}
