using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.MultipleAdvisors
{
    public class Tester
    {
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
                    Log($"Interview # {interview.Id} with {interview.StudentId} is attended by {interview.Advisor}.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(rdn.Next(3000,6000));
                    center.End(interview);

                    Console.ForegroundColor = color;
                    Log($"Interview # {interview.Id} with {interview.StudentId} is ended by {interview.Advisor}");
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
                int stId = rdn.Next(10000, 80000);
                int waitingCount = center.Interview(stId);
                Log($"Consultation with {stId}, waiting in queue : {waitingCount}");
                Thread.Sleep(rdn.Next(5000, 10000));
            }
        }
        static void Log(string str)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] - {str}");
        }
    }
}
