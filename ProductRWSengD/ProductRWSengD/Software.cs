using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class Software: Disk
    {

        public string TypeSoft { get; set; }

        public Software(string Type, string ID, string Desc, double Price, int Qty,
              string ReleaseDate,
              int NumDisks, int Size, string TypeDisk,
              string TypeSoft) : base(Type, ID, Desc, Price, Qty, ReleaseDate, NumDisks, Size, TypeDisk)
        {
            this.TypeSoft = TypeSoft;
        }
        public override string getDisplayText(string Sep)
        {
            return base.getDisplayText(Sep) + Sep + this.TypeSoft;
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