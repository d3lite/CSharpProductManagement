using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class Apparel : Product
    {
        public string Color { get; set; }
        public string Manufacturer { get; set; }

        public string Material { get; set; }


     
        public Apparel(string Type, string ID, string Desc, double Price, int Qty,
            string Color, string Manufacturer, string Material) : base(Type, ID, Desc, Price, Qty)
        {
            this.Color = Color;
            this.Manufacturer = Manufacturer;
            this.Material = Material;
        }

        public override string getDisplayText(string Sep)
        {
            return base.getDisplayText(Sep) + Sep + this.Material + Sep + this.Material + Sep + this.Color;
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