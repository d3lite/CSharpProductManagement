using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class Music : Entertainment
    {

        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Label { get; set; }


        public Music(string Type, string ID, string Desc, double Price, int Qty,
              string ReleaseDate,
              int NumDisks, int Size, string TypeDisk,
              string RunTime,
              string Artist, string Genre, string Label) : base(Type, ID, Desc, Price, Qty, ReleaseDate, NumDisks, Size, TypeDisk, RunTime)
        {
            this.Artist = Artist;
            this.Genre = Genre;
            this.Label = Label;
        }
        public override string getDisplayText(string Sep)
        {
            return base.getDisplayText(Sep) + Sep + this.Artist + Sep + this.Genre + Sep + this.Label;
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