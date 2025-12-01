namespace OOP_Final_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

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

                Selection form2 = new Selection();
                form2.Show();
                this.Hide();
                form2.FormClosed += (s, args) => this.Close();
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
