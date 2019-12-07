using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace File_Scanner_Application
{
    public partial class external_supplier_form : Form
    {

        private string service, url, key;

        private List<String> formData = new List<String>();

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

        private void service_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new login_form().Show();
            this.Hide();
        }

        private void url_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void key_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void external_supplier_submit_Click(object sender, EventArgs e)
        {
            formData.Add(service_box.Text);
            formData.Add(url_box.Text);
            formData.Add(key_box.Text);

            if (service == "" || url == "" || key == "")
            {
                new Utils().showAlertBox("Please enter a value for all of the fields");
            } else
            {
                Object jsonData = new Utils().Send(formData);
            }
        }

        private void external_supplier_form_FormClosing(Object sender, FormClosingEventArgs e)
        {
            new Utils().closeApplication(e);
        }
    }
}
