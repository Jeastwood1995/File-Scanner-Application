namespace File_Scanner_Application
{
    partial class external_supplier_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Service = new System.Windows.Forms.Label();
            this.service_box = new System.Windows.Forms.TextBox();
            this.url_box = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.Label();
            this.key_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.external_supplier_submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fill out this form to check if we can link your external supplier details\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Service
            // 
            this.Service.AutoSize = true;
            this.Service.Location = new System.Drawing.Point(104, 84);
            this.Service.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(43, 13);
            this.Service.TabIndex = 1;
            this.Service.Text = "Service";
            this.Service.Click += new System.EventHandler(this.label2_Click);
            // 
            // service_box
            // 
            this.service_box.Location = new System.Drawing.Point(170, 80);
            this.service_box.Margin = new System.Windows.Forms.Padding(2);
            this.service_box.Name = "service_box";
            this.service_box.Size = new System.Drawing.Size(332, 20);
            this.service_box.TabIndex = 2;
            this.service_box.TextChanged += new System.EventHandler(this.service_box_TextChanged);
            // 
            // url_box
            // 
            this.url_box.Location = new System.Drawing.Point(170, 119);
            this.url_box.Margin = new System.Windows.Forms.Padding(2);
            this.url_box.Name = "url_box";
            this.url_box.Size = new System.Drawing.Size(332, 20);
            this.url_box.TabIndex = 3;
            this.url_box.TextChanged += new System.EventHandler(this.url_box_TextChanged);
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(106, 123);
            this.URL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(29, 13);
            this.URL.TabIndex = 4;
            this.URL.Text = "URL";
            // 
            // key_box
            // 
            this.key_box.Location = new System.Drawing.Point(170, 161);
            this.key_box.Margin = new System.Windows.Forms.Padding(2);
            this.key_box.Name = "key_box";
            this.key_box.Size = new System.Drawing.Size(332, 20);
            this.key_box.TabIndex = 5;
            this.key_box.TextChanged += new System.EventHandler(this.key_box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key";
            // 
            // external_supplier_submit
            // 
            this.external_supplier_submit.Location = new System.Drawing.Point(260, 226);
            this.external_supplier_submit.Margin = new System.Windows.Forms.Padding(2);
            this.external_supplier_submit.Name = "external_supplier_submit";
            this.external_supplier_submit.Size = new System.Drawing.Size(56, 32);
            this.external_supplier_submit.TabIndex = 7;
            this.external_supplier_submit.Text = "Submit\r\n";
            this.external_supplier_submit.UseVisualStyleBackColor = true;
            this.external_supplier_submit.Click += new System.EventHandler(this.external_supplier_submit_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(344, 226);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // external_supplier_form
            // 
            this.AcceptButton = this.external_supplier_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.external_supplier_submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.key_box);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.url_box);
            this.Controls.Add(this.service_box);
            this.Controls.Add(this.Service);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "external_supplier_form";
            this.Text = "API Link";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Service;
        private System.Windows.Forms.TextBox service_box;
        private System.Windows.Forms.TextBox url_box;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.TextBox key_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button external_supplier_submit;
        private System.Windows.Forms.Button button1;
    }
}