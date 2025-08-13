////Libary////
using System.Reflection.Metadata;
using UglyToad.PdfPig;

///DATA///
List<string> historylist = new List<string>();
string historydata = "historydata.txt";

if (File.Exists(historydata))
{
    string[] historys = File.ReadAllLines(historydata);
    for (int i = 0; i < historys.Length; i++)
    {
        historylist.Add(historys[i]);
    }
}

///////SYSTEMS//////
while (true)
{
    Console.WriteLine("Write 1 for historical pdf data");
    string path = "";
    Console.WriteLine("PDF PATH: ");
    path = Console.ReadLine();

    if (path == "1")
    {
        historysystem();
        continue;
    }
    else if (!System.IO.File.Exists(path))
    {
        Console.WriteLine("Path not found");
        continue;
    }


    try
    {
        using (var document = PdfDocument.Open(path))
        {
            var info = document.Information;
            Console.WriteLine("-----PDF METADATA-----");
            Console.WriteLine("Title: " + info.Title);
            Console.WriteLine("Page Count: " + document.NumberOfPages);
            Console.WriteLine("Author: " + info.Author);
            Console.WriteLine("Creator: " + info.Creator);
            Console.WriteLine("Producer: " + info.Producer);
            Console.WriteLine("CreationDate: " + info.CreationDate);
            Console.WriteLine("ModifiedDate: " + info.ModifiedDate);

            string topdata = info.Title + " --> " + document.NumberOfPages + " --> " + info.Author + " --> " + info.Creator + " --> " + info.Producer + " --> " + info.CreationDate + " --> " + info.ModifiedDate;
            historylist.Add(topdata);
            File.AppendAllText(historydata, topdata + Environment.NewLine);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Xeta: {ex.Message}");
    }

}


//////HISTORY////////////
void historysystem()
{
    Console.WriteLine("-----HISTORY-----");
    if (historylist.Count == 0)
    {
        Console.WriteLine("There is no history!");
        Console.WriteLine("-----------------");
        return;
    }
    Console.WriteLine("Title --> PageCount --> Author --> Creator --> Producer --> CretionData --> ModifiedDate");
    for (int i = 0; i < historylist.Count; i++)
    {
        Console.WriteLine(historylist[i]);
        Console.WriteLine("-----------------");
    }
}