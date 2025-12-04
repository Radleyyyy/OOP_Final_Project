using SQLite;
namespace OOP_Final_Project
{
    public partial class Form1 : Form
    {
        private string Username;
        private string Password;

       
        public Form1()
        {
            InitializeComponent();
        }
        //sdfgh
        private void button1_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;


            this.Username = "admin";
            this.Password = "1234";

            if (this.Username == username && this.Password == password)
            {
                MessageBox.Show("Login Successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
