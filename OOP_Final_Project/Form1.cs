namespace OOP_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //sdfgh
        private void button1_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;


            string correctUser = "admin";
            string correctPass = "1234";

            if (username == correctUser && password == correctPass)
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
