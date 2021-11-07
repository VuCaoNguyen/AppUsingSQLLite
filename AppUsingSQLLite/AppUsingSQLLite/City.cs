using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace AppUsingSQLLite
{
   public class City
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public String Img { get; set; }

    }
}
