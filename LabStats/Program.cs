using System;

namespace LabStats
{
    class Program
    {

        //let user enter how many potatoes.
        static int GetPotatoes()
        {
            int potatoes;
            bool correctNum = true;
            while (correctNum)
            {
                Console.WriteLine("How many potatoes bags do you have?");
                potatoes = Convert.ToInt32(Console.ReadLine());
                if(potatoes > 0 && potatoes < 41)
                {
                    return potatoes;
                }
                else
                {
                    Console.WriteLine("Please enter number 1-40. ");
                }
            }

            return 0;
        }

        //get the red potatoes
        static int GetRedPotatoes(int potatoes)
        {
            double redPotatoes = 0;
            for (int i = 1; i <= potatoes; i++)
            {
                if (i % 2 == 0)
                {
                    redPotatoes += Math.Pow(i, 2);
                }
            }
            return (int)redPotatoes;
        }

        //get the Russet Potatoes
        static int GetRussetPotatoes(int potatoes)
        {
            double russetPotatoes = 0;
            for (int i = 1; i <= potatoes; i++)
            {
                if (i % 2 != 0)
                {
                    russetPotatoes += Math.Pow(i, 2);
                }
            }

            return (int)russetPotatoes;
        }


        //find the different 
        static int GetDifferent(int redPotatoes, int russetPotatoes)
        {
            int number;
            if(redPotatoes > russetPotatoes)
            {
                number = redPotatoes - russetPotatoes;
            }
            else
            {
                number = russetPotatoes - redPotatoes;
            }
            return number;
        }

        static void Main(string[] args)
        {
            int potatoes = GetPotatoes();
            int redPotatoes = GetRedPotatoes(potatoes);
            int russetPotatoes = GetRussetPotatoes(potatoes);
            int number = GetDifferent(redPotatoes, russetPotatoes);
            string again;
            Console.WriteLine("The different between red potatoes and russetPotatoes is: " + number);
        }
    }
}
