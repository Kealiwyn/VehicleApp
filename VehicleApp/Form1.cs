using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class Form1 : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFuel.Items.Add("Gas");
            cbFuel.Items.Add("Diesel");
            cbFuel.Items.Add("Electric");
            cbFuel.Items.Add("Hybrid");

            cbTerrain.Items.Add("Paved");
            cbTerrain.Items.Add("Unpaved");


        }

        private void cbFuel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTerrain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void gbForCars_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCar.Checked)
                gbForCars.Enabled = true;
            gbForBikes.Enabled = false;
        }

        private void rbtnBycicle_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtnBycicle.Checked)
                gbForCars.Enabled = false;
            gbForBikes.Enabled = true;
        }

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            if (rbtnBycicle.Checked == true)
            {
                try
                {
                    Bicycle bicycle = new Bicycle(txtName.Text, txtBrand.Text, int.Parse(txtPrice.Text), int.Parse(txtWarranty.Text), txtStore.Text, int.Parse(nudTireSize.Text), cbTerrain.Text);
                    vehicles.Add(bicycle);
                    MessageBox.Show($"Vehicle #{vehicles.Count} was added to the list.");
                }
                catch (FormatException)
                {
                    MessageBox.Show($"Error: FORMAT EXCEPTION");
                }
            }
            else if (rbtnBycicle.Checked == false)
            {
                try
                {
                    Car car = new Car(txtName.Text, txtBrand.Text, int.Parse(txtPrice.Text), int.Parse(txtWarranty.Text), txtStore.Text, int.Parse(nudPassengers.Text), cbFuel.Text);
                    vehicles.Add(car);
                    MessageBox.Show($"Vehicle #{vehicles.Count} was added to the list.");
                }
                catch (FormatException)
                {
                    MessageBox.Show($"Error: FORMAT EXCEPTION");
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                txtDisplay.Text += vehicle.ToString();
            }
            MessageBox.Show($"You have {vehicles.Count} Vehicles");
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtBrand.Text = "";
            txtPrice.Text = "";
            txtWarranty.Text = "";
            txtStore.Text = "";
            
            nudPassengers.Text = "0";
            cbFuel.Text = "None";

            nudTireSize.Text = "0";
            cbTerrain.Text = "None";

            rbtnCar.Checked = true;
            rbtnBycicle.Checked = false;

            txtDisplay.Text = "------------- ALL VEHICLES -------------";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = 0;
            txtDisplay.Text += $"\r\n\r\n===========VEHICLES FOUND===========";
            foreach (Vehicle vehicle in vehicles)
            {
                if(txtNameSearch.Text == vehicle.Name)
                {
                    index++;
                    txtDisplay.Text += vehicle.ToString();
                }
                if(vehicles.Count == index)
                {
                    index = 0;
                    MessageBox.Show($"{vehicle.MakeSale()} \nYou have made: {vehicle.CalculateInterest():C} profit");
                }
            }
        }
    }
}

