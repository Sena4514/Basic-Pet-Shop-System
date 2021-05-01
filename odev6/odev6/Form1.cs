using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev6
{
    public partial class frmPetShopSystem : Form
    {
        public frmPetShopSystem()
        {
            InitializeComponent();
        }

        private void frmPetShopSystem_Load(object sender, EventArgs e)
        {
            string[] animals = new string[] {"Dog", "Cat", "Fish", "Bird", "Hamster"};

            foreach (string animal in animals)
            {
                lbxExistInPetShop.Items.Add(animal);
            }
            btnRemoveFromCard.Enabled = false;

        }

        private void btnRemoveFromPetShop_Click(object sender, EventArgs e)
        {
            if (lbxExistInPetShop.SelectedItem != null)
            {
                btnRemoveFromCard.Enabled = true;
                lbxAbsentInPetShop.Items.Add(lbxExistInPetShop.SelectedItem);
                lbxExistInPetShop.Items.Remove(lbxExistInPetShop.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please Select One More Animal!!");
            }
        }

        private void btnRemoveFromCard_Click(object sender, EventArgs e)
        {
            if (lbxAbsentInPetShop.SelectedItem != null)
            {
                //lbxExistInPetShop.Items.Add(lbxAbsentInPetShop.SelectedItem);
                lbxAbsentInPetShop.Items.Remove(lbxAbsentInPetShop.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please Select One More Animal!!");
            }
        }

        private void btnAddToExistInPetShop_Click(object sender, EventArgs e)
        {
            lbxExistInPetShop.Items.Add(txtAddAnimalToExistInPetShop.Text);
        }
    }
}
