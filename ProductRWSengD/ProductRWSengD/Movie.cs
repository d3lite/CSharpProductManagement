using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class Movie : Entertainment
    {

        public string Director { get; set; }
        public string Producer { get; set; }

        public Movie(string Type, string ID, string Desc, double Price, int Qty,
            string ReleaseDate,
            int NumDisks, int Size, string TypeDisk,
            string RunTime,
            string Director, string Producer) : base(Type, ID, Desc, Price, Qty, ReleaseDate, NumDisks, Size, TypeDisk, RunTime)
        {
            this.Director = Director;
            this.Producer = Producer;
        }

        public override string getDisplayText(string Sep)
        {
            return base.getDisplayText(Sep) + Sep + this.Director + Sep + this.Producer;
        }

        public override string ToString()
        {
            return this.getDisplayText("\r\n");

        }

        public override String ToCSV()
        {
            return this.getDisplayText(",");
        }
    }
}