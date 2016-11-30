using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static int[] RandomArray()
        {
            int[] array = new int[10];
            Random rnd = new Random();
            int max = int.MinValue,
                min = int.MaxValue,
                sum = 0;

            for(int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(5,26);
                if(array[i] > max)
                {
                    max = array[i];
                }
                if(array[i] < min)
                {
                    min = array[i];
                }
                sum += array[i];
            }
            Console.WriteLine(max + ", " + min + ", " + sum);
            return array;
        }
        public static string CoinFlip()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            Console.WriteLine("Tossing a Coin!...");
            int result = rand.Next(1,3);
            if(result == 1)
            {
                Console.WriteLine("You Flipped Tails!");
            }
            if(result == 2)
            {
                Console.WriteLine("You Flipped Heads!");
            }
            return("The result was: " + result);
        }
            public static string TossMultipleCoins(int num){
           int headToss = 0;
           int totalToss = 0;
           Random rand = new Random();
           for(int i = 1; i < num; i++) {
               Console.WriteLine("Tossing A Coin...");
               int result = rand.Next(1,3);
               if(result == 1) {
                   totalToss += 1;
                   Console.WriteLine("You Flipped Tails!");
               }
               if(result == 2) {
                   headToss += 1;
                   totalToss += 1;
                   Console.WriteLine("You Flipped Heads!");
               }
           }
           var ratio = ((double)headToss / totalToss);
           
           Console.WriteLine("Total # of tosses: " + totalToss + " - # of heads tosses: " + headToss + " - Ratio: " + ratio);
           return("coin toss done");
           }
            public static void Names()
           {
               string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
               string[] shuffled = new string[5];
               Random random = new Random();
               for(int i = 0; i < names.Length; i++)
               {
                   bool flag = true;
                   while(flag)
                   {
                       int idx = random.Next(0,5);
                       if(shuffled[idx] == null)
                       {
                           shuffled[idx] = names[i];
                           flag = false;
                       }

                   }
               }
               for(int k = 0; k < shuffled.Length; k++)
              {
                  if(shuffled[k].Length < 5){
                      shuffled[k] = null;
                  }
                  Console.WriteLine(shuffled[k]);
              }
          }
           public static void Main(string[] args)
         {
             RandomArray();
             CoinFlip();
             TossMultipleCoins(55);
             Names();
         }
        }
    }
