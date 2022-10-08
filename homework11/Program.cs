namespace homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDictionary <string, string> dict = new ApplicationDictionary<string, string>();
            dict.Add("flower", "цветок");
            dict.Add("table", "стол");
            dict.Add("tree", "дерево");
            dict.ListOfKey();
            dict.Remove("table");
            dict.ListOfKey();
            Console.WriteLine(dict.GetValueByKey("tree"));

        }
    }
}