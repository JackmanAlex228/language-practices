using System;
using System.Collections.Generic;

namespace Scratch_Paper
{
    class Program
    {
        // static bool isPrime(int n) {
        //     if (n < 1) return false;
        //     for (int i = 2; i < n / 2; i++) {
        //         if (n % i == 0) {
        //             return false;
        //         }
        //     }
        //     return true;
        // }
        // static void Mult35(int[] nums) {
        //     foreach(int n in nums) {
        //         if (n % 3 == 0 || n % 5 == 0) {
        //             Console.Write(n + " ");
        //         }
        //     }
        // }
        // static bool NotValid(int n) {
        //     int[] list = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        //     for (int i = 0; i < list.Length; i++) {
        //         if (list[i] == n) {
        //             list[i] = 0;
        //             return false;
        //         }
        //     }
        //     return true;
        // }
        // static bool SudokuValidator(int[][] m) {
        //     for (int i = 0; i < m.Length; i++) {
        //         for (int j = 0; j < m[i].Length; j++) {
        //             if (NotValid(m[i][j])) {
        //                 return false;
        //             }
        //         }
        //     }
        //     return true;
        // }
        // static int ReverseInt(int n) {
        //     int r = 0;
        //     while (n > 0) {
        //         r *= 10;
        //         r += n % 10;
        //         n /= 10;
        //     }
        //     return r;
        // }
        // static string ReverseString(string s) {
        //     string r = "";
        //     for (int i = s.Length-1; i >= 0; i--) {
        //         r += s[i];
        //     }
        //     return r;
        // }
        // static int StringToInt(string s) {
        //     const int ASCII_OFFSET = 48;
        //     int r = 0;
        //     int start;
        //     bool isNeg;

        //     if (s[0] == '-') { isNeg = true; start = 1; }
        //     else { isNeg = false; start = 0; }

        //     for (int i = start; i < s.Length; i++) {
        //         r *= 10;
        //         r += s[i] - ASCII_OFFSET;
        //     }

        //     if (isNeg) return r * -1;
        //     else return r;
        // }

        // static string IntToString(int n) {
            // string rf = "", f = "";
            // bool isNeg = false;
            // if (n < 0) {
            //     n *= -1;
            //     isNeg = true;
            // }
            // while (n > 0) {
            //     rf += (n % 10);
            //     n /= 10;
            // }
            // if (isNeg) {
            //     rf += "-";
            // }
            // for (int i = rf.Length-1; i >= 0; i--) {
            //     f += rf[i];
            // }
            // string r = "";
            // r += n;
            // return r;
        // }
        
        public static void fib(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write(a + " " + b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // int[][] m = new int[3][];
            // m[0] = new int[3] {3, 8, 7};
            // m[1] = new int[3] {6, 5, 4};
            // m[2] = new int[3] {3, 1, 1};
            // Console.WriteLine(SudokuValidator(m));
            // Console.WriteLine(IntToString(-1235));

            fib(12);
        }
    }
}
