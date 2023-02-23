int numberOfSongs = int.Parse(Console.ReadLine());
List<Song> songs = new List<Song>();

for (int i = 0; i < numberOfSongs; i++)
{
    string[] songData = Console.ReadLine().Split('_').ToArray();
    var song = new Song { typeList = songData[0], name = songData[1], time = songData[2] };
    songs.Add(song);
}
string typeList = Console.ReadLine();

if (typeList == "all")
{
    foreach (var song in songs)
    {
        Console.WriteLine(song.name);
    }
}
else
{
    foreach (var song in songs)
    {
        if (typeList == song.typeList)
        {
            Console.WriteLine(song.name);
        }
    }
}

class Song
{
    public string typeList { get; set; }
    public string name { get; set; }
    public string time { get; set; }
}
