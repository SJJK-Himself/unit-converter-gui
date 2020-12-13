using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverterGUI
{
    public partial class UnitConverterGUI : Form
    {
        Decimal result;


        public UnitConverterGUI()
        {
            InitializeComponent();
        }


        private void unitBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            measurement1_label.Text = comboBox1.SelectedItem.ToString();

            if (comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                textBoxResult.Text = "same amount of";
            }
        }


        private void unitBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            measurement2_label.Text = comboBox2.SelectedItem.ToString();
            toLabel.Text = "to";

            if (comboBox2.SelectedItem == comboBox1.SelectedItem)
            {
                textBoxResult.Text = "same amount of";
            }
        }


        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null | comboBox2.SelectedItem == null)
            {
                comboBox1.SelectedItem = "Kilometers";
                comboBox2.SelectedItem = "Miles";
                MessageBox.Show("You didn't choose the units." + "\nSetting units to Kilometers and Miles");
            }

            if (comboBox1.SelectedItem.ToString() == "Kilometers")
            {
                if (comboBox2.SelectedItem.ToString() == "Miles")
                {
                    result = numericUpDown1.Value * 0.621371192m;
                    textBoxResult.Text = result.ToString();
                }

                if (comboBox2.SelectedItem.ToString() == "Meters")
                {
                    result = numericUpDown1.Value * 1000;
                    textBoxResult.Text = result.ToString();
                }

                if (comboBox2.SelectedItem.ToString() == "Feet")
                {
                    result = numericUpDown1.Value * 3280.8399m;
                    textBoxResult.Text = result.ToString();
                }
            }

            if (comboBox1.SelectedItem.ToString() == "Miles")
            {
                if (comboBox2.SelectedItem.ToString() == "Kilometers")
                {
                    result = numericUpDown1.Value * 1.609344m;
                    textBoxResult.Text = result.ToString();
                }

                if (comboBox2.SelectedItem.ToString() == "Meters")
                {
                    result = numericUpDown1.Value * 1609.344m;
                    textBoxResult.Text = result.ToString();
                }

                if (comboBox2.SelectedItem.ToString() == "Feet")
                {
                    result = numericUpDown1.Value * 5280;
                    textBoxResult.Text = result.ToString();
                }
            }

            if (comboBox1.SelectedItem.ToString() == "Meters")
            {
                if (comboBox2.SelectedItem.ToString() == "Kilometers")
                {
                    result = numericUpDown1.Value * 0.001m;
                    textBoxResult.Text = result.ToString();
                }

                if (comboBox2.SelectedItem.ToString() == "Miles")
                {
                    result = numericUpDown1.Value * 0.000621371192m;
                    textBoxResult.Text = result.ToString();
                }

                if (comboBox2.SelectedItem.ToString() == "Feet")
                {
                    result = numericUpDown1.Value * 3.2808399m;
                    textBoxResult.Text = result.ToString();
                }
            }

            if (comboBox1.SelectedItem.ToString() == "Feet")
            {
                if (comboBox2.SelectedItem.ToString() == "Kilometers")
                {
                    result = numericUpDown1.Value * 0.0003048m;
                    textBoxResult.Text = result.ToString();
                }

                if (comboBox2.SelectedItem.ToString() == "Miles")
                {
                    result = numericUpDown1.Value * 0.000189393939m;
                    textBoxResult.Text = result.ToString();
                }

                if (comboBox2.SelectedItem.ToString() == "Meters")
                {
                    result = numericUpDown1.Value * 0.3048m;
                    textBoxResult.Text = result.ToString();
                }
            }
        }


        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            convertLabel.Text = "converts to";
        }


        private void measurement1_label_Click(object sender, EventArgs e)
        {

        }


        private void static1_label_Click(object sender, EventArgs e)
        {

        }


        private void measurement2_label_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UnitConverterGUI_Load(object sender, EventArgs e)
        {

        }
    }
}