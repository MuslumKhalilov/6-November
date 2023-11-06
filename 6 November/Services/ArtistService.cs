//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using _6_November.Models;

//namespace _6_November.Services
//{
//    internal class ArtistService
//    {
//        private SQL _database = new SQL();





//        public void CreateArtists(Artist artist)
//        {
//            string cmd = ($"insert into Artists values({artist.Name},{artist.Surname},{artist.Birthday}<{artist.Gender})");
//            _database.ExecuteCommand(cmd);
//        }



//        public void DeleteArtist(int id)
//        {
//            string cmd = ($"delete * from Artists where Id={id}");
//            int result = 0;
//            _database.ExecuteCommand(cmd);
//            if(result == 0) 
//            {
//                Console.WriteLine($"Artist with this Id{id} was not found");

//            }
//            else { Console.WriteLine($"Artis with this Id{id} was deleted"); }
//        }

//        public List<Artist> GetAllArtists()
//        {
//            string cmd = ($"get * from Artists");
//            DataTable table = _database.ExecuteQuery(cmd);
//            List<Artist> artists = new List<Artist>();
//            foreach (DataRow row in table.Rows)
//            {
//                Artist artist = new Artist
//                {
//                    Id = (int)row["Id"],
//                    Name = row["Name"].ToString(),
//                    Surname = row["Surname"].ToString(),
//                    Birthday = row["Birthday"].ToString(),
//                    Gender = row["Gender"].ToString(),


//                };
//                artists.Add(artist);
//            }
//            return artists;

//        }

//        public Artist GetArtistById(int id)
//        {
//            string query = ($"get all from Artists where Id={id}");
//            DataTable table = _database.ExecuteQuery(query);
//            if (table.Rows.Count > 0)
//            {
//                Artist artist= new Artist
//                {
//                    Id = (int)table.Rows[0]["Id"],
//                    Name = table.Rows[1]["Name"].ToString(),
//                    Surname = table.Rows[2]["Surname"].ToString(),
//                    Birthday = table.Rows[3]["Birthday"].ToString(),
//                    Gender = table.Rows[4]["Gender"].ToString(),


//                };
//                return artist;
//            }
//            return null;


//        }
//    }
//}
