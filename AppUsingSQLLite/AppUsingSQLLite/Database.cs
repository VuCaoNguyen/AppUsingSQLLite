using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace AppUsingSQLLite
{
   public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDatabase()
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "booking.db");
                var connection = new SQLiteConnection(path);
                connection.CreateTable<City>();
                connection.CreateTable<Hotel>();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddNewCity(City city)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "booking.db");
                var connection = new SQLiteConnection(path);
                connection.Insert(city);
                return true;
            }
            catch (Exception ex){
                return false;
            }
        }

        public List<City> GetCities()
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "booking.db");
                var connection = new SQLiteConnection(path);
                return connection.Table<City>().ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool AddNewHotel(Hotel hotel)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "booking.db");
                var connection = new SQLiteConnection(path);
                connection.Insert(hotel);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<Hotel> GetHotels(int Id)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "booking.db");
                var connection = new SQLiteConnection(path);
                return connection.Query<Hotel>("select * from Hotel where cId=" + Id.ToString());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
