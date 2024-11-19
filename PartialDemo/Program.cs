using System;
/*Partial Class
1.When we want to separate the task with multiple developers with diff files
2.Diff files have same class name, but having diff methods implementation
3.Complete the task of one class with help of multiple developers
//Partial Method
// in one file we have declared a method, & in another file we have provided the implementation
// if we have declared partial method & not provided the implementation
// then compiler will ignore the method
// it must be private & void return type for method

 */

namespace PartialDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            Console.WriteLine(c.add(10, 20));
            Console.WriteLine(c.sub(30, 20));
            Console.WriteLine(c.mul(10, 20));
            c.Invoke(50, 5);
     
        }
    }
}
