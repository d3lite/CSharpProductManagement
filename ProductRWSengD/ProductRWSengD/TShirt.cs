using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class TShirt : Apparel
    {

        public string size { get; set; }

        public TShirt(string Type, string ID, string Desc, double Price, int Qty,
           string Color, string Manufacturer, string Material,
           string Size) : base(Type, ID, Desc, Price, Qty, Color, Manufacturer, Material)
        {
            this.size = Size;
        }
        public override string getDisplayText(string Sep)
        {
            return base.getDisplayText(Sep) + Sep + this.size;
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