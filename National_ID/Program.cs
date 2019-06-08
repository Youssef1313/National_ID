using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace National_ID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your national id:");
            var userNationalId = Console.ReadLine();
            CitizenData citizenData = CitizenDataExtractor.GetCitizenData(userNationalId);
            Console.WriteLine($"DateOfBirth (d/M/yyyy): {citizenData.DayOfBirth}/{citizenData.MonthOfBirth}/{citizenData.YearOfBirth}");
            Console.WriteLine($"Governorate: {citizenData.Governorate}");
            Console.WriteLine($"Gender: {citizenData.Gender}");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
