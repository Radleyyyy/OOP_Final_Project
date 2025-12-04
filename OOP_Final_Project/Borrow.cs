using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;

namespace OOP_Final_Project
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string borroweditems = comboBox1.Text;
            string borrowdate = dateTimePicker1.Text;
            string borrowQuantity= txtBoxQuantity.Text;
            if (string.IsNullOrWhiteSpace(username)||
                string.IsNullOrWhiteSpace(borroweditems)||
                string.IsNullOrWhiteSpace(borrowdate)||
                string.IsNullOrWhiteSpace(borrowQuantity))
            {
                MessageBox.Show("Please enter your Name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                User userToSave = new User();
                userToSave.Username = username;
                userToSave.BorrowedItems = borroweditems;
                userToSave.BorrowDate = borrowdate;
                userToSave.BorrowNumber = int.Parse(borrowQuantity);

                UserRepository repository = new UserRepository();
                bool isSaved = repository.Add(userToSave);

                if (isSaved)
                {
                    MessageBox.Show("Boy na-saved!", "Successful",


                   MessageBoxButtons.OK, MessageBoxIcon.Information);



                    textBoxUsername.Clear();
                   


                }
            }
                Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            
            
        }
    }
}
