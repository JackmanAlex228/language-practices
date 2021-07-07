using System;
using System.Collections.Generic;

namespace Roman_to_Int
{
    class Program
    {
        // I    1
        // V    5
        // X    10
        // L    50
        // C    100
        // D    500
        // M    1000

        // I can be placed before V and X (4 and 9)
        // X can be placed before L and C (40 and 90)
        // C can be placed before D and M (400 and 900)

        private static Dictionary<char, int> rMap = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        static int RomanToInt(string s) {
            int sum = 0;
            if (s.Contains('I') || 
                s.Contains('V') ||
                s.Contains('X') ||
                s.Contains('L') ||
                s.Contains('C') ||
                s.Contains('D') ||
                s.Contains('M')) {

                for (int i = 0; i < s.Length; i++) {
                    if (i + 1 < s.Length && (
                        (rMap[s[i]] == 'I' && rMap[s[i+1]] == 'V') ||
                        (rMap[s[i]] == 'I' && rMap[s[i+1]] == 'X') ||
                        (rMap[s[i]] == 'X' && rMap[s[i+1]] == 'L') ||
                        (rMap[s[i]] == 'X' && rMap[s[i+1]] == 'C') ||
                        (rMap[s[i]] == 'C' && rMap[s[i+1]] == 'D') ||
                        (rMap[s[i]] == 'C' && rMap[s[i+1]] == 'M')))
                        sum -= rMap[s[i]];
                    else
                        sum += rMap[s[i]];
                }
            }
            else {
                Console.WriteLine("Input error");
                return -1;
            }
            return sum;
        }
        static void Main(string[] args) {
            Console.WriteLine(RomanToInt("IVXCM"));
        }
    }
}
