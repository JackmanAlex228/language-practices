using System;

namespace Reverse_Int32
{
    class Program
    {
        static int Reverse(int x)
        {
            int rev = 0;
            while (x != 0) {
                int pop = x % 10;
                x /= 10;
                if (rev > Int32.MaxValue/10
                || (rev == Int32.MaxValue/10 && pop > 7))
                    return 0;
                if (rev < Int32.MinValue/10 
                || (rev == Int32.MinValue/10 && pop < -8))
                    return 0;
                rev = rev * 10 + pop;
            }
            return rev;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a 32-bit integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The reverse of the number is {0}", Reverse(input));
        }
    }
}
