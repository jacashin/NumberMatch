using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{

    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            //Input 1st number
            Console.WriteLine("Please enter 1st Number");
            //convert string into int
            num1 = int.Parse(Console.ReadLine());

            List<int> listOfInts1 = new List<int>();
            while (num1 > 0)

            // Gets value of entered int1 by giving remainder
            {
                listOfInts1.Add(num1 % 10);
                
                num1 = num1 / 10;
            }
            //Repeat step above for 2nd int
            Console.WriteLine("Please enter 2nd Number");
            num2 = int.Parse(Console.ReadLine());
            List<int> listOfInts2 = new List<int>();
            while (num2 > 0)
            {
                listOfInts2.Add(num2 % 10);
                num2 = num2 / 10;
            }

            //Array with for loop, goes through int
            int[] sums1 = new int[listOfInts1.Count];

            for (int i = 0; i < listOfInts1.Count; i++)

            //Adds int1 and int2 together to create sum
            {
                sums1[i] = listOfInts1[i] + listOfInts2[i];


            }
            //separate loop 
            bool Failed = false;

            int j = 0;
            for (j = 0; j < sums1.Length; j++)
            {
                //if (sums1[j] == sums1[j++])

                if (sums1.Length > j + 1)
                {
                    if (sums1[j] == sums1[j + 1])
                    {
                        //so far ok, does nothing

                    }
                    else
                    {
                        //doesnt match print false, exit loop
                        Failed = true;
                        break;
                    }
                }


            }

            if (Failed == true)
            {
                Console.WriteLine("The numbers do not match");
            }
            else
            {
                Console.WriteLine("Great, the numbers match up!");
            }
            Console.ReadKey();

        }
    }

}


