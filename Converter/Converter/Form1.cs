using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(this.textBox1.Text);

            if ((string)comboBox1.SelectedItem == "Indonesia(IDR)" && (string)comboBox2.SelectedItem == "Amerika(USD)")
            {
                double hasil;
                hasil = i*0.00001;
                lblResult.Text = hasil.ToString("0.00");
            }
            else if ((string)comboBox1.SelectedItem == "Indonesia(IDR)" && (string)comboBox2.SelectedItem == "Korea(KRW)")
            {
                double hasil;
                hasil = i * 0.07694;
                lblResult.Text = hasil.ToString("0.00");
            }
            else if ((string)comboBox1.SelectedItem == "Indonesia(IDR)" && (string)comboBox2.SelectedItem == "Jepang(JPY)")
            {
                double hasil;
                hasil = i * 0.00766;
                lblResult.Text = hasil.ToString("0.00");
            }

            else if ((string)comboBox1.SelectedItem == "Amerika(USD)" && (string)comboBox2.SelectedItem == "Indonesia(IDR)")
            {
                double hasil;
                hasil = i * 14560;
                lblResult.Text = hasil.ToString("0.00");
            }
            else if ((string)comboBox1.SelectedItem == "Amerika(USD)" && (string)comboBox2.SelectedItem == "Korea(KRW)")
            {
                double hasil;
                hasil = i * 1130.200;
                lblResult.Text = hasil.ToString("0.00");
            }
            else if ((string)comboBox1.SelectedItem == "Amerika(USD)" && (string)comboBox2.SelectedItem == "Jepang(JPY)")
            {
                double hasil;
                hasil = i * 110.950;
                lblResult.Text = hasil.ToString("0.00");
            }

            else if ((string)comboBox1.SelectedItem == "Korea(KRW)" && (string)comboBox2.SelectedItem == "Indonesia(IDR)")
            {
                double hasil;
                hasil = i * 12.888;
                lblResult.Text = hasil.ToString("0.00");
            }
            else if ((string)comboBox1.SelectedItem == "Korea(KRW)" && (string)comboBox2.SelectedItem == "Amerika(USD)")
            {
                double hasil;
                hasil = i * 0.00088;
                lblResult.Text = hasil.ToString("0.00");
            }
            else if ((string)comboBox1.SelectedItem == "Korea(KRW)" && (string)comboBox2.SelectedItem == "Jepang(JPY)")
            {
                double hasil;
                hasil = i * 0.09793;
                lblResult.Text = hasil.ToString("0.00");
            }

            else if ((string)comboBox1.SelectedItem == "Jepang(JPY)" && (string)comboBox2.SelectedItem == "Indonesia(IDR)")
            {
                double hasil;
                hasil = i * 131.230;
                lblResult.Text = hasil.ToString("0.00");
            }
            else if ((string)comboBox1.SelectedItem == "Jepang(JPY)" && (string)comboBox2.SelectedItem == "Amerika(USD)")
            {
                double hasil;
                hasil = i * 0.009;
                lblResult.Text = hasil.ToString("0.00");
            }
            else if ((string)comboBox1.SelectedItem == "Jepang(JPY)" && (string)comboBox2.SelectedItem == "Korea(KRW)")
            {
                double hasil;
                hasil = i * 10.186;
                lblResult.Text = hasil.ToString("0.00");
            }

            else if (comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                double hasil;
                hasil = i;
                lblResult.Text = hasil.ToString("0.00");
            }
        }
    }
}
