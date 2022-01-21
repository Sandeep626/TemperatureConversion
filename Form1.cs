using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_fahrenheit_Click(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }

        private void btn_celsius_Click(object sender, EventArgs e)
        {
            convertFromCelsius();
        }

        private void btn_kevin_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }

        private void convertFromFahrenheit()
        {
            float f = 0;
            try
            {
                //get text from textbox fahrenheit
                f = float.Parse(txt_fahrenheit.Text);
            }
            catch
            {
                MessageBox.Show("Use Numbers Only");
            }

            //convert farenheit to celsius
            float c = (f - 32) * (5f / 9f);

            //convert celsius to kelvin
            float k = c - 273;

            //set celsius textbox value to converted value
            txt_celsius.Text = c.ToString();

            //set kelvin textbox value to converted value
            txt_kelvin.Text = k.ToString();
        }

        private void convertFromCelsius()
        {
            float c = 0;
            try
            {
                //get text from textbox celsius
                c = float.Parse(txt_celsius.Text);
            }
            catch
            {
                MessageBox.Show("Use Numbers Only");
            }

            //convert celsius to fahrenheit
            float f = (c * 9f / 5f) + 32;

            //convert celsius to kelvin
            float k = c - 273;

            //set fahrenheit textbox value to converted value
            txt_fahrenheit.Text = f.ToString();

            //set kelvin textbox value to converted value
            txt_kelvin.Text = k.ToString();
        }

        private void convertFromKelvin()
        {
            //get text from textbox kelvin
            float k = 0;
            try
            {
                //get text from textbox celsius
                k = float.Parse(txt_kelvin.Text);
    }
            catch
            {
                MessageBox.Show("Use Numbers Only");
            }

//convert kelvin to celsius
float c = k + 273;

//convert celsius to fahrenheit
float f = (c * 9f / 5f) + 32;

//set fahrenheit textbox value to converted value
txt_fahrenheit.Text = f.ToString();

//set celsius textbox value to converted value
txt_celsius.Text = c.ToString();
        }
    }
}
