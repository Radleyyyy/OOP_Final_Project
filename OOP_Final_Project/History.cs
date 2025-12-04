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
        UserRepository repository = new UserRepository();
        public History()
        {
            InitializeComponent();

            LoadUzerToDataGridView();
        }

        private void LoadUzerToDataGridView()
        {
            List<User> users = repository.GetAll();
            dataGridView1.DataSource = users;
        }

        private void ListUsersForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to user manager",
                "Greetings",

               MessageBoxButtons.OK,
               MessageBoxIcon.Information);




        }
     

        private void Ok_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            
        }
    }
}
