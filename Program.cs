namespace textfile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string filepath = Path.Combine(DocumentPath, "New.txt");

                 Console.WriteLine("Please Enter your name");
                 string Texttowrite = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.WriteLine(Texttowrite);
            }

            Console.WriteLine("Successfully");
        }


    }
}
