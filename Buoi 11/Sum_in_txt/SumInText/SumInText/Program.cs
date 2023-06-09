namespace SumInText;
class ReadTextFileExample
{
    static void Main(string[] args)
    {
        Console.Write("File path: ");
        string path = Console.ReadLine();
        ReadTextFileExample example = new ReadTextFileExample();
        example.ReadTextFile(path);
    }

    void ReadTextFile(string filePath)
    {
        try
        {
            FileInfo file = new FileInfo(filePath);
            if (!file.Exists)
            {
                throw new FileNotFoundException();
            }

            StreamReader reader = new StreamReader(filePath);
            string line = "";
            int sum = 0;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                sum += int.Parse(line);
            }
            reader.Close();
            Console.WriteLine("Total: " + sum);
        }
        catch (System.Exception)
        {
            Console.Error.WriteLine("File not found or invalid content");
        }
    }
}

