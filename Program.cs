using System.Runtime.ExceptionServices;

namespace _5_3_DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //int[] bed = new int[random.Next(4, 20)];
            //for (int i = 0; i < bed.Length; i++)
            //{
            //    bed[i] = random.Next(0, 2); // Randomly fill the bed with 0s and 1s
            //}
            //int n = random.Next(1, 3); // Random number of flowers to plant
            //for (int i = 0; i < bed.Length; i++)
            //{
            //    Console.Write(bed[i] + " ");
            //}
            //Console.WriteLine("\nNumber of flowers to plant: " + n);
            //Console.WriteLine(FlowerBed(bed, n));
            Console.WriteLine(Staircase(5));
            Console.WriteLine(Staircase(4));
            Console.WriteLine(Staircase(13));

        }

        static bool FlowerBed(int[] bed, int n)
        {
            int flowersPlanted = 0;
            for (int i = 0; i < bed.Length; i++)
            {

                if (bed[i] == 0)
                {
                    bool emptyLeft = (i == 0) || (bed[i - 1] == 0);
                    bool emptyRight = (i == bed.Length - 1) || (bed[i + 1] == 0);
                    if (emptyLeft && emptyRight)
                    {
                        flowersPlanted++; // Plant a flower here
                    }
                }
            }
            if (flowersPlanted >= n)
            {
                return true;
            }
            return false;
        }

        static int Staircase(int n)
        {
            //takes n steps to reach the top of the staircase,
            //and you can climb either 1 or 2 steps at a time.

            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }
            else
            {
                //count backward from the options for the last step, which is either 1 or 2 steps
                return Staircase(n - 1) + Staircase(n - 2);

            }
        }
    }
}
