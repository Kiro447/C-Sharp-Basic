using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public Enum FavoriteMusicType { get; set; } 
        public List<Song> FavoritesSongs { get; set; }
        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            FavoritesSongs = new List<Song>();

        }
        public void AddSong(Song song)
        {
            FavoritesSongs.Add(song);
        }

        public void GetFavSongs()
        {
            if (FavoritesSongs.Count == 0)
            {
                return;
            }
            else
            {
                foreach (var song in FavoritesSongs)
                {
                    Console.WriteLine(song);
                }
            }
        }

    }


}
