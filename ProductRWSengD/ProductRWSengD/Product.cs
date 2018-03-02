using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class Product
    {
        public string Type { get; set; }

        public string ID { get; set; }

        public string Desc { get; set; }

        public double price { get; set; }

        public int Qty { get; set; }



        private void Product_Load(Object sender, EventArgs e)
        { }

        public Product(string type, string id, string desc, double price, int qty)
        {
            this.Desc = desc;
            this.ID = id;
            this.Type = type;
            this.price = price;
            this.Qty = qty;
        }

        public virtual string getDisplayText(string Sep)
        {
            return this.Type + Sep + this.ID + Sep + this.Desc + Sep + (object)this.price + Sep + (Object)this.Qty;
        }

        public virtual string ToCSV()
        {
            return this.getDisplayText(",");
        }

        public override string ToString()
        {
            return this.getDisplayText("\r\n");
        }

     
    }
}