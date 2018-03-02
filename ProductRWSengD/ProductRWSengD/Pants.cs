using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class Pants : Apparel
    {

        public int Inseam { get; set; }
        public int Waist { get; set; }


        public Pants(string Type, string ID, string Desc, double Price, int Qty,
          string Color, string Manufacturer, string Material,
          int Inseam, int Waist) : base(Type, ID, Desc, Price, Qty, Color, Manufacturer, Material)
        {
            this.Inseam = Inseam;
            this.Waist = Waist;
        }

        public override string getDisplayText(string Sep)
        {
            return base.getDisplayText(Sep) + Sep + this.Inseam + Sep + this.Waist;
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