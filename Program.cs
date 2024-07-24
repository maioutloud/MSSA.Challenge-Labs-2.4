using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Labs_2._4
{
    // CHALLENGE LABS 2.4 : STUDENT MARKS
    // CCAD12 STUDENT : MAI LOR
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Student Role Number: ");
            string rollNo = Console.ReadLine();
            Console.Write("Enter the Student Name: ");
            string stuName = Console.ReadLine();
            Console.WriteLine("Enter the marks of Physics, Chemistry, and Computer Applications (separated by enter): ");
            int physics = Int32.Parse(Console.ReadLine());
            int chemistry = Int32.Parse(Console.ReadLine());
            int compApp = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Roll No : {rollNo}");
            Console.WriteLine("Name of Student : {0}", stuName);
            Console.WriteLine("Marks in Physics : {0} \nMarks in Chemistry : {1} \nMarks in Computer Applications : {2}", physics, chemistry, compApp);

            int total = physics + chemistry + compApp;
            float percentage = (float)total / 300 * 100;

            // division is based on percentile
            string division = null;
            if (percentage >= 80)
            {
                division = "First";
            }
            else if (percentage >= 60)
            {
                division = "Second";
            }
            else
            {
                division = "Third";
            }

            Console.WriteLine("Total Marks = {0}", total);
            Console.WriteLine("Percentage = {0}", percentage);
            Console.WriteLine("Division = {0}", division);
            Console.ReadKey();
        }
    }
}
