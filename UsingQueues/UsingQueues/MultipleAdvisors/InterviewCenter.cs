using Microsoft.VisualBasic;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.MultipleAdvisors
{
    public class InterviewCenter
    {
        private int _count = 0;
        public ConcurrentQueue<WalkInInterview>? Interviews { get; private set; }
        public InterviewCenter()
        {
            Interviews = new ConcurrentQueue<WalkInInterview>();
        }
        public int Interview(Student st)
        {
            WalkInInterview interview = new WalkInInterview()
            {
                Id = ++_count,
                Student = st,
                InterviewTime = DateTime.Now
            };
            Interviews.Enqueue(interview);
            return Interviews.Count;
        }
        public WalkInInterview? AttendToStudent(string advisor)
        {
            if (Interviews.Count > 0 && Interviews.TryDequeue(out WalkInInterview? interview))
            {
                interview.Advisor = advisor;
                interview.StartTime = DateTime.Now;
                return interview;
            }
            return null;
        }
        public void End(WalkInInterview interview)
        {
            interview.EndTime = DateTime.Now;
        }
        public bool AreStudentsWaiting() => Interviews.Count > 0;
    }
}
