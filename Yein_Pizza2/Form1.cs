using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
//Yein An 301316062
namespace Yein_Pizza2
{
    public partial class Form1 : Form
    {
        public enum SizeOfPizza
        {
            Small, Medium, Large, ExtraLarge

        }

        List<Order> OrderList;

        public Form1()
        {
            OrderList = new List<Order>();
            InitializeComponent();

            this.CbSize.DataSource = Enum.GetNames(typeof(SizeOfPizza));

            this.RbNonVege.Checked = true;
            this.CbSize.SelectedIndex = 1;
            this.LbQuantity.Text = "1";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtNumber.Text = "";
            this.CbSize.SelectedIndex = 1;
            this.LbQuantity.Text = "1";
            this.RbNonVege.Checked = true;
            this.CbHam.Checked = false;
            this.CbBacon.Checked = false;
            this.CbCheese.Checked = false;
            this.CbChicken.Checked = false;
            this.CbOnion.Checked = false;
            this.CbOlive.Checked = false;
            this.txtCouponCode.Text = "";

            this.LbOrderName.Text = "";
            this.LbOrderNum.Text = "";
            this.LbVegan.Text = "";
            this.LbToppings.Text = "";
            this.LbOrderQuantity.Text = "";
            this.LbPizzaSize.Text = "";
            this.LbTaxAmount.Text = "";
            this.LbFinalCost.Text = "";
        }


        private void BtDailySpecial_Click(object sender, EventArgs e)
        {
            this.CbSize.SelectedIndex = 2;
            this.LbQuantity.Text = "2";
            this.txtCouponCode.Text = "OFFERSPECIAL";
            this.RbNonVege.Checked = true;
            this.CbHam.Checked = false;
            this.CbBacon.Checked = true;
            this.CbCheese.Checked = true;
            this.CbChicken.Checked = false;
            this.CbOnion.Checked = false;
            this.CbOlive.Checked = true;





        }

        private void BtOrder_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Name cannot be empty");

            }

            if (string.IsNullOrEmpty(this.txtNumber.Text))
            {

                MessageBox.Show("Customer Number cannot be empty");
            }

            else
            {

                try
                {
                    double Digits = Math.Round(Convert.ToDouble(this.txtNumber.Text), 0);
                    //MessageBox.Show($"{this.txtNumber.TextLength}");

                    if (Digits <= 9999999999 && (this.txtName.TextLength) >= 1)
                    {
                        this.LbOrderNum.Text = this.txtNumber.Text;
                        this.LbOrderName.Text = this.txtName.Text;
                        this.LbPizzaSize.Text = this.CbSize.SelectedItem.ToString();

                        Order currentOrder = new Order();
                        currentOrder.Name = this.txtName.Text;
                        currentOrder.Number = double.Parse(this.txtNumber.Text);
                        currentOrder.Coupon = this.txtCouponCode.Text;

                        currentOrder.OrderedSize = this.CbSize.SelectedItem.ToString();
                        currentOrder.OrderedQuantity = Convert.ToInt32(this.LbQuantity.Text);



                        if (this.RbNonVege.Checked)
                        {
                            this.LbVegan.Text = this.RbNonVege.Text;
                            currentOrder.OrderVege = this.RbNonVege.Text;
                        }
                        else if(this.RbVegeterian.Checked)
                        {

                            this.LbVegan.Text = this.RbVegeterian.Text;
                            currentOrder.OrderVege = this.RbVegeterian.Text;
                        }


                        this.LbToppings.Text = "";
                        currentOrder.OrderedToppings = "";

                        if (this.CbBacon.Checked)
                        {
                            this.LbToppings.Text += this.CbBacon.Text + ", ";
                            currentOrder.OrderedToppings += this.CbBacon.Text + ", ";
                        }
                        if (this.CbOnion.Checked)
                        {
                            this.LbToppings.Text += this.CbOnion.Text + ", ";
                            currentOrder.OrderedToppings += this.CbOnion.Text + ", ";
                        }
                        if (this.CbHam.Checked)
                        {
                            this.LbToppings.Text += this.CbHam.Text + ", ";
                            currentOrder.OrderedToppings += this.CbHam.Text + ", ";
                        }
                        if (this.CbCheese.Checked)
                        {
                            this.LbToppings.Text += this.CbCheese.Text + ", ";
                            currentOrder.OrderedToppings += this.CbCheese.Text + ", ";
                        }
                        if (this.CbOlive.Checked)
                        {
                            this.LbToppings.Text += this.CbOlive.Text + ", ";
                            currentOrder.OrderedToppings += this.CbOlive.Text + ", ";
                        }
                        if (this.CbChicken.Checked)
                        {
                            this.LbToppings.Text += this.CbChicken.Text + ", ";
                            currentOrder.OrderedToppings += this.CbChicken.Text + ", ";
                        }
                        currentOrder.OrderedToppings = this.LbToppings.Text;
                        this.OrderList.Add(currentOrder);

                        this.LbOrderQuantity.Text = this.LbQuantity.Text;
                        currentOrder.CalculateCost();
                        double finalCost = currentOrder.FinalCost;
                        double taxAmount = currentOrder.TaxAmount;
                        //double subTotal = currentOrder.TotalCost;

                        this.LbFinalCost.Text = "$" + finalCost.ToString("N2");
                        this.LbTaxAmount.Text = "$" + taxAmount.ToString("N2");

                        

                    }
                    else
                    {
                        MessageBox.Show("Please check the customer information");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Please provide nemeric input only");
                    MessageBox.Show(ex.Message);
                }


            }

        }


        private void AddQuantity_Click(object sender, EventArgs e)
        {

            int Quantity = Convert.ToInt32(this.LbQuantity.Text);
            Quantity += 1;
            if (Quantity >= 1)
            {
                this.LbQuantity.Text = Quantity.ToString();
            }

            if (Quantity == 6)
            {
                MessageBox.Show("Maximum Quantity is 5");
                this.LbQuantity.Text = "5";
            }

        }

        private void SubsQuantity_Click(object sender, EventArgs e)
        {

            int Quantity = Convert.ToInt32(this.LbQuantity.Text);
            Quantity -= 1;

            if (Quantity >= 1)
            {
                this.LbQuantity.Text = Quantity.ToString();
            }
            else
            {
                MessageBox.Show("Minimum Quantity is 1");
            }

        }

        private void BtViewOrder_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(OrderList);
            form2.Show();
        }
    }
}