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
            decimal sum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Sum Number");
            decimal sum2 = Convert.ToInt32(Console.ReadLine());
            decimal sum = sum1 + sum2;
            Console.WriteLine("The Total Sum Is {0}", sum);

            // Exercise 3
            decimal div = sum1 / sum2;
            Console.WriteLine("The dividing is {0}", div);

            // Exercise 5
            int swap1 = Convert.ToInt32(Console.ReadLine());
            int swap2 = Convert.ToInt32(Console.ReadLine());
            int temp = swap1;
            swap1 = swap2;
            swap2 = temp;
            Console.WriteLine("Swap 1 is {0} and Swap2 is {1}", swap1, swap2);

            // Exercise 6

            int multiply1 = 2;
            int multiply2 = 3;
            int multiply3 = 6;
            int multiplyres = multiply1 * multiply2 * multiply3;
            Console.WriteLine("The Multiply Result is {0}", multiplyres);


            // Exercise 7

            decimal firstnumber = 25;
            decimal secondnumber = 4;
            decimal sum7 = firstnumber + secondnumber;
            decimal sub = firstnumber - secondnumber;
            decimal multi = firstnumber * secondnumber;
            decimal devi = firstnumber / secondnumber;
            decimal modules = firstnumber % secondnumber;
            Console.WriteLine("{0},{1},{2},{3},{4}",sum7 , sub , multi , devi , modules);


            //Exercise 8

            Console.WriteLine("Eneter the number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 0; i <= 10; i++)
            {
                int res = num1 * i;
                Console.WriteLine(" {0} * {1} = {2}", num1, i, res);
            }


           //Exercise 10
            


            Console.ReadKey();
        }
    }
}
