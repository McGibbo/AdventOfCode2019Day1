using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode2019Day1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddModuleButton_Click(object sender, EventArgs e)
        {
            if (MassSelector.Value != 0)
            {
                ModulesListBox.Items.Add(MassSelector.Value);
                MassSelector.Value = 0;
            }
        }

        private void CountFuelButton_Click(object sender, EventArgs e)
        {
            double fuel = 0;

            for (int i = 0; i < ModulesListBox.Items.Count; i++)
            {
                double value = float.Parse(ModulesListBox.Items[i].ToString());

                value /= 3;

                value = Math.Floor(value);

                value -= 2;

                fuel += value;
            }

            fuelRequirementLable.Text = "Fuel Requirement: " + fuel;
        }
    }
}
