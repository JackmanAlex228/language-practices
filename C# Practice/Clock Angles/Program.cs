using System;

namespace Clock_Angles
{
    class Program
    {

        static void InputValidation(int h, int m)
        {
            if ((h < 1 || h > 12) || (m < 0 || m > 59))
            {
                Console.WriteLine("Invalid time format!");
                Console.Write("Enter the hour: ");
                h = int.Parse(Console.ReadLine());
                Console.Write("Enter the minute: ");
                m = int.Parse(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            // Input: Time (12-hour)
            // Output: The angles from an analog clock

            // Constants
            const int MIN = 60;
            const int HOUR = 12;
            const int CYCLE = 360;
            const int MIN_PER_CYCLE = CYCLE / MIN; // 6
            const int HOUR_PER_CYCLE = CYCLE / HOUR; // 30

            // Variables
            int minute, hour, angle;

            // User IO
            Console.Write("\nEnter the hour: ");
            hour = int.Parse(Console.ReadLine());
            Console.Write("Enter the minute: ");
            minute = int.Parse(Console.ReadLine());

            // Input Validation
            InputValidation(hour, minute);

            // Calculating the angle between the minute and the hour hand
            angle = Math.Abs((HOUR_PER_CYCLE * hour) - (MIN_PER_CYCLE * minute));
            if (angle > 180)
                angle = Math.Abs(angle - CYCLE);

            // Outputting the angle
            Console.WriteLine($"The angle between the hands on the clock is {angle} degrees.\n");
        }
    }
}
