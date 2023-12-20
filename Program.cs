using Kimmy_SD_M2;
using System.Reflection;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<MusicRecords>();
for (int i = 0; i < numberOfRecords; i++)
{
    var musicRecords = new MusicRecords();

    Console.WriteLine("What is the name of the artist? ");
    musicRecords.ArtistName = Console.ReadLine();

    Console.WriteLine("What is the song title? ");
    musicRecords.SongTitle = Console.ReadLine();

    Console.WriteLine("What is the price? ");
    musicRecords.Price = decimal.Parse(Console.ReadLine());

    Console.WriteLine("How many records of this album do your want? ");
    musicRecords.Quantity = int.Parse(Console.ReadLine());

    Console.WriteLine("Provide a description title. ");
    musicRecords.Description = Console.ReadLine();

    recordList.Add(musicRecords);

    Console.WriteLine("Record added!");
}

foreach (var musicRecord in recordList)
{
    foreach (PropertyInfo prop in musicRecord.GetType().GetProperties())
    {
        var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
        {
            Console.WriteLine(prop.GetValue(musicRecord, null).ToString());
        }
    }
}
