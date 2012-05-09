using System;

namespace Codejam
{
    class ChickenOrEgg
    {
        string TheTruth(int n, int eggCount, int lieCount, int liarCount)
        {

           bool resultEgg=false;
           bool resultChicken=false;

           int low = (int)Math.Abs((n - lieCount) - liarCount);
           int high = n - (int)Math.Abs(lieCount - liarCount);

           
           if (eggCount >= low && eggCount <= high && eggCount % 2 == low % 2)
             resultEgg = true;
          
           if (eggCount >= (n - high) && eggCount <= (n - low) && eggCount % 2 == (n - high) % 2)
              resultChicken = true;



            if (resultEgg && resultChicken)
            {
                return "Ambiguous";
            }
            else if (resultEgg)
            {
                return "The egg";
            }
            else if (resultChicken)
            {
              
                return "The chicken";
            }
            else
            {
                return "The oracle is a lie";
            }

          }

       

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            ChickenOrEgg chickenOrEgg = new ChickenOrEgg();
            String input = Console.ReadLine();
            try
            {
                do
                {
                    string[] values = input.Split(',');
                    int n = int.Parse(values[0]);
                    int eggCount = int.Parse(values[1]);
                    int lieCount = int.Parse(values[2]);
                    int liarCount = int.Parse(values[3]);
                    string output = chickenOrEgg.TheTruth(n, eggCount, lieCount, liarCount);
                    Console.WriteLine(output);
                    input = Console.ReadLine();
                } while (input != "-1");
            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format("{0} for input: {1}", ex.Message, input));
            }
        }
        #endregion

    }
}