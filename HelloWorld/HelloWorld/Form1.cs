using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setLabel2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void setLabel2()
        {
            label2.Text = "Devi Indah Sari";
            label2.Font = new Font("Comic Sans MS", 12, FontStyle.Underline);
        }
    }
}