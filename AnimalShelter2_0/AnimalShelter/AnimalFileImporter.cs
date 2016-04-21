using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace AnimalShelter
{
    public partial class AnimalFileImporter: Form
    {
        private readonly Adminstration adminstration;
        private ListBox reserved;
        private ListBox unReserved;
     
        
        public AnimalFileImporter(Adminstration adminstration,ListBox reserved,ListBox unReserved)
        {
            InitializeComponent();
            MessageBox.Show("Please enter a Directory path");
            btnLoad.Visible = false;
            btnSave.Visible = false;
            btnExport.Visible = false;
            this.adminstration = adminstration;
            this.reserved = reserved;
            this.unReserved = unReserved;

        }

      
      
        private void AnimalFileImporter_Load(object sender, EventArgs e)
        {

        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (.txt)|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = dialog.FileName;
            }
            btnSave.Visible = true;
            btnLoad.Visible = true;
            btnExport.Visible = true;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
          
                reserved.Items.Clear();
                unReserved.Items.Clear();
            
            if (tbPath.Text != "")
            {
                adminstration.Save(tbPath.Text);
            }
            else
            {
                MessageBox.Show("Please Choose a valid file");
            }
        }

        private void btnExport_Click(object sender, EventArgs e) // button Load
        {

            try
            {
                reserved.Items.Clear();
                unReserved.Items.Clear();
                adminstration.Load(tbPath.Text);
                foreach (Animal dier in adminstration.AnimalList)
                {
                    if (dier is Dog)
                    {
                        lbDogs.Items.Add(dier);
                    }
                    if (dier is Cat)
                    {
                        lbCats.Items.Add(dier);
                    }
                    if (dier.IsReserved == true)
                    {
                        reserved.Items.Add(dier);
                    }
                    else
                    {
                        unReserved.Items.Add(dier);
                    }
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("something went wrong, make sure the file exist & contains content");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("something went wrong, make sure the file exist & contains content");
            }
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            try
            {
                adminstration.Export(tbPath.Text);
                reserved.Items.Clear();
                unReserved.Items.Clear();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("something went wrong, make sure the file exist");
            }

        }
    }
}
