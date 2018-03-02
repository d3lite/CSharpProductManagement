using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class Book : Media
    {
        public string Author { get; set; }
        public int NumPages { get; set; }
        public string Publisher { get; set; }


        public Book(string Type, string ID, string Desc, double Price, int Qty,
           string ReleaseDate,
           int NumPages, string Author, string Publisher) : base(Type, ID, Desc, Price, Qty, ReleaseDate)
        {
            this.Author = Author;
            this.NumPages = NumPages;
            this.Publisher = Publisher;
        }

        public override string getDisplayText(string Sep)
        {
            return base.getDisplayText(Sep) + Sep + this.Author + Sep + (object)this.NumPages + Sep + this.Publisher;
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