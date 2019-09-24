using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            DrawPynamid(number, 'x');
        }
        static void CreateHorizon(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(c);
            }
        }
        static void CreateVertical(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(c);
            }
        }
        static void Dline(int number,char c)
        {
            for (int i = 0; i < number; i++)
            {
                CreateHorizon(i, ' ');
                Console.WriteLine(c);
            }
        }
        static void DrawPynamid(int number, char c)
        // line 1 : n-1 space / 1 star
         // line 2 : n-2 space/ 1 star, 1 space/1 star
         // line 3 : n-3 space/ 1 star, 3 space/1 star
        // last line 2n-1 star 
        { 
         //first line
            CreateHorizon(number - 1, ' '); CreateHorizon(1, c); Console.WriteLine();
        // i-th line
            int a = 2, b = 1;
            for (int i = 0; i < number-2; i++)
            {
                CreateHorizon(number - a, ' '); CreateHorizon(1, c); Console.WriteLine();
                CreateHorizon(number - b, ' '); CreateHorizon(1, c); Console.WriteLine();
            }
            
        }
    }
}
