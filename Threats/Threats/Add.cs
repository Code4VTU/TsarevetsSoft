using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Threats
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        public double Lat;
        public double Long;
        public bool set = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbLoc.Text == string.Empty) MessageBox.Show("Add a location!");
            else if (tbDesc.Text == string.Empty) MessageBox.Show("Add a description!");
            else if (tbLat.Text == string.Empty) MessageBox.Show("Enter coordinates!");
            else if (tbLong.Text == string.Empty) MessageBox.Show("Enter coordinates!");
            else if (pbImage.ImageLocation == string.Empty) MessageBox.Show("Add an image!");

            else
            {
                string path = Directory.GetCurrentDirectory() +"\\db.txt";
                StreamWriter save = new StreamWriter(path, true);
                
                save.WriteLine(tbLoc.Text);
                save.WriteLine(tbDesc.Text);
                save.WriteLine(tbLat.Text);
                save.WriteLine(tbLong.Text);
                save.WriteLine(); save.WriteLine();
                save.Close();
                set = true;
                var ci = CultureInfo.InvariantCulture.Clone() as CultureInfo;
                ci.NumberFormat.NumberDecimalSeparator = ",";
                decimal number = decimal.Parse(tbLat.Text, ci);
                Long = double.Parse(tbLong.Text, ci);
                MessageBox.Show("Entry succesfully added!");
                Close();
            }

            }
        }
    }
