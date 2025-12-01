using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace OOP_Final_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borrow form3 = new Borrow();
            form3.Show();
            this.Hide();
            form3.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Return form4 = new Return();
            form4.Show();
            this.Hide();
            form4.FormClosed += (s, args) => this.Close();
        }

        private void History_Click(object sender, EventArgs e)
        {
            History form5 = new History();
            form5.Show();
            this.Hide();
            form5.FormClosed += (s, args) => this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
        }
    }
}
