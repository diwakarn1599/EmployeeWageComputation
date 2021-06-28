using System;

namespace EmployeeWageComputation
{
    class Program
    {
        //initialzing constants
        public const int FULL_TIME = 1;
        public const int ABSENT = 0;
        public const int PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;

        static void Main(string[] args)
        {
            int wagesPerDay;   
            int workingHours = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            Random rand = new Random(); // intializing random class
            int empInput = rand.Next(0, 3);//Generating random b/w 0 and 3
            if(empInput == FULL_TIME)
            {
                Console.WriteLine("Employee is Present Full Time");
                workingHours = 8;
            }else if(empInput == PART_TIME)
            {
                Console.WriteLine("Employee is Present Part Time");
                workingHours = 4;
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
