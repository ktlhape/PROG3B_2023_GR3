using System.ComponentModel.DataAnnotations;

namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emList = new List<Employee>()
            {
                new("Kabelo","Tlhape"),
                new("Kevin","Smith"),
                new("Jessica","Jones"),
                new("Caroline","Smith"),
                new("Samantha","Williams"),
                new("Jessica","Williams")
            };

            Console.WriteLine("=======Unsorted=======");
            Display(emList);
            BubbleSort(emList);
            Console.WriteLine("\n=======Sorted=======");
            Display(emList);
            Console.Read();
        }

        private static void BubbleSort(List<Employee> ls)
        {
            for (int i = 0; i < ls.Count - 1; i++)
            {
                for (int j = (i + 1); j < ls.Count; j++)
                {
                    if (ls[i].CompareTo(ls[j]) == 1)
                    {
                        Swap(ls[i], ls[j]);
                    }
                }
            }
        }
        private static void Swap(Employee em1, Employee em2)
        {
            Employee temp = em1;
            em1 = em2;
            em2 = temp;
        }

        private static void Display(List<Employee> emList)
        {
            foreach (Employee em in emList)
            {
                Console.WriteLine(em.ToString());
            }
        }
    }

    public class Employee :IComparable<Employee>
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public Employee(string firstname, string lastname) =>
            (Firstname, Lastname) = (firstname, lastname);
        public override string ToString() =>
            $"{Firstname} {Lastname}";

        public int CompareTo(Employee? otherEm)
        {
            int results = this.Lastname.CompareTo(otherEm.Lastname);
            if (results == 0)
            {
                results = this.Firstname.CompareTo(otherEm.Firstname);
            }
            return results;
        }
    }
}