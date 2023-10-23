using System.Collections.Immutable;

namespace ICE_TASK4_MEMO
{
    internal class Program
    {
        static Dictionary<string, int> places = new();
        static void Main(string[] args)
        {

            /*0*/ places.Add("South Africa",-1);
            /*1*/ places.Add("KZN",0);
            /*2*/ places.Add("Midrand",4);
            /*3*/ places.Add("Pretoria",4);
            /*4*/ places.Add("Gauteng",0);
            /*5*/ places.Add("Durban",1);
            /*6*/ places.Add("Waterfall",2);
            /*7*/ places.Add("North West",0);
            /*8*/ places.Add("Cape Town",10);
            /*9*/ places.Add("Rustenburg",7);
            /*10*/ places.Add("Western Cape",0);
            /*11*/ places.Add("Centurion",3);
            /*12*/ places.Add("Die Hoewes",11);

            FindParent("Die Hoewes");
            Console.Read();

        }
        //South Africa
        static void FindParent(string child)
        {
            Console.WriteLine($"{child.PadLeft(child.Length)}"); //South Africa
            int index = places[child]; // -1
            if (index != -1 && index < places.Count)
            {
                Thread.Sleep(3000);
                FindParent(places.ElementAt(index).Key); //South Africa
            }

        }
    }
}