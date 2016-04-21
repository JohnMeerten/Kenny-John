using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
       
        private Animal animal;

        private SimpleDate birthday;

        private Adminstration adminstration = new Adminstration();

        public List<Animal> ListUnReserved = new List<Animal>();
        public List<Animal> ListReserved = new List<Animal>();
        
        public AdministrationForm()
        {
            
            InitializeComponent();
            cbAnimalType.SelectedIndex = 0;
            animal = null;
            cbLastwalkDay.Visible = false;
            cbLastwalkMonth.Visible = false;
            cbLastwalkYear.Visible = false;

            for (int i = 1960; i <= DateTime.Now.Year; i++)
            {
                cbYear.Items.Add(i.ToString());
            }
            for (int i = 1; i < 32; i++)
            {
                cbDay.Items.Add(i.ToString());
                cbLastwalkDay.Items.Add(i.ToString());
            }
            for (int i = 1; i < 13; i++)
            {
                cbMonth.Items.Add(i.ToString());
                cbLastwalkMonth.Items.Add(i.ToString());
            }
        }

       
        private void createAnimalButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (cbDay.SelectedItem != null && cbMonth.SelectedItem != null && cbYear.SelectedItem != null)
                {
                    birthday = new SimpleDate(Convert.ToInt32(cbDay.SelectedItem),
                        Convert.ToInt32(cbMonth.SelectedItem), Convert.ToInt32(cbYear.SelectedItem));
                    if (cbAnimalType.SelectedIndex == 1 && tbName.Text != "" &&
                        Convert.ToInt32(tbchipRegistrationNumber.Text) > 0)
                    {
                        SimpleDate walkday = new SimpleDate(cbLastwalkDay.SelectedIndex, cbLastwalkMonth.SelectedIndex,
                            cbLastwalkYear.SelectedIndex);
                        animal = new Dog(Convert.ToInt32(tbchipRegistrationNumber.Text),
                            birthday,
                            tbName.Text,
                            walkday);
                        if (adminstration.Add(animal) == true)
                        {
                            ListUnReserved.Add(animal);
                            lbUnReserved.Items.Clear();
                            cbDeleteShowAnimal.Items.Add(animal);
                            ListUnReserved.Sort();
                            foreach (Animal dier in ListUnReserved)
                            {
                                lbUnReserved.Items.Add(dier);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Animal number already in use");
                        }

                    }
                    if (cbAnimalType.SelectedIndex == 0 && tbName.Text != "" &&
                        Convert.ToInt32(tbchipRegistrationNumber.Text) > 0)
                    {
                        animal = new Cat(Convert.ToInt32(tbchipRegistrationNumber.Text),
                            birthday,
                            tbName.Text,
                            tbBadHabits.Text);
                        if (adminstration.Add(animal) == true)
                        {
                            MessageBox.Show("Animal Accepted");
                            ListUnReserved.Add(animal);
                            cbDeleteShowAnimal.Items.Add(animal);
                            lbUnReserved.Items.Clear();
                            ListUnReserved.Sort();
                            foreach (Animal dier in ListUnReserved)
                            {
                                lbUnReserved.Items.Add(dier);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Animal number already in use");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Animal Not Accepted,Check registrationnumber or empty boxes");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the boxes");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter in right format");
            }

        }


        private void showInfoButton_Click(object sender, EventArgs e)
        {
            
            animal = cbDeleteShowAnimal.SelectedItem as Animal;
            if (animal != null)
            {
                MessageBox.Show(animal.ToString());
            }
            else
            {
                MessageBox.Show("Niks geselecteerd");
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = DateTime.Now.Year;
            int time = Convert.ToInt32(cbYear.SelectedItem);
            while (i >= time)
            {
                cbLastwalkYear.Items.Add(i.ToString());
                i--;
            }


        }

        private void cbAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnimalType.SelectedItem.ToString() == "Dog")
            {
                lbBadHabitWalkDate.Text = "Last Walk Date";
                cbLastwalkDay.Visible = true;
                cbLastwalkMonth.Visible = true;
                cbLastwalkYear.Visible = true;
                tbBadHabits.Visible = false;

            }
            else if (cbAnimalType.SelectedItem.ToString() == "Cat")
            {
                lbBadHabitWalkDate.Text = "Bad Habits";
                cbLastwalkDay.Visible = false;
                cbLastwalkMonth.Visible = false;
                cbLastwalkYear.Visible = false;
                tbBadHabits.Visible = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            animal = cbDeleteShowAnimal.SelectedItem as Animal;
            if (animal != null)
            {
                if (animal.ChipRegistrationNumber > 0)
                {
                    adminstration.RemoveAnimal(animal.ChipRegistrationNumber);
                }
                foreach (Animal animalitem in lbUnReserved.Items)
                {
                    if (animalitem == animal)
                    {
                        lbUnReserved.Items.Remove(animalitem);
                        ListUnReserved.Remove(animalitem);
                    }
                }
                foreach (Animal animalitem in lbReserved.Items)
                {
                    if (animalitem == animal)
                    {
                        lbReserved.Items.Remove(animalitem);
                        ListReserved.Remove(animalitem);
                    }
                }
            }
            else
            {
                MessageBox.Show("Niks geselecteerd");
            }
        }

        private void btnReserved_Click(object sender, EventArgs e)
        {
            animal = lbUnReserved.SelectedItem as Animal;
            if (animal != null)
            {
                animal.IsReserved = true;
                ListUnReserved.Remove(animal);
                ListReserved.Add(animal);
                lbReserved.Items.Clear();
                lbUnReserved.Items.Clear();
                ListUnReserved.Sort();
                ListReserved.Sort();
                foreach (Animal dier in ListReserved)
                {
                    lbReserved.Items.Add(dier);
                }
                foreach (Animal dier in ListUnReserved)
                {
                    lbUnReserved.Items.Add(dier);
                }

            }
        }

        private void btnUnReserved_Click(object sender, EventArgs e)
        {
            animal = lbReserved.SelectedItem as Animal;
            if (animal != null)
            {
                animal.IsReserved = false;
                ListUnReserved.Add(animal);
                ListReserved.Remove(animal);
                lbReserved.Items.Clear();
                lbUnReserved.Items.Clear();
                ListUnReserved.Sort();
                ListReserved.Sort();
                foreach (Animal dier in ListReserved)
                {
                    lbReserved.Items.Add(dier);
                }
                foreach (Animal dier in ListUnReserved)
                {
                    lbUnReserved.Items.Add(dier);
                }

           }
    }

        private void cbLastwalkYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (cbDeleteShowAnimal.SelectedItem != null)
            {
                animal = cbDeleteShowAnimal.SelectedItem as Animal;
                MessageBox.Show("Dit dier kost " + animal.Price + " euro");
            }
            else
            {
                MessageBox.Show("Please choose something from the combobox");
            }
        }

        private void lbReserved_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImportExport_Click(object sender, EventArgs e)
        {
            AnimalFileImporter frm = new AnimalFileImporter(adminstration,lbReserved,lbUnReserved);
            frm.Show();
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {

        }

        private void ClearSort()
        {
            lbReserved.Items.Clear();
            lbUnReserved.Items.Clear();
            ListUnReserved.Sort();
            ListReserved.Sort();
        }
    }
}
