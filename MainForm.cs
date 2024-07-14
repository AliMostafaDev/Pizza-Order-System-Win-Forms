using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdatePrice()
        {
             labelTotalPriceAnswer.Text = ((int.Parse(gbSize.Tag.ToString()) + int.Parse(gbToppings.Tag.ToString()) + int.Parse(gbCrustType.Tag.ToString())) * numericUpDown1.Value).ToString();
        }

        public void UpdateToppings()
        {
            string Toppings = "";

            if (chkExtraCheese.Checked)
                Toppings += Toppings.Length == 0 ? chkExtraCheese.Text : ", " + chkExtraCheese.Text;

            if (chkMushrooms.Checked)
                Toppings += Toppings.Length == 0 ? chkMushrooms.Text : ", " + chkMushrooms.Text;

            if (chkTomatoes.Checked)
                Toppings += Toppings.Length == 0 ? chkTomatoes.Text : ", " + chkTomatoes.Text;

            if (chkOnion.Checked)
                Toppings += Toppings.Length == 0 ? chkOnion.Text : ", " + chkOnion.Text;

            if (chkOlives.Checked)
                Toppings += Toppings.Length == 0 ? chkOlives.Text : ", " + chkOlives.Text;

            if (chkGreenPeppers.Checked)
                Toppings += Toppings.Length == 0 ? chkGreenPeppers.Text : ", " + chkGreenPeppers.Text;

            if (Toppings.Length == 0)
                Toppings = "No Toppings";

            labelToppingsAnswer.Text = Toppings;

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            labelSizeAnswer.Text = rbSmall.Text;
            gbSize.Tag = rbSmall.Tag;
            UpdatePrice();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            labelSizeAnswer.Text = rbMedium.Text;
            gbSize.Tag = rbMedium.Tag;
            UpdatePrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            labelSizeAnswer.Text = rbLarge.Text;
            gbSize.Tag = rbLarge.Tag;
            UpdatePrice();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            labelCrustTypeAnswer.Text = rbThinCrust.Text;
            gbCrustType.Tag = rbThinCrust.Tag;
            UpdatePrice();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            labelCrustTypeAnswer.Text = rbThickCrust.Text;
            gbCrustType.Tag = rbThickCrust.Tag;
            UpdatePrice();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked)
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) + 5).ToString();
                UpdatePrice();
                UpdateToppings();

            }
            else
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) - 5).ToString();
                UpdatePrice();
                UpdateToppings();

            }
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushrooms.Checked)
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) + 5).ToString();
                UpdatePrice();
                UpdateToppings();

            }
            else
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) - 5).ToString();
                UpdatePrice();
                UpdateToppings();

            }
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            labelWhereToEatAnswer.Text = rbEatIn.Text;
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            labelWhereToEatAnswer.Text = rbTakeOut.Text;
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Order Placed Successfully!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereToEat.Enabled = false;

                btnOrderPizza.Enabled = false;
                btnOrderPizza.FlatAppearance.BorderColor = Color.White;

                numericUpDown1.Enabled = false;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;
            numericUpDown1.Enabled = true;

            rbSmall.Checked = false;
            rbMedium.Checked = true;
            rbLarge.Checked = false;

            rbThinCrust.Checked = true;
            rbThickCrust.Checked = false;

            rbTakeOut.Checked = false;
            rbEatIn.Checked = true;

            chkExtraCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;

            btnOrderPizza.Enabled = true;
            btnOrderPizza.FlatAppearance.BorderColor = Color.Black;
            numericUpDown1.Value = 1;
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomatoes.Checked)
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) + 5).ToString();
                UpdatePrice();
                UpdateToppings();
            }
            else
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) - 5).ToString();
                UpdatePrice();
                UpdateToppings();
            }
                
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked)
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) + 5).ToString();
                UpdatePrice();
                UpdateToppings();
            }
            else
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) - 5).ToString();
                UpdatePrice();
                UpdateToppings();
            }
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked)
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) + 5).ToString();
                UpdatePrice();
                UpdateToppings();
            }
            else
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) - 5).ToString();
                UpdatePrice();
                UpdateToppings();
            }
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenPeppers.Checked)
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) + 5).ToString();
                UpdatePrice();
                UpdateToppings();
            }
            else
            {
                gbToppings.Tag = (int.Parse(gbToppings.Tag.ToString()) - 5).ToString();
                UpdatePrice();
                UpdateToppings();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
         UpdatePrice();
            
        }
    }
}
