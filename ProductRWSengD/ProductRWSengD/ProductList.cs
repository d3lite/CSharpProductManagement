using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProductRWSengD
{
    class ProductList: List<Product>
    {

        public void readFromFile(string fileName)
        {
            StreamReader textIn = new StreamReader(new FileStream(@"Products.csv",
                FileMode.OpenOrCreate, FileAccess.Read));

            string dir = @"Outputs";
            string path = dir + "/Products.csv";
            string[] splitEntry;
            string curLine;

            while ((curLine = textIn.ReadLine()) != null)
            {
                splitEntry = curLine.Split(',');
                this.Add(splitEntry);
            }
            textIn.Close();
        }

        public void readFromBinary(string fileName)
        {
            string dir = @"Outputs";
            string path = dir + "/Products.bin";

            BinaryReader binaryIn = new BinaryReader(new FileStream(@"Products.bin",
                FileMode.OpenOrCreate, FileAccess.Read));

            while (binaryIn.PeekChar() != -1)
            {
                this.Add(binaryIn.ReadString().Split(','));
            }

            binaryIn.Close();
        }

        public void writeToFile(string fileName)
        {
            string dir = @"Outputs";
            string path = dir + "/Output.csv";

            StreamWriter textOut = new StreamWriter(new FileStream(@"Output.csv",
                FileMode.Create, FileAccess.Write));

            foreach (Product p in this)
            {
                textOut.WriteLine(p.ToCSV());
            }
            textOut.Close();
        }

        public void writeToBinary(string fileName)
        {
            string dir = @"Outputs";
            string path = dir + "/Output.bin";

            BinaryWriter binaryOut = new BinaryWriter(new FileStream(@"Output.bin",
                FileMode.Create, FileAccess.Write));

            foreach (Product p in this)
            {
                binaryOut.Write(p.ToCSV());
            }
            binaryOut.Close();
        }

        public void Add(string[] splitEntry)
        {
            if (splitEntry[0] == "DressShirt")
            {
                this.Add(new DressShirt(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse(splitEntry[3]), int.Parse(splitEntry[4]),
                    splitEntry[6], splitEntry[7], splitEntry[5], int.Parse(splitEntry[8]), int.Parse(splitEntry[9])));
            }
            else if (splitEntry[0] == "Pants")
            {
                this.Add(new Pants(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse(splitEntry[3]), int.Parse(splitEntry[4]),
                    splitEntry[6], splitEntry[7], splitEntry[5], int.Parse(splitEntry[8]), int.Parse(splitEntry[9])));

            }
            else if (splitEntry[0] == "TShirt")
            {
                this.Add(new TShirt(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse(splitEntry[3]), int.Parse(splitEntry[4]),
                    splitEntry[6], splitEntry[7], splitEntry[5], splitEntry[8]));
            }
            else if (splitEntry[0] == "Book")
            {
                this.Add(new Book(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse((splitEntry[3])), int.Parse((splitEntry[4])),
                    splitEntry[5], int.Parse(splitEntry[6]), splitEntry[7], splitEntry[8]));
            }
            else if (splitEntry[0] == "Software")
            {
                this.Add(new Software(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse((splitEntry[3])), int.Parse((splitEntry[4])),
                    splitEntry[5], int.Parse(splitEntry[6]), int.Parse(splitEntry[7]), splitEntry[8], splitEntry[9]));
            }
            else if (splitEntry[0] == "Movie")
            {
                this.Add(new Movie(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse((splitEntry[3])), int.Parse((splitEntry[4])),
                       splitEntry[5], int.Parse(splitEntry[6]), int.Parse(splitEntry[7]), splitEntry[8], splitEntry[9], splitEntry[10], splitEntry[11]));
            }
            else if (splitEntry[0] == "Music")
            {
                this.Add(new Music(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse((splitEntry[3])), int.Parse((splitEntry[4])),
                       splitEntry[5], int.Parse(splitEntry[6]), int.Parse(splitEntry[7]), splitEntry[8], splitEntry[9], splitEntry[10], splitEntry[12], splitEntry[11]));
            }
        }

        public virtual string ToCSV()
        {
            string CSVString = "";
            foreach (Product product in this)
                CSVString = CSVString + product.ToCSV() + "\r\n";
            return CSVString;
        }

        public override string ToString()
        {
            string ToStringString = String.Join(" ", this.Select(x => x.ToString().ToArray()));

            return ToStringString;
        }


    }
}
