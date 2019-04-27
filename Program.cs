using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taking_input
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            //message = Console.ReadLine();
            //Console.WriteLine("output: "+ message); //readline only give string type for others type we have toconvert it

            Console.WriteLine("Enter firstnumber:"); 
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            int result = firstnumber + secondnumber;
            Console.WriteLine("Result: " + result);
            //Console.WriteLine(firstnumber);
            //Console.WriteLine(firstnumber + 10); // here i want to add 10 with the input number
            //int result = firstnumber + 10;
            //Console.WriteLine("Result:" + result); // output here is more suitable


            Console.ReadKey();


        }
    }
}
