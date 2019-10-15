using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        public VehicleUi()
        {
            InitializeComponent();
        }
        Vechicle vechile = new Vechicle();

        private void CreateButton_Click(object sender, EventArgs e)
        {
            vechile.vechileName = vehicleNameTextBox.Text;
            vechile.regNo = regNoTextBox.Text;
            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            maxSpeedTextBox.Text = vechile.GetMax().ToString();
            minSpeedTextBox.Text = vechile.GetMin().ToString();
            averageSpeedTextBox.Text = vechile.GetAvg().ToString();



        }

        private void minSpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            vechile.GetMin();
        }

        private void maxSpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            vechile.GetMax();
        }

        private void averageSpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            vechile.GetAvg();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            vechile.speed.Add(Convert.ToDouble(speedTextBox.Text));
            speedTextBox.Clear();
        }
    }
}
