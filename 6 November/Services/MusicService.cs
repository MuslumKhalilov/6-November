//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using _6_November.Models;

//namespace _6_November.Services
//{
//    internal class MusicService
//    {
//        private static SQL _database = new SQL();


//        public void CreateMusic(Music music)
//        {
//            string cmd = ($"insert into Musics values({music.Name},{music.Duration},{music.ArtistId},{music.CategoryId})");
//            _database.ExecuteCommand(cmd);
//        }

//        public List<Music> GetAllMusics()
//        {
//            string cmd = ($"get * from Musics");
//            DataTable table = _database.ExecuteQuery(cmd);
//            List<Music> musics = new List<Music>();
//            foreach (DataRow row in table.Rows)
//            {
//                Music music = new Music
//                {
//                    Id = (int)row["Id"],
//                    Name = row["Name"].ToString(),
//                    Duration = (int)row["Duration"],
//                    ArtistId = (int)row["ArtistId"],
//                    CategoryId = (int)row["CategoryId"]

//                };
//                musics.Add(music);
//            }
//            return musics;

//        }
//        public void DeleteMusic(int id)
//        {
//            string cmd = ($"delete * from Musics where Id={id}");
//            int result = 0;
//            _database.ExecuteCommand(cmd);
//            if (result == 0)
//            {
//                Console.WriteLine($"Music with this Id{id} was not found");

//            }
//            else { Console.WriteLine($"Music with this Id{id} was deleted"); }
//        }

//        public Music GetMusicById(int id)
//        {
//            string query = ($"get all from Musics where Id={id}");
//            DataTable table = _database.ExecuteQuery(query);
//            if (table.Rows.Count > 0)
//            {
//                Music music = new Music
//                {
//                    Id = (int)table.Rows[0]["Id"],
//                    Name = table.Rows[1]["Name"].ToString(),
//                    Duration = (int)table.Rows[2]["Duration"],
//                    ArtistId = (int)table.Rows[3]["ArtistId"],
//                    CategoryId = (int)table.Rows[4]["CategoryId"]

//                };
//                return music;
//            }
//            return null;


//        }
//    }
//}

