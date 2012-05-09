using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



/*
Exercise C# 2.4 
The purpose of this exercise is to investigate type parameter constraints. You may continue with the same source file as in the previous two exercises.
We want to declare a method similar to GreaterCount above, but now it should work for an enumerable
with any element type T, not just double. But then we need to know that values of type T can be compared to
each other. Therefore we need a constraint on type T:
static int GreaterCount<T>(IEnumerable<T> eble, T x) where T : ... { ... }
(Note that in C# methods can be overloaded also on the number of type parameters; and the same holds for generic classes, interfaces and struct types). Complete the type constraint and the method body. Try the method on your List<double> and on various array types such as int[] and String[]. This should work because whenever T is a simple type or String, T implements IComparable<T>.
*/


namespace Generic_List
{
    public class List_Demo
    {
        static int GreaterCount<T>(IEnumerable<T> eble, double min) where T : IComparable
        {
            Console.WriteLine("\n\n Exercise 4 Output :- ");
            int count = 0;

            Console.WriteLine(" Max Value using IEnumerable for Generic type :- " + eble.Max());
            foreach (T item in eble)
            {
                if (item.CompareTo(min) > 0)
                {
                    count++;
                }

            }

            return count;
        }


        public static void Main(string[] args)
        {
            List<double> temperatures = new List<double>();

            temperatures.Add(24.7);
            temperatures.Add(5.7);
            temperatures.Add(70.0);
            temperatures.Add(25.2);
            temperatures.Add(55.2);


            

            Console.WriteLine(" No of count Which is Greater than or equle to 25 degree:- " + GreaterCount((IEnumerable<double>)temperatures, 25));
            Console.ReadLine();
        }
    }
}
