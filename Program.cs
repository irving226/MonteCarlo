using System;

namespace MonteCarlo
{
    class Program
    {

        static (double, double) RandomXY(Random ranNum)
        {
            return (ranNum.NextDouble(), ranNum.NextDouble());
        }

        static double Hypotenuse(double x, double y)

        {
            x = Math.Pow(x, 2);
            y = Math.Pow(y, 2);

            double c = Math.Sqrt(x + y);


            return c;
        }



  
        static void Main(string[] args)
        {

            Random ranNum = new Random();
            double insideCounter = 0;
            int outsideCounter = 0;

            Console.WriteLine(args[0]);
           
            int iterations = int.Parse(args[0]);

            for (int i = 0; i < iterations; i++)
            {
                (double x, double y) = RandomXY(ranNum);
                double answer = Hypotenuse(x, y);
                Console.WriteLine($"Iteration{i + 1}\n");
                Console.WriteLine($"X:{x}\nY:{y}\nHypo: {answer}\n ");

                if (answer < 1)
                {
                    insideCounter++;
                }
                else
                {
                    outsideCounter++;
                }

            }
            double sum = insideCounter / iterations * 4;
            Console.WriteLine($"Estimated sum= {sum}\nActual Pi= {Math.PI}\nEstimate was off by {Math.Abs(sum - Math.PI)}   ");

        }
    }
    }

    

