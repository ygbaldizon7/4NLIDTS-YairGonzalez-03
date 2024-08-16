using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4NLIDTS_YairGonzalez_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnCelsius_Click(object sender, EventArgs e)
        {
            float Celsius = float.Parse(tbCelsius.Text);
            float Farenheit = (Celsius * 9f / 5f) + 32;
            tbFarenheit.Text = Farenheit.ToString();
        }

        private void btnFarenheit_Click(object sender, EventArgs e)
        {
            float Farenheit = float.Parse(tbFarenheit.Text);
            float Celsius = (Farenheit - 32)*5.0f/9.0f;
            tbCelsius.Text = Celsius.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbFarenheit.Text = "0.0";
            tbCelsius.Text = "0.0";
            MessageBox.Show("Se resetearon los valores de los textBox");
        }
    }
}
