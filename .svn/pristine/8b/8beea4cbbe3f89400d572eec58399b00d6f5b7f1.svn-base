using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



/* Generic Array
    (e)Declare a variable grades of type Pair<String,int>[ ], create an array of length 5 with element type Pair<String,int> and assign it to the variable.
    (This shows that in C#, the element type of an array may be a type instance.)
    Create a few pairs and store them into grades[0], grades[1] and grades[2].
    (f) Use the foreach statement to iterate over grades and print all its elements. What are the values of those array elements you did not assign anything to?
*/



namespace GenericArray
{
    class GenericArray
    {
        public struct Pair<T, U>
        {
            public readonly T Fst;
            public readonly U Snd;
            public Pair(T fst, U snd)
            {
                this.Fst = fst;
                this.Snd = snd;
            }
            public override String ToString()
            {
                return "(" + Fst + ", " + Snd + ")";
            }
        }

        public static void Main(String[] args)
        {
            Pair<String, int>[] grades = new Pair<String, int>[5];
            grades[0] = new Pair<string, int>("Girish", 00);
            grades[1] = new Pair<string, int>("Manoj", 01);
            grades[2] = new Pair<string, int>("Anil", 02);
            grades[3] = new Pair<string, int>("Pravin", 03);
            grades[4] = new Pair<string, int>("Mandar", 04);

            Console.WriteLine("\n Array elements are Printed :- \n");

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i].ToString());
            }

            Console.WriteLine("\n Array elements are Printed using FOREACH :- \n");

            foreach (Pair<String, int> data in grades)
            {
                Console.WriteLine(data.ToString());
            }


            /* 
              (g) Declare a variable appointment of type Pair<Pair<int,int>,String>, and create a value of this type and assign it to the variable.
                  What is the type of appointment.Fst.Snd? 
                  This shows that a type argument may itself be a constructed type.
            */


            Pair<Pair<string, int>, string> appointment = new Pair<Pair<string, int>, string>(grades[0], "Array");
            Console.WriteLine("\n\n Spcific Type implemetation :-\n");
            Console.WriteLine("1st Element :- " + appointment.Fst.Fst);
            Console.WriteLine("2nd Element :- " + appointment.Fst.Snd);

            Console.Read();

        }
    }

}





