﻿

public class Video
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int PlaylistID { get; set; }
    public Playlist Playlist { get; set; }
}