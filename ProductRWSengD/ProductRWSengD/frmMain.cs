using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductRWSengD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Product p;
        private int idx = -1;
        private ProductList pl = new ProductList();

        public void drawApparel()
        {
            Apparel a = (Apparel)p;
            lblVar1.Text = "Color";
            txtVar1.Text = a.Color;
            lblVar2.Text = "Manufacturer";
            txtVar2.Text = a.Manufacturer;
            lblVar3.Text = "Material";
            txtVar3.Text = a.Material;
        }

        public void drawDisk()
        {
            Disk d = (Disk)p;
            drawMedia();
            lblVar2.Text = "Number of Disks";
            txtVar2.Text = d.NumDisks.ToString();
            lblVar3.Text = "Data Size";
            txtVar3.Text = d.DiskSize.ToString();
            lblVar4.Text = "Type Disk";
            txtVar4.Text = d.TypeDisk;
        }

        public void drawEntertaunment()
        {
            Entertainment entereainment = (Entertainment)p;
            this.drawDisk();
            this.lblVar5.Text = "RunTime";
            this.txtVar5.Text = entereainment.Runtime;
        }
        public void drawBook()
        {
            Book b = (Book)p;
            drawSet(true, true, true, true, false, false, false, false);
            drawMedia();
            lblVar2.Text = "Author";
            txtVar2.Text = b.Author;
            lblVar3.Text = "Pages";
            txtVar3.Text = b.NumPages.ToString();
            lblVar4.Text = "Publisher";
            txtVar4.Text = b.Publisher;
        }
        public void drawSoftware()
        {
            Software s = (Software)p;
            drawSet(true, true, true, true, true, false, false, false);
            drawDisk();
            lblVar5.Text = "Type Software";
            txtVar5.Text = s.TypeSoft;
        }
        public void drawMusic()
        {
            Music m = (Music)p;
            drawSet(true, true, true, true, true, true, true, true);
            drawEntertaunment();
            lblVar6.Text = "Artist";
            txtVar6.Text = m.Artist;
            lblVar7.Text = "Label";
            txtVar7.Text = m.Label;
            lblVar8.Text = "Genre";
            txtVar8.Text = m.Genre;
        }
        public void drawMovie()
        {
            Movie m = (Movie)p;
            drawSet(true, true, true, true, true, true, true, false);
            drawEntertaunment();
            lblVar6.Text = "Director";
            txtVar6.Text = m.Director;
            lblVar7.Text = "Producer";
            txtVar7.Text = m.Producer;
        }

        public void drawPants()
        {
            Pants P = (Pants)p;
            drawSet(true, true, true, true, true, false, false, false);
            drawApparel();
            lblVar4.Text = "Waist";
            txtVar4.Text = P.Waist.ToString();
            lblVar5.Text = "Inseam";
            txtVar5.Text = P.Inseam.ToString();
        }

        public void drawTShirt()
        {
            TShirt TS = (TShirt)p;
            drawSet(true, true, true, true, false, false, false, false);
            drawApparel();
            lblVar4.Text = "Size";
            txtVar4.Text = TS.size.ToString();
        }

        public void drawDressShirt()
        {
            DressShirt DS = (DressShirt)p;
            drawSet(true, true, true, true, true, false, false, false);
            drawApparel();
            this.lblVar4.Text = "Neck";
            this.txtVar4.Text = DS.Neck.ToString();
            this.lblVar5.Text = "Sleeve";
            this.txtVar5.Text = DS.Sleeve.ToString();
        }

        public void drawMedia()
        {
            Media m = (Media)p;
            lblVar1.Text = "Release Date";
            txtVar1.Text = m.RealseDate;
        }

        public void drawProduct()
        {
            if (idx >= 0 && idx < pl.Count)
            {
                p = pl.ElementAt(idx);
                txtType.Text = p.Type;
                txtID.Text = p.ID;
                txtDescription.Text = p.Desc;
                txtPrice.Text = p.price.ToString("C");
                txtQuantity.Text = p.Qty.ToString();
                if (p.Type == "Book")
                    drawBook();
                else if (p.Type == "Software")
                    drawSoftware();
                else if (p.Type == "Music")
                    drawMusic();
                else if (p.Type == "Movie")
                    drawMovie();
                else if (p.Type == "Pants")
                    drawPants();
                else if (p.Type == "TShirt")
                    drawTShirt();
                else if (p.Type == "DressShirt")
                    drawDressShirt();
                else
                    MessageBox.Show("Not found.");
            }
        }

        public void drawSet(bool var1, bool var2, bool var3, bool var4, bool var5, bool var6, bool var7, bool var8)
        {
            lblVar1.Visible = var1;
            txtVar1.Visible = var1;
            lblVar2.Visible = var2;
            txtVar2.Visible = var2;
            lblVar3.Visible = var3;
            txtVar3.Visible = var3;
            lblVar4.Visible = var4;
            txtVar4.Visible = var4;
            lblVar5.Visible = var5;
            txtVar5.Visible = var5;
            lblVar6.Visible = var6;
            txtVar6.Visible = var6;
            lblVar7.Visible = var7;
            txtVar7.Visible = var7;
            lblVar8.Visible = var8;
            txtVar8.Visible = var8;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnWrite.Enabled = false;
            btnWriteBin.Enabled = false;
            drawSet(false, false, false, false, false, false, false, false);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            pl.Clear();
            pl.readFromFile("Products.csv");
            idx = 0;
            drawProduct();
            btnPrevious.Enabled = false;
            btnNext.Enabled = true;
            btnWrite.Enabled = true;
            btnWriteBin.Enabled = true;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            pl.writeToBinary("Output.bin");
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bool check;
            check = idx == 1;
            if (check)
            {
                idx--;
                p = pl.ElementAt(idx);
                drawProduct();
                btnPrevious.Enabled = false;
            }
            else
            {
                idx--;
                p = pl.ElementAt(idx);
                drawProduct();
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            bool check;
            check = idx == pl.Count - 2;
            if (check)
            {
                idx++;
                p = pl.ElementAt(idx);
                drawProduct();
                btnNext.Enabled = false;
            }
            else
            {
                bool check2;
                check2 = idx < pl.Count - 2;
                if (check2)
                {
                    idx++;
                    p = pl.ElementAt(idx);
                    drawProduct();
                    btnPrevious.Enabled = true;
                }
            }
        }

        private void btnReadBin_Click(object sender, EventArgs e)
        {
            pl.Clear();
            pl.readFromBinary("Products.bin");
            idx = 0;
            drawProduct();

            btnWrite.Enabled = true;
            btnWriteBin.Enabled = true;
            btnPrevious.Enabled = false;
            btnNext.Enabled = true;
        }
    }
}
