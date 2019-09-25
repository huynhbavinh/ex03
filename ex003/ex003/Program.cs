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
            Console.WriteLine();
            CreateN(number, 'x');
            ReservePynamid(number, 'x');
        }
        static void CreateHorizon(int number, char c)
        {
            //plus space then print *
            for (int i = 0; i < number; i++)
            {
                Console.Write(c);
            }
        }
        static void CreateVertical(int number, char c)
        {
            //plus space then print *
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(c);
            }
        }
        static void Dline(int number, char c)
        {
            //plus space then print *
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
            int line = 1, space = number + 1;
            for (int i = 1; i < number; i++)
            {
                line = line + 1;
                CreateHorizon(number - line, ' '); CreateHorizon(1, c);
                // we got space = number+1 - 2, because Value (number - space) must grow 2 time/ 1 it's only a oDD 
                space = space - 2;
                CreateHorizon(number - space, ' '); CreateHorizon(1, c); Console.WriteLine();
            }
            // last line
            CreateHorizon(number * 2 - 1, c);
        }
        static void CreateN(int number, char c)
        {
            //first line        
            CreateHorizon(1, c); CreateHorizon(number - 2, ' '); CreateHorizon(1, c); Console.WriteLine();
            //i-th line
            // under-space is ascentding 1 element any single line,value "number-space" represent for its , < number-1
            // top-space is decrease 1 element any single line, "i" represent for its, >= 0
            // Pemanent 2 line, we always got i = number - 2 
            // we got "space" = "i+2 = number", but i will decrease 1 ele in the floop -> number-space is the space the first * xin floop will appear
            //this loop make a diagonal line between "number-2" element (>o<)
            for (int i = number - 2; i > 0; i--)
            {
                int space = i + 2;
                CreateHorizon(1, c); CreateHorizon(number - space, ' '); CreateHorizon(1, c); CreateHorizon(i - 1, ' '); CreateHorizon(1, c);
                Console.WriteLine();
            }
            //last line do same first line
            CreateHorizon(1, c); CreateHorizon(number - 2, ' '); CreateHorizon(1, c); Console.WriteLine();
        }
        static void ReservePynamid(int number, char c)
        {
            //first line 
            CreateHorizon(number * 2 - 1, c); Console.WriteLine();
            //i-th line
            //idea : mid-space decrease 2 element any single line 
            //at : line 2 : mid-space  got 12 ( at number=8)
            // line 3 got : got 10
            // so : we got Space = number(8) + (8)/2 + 1 at first loop
            // mid-space of line2 = Space - 2 because its decrease 2 element any single line 
            int space = number + number / 2 + 1;
            for (int i = number - 1; i > 1; i--)
            {
                CreateHorizon(number - i, ' '); CreateHorizon(1, c);
                space = space - 2;
                CreateHorizon(space, ' '); CreateHorizon(1, c); Console.WriteLine();
            }
            //last line
            CreateHorizon(number - 1, ' '); CreateHorizon(1, c); Console.WriteLine();
        }
    }
}
