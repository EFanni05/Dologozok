// See https://aka.ms/new-console-template for more information
using Dologozok;
List<Dolgozok> workers = new List<Dolgozok>();


string fileName = FileTypeChooes();
StreamReader reader = new StreamReader(fileName);
if (fileName.Contains("csv"))
{
    //csv read in
    reader.ReadLine();
    while (!reader.EndOfStream)
    {
        string[] line = reader.ReadLine().Split(',');
        Dolgozok a = new(int.Parse(line[0]), line[1], line[2], int.Parse(line[3]), int.Parse(line[4]));
        workers.Add(a);
    }
}
else if (fileName.Contains("json"))
{
    //json read in
}
else if (fileName.Contains("sql"))
{
    //SQL read in
}
else
{
    throw new Exception();
}
TaskChoose(workers);

static string FileTypeChooes()
{
    string fileName = "";
    do
    {
        Console.WriteLine("Melyik file olvassukbe?\n[ .csv ]\t[ .json ]\t[ .sql ]");
        string type = Console.ReadLine();
        if (type.Trim() is ".csv" or "csv")
        {
            fileName = "dolgozok.csv";
        }
        else if(type.Trim() is ".json" or "json")
        {
            fileName = "dolgozok.json";
        }
        else if(type.Trim() is ".sql" or "sql")
        {
            fileName = "dolgozok.sql";
        }
        else
        {
            Console.WriteLine("Hibás adat");
        }
    } while (fileName == "");
    return fileName;
}
static void TaskChoose(List<Dolgozok> workers)
{
    //you choose here what to do
    Console.WriteLine("Mit akarsz Csinálni?\n1. feladat részek [1]\t2. feladat részek [2]");
    string choose = Console.ReadLine();
    if (choose.Trim() == "1")
    {
        //Task 1 parts
    }
    else if (choose.Trim() == "2")
    {
        //Task 2 Parts
        Task2(workers);
    }
    else
    {
        Console.WriteLine("Hibás adat");
    }
}

static void Task2(List<Dolgozok> workers)
{
    Console.WriteLine($"Férfi dolgozók száma: {workers.FindAll(x => x.Gender == "férfi").Count}");
    Console.WriteLine($"Női dolgozók száma: {workers.FindAll(x => x.Gender == "nő").Count}");
    Console.WriteLine($"A legmagasabb fizetésű dolgozó: {workers.Find(x => x.Salary == workers.Max().Salary).Name} - {workers.Max().Salary}");
    Console.WriteLine($"A legalacsonyabb fizetésű dolgozó: {workers.Find(x => x.Salary == workers.Min().Salary).Name} - {workers.Min().Salary}");
    Console.WriteLine($"A férfiak átlagfizetése: {workers.FindAll(x => x.Gender == "férfi").Average(x => x.Salary)}");
    Console.WriteLine($"A nők átlagfizetése: {workers.FindAll(x => x.Gender == "nő").Average(x => x.Salary)}");
    Console.WriteLine($"A dolgozók álagfizetése: {workers.Average(x => x.Salary)}");
    Console.WriteLine($"A legfiatalabb dolgozó: {workers.Find(x => x.Age == workers.Min().Age).Name}");
    Console.WriteLine($"A legidősebb dolgozó: {workers.Find(x => x.Age == workers.Max().Age).Name}");
    Console.WriteLine($"A dolgozók átlag életkora: {workers.Average(x => x.Age)}");
}