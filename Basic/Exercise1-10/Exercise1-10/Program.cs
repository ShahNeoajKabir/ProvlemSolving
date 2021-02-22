using System;

namespace Exercise1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            string First = "Hello";
            string Second = "Shah Neoaj";
            Console.WriteLine("{0} : {1}", First, Second);


            // Exercise 2
            Console.WriteLine("Enter The First Sum Number");
            int sum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Sum Number");
            int sum2 = Convert.ToInt32(Console.ReadLine());
            int sum = sum1 + sum2;
            Console.WriteLine("The Total Sum Is {0}", sum);

            // Exercise 3
            double div = sum1 / sum2;
            Console.WriteLine("The dividing is {0}", div);

            // Exercise 5
            int swap1 = Convert.ToInt32(Console.ReadLine());
            int swap2 = Convert.ToInt32(Console.ReadLine());
            int temp = swap1;
            swap1 = swap2;
            swap2 = temp;
            Console.WriteLine("Swap 1 is {0} and Swap2 is {1}", swap1, swap2);

            Console.ReadKey();
        }
    }
}
