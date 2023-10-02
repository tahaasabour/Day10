

using System.Collections.Generic;

public class Playlist
{
    public int ID { set; get; }
    public string Title { set; get; }
    public ICollection<Video> Videos { set; get; }
}