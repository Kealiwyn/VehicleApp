
namespace VehicleApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.gbForCars = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudPassengers = new System.Windows.Forms.NumericUpDown();
            this.cbFuel = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnCar = new System.Windows.Forms.RadioButton();
            this.rbtnBycicle = new System.Windows.Forms.RadioButton();
            this.gbForBikes = new System.Windows.Forms.GroupBox();
            this.nudTireSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTerrain = new System.Windows.Forms.ComboBox();
            this.btnCreateVehicle = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbForCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassengers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbForBikes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTireSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbForBikes);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.gbForCars);
            this.groupBox1.Controls.Add(this.txtStore);
            this.groupBox1.Controls.Add(this.txtWarranty);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.label1.Size = new System.Drawing.Size(38, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.label2.Size = new System.Drawing.Size(38, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.label3.Size = new System.Drawing.Size(34, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.label4.Size = new System.Drawing.Size(53, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Warranty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.label5.Size = new System.Drawing.Size(35, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "Store:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(92, 82);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(92, 125);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(92, 168);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(100, 20);
            this.txtWarranty.TabIndex = 8;
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(92, 211);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(100, 20);
            this.txtStore.TabIndex = 9;
            // 
            // gbForCars
            // 
            this.gbForCars.Controls.Add(this.cbFuel);
            this.gbForCars.Controls.Add(this.nudPassengers);
            this.gbForCars.Controls.Add(this.label7);
            this.gbForCars.Controls.Add(this.label6);
            this.gbForCars.Location = new System.Drawing.Point(286, 42);
            this.gbForCars.Name = "gbForCars";
            this.gbForCars.Size = new System.Drawing.Size(200, 100);
            this.gbForCars.TabIndex = 10;
            this.gbForCars.TabStop = false;
            this.gbForCars.Text = "For Cars";
            this.gbForCars.Enter += new System.EventHandler(this.gbForCars_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Passengers:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fuel:";
            // 
            // nudPassengers
            // 
            this.nudPassengers.Location = new System.Drawing.Point(79, 29);
            this.nudPassengers.Name = "nudPassengers";
            this.nudPassengers.Size = new System.Drawing.Size(85, 20);
            this.nudPassengers.TabIndex = 2;
            // 
            // cbFuel
            // 
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Location = new System.Drawing.Point(43, 60);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(121, 21);
            this.cbFuel.TabIndex = 3;
            this.cbFuel.Text = "None";
            this.cbFuel.SelectedIndexChanged += new System.EventHandler(this.cbFuel_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnBycicle);
            this.groupBox3.Controls.Add(this.rbtnCar);
            this.groupBox3.Location = new System.Drawing.Point(504, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type of Vehicle";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbtnCar
            // 
            this.rbtnCar.AutoSize = true;
            this.rbtnCar.Checked = true;
            this.rbtnCar.Location = new System.Drawing.Point(23, 32);
            this.rbtnCar.Name = "rbtnCar";
            this.rbtnCar.Size = new System.Drawing.Size(41, 17);
            this.rbtnCar.TabIndex = 0;
            this.rbtnCar.TabStop = true;
            this.rbtnCar.Text = "Car";
            this.rbtnCar.UseVisualStyleBackColor = true;
            this.rbtnCar.CheckedChanged += new System.EventHandler(this.rbtnCar_CheckedChanged);
            // 
            // rbtnBycicle
            // 
            this.rbtnBycicle.AutoSize = true;
            this.rbtnBycicle.Location = new System.Drawing.Point(23, 63);
            this.rbtnBycicle.Name = "rbtnBycicle";
            this.rbtnBycicle.Size = new System.Drawing.Size(59, 17);
            this.rbtnBycicle.TabIndex = 1;
            this.rbtnBycicle.Text = "Bycicle";
            this.rbtnBycicle.UseVisualStyleBackColor = true;
            this.rbtnBycicle.CheckedChanged += new System.EventHandler(this.rbtnBycicle_CheckedChanged);
            // 
            // gbForBikes
            // 
            this.gbForBikes.Controls.Add(this.cbTerrain);
            this.gbForBikes.Controls.Add(this.label9);
            this.gbForBikes.Controls.Add(this.label8);
            this.gbForBikes.Controls.Add(this.nudTireSize);
            this.gbForBikes.Enabled = false;
            this.gbForBikes.Location = new System.Drawing.Point(286, 154);
            this.gbForBikes.Name = "gbForBikes";
            this.gbForBikes.Size = new System.Drawing.Size(185, 103);
            this.gbForBikes.TabIndex = 12;
            this.gbForBikes.TabStop = false;
            this.gbForBikes.Text = "For Bikes";
            // 
            // nudTireSize
            // 
            this.nudTireSize.Location = new System.Drawing.Point(64, 24);
            this.nudTireSize.Name = "nudTireSize";
            this.nudTireSize.Size = new System.Drawing.Size(74, 20);
            this.nudTireSize.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tire Size:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Terrain:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cbTerrain
            // 
            this.cbTerrain.FormattingEnabled = true;
            this.cbTerrain.Location = new System.Drawing.Point(64, 54);
            this.cbTerrain.Name = "cbTerrain";
            this.cbTerrain.Size = new System.Drawing.Size(100, 21);
            this.cbTerrain.TabIndex = 3;
            this.cbTerrain.Text = "None";
            this.cbTerrain.SelectedIndexChanged += new System.EventHandler(this.cbTerrain_SelectedIndexChanged);
            // 
            // btnCreateVehicle
            // 
            this.btnCreateVehicle.Location = new System.Drawing.Point(12, 293);
            this.btnCreateVehicle.Name = "btnCreateVehicle";
            this.btnCreateVehicle.Size = new System.Drawing.Size(209, 38);
            this.btnCreateVehicle.TabIndex = 1;
            this.btnCreateVehicle.Text = "Create Vehicle";
            this.btnCreateVehicle.UseVisualStyleBackColor = true;
            this.btnCreateVehicle.Click += new System.EventHandler(this.btnCreateVehicle_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(227, 294);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(133, 37);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display Vehicles";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(648, 54);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDisplay.Size = new System.Drawing.Size(415, 233);
            this.txtDisplay.TabIndex = 3;
            this.txtDisplay.Text = "------------- ALL VEHICLES -------------";
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(648, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Search By Vehicle Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(872, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(782, 21);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(70, 20);
            this.txtNameSearch.TabIndex = 7;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 353);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnCreateVehicle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbForCars.ResumeLayout(false);
            this.gbForCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassengers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbForBikes.ResumeLayout(false);
            this.gbForBikes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTireSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbForBikes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudTireSize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnBycicle;
        private System.Windows.Forms.RadioButton rbtnCar;
        private System.Windows.Forms.GroupBox gbForCars;
        private System.Windows.Forms.ComboBox cbFuel;
        private System.Windows.Forms.NumericUpDown nudPassengers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTerrain;
        private System.Windows.Forms.Button btnCreateVehicle;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNameSearch;
    }
}

