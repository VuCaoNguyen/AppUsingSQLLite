using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace AppUsingSQLLite
{
    public class Hotel
    {
        [PrimaryKey, AutoIncrement]
        public int hId { get; set; }

        public string hName { get; set; }
        public int cId { get; set; }
        public string hImg { get; set; }
    }
}
