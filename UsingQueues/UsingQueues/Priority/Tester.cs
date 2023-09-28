using Priority_Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.Priority
{
    public class Tester
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, string> names = new PriorityQueue<string, string>();
            //SimplePriorityQueue<string> q_names = 
            //    new SimplePriorityQueue<string>();
            PriorityQueue<Customer, Level> customers = new();
            #region Names Queue
            names.Enqueue("Kabelo","C");
            names.Enqueue("David","C");
            names.Enqueue("Carol","A");
            names.Enqueue("Jessica","B");

            //while (names.Count > 0)
            //{
            //    Console.WriteLine(names.Dequeue());
            //}
            #endregion

            customers.Enqueue(new("David", "Smith"), Level.Silver);
            customers.Enqueue(new("Jessica", "Pearson"), Level.Gold);
            customers.Enqueue(new("Mike", "Ross"), Level.Platinum);
            customers.Enqueue(new("Havey", "Specter"), Level.Platinum);
            customers.Enqueue(new("Donna", "Paulsen"), Level.Gold);
            customers.Enqueue(new("Henry", "Gerald"), Level.Gold);

            while (customers.Count > 0)
            {
                Console.WriteLine(customers.Dequeue());
            }
        }
    }
}
