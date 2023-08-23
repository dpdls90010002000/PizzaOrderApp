using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
//Yein An 301316062
namespace Yein_Pizza2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputPanel = new System.Windows.Forms.Panel();
            this.txtCouponCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.BtOrder = new System.Windows.Forms.Button();
            this.BtDailySpecial = new System.Windows.Forms.Button();
            this.LbQuantity = new System.Windows.Forms.Label();
            this.SubsQuantity = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddQuantity = new System.Windows.Forms.Button();
            this.CbCheese = new System.Windows.Forms.CheckBox();
            this.CbOlive = new System.Windows.Forms.CheckBox();
            this.CbOnion = new System.Windows.Forms.CheckBox();
            this.CbHam = new System.Windows.Forms.CheckBox();
            this.CbChicken = new System.Windows.Forms.CheckBox();
            this.CbBacon = new System.Windows.Forms.CheckBox();
            this.Toppings = new System.Windows.Forms.Label();
            this.CbSize = new System.Windows.Forms.ComboBox();
            this.sizeofpizza = new System.Windows.Forms.Label();
            this.Veges = new System.Windows.Forms.Label();
            this.RbNonVege = new System.Windows.Forms.RadioButton();
            this.RbVegeterian = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LbOrderNum = new System.Windows.Forms.Label();
            this.LbPizzaSize = new System.Windows.Forms.Label();
            this.LbVegan = new System.Windows.Forms.Label();
            this.LbOrderQuantity = new System.Windows.Forms.Label();
            this.LbToppings = new System.Windows.Forms.Label();
            this.LbTaxAmount = new System.Windows.Forms.Label();
            this.LbFinalCost = new System.Windows.Forms.Label();
            this.LbOrderName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shopTitle = new System.Windows.Forms.Label();
            this.BtViewOrder = new System.Windows.Forms.Button();
            this.InputPanel.SuspendLayout();
            this.DisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.SystemColors.Info;
            this.InputPanel.Controls.Add(this.txtCouponCode);
            this.InputPanel.Controls.Add(this.label14);
            this.InputPanel.Controls.Add(this.label7);
            this.InputPanel.Controls.Add(this.btReset);
            this.InputPanel.Controls.Add(this.BtOrder);
            this.InputPanel.Controls.Add(this.BtDailySpecial);
            this.InputPanel.Controls.Add(this.LbQuantity);
            this.InputPanel.Controls.Add(this.SubsQuantity);
            this.InputPanel.Controls.Add(this.label3);
            this.InputPanel.Controls.Add(this.AddQuantity);
            this.InputPanel.Controls.Add(this.CbCheese);
            this.InputPanel.Controls.Add(this.CbOlive);
            this.InputPanel.Controls.Add(this.CbOnion);
            this.InputPanel.Controls.Add(this.CbHam);
            this.InputPanel.Controls.Add(this.CbChicken);
            this.InputPanel.Controls.Add(this.CbBacon);
            this.InputPanel.Controls.Add(this.Toppings);
            this.InputPanel.Controls.Add(this.CbSize);
            this.InputPanel.Controls.Add(this.sizeofpizza);
            this.InputPanel.Controls.Add(this.Veges);
            this.InputPanel.Controls.Add(this.RbNonVege);
            this.InputPanel.Controls.Add(this.RbVegeterian);
            this.InputPanel.Controls.Add(this.txtName);
            this.InputPanel.Controls.Add(this.txtNumber);
            this.InputPanel.Controls.Add(this.label2);
            this.InputPanel.Controls.Add(this.label1);
            this.InputPanel.Location = new System.Drawing.Point(23, 76);
            this.InputPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(457, 493);
            this.InputPanel.TabIndex = 0;
            // 
            // txtCouponCode
            // 
            this.txtCouponCode.Location = new System.Drawing.Point(177, 365);
            this.txtCouponCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCouponCode.Name = "txtCouponCode";
            this.txtCouponCode.Size = new System.Drawing.Size(156, 26);
            this.txtCouponCode.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(22, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 30);
            this.label14.TabIndex = 26;
            this.label14.Text = "Coupon Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(144, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 30);
            this.label7.TabIndex = 25;
            this.label7.Text = "Order Here";
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btReset.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btReset.Location = new System.Drawing.Point(171, 419);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(126, 36);
            this.btReset.TabIndex = 24;
            this.btReset.Text = "Start Over";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // BtOrder
            // 
            this.BtOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtOrder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtOrder.Location = new System.Drawing.Point(305, 419);
            this.BtOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtOrder.Name = "BtOrder";
            this.BtOrder.Size = new System.Drawing.Size(132, 36);
            this.BtOrder.TabIndex = 23;
            this.BtOrder.Text = "Place Order";
            this.BtOrder.UseVisualStyleBackColor = true;
            this.BtOrder.Click += new System.EventHandler(this.BtOrder_Click);
            // 
            // BtDailySpecial
            // 
            this.BtDailySpecial.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtDailySpecial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtDailySpecial.Location = new System.Drawing.Point(16, 419);
            this.BtDailySpecial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtDailySpecial.Name = "BtDailySpecial";
            this.BtDailySpecial.Size = new System.Drawing.Size(142, 36);
            this.BtDailySpecial.TabIndex = 22;
            this.BtDailySpecial.Text = "Daily Special";
            this.BtDailySpecial.UseVisualStyleBackColor = true;
            this.BtDailySpecial.Click += new System.EventHandler(this.BtDailySpecial_Click);
            // 
            // LbQuantity
            // 
            this.LbQuantity.AutoSize = true;
            this.LbQuantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LbQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbQuantity.Location = new System.Drawing.Point(189, 308);
            this.LbQuantity.Name = "LbQuantity";
            this.LbQuantity.Size = new System.Drawing.Size(26, 30);
            this.LbQuantity.TabIndex = 21;
            this.LbQuantity.Text = "1";
            // 
            // SubsQuantity
            // 
            this.SubsQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SubsQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SubsQuantity.Location = new System.Drawing.Point(228, 302);
            this.SubsQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubsQuantity.Name = "SubsQuantity";
            this.SubsQuantity.Size = new System.Drawing.Size(39, 41);
            this.SubsQuantity.TabIndex = 20;
            this.SubsQuantity.Text = "🔽";
            this.SubsQuantity.UseVisualStyleBackColor = true;
            this.SubsQuantity.Click += new System.EventHandler(this.SubsQuantity_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(22, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Quantity";
            // 
            // AddQuantity
            // 
            this.AddQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.AddQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddQuantity.Location = new System.Drawing.Point(137, 302);
            this.AddQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddQuantity.Name = "AddQuantity";
            this.AddQuantity.Size = new System.Drawing.Size(39, 42);
            this.AddQuantity.TabIndex = 18;
            this.AddQuantity.Text = "🔼";
            this.AddQuantity.UseVisualStyleBackColor = true;
            this.AddQuantity.Click += new System.EventHandler(this.AddQuantity_Click);
            // 
            // CbCheese
            // 
            this.CbCheese.AutoSize = true;
            this.CbCheese.Location = new System.Drawing.Point(228, 229);
            this.CbCheese.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbCheese.Name = "CbCheese";
            this.CbCheese.Size = new System.Drawing.Size(90, 24);
            this.CbCheese.TabIndex = 17;
            this.CbCheese.Text = "Cheese";
            this.CbCheese.UseVisualStyleBackColor = true;
            // 
            // CbOlive
            // 
            this.CbOlive.AutoSize = true;
            this.CbOlive.Location = new System.Drawing.Point(339, 229);
            this.CbOlive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbOlive.Name = "CbOlive";
            this.CbOlive.Size = new System.Drawing.Size(69, 24);
            this.CbOlive.TabIndex = 16;
            this.CbOlive.Text = "Olive";
            this.CbOlive.UseVisualStyleBackColor = true;
            // 
            // CbOnion
            // 
            this.CbOnion.AutoSize = true;
            this.CbOnion.Location = new System.Drawing.Point(228, 273);
            this.CbOnion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbOnion.Name = "CbOnion";
            this.CbOnion.Size = new System.Drawing.Size(77, 24);
            this.CbOnion.TabIndex = 15;
            this.CbOnion.Text = "Onion";
            this.CbOnion.UseVisualStyleBackColor = true;
            // 
            // CbHam
            // 
            this.CbHam.AutoSize = true;
            this.CbHam.Location = new System.Drawing.Point(339, 273);
            this.CbHam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbHam.Name = "CbHam";
            this.CbHam.Size = new System.Drawing.Size(69, 24);
            this.CbHam.TabIndex = 14;
            this.CbHam.Text = "Ham";
            this.CbHam.UseVisualStyleBackColor = true;
            // 
            // CbChicken
            // 
            this.CbChicken.AutoSize = true;
            this.CbChicken.Location = new System.Drawing.Point(115, 273);
            this.CbChicken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbChicken.Name = "CbChicken";
            this.CbChicken.Size = new System.Drawing.Size(92, 24);
            this.CbChicken.TabIndex = 12;
            this.CbChicken.Text = "Chicken";
            this.CbChicken.UseVisualStyleBackColor = true;
            // 
            // CbBacon
            // 
            this.CbBacon.AutoSize = true;
            this.CbBacon.Location = new System.Drawing.Point(115, 229);
            this.CbBacon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbBacon.Name = "CbBacon";
            this.CbBacon.Size = new System.Drawing.Size(81, 24);
            this.CbBacon.TabIndex = 11;
            this.CbBacon.Text = "Bacon";
            this.CbBacon.UseVisualStyleBackColor = true;
            // 
            // Toppings
            // 
            this.Toppings.AutoSize = true;
            this.Toppings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Toppings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Toppings.Location = new System.Drawing.Point(22, 239);
            this.Toppings.Name = "Toppings";
            this.Toppings.Size = new System.Drawing.Size(98, 30);
            this.Toppings.TabIndex = 10;
            this.Toppings.Text = "Topping";
            // 
            // CbSize
            // 
            this.CbSize.FormattingEnabled = true;
            this.CbSize.Location = new System.Drawing.Point(169, 191);
            this.CbSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbSize.Name = "CbSize";
            this.CbSize.Size = new System.Drawing.Size(164, 28);
            this.CbSize.TabIndex = 9;
            // 
            // sizeofpizza
            // 
            this.sizeofpizza.AutoSize = true;
            this.sizeofpizza.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.sizeofpizza.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sizeofpizza.Location = new System.Drawing.Point(22, 191);
            this.sizeofpizza.Name = "sizeofpizza";
            this.sizeofpizza.Size = new System.Drawing.Size(54, 30);
            this.sizeofpizza.TabIndex = 8;
            this.sizeofpizza.Text = "Size";
            // 
            // Veges
            // 
            this.Veges.AutoSize = true;
            this.Veges.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Veges.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Veges.Location = new System.Drawing.Point(22, 142);
            this.Veges.Name = "Veges";
            this.Veges.Size = new System.Drawing.Size(126, 30);
            this.Veges.TabIndex = 7;
            this.Veges.Text = "Vegetarian";
            // 
            // RbNonVege
            // 
            this.RbNonVege.AutoSize = true;
            this.RbNonVege.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RbNonVege.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RbNonVege.Location = new System.Drawing.Point(305, 142);
            this.RbNonVege.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbNonVege.Name = "RbNonVege";
            this.RbNonVege.Size = new System.Drawing.Size(122, 29);
            this.RbNonVege.TabIndex = 6;
            this.RbNonVege.TabStop = true;
            this.RbNonVege.Text = "Non-Vege";
            this.RbNonVege.UseVisualStyleBackColor = true;
            // 
            // RbVegeterian
            // 
            this.RbVegeterian.AutoSize = true;
            this.RbVegeterian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RbVegeterian.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RbVegeterian.Location = new System.Drawing.Point(167, 142);
            this.RbVegeterian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbVegeterian.Name = "RbVegeterian";
            this.RbVegeterian.Size = new System.Drawing.Size(129, 29);
            this.RbVegeterian.TabIndex = 5;
            this.RbVegeterian.TabStop = true;
            this.RbVegeterian.Text = "Vegetarian";
            this.RbVegeterian.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(177, 63);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(102, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(177, 97);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(102, 26);
            this.txtNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Num";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Name";
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayPanel.Controls.Add(this.label16);
            this.DisplayPanel.Controls.Add(this.label15);
            this.DisplayPanel.Controls.Add(this.LbOrderNum);
            this.DisplayPanel.Controls.Add(this.LbPizzaSize);
            this.DisplayPanel.Controls.Add(this.LbVegan);
            this.DisplayPanel.Controls.Add(this.LbOrderQuantity);
            this.DisplayPanel.Controls.Add(this.LbToppings);
            this.DisplayPanel.Controls.Add(this.LbTaxAmount);
            this.DisplayPanel.Controls.Add(this.LbFinalCost);
            this.DisplayPanel.Controls.Add(this.LbOrderName);
            this.DisplayPanel.Controls.Add(this.label13);
            this.DisplayPanel.Controls.Add(this.label12);
            this.DisplayPanel.Controls.Add(this.label11);
            this.DisplayPanel.Controls.Add(this.label10);
            this.DisplayPanel.Controls.Add(this.label9);
            this.DisplayPanel.Controls.Add(this.label8);
            this.DisplayPanel.Controls.Add(this.label6);
            this.DisplayPanel.Controls.Add(this.label5);
            this.DisplayPanel.Controls.Add(this.label4);
            this.DisplayPanel.Location = new System.Drawing.Point(506, 76);
            this.DisplayPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(489, 493);
            this.DisplayPanel.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(111, 338);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(329, 20);
            this.label16.TabIndex = 41;
            this.label16.Text = "----------------------------------------------------------------";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(87, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(329, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "----------------------------------------------------------------";
            // 
            // LbOrderNum
            // 
            this.LbOrderNum.AutoSize = true;
            this.LbOrderNum.Location = new System.Drawing.Point(270, 108);
            this.LbOrderNum.Name = "LbOrderNum";
            this.LbOrderNum.Size = new System.Drawing.Size(77, 20);
            this.LbOrderNum.TabIndex = 39;
            this.LbOrderNum.Text = "ordernum";
            // 
            // LbPizzaSize
            // 
            this.LbPizzaSize.AutoSize = true;
            this.LbPizzaSize.Location = new System.Drawing.Point(270, 152);
            this.LbPizzaSize.Name = "LbPizzaSize";
            this.LbPizzaSize.Size = new System.Drawing.Size(92, 20);
            this.LbPizzaSize.TabIndex = 38;
            this.LbPizzaSize.Text = "sizeOfPizza";
            // 
            // LbVegan
            // 
            this.LbVegan.AutoSize = true;
            this.LbVegan.Location = new System.Drawing.Point(270, 201);
            this.LbVegan.Name = "LbVegan";
            this.LbVegan.Size = new System.Drawing.Size(47, 20);
            this.LbVegan.TabIndex = 37;
            this.LbVegan.Text = "Vege";
            // 
            // LbOrderQuantity
            // 
            this.LbOrderQuantity.AutoSize = true;
            this.LbOrderQuantity.Location = new System.Drawing.Point(270, 246);
            this.LbOrderQuantity.Name = "LbOrderQuantity";
            this.LbOrderQuantity.Size = new System.Drawing.Size(65, 20);
            this.LbOrderQuantity.TabIndex = 36;
            this.LbOrderQuantity.Text = "quantity";
            // 
            // LbToppings
            // 
            this.LbToppings.AutoSize = true;
            this.LbToppings.Location = new System.Drawing.Point(270, 293);
            this.LbToppings.Name = "LbToppings";
            this.LbToppings.Size = new System.Drawing.Size(70, 20);
            this.LbToppings.TabIndex = 35;
            this.LbToppings.Text = "toppings";
            // 
            // LbTaxAmount
            // 
            this.LbTaxAmount.AutoSize = true;
            this.LbTaxAmount.Location = new System.Drawing.Point(276, 366);
            this.LbTaxAmount.Name = "LbTaxAmount";
            this.LbTaxAmount.Size = new System.Drawing.Size(86, 20);
            this.LbTaxAmount.TabIndex = 34;
            this.LbTaxAmount.Text = "taxAmount";
            // 
            // LbFinalCost
            // 
            this.LbFinalCost.AutoSize = true;
            this.LbFinalCost.Location = new System.Drawing.Point(276, 399);
            this.LbFinalCost.Name = "LbFinalCost";
            this.LbFinalCost.Size = new System.Drawing.Size(76, 20);
            this.LbFinalCost.TabIndex = 33;
            this.LbFinalCost.Text = "FinalCost";
            // 
            // LbOrderName
            // 
            this.LbOrderName.AutoSize = true;
            this.LbOrderName.Location = new System.Drawing.Point(270, 66);
            this.LbOrderName.Name = "LbOrderName";
            this.LbOrderName.Size = new System.Drawing.Size(86, 20);
            this.LbOrderName.TabIndex = 32;
            this.LbOrderName.Text = "ordername";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(56, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 32);
            this.label13.TabIndex = 31;
            this.label13.Text = "Final Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(56, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 32);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tax amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(49, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 32);
            this.label11.TabIndex = 29;
            this.label11.Text = "Selected Toppings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(49, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 32);
            this.label10.TabIndex = 28;
            this.label10.Text = "Quantity ordered";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(49, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 32);
            this.label9.TabIndex = 27;
            this.label9.Text = "Veg/Non-veg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(130, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 30);
            this.label8.TabIndex = 26;
            this.label8.Text = "Order Confirmation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(49, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "Size of Pizza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(49, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Customer Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(49, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Order Name";
            // 
            // shopTitle
            // 
            this.shopTitle.AutoSize = true;
            this.shopTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.shopTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.shopTitle.Location = new System.Drawing.Point(320, 9);
            this.shopTitle.Name = "shopTitle";
            this.shopTitle.Size = new System.Drawing.Size(332, 45);
            this.shopTitle.TabIndex = 3;
            this.shopTitle.Text = "Yein\'s  Pizza Pizza";
            // 
            // BtViewOrder
            // 
            this.BtViewOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtViewOrder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtViewOrder.Location = new System.Drawing.Point(809, 12);
            this.BtViewOrder.Name = "BtViewOrder";
            this.BtViewOrder.Size = new System.Drawing.Size(186, 59);
            this.BtViewOrder.TabIndex = 28;
            this.BtViewOrder.Text = "View Orders";
            this.BtViewOrder.UseVisualStyleBackColor = true;
            this.BtViewOrder.Click += new System.EventHandler(this.BtViewOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 580);
            this.Controls.Add(this.BtViewOrder);
            this.Controls.Add(this.shopTitle);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.InputPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Yein An";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.DisplayPanel.ResumeLayout(false);
            this.DisplayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel InputPanel;
        private Panel DisplayPanel;
        private Label label1;
        private Label shopTitle;
        private TextBox txtNumber;
        private Label label2;
        private TextBox txtName;
        private Label Veges;
        private RadioButton RbNonVege;
        private RadioButton RbVegeterian;
        private ComboBox CbSize;
        private Label sizeofpizza;
        private CheckBox CbCheese;
        private CheckBox CbOlive;
        private CheckBox CbOnion;
        private CheckBox CbHam;
        private CheckBox CbChicken;
        private CheckBox CbBacon;
        private Label Toppings;
        private Label LbQuantity;
        private Button SubsQuantity;
        private Label label3;
        private Button AddQuantity;
        private Button btReset;
        private Button BtOrder;
        private Button BtDailySpecial;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label LbOrderName;
        private Label LbOrderNum;
        private Label LbPizzaSize;
        private Label LbVegan;
        private Label LbOrderQuantity;
        private Label LbToppings;
        private Label LbTaxAmount;
        private Label LbFinalCost;
        private TextBox txtCouponCode;
        private Label label14;
        private Label label16;
        private Label label15;
        private Button BtViewOrder;
    }
}