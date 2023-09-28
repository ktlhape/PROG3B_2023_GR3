namespace UsingDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Dictionary
            //Declare a Dictionary
            Dictionary<int, string> numbers = new();
            //Add Items
            numbers.Add(2, "Two");
            numbers.Add(1, "One"); 
            numbers.Add(5, "Five"); //index = 2
            numbers.Add(7, "Seven");
            numbers.Add(4, "Four");

            //Access the items
            //Console.WriteLine(numbers[2]); //Two
            //Console.WriteLine(numbers.ElementAt(2).Value);//Five
            //Console.WriteLine(numbers[key:(7)]); //Seven
            //Console.WriteLine(numbers[4]);
            //Update items
            //Console.WriteLine();
            numbers[4] = "Steven";
            numbers[key:(12)] = "Twelve";

            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers[12]);

            //Display 
            //Console.WriteLine("======================");
            //foreach (KeyValuePair<int,string> num in numbers)
            //{
            //    Console.WriteLine(num.Key + " - " + num.Value);
            //}
            #endregion

            /*Create a Dictionary that will store a module and
             a list of students enrolled for the module*/
            Dictionary<string, List<string>> modules = new();
            //Add items
            //C#, JAVA, PHP, PYTHON
            modules.Add("C#", new() { "David","Carol","Jessica","Rachael" });
            modules.Add("JAVA", new() { "Kabelo","Jessica","Mike" });
            modules.Add("PHP", new() { "Thabo","Angela","Tyla","Jessica" });
            modules.Add("PYTHON", new() { "Jason","Kabelo","Fiona","Monica","Henry","Rachael" });

            //Access
            //List<string> csharp = modules["C#"];
            if (modules.TryGetValue("C#", out List<string> csharp))
            {
                //Add new items
                csharp.Add("Kevin");
                csharp.Add("Roger");
                foreach (string st in csharp)
                {
                    Console.WriteLine(st);
                }
            }
            else { Console.WriteLine("Key not found"); }
            //Display all the items
            Console.WriteLine("============All Items============");
            int count = 0;
            foreach (string mod in modules.Keys)
            {
                Console.Write(mod); //C#
                foreach (string st in modules[mod])
                {
                    Console.WriteLine($"\t{++count}. {st}");
                }
                Console.WriteLine("-------------------");
                count = 0;
            }







        }
    }
}