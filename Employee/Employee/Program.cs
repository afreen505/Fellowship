using System;

namespace UC_1_EmpPresence
{
    class UC_1_EmpPresence
    {
        static void Main(string[] args)
        {
            int IS_FULL_Time = 1;
            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == IS_FULL_Time)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();
        }
    }
}