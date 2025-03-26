namespace NameSorter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Any())
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string filePath = Path.Combine(currentDirectory, args[0]);
                if (File.Exists(filePath))
                {
                    string[] names = File.ReadAllLines(filePath);
                    NameSorter.SortNames(names);
                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }

                    //Write to file
                    File.WriteAllLines("sorted-names-list.txt", names);

                    Console.WriteLine("Sorted names list has saved into sorted-names-list.txt file.");
                }
                else
                {
                    Console.WriteLine("The file is not existed");
                }
            }
            else
            {
                Console.WriteLine("The file name is not provided");
            }
            Console.ReadLine();
        }
    }
}

