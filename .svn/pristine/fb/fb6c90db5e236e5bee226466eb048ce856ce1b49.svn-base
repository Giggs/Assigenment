using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//(h) Declare a method Swap() in Pair<T,U> that returns a new struct value of type Pair<U,T> in which the components have been swapped.


namespace GenericSwap
{
    public class Swap
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

        public static Pair<int, string> Swapcode(Pair<string, int> strInt)
        {
            Pair<int, string> intStr = new Pair<int, string>(strInt.Snd, strInt.Fst);
            return intStr;
        }
            
       
         static void Main(string[] args)
        {
            Pair<string,int> str_int = new Pair<string,int>("Str And Int",99);

            Console.WriteLine("\n Initial level :-");
            Console.WriteLine(str_int.ToString());

            Console.WriteLine("\n Final level after Swap :-");
            Console.WriteLine(Swapcode(str_int).ToString());

            Console.ReadLine();
        }
    }
}


