using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.MultipleAdvisors
{
    public class Tester
    {
        static string[] names = { "David", "Mike", "Jason", "Kabelo", "Michael", "Rachael", "Donna", "Henry", "Lesego", "Thabiso" };
        static string[] lastnames = { "Smith", "Stevens", "Barron", "Mokoena", "Pearson", "Ross", "Paulsen" };
        static void Main(string[] args)
        {
            InterviewCenter center = new();
            Parallel.Invoke(
           () => StudentAction(center),
           () => AdvisorAction(center, "Tyler",ConsoleColor.Red),
           () => AdvisorAction(center, "Jessica", ConsoleColor.Green),
           () => AdvisorAction(center, "Lungelo", ConsoleColor.Blue),
           () => AdvisorAction(center, "Mpumi", ConsoleColor.Yellow)
           );

            Console.Read();
        }
        public static void AdvisorAction(InterviewCenter center, string advisorName, ConsoleColor color)
        {
            Random rdn = new Random();
            while (true)
            {
                WalkInInterview? interview = center.AttendToStudent(advisorName);

                if (interview != null)
                {
                    Console.ForegroundColor = color;
                    Log($"Interview # {interview.Id} with {interview.Student.ToString()} is attended by {interview.Advisor}.");

                    Thread.Sleep(rdn.Next(5000,8000));
                    center.End(interview);

                    Console.ForegroundColor = color;
                    Log($"Interview # {interview.Id} with {interview.Student.ToString()} is ended by {interview.Advisor}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(rdn.Next(2000, 4000));
                }
                else
                {
                    Thread.Sleep(1000);
                }
            
            }
        }
        public static void StudentAction(InterviewCenter center)
        {
            Random rdn = new Random();
            while (true)
            {
                int stId = rdn.Next(10000, 89999);
                string name = names[rdn.Next(0, names.Length - 1)];
                string lastname = lastnames[rdn.Next(0, lastnames.Length - 1)];
                Student st = new(stId, name, lastname);
                int waitingCount = center.Interview(st);
                Log($"Consultation with {st.ToString()}, waiting in queue : {waitingCount}");
                Thread.Sleep(rdn.Next(4000, 6000));
            }
        }
        static void Log(string str)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] - {str}");
        }
    }
}
