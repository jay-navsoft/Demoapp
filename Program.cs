using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Please enter your marks");
            i = Convert.ToInt32(Console.ReadLine());
            
            
            if(i>=60)
            {
                Console.WriteLine("First Div");               
                
            }
            if(i<33)
            {
                Console.WriteLine("Failed");

            }
            if (i==33)
            {
                Console.WriteLine("Second Div");

            }
            else
            {
                
            }

            Console.ReadLine();
        }
    }
}
