using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Selection form2 = new Selection();
            form2.Show();
            this.Hide();
            form2.FormClosed += (s, args) => this.Close();
        }
    }
}
