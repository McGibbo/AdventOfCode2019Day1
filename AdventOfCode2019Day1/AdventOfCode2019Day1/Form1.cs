using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode2019Day1
{
    public partial class Form1 : Form
    {
        double countedFuel;

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

        private void CountFuelTextBoxButton_Click(object sender, EventArgs e)
        {
            double fuel = 0;

            string input = inputModuleTextBox.Text;

            string[] inputRows = input.Split('\n');

            double[] inputNumbers = new double[inputRows.Length];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                double value = double.Parse(inputRows[i]);

                double totalValue = 0;

                while (value > 0)
                {
                    value /= 3;

                    value = Math.Floor(value);

                    value -= 2;

                    if (value > 0)
                        totalValue += value;
                }

                fuel += totalValue;
            }

            
            fuelRequirementLable.Text = "Fuel Requirement: " + fuel;
        }
    }
}
