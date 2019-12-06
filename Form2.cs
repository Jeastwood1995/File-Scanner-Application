using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Scanner_Application
{
    public partial class external_supplier_form : Form
    {
        public external_supplier_form()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new login_form().Show();
            this.Hide();
        }

        private void external_supplier_submit_Click(object sender, EventArgs e)
        {

        }

        private void external_supplier_form_FormClosing(Object sender, FormClosingEventArgs e)
        {
            new Utils().closeApplication(e);
        }
    }
}
