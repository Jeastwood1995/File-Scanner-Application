using System;
using System.Windows.Forms;


namespace File_Scanner_Application
{
    public partial class login_form : Form
    {
        private string username, password;

        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = this.username_field.Text;
            password = this.password_field.Text;
        }

        private void forgottenPassword_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void username_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new external_supplier_form().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void login_form_FormClosing(Object sender, FormClosingEventArgs e)
        {
            new Utils().closeApplication(e);
        }
    }
}
