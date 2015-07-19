
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// start namespace HarmonicSeries
namespace HarmonicSeries
{
    /// <summary>
    /// This program will compute the sum of a harmonic series.
    /// It will Calculate the sum from left-to-right, and then from right-to-left. 
    /// </summary>
    
    // start class Program
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float sum = 0;
            Console.Clear();
            Console.WriteLine("Enter the value of n: ");
            n = int.Parse(Console.ReadLine());
                        
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("1/" + i + " +");
                sum = sum + (float)1 / i;
            }

            // Print out eh sum of harmonic series from left to right
            Console.WriteLine("Sum of Harmonic Series is: " + sum);
            Console.ReadLine();

            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine("1/" + i + " -");
                sum = sum + (float)1 / i;
            }

            // Print out the sum of harmonic series from right to left
            Console.WriteLine("Sum of Harmonic Series is: " + sum);
            Console.ReadLine();

        }// end main Method
    }// end class Program
}// end namespace HarmonicSeries