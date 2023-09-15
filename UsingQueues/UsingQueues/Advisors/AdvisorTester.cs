using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.Advisors
{
    internal class AdvisorTester
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            InterviewCenter center = new();
            center.Interview(100);
            center.Interview(102);
            center.Interview(105);
            center.Interview(115);

            while (center.AreStudentsWaiting())
            {
                WalkInInterview interview = center.AttendToStudent("Tyler");
                Log($"Interview # {interview.Id} for Student {interview.StudentId}" +
                    $" is attended by {interview.Advisor}");
                Thread.Sleep(r.Next(3000,15000));
                center.EndInterview(interview);

                Log($"Interview # {interview.Id} for Student {interview.StudentId}" +
                    $" is ended by {interview.Advisor}");
            }

            Console.Read();
        }

        static void Log(string str)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] - {str}");
        }
    }
}
