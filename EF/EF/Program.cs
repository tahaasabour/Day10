

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {



        EntitiesContext db = new EntitiesContext();

        foreach(Playlist pL in db.Playlists.Include(i=>i.Videos.Where(x=>x.Title.Contains("BV"))))
        {
            Console.WriteLine(pL.Title);
            foreach(Video v in pL.Videos)
            {
                Console.WriteLine("\t"+ v.Title);
            }
        }

        /*
        Playlist pL
            = new Playlist()
            {
                Title="Play LIst 1", 
                Videos = new List<Video>
                {
                    new Video { Title= "Video A", Description="Desc A"},
                    new Video { Title= "Video B", Description="Desc B"}
                }
            };

        db.Playlists.Add(pL);
        db.SaveChanges();
        */

        /*
        Video V = db.Videos.FirstOrDefault();


        db.Videos.Remove(V);
        db.SaveChanges();
        */

        
        /*
        if(V != null )
        {
            V.Title = "New New Title";
            db.SaveChanges();
        }
        */

        /*
        foreach(Video V in db.Videos.Where(i=>i.ID>1))
            Console.WriteLine(V.Title);
        */




        /*
         Video V = new Video
         {
             Title= "Video 1", 
             Description="Description1"
         };
         db.Videos.Add(V);
         db.SaveChanges();
        */
    }
}