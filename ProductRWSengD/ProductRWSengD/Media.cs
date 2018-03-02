using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class Media : Product
    {
        public string RealseDate { get; set; }

        public Media(string Type, string ID, string Desc, double Price, int Qty,
         string releaseDate) : base(Type, ID, Desc, Price, Qty)
        {
            this.RealseDate = releaseDate;
        }
        public override string getDisplayText(string Sep)
        {
            return base.getDisplayText(Sep) + Sep + this.RealseDate;
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