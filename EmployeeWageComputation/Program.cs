using System;

namespace EmployeeWageComputation
{
    class Program
    {
        //initialzing constants
        public const int PRESENT = 1;
        public const int ABSENT = 0;
        public const int WAGE_PER_HOUR = 20;

        static void Main(string[] args)
        {
            int wagesPerDay;   
            int workingHours = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            Random rand = new Random(); // intializing random class
            int empInput = rand.Next(0, 2);//Generating random b/w 0 and 2
            if(empInput == PRESENT)
            {
                Console.WriteLine("Employee is Present");
                workingHours = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                workingHours = 0;
            }
            wagesPerDay = WAGE_PER_HOUR * workingHours;
            Console.WriteLine("Employee wage per day is "+ wagesPerDay);
            

        }
    }
}
