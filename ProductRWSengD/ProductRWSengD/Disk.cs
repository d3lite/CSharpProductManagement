using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class Disk : Media
    {
        public int NumDisks { get; set; }

        public int DiskSize { get; set; }

        public string TypeDisk { get; set; }

        public Disk(string Type, string ID, string Desc, double Price, int Qty,
            string ReleaseDate,
            int NumDisks, int Size, string TypeDisk) : base(Type, ID, Desc, Price, Qty, ReleaseDate)
        {
            this.NumDisks = NumDisks;
            this.DiskSize = Size;
            this.TypeDisk = TypeDisk;
        }
        public override string getDisplayText(string Sep)
        {
            return base.getDisplayText(Sep) + Sep + (object)this.DiskSize + Sep + this.TypeDisk;
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