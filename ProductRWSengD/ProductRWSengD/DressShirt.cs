using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class DressShirt : Apparel
    {
        public int Neck { get; set; }
        public int Sleeve { get; set; }



        public DressShirt(string Type, string ID, string Desc, double Price, int Qty,
             string Color, string Manufacturer, string Material,
             int Neck, int Sleeve) : base(Type, ID, Desc, Price, Qty, Color, Manufacturer, Material)
        {
            this.Neck = Neck;
            this.Sleeve = Sleeve;
        }
        public override string getDisplayText(string Sep)
        {
            return base.getDisplayText(Sep) + Sep + this.Neck + Sep + this.Sleeve;
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