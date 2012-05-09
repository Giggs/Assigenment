using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Generic
{
    class Genenric
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
            //Declare a variable of type Pair<String, int> and create some values, for instance new Pair<String,int>("Anders", 13), and assign them to the variable.
            Pair<String, int> intpairstr = new Pair<String,int>("Anders", 13);

            //Declare a variable of type Pair<String, double>. Create a value such as new Pair<String,double>("Phoenix", 39.7) and assign it to the variable.
            Pair<String, double> strpairdouble = new Pair<String, double>("Phoenix", 39.7);

            //Can you assign a value of type Pair<String,int> to a variable of type Pair<String,double>? Should this be allowed?
            Pair<String, double> strpairdouble_odd = new Pair<String, double>("Anders", 13);



            Console.WriteLine(intpairstr.ToString());
            Console.WriteLine(strpairdouble.ToString());
            Console.WriteLine(strpairdouble_odd.ToString());
            Console.Read();
        }
    }
}



