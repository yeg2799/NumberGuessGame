using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberguessgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int ComputerGuess;
            ComputerGuess = random.Next(1000, 9999);
            Console.WriteLine("Random Number Copy="+ComputerGuess);

            int Number;
            bool Control = false;
            int[] ComputerArray = new int[4];
            int[] UserArray = new int[4];


           //while control not equal true
            while (Control != true)
            {
                //User Enter the Number 
                Console.Write("Enter The Number=");
                Number = Convert.ToInt32(Console.ReadLine());

                //if ComputerGuess and Number not equal 
                if (ComputerGuess !=Number)
                {
                    while (ComputerGuess > 0)
                    {
                        for (int i = 0; i < 4; i++)
                        {

                            int NumberArray = ComputerGuess % 10;
                            ComputerArray[4 - i - 1] = NumberArray;
                            ComputerGuess = ComputerGuess / 10;
                        }
                    }
                    Console.WriteLine("\n");
                    while (Number > 0)
                    {
                        for (int j = 0; j < 4; j++)
                        {

                            int UserNumber = Number % 10;
                            UserArray[4 - j - 1] = UserNumber;
                            Number = Number / 10;


                        }
                    }
                    int CountPositive = 0, CountNegative = 0;

                    //Enter the loop
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            //if computerArray equal UserArray and i equal j
                            if (ComputerArray[i] == UserArray[j] && i == j)


                                CountPositive++;

                            if (ComputerArray[i] == UserArray[j] && i != j)


                                CountNegative--;
                        }
                    }
                    //if countpositive equal 4 , You win
                    if (CountPositive == 4)
                    {
                        Control = true;
                        Console.WriteLine("\n You Win");
                    }

                    Console.WriteLine("\n" + CountPositive + " " + CountNegative);
                }
            }
            Console.ReadLine();
        }
    }
}
