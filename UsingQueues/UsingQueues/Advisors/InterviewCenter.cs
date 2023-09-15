using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.Advisors
{
    public class InterviewCenter
    {
        private int _count = 0;
        public Queue<WalkInInterview>? Interviews { get; set; }
        public InterviewCenter()
        {
            Interviews = new Queue<WalkInInterview>();
        }
        public void Interview(int stId)
        {
            WalkInInterview interview = new()
            {
                Id = ++_count,
                StudentId = stId,
                InterviewTime = DateTime.Now
            };
            Interviews.Enqueue(interview);
        }
        public WalkInInterview? AttendToStudent(string advisor)
        {
            if (Interviews.Count > 0)
            {
                WalkInInterview interview = Interviews.Dequeue();
                interview.Advisor = advisor;
                interview.StartTime = DateTime.Now;
                return interview;
            }
            return null;
        }
        public void EndInterview(WalkInInterview interview)
        {
            interview.EndTime = DateTime.Now;
        }
        public bool AreStudentsWaiting() =>
            Interviews.Count > 0;
    
    }
}
