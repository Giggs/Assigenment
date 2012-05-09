using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*   
     2.	Create a new source file. In a method, declare a variable temperatures of type List<double>. (The C# collection type List<T> is similar to Java’s ArrayList<T>). 
        Add some numbers to the list. Write a foreach loop to count the number of temperatures that equal or exceed 25 degrees.
        Write a method GreaterCount with signature static int GreaterCount(List<double> list, double min) { ... } that returns the number of elements of list that are greater than or equal to min. 
        Note that the method is not generic, but the type of one of its parameters is a type instance of the generic type List<T>. Call the method on your temperatures list.
*/

/*
     3. Write a generic method with signature static int GreaterCount(IEnumerable<double> eble, double min) { ... } that returns the number of elements of the enumerable eble that are greater than or equal to min.
        Call the method on an array of type double[]. Can you call it on an array of type int[]?
        Now call the method on temperatures which is a List<double>. If you just call
        GreaterCount(temperatures, 25.0) you’ll actually call the GreaterCount method declared in exercise 2.2 because that method is a better overload (more specific signature) than the new GreaterCount method. 
        To call the new one, you must cast temperatures to type IEnumerable<double>—and that’s legal in C#.
        
        In C# it is legal to overload a method on type instances of generic types. You may try this by declaring also static int GreaterCount(IEnumerable<String> eble, String min) { ... }
        This methods must have a slightly different method body, because the operators (<=) and (>=) are not defined on type String. Instead, use method CompareTo(...). 
        Maybe insert a Console.WriteLine(...) in each method to be sure which one is actually called.
  
*/



namespace ArrayList
{
    public class List
    {
        // Exercise 2
        public static int GreaterCount(List<double> temperatures, double min)
        {
            Console.WriteLine("\n Exercise 2 Output :- ");
            int count = 0;
            foreach (double content in temperatures)
            {

                if (content > min)
                    count++;
            }
            
            return count;
        }

        // Exercise 3
        static int GreaterCount(IEnumerable<double> eble, double min)
        {
            Console.WriteLine("\n\n Exercise 3 Output :- ");
            int count = 0;

            Console.WriteLine(" Max Value using IEnumerable:- " + eble.Max());
            foreach (double content in eble)
            {
                if (content >= min)
                    count++;
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

            //Console.WriteLine("\n No of count Which is Greater than 25 degree:- " + GreaterCount(temperatures,25));

            Console.WriteLine(" No of count Which is Greater than or equle to 25 degree:- " + GreaterCount((IEnumerable<double>)temperatures, 25));
            Console.ReadLine();
        }
        
    }
}
