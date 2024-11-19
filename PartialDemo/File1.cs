using System;

namespace PartialDemo
{
     public partial class Calculation
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        partial void Divide(int a, int b);

    }
}
