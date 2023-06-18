namespace HTTP_Shell_Backdoor
{
    partial class Form1
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
            this.url_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.key_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.status_text = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmd_textbox = new System.Windows.Forms.TextBox();
            this.execute_button = new System.Windows.Forms.Button();
            this.output_richbox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // url_textbox
            // 
            this.url_textbox.Location = new System.Drawing.Point(90, 19);
            this.url_textbox.Name = "url_textbox";
            this.url_textbox.Size = new System.Drawing.Size(182, 20);
            this.url_textbox.TabIndex = 0;
            this.url_textbox.Text = "http://127.0.0.1/my_backdoor.php";
            this.url_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.key_textbox);
            this.groupBox1.Controls.Add(this.url_textbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shell Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // key_textbox
            // 
            this.key_textbox.Location = new System.Drawing.Point(90, 48);
            this.key_textbox.Name = "key_textbox";
            this.key_textbox.Size = new System.Drawing.Size(67, 20);
            this.key_textbox.TabIndex = 1;
            this.key_textbox.Text = "user123";
            this.key_textbox.UseSystemPasswordChar = true;
            this.key_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backdoor Link";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key Access";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(6, 46);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(136, 23);
            this.connect_button.TabIndex = 2;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.status_text);
            this.groupBox2.Controls.Add(this.connect_button);
            this.groupBox2.Location = new System.Drawing.Point(306, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 79);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status: ";
            // 
            // status_text
            // 
            this.status_text.Location = new System.Drawing.Point(23, 22);
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(119, 13);
            this.status_text.TabIndex = 4;
            this.status_text.Text = "-";
            this.status_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status_text.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.output_richbox);
            this.groupBox3.Location = new System.Drawing.Point(13, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 294);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.execute_button);
            this.groupBox4.Controls.Add(this.cmd_textbox);
            this.groupBox4.Location = new System.Drawing.Point(12, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 41);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shell Command";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // cmd_textbox
            // 
            this.cmd_textbox.Location = new System.Drawing.Point(9, 15);
            this.cmd_textbox.Name = "cmd_textbox";
            this.cmd_textbox.Size = new System.Drawing.Size(387, 20);
            this.cmd_textbox.TabIndex = 0;
            this.cmd_textbox.Text = "whoami";
            // 
            // execute_button
            // 
            this.execute_button.Location = new System.Drawing.Point(400, 15);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(27, 20);
            this.execute_button.TabIndex = 6;
            this.execute_button.Text = ">>";
            this.execute_button.UseVisualStyleBackColor = true;
            this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
            // 
            // output_richbox
            // 
            this.output_richbox.Location = new System.Drawing.Point(8, 20);
            this.output_richbox.Name = "output_richbox";
            this.output_richbox.ReadOnly = true;
            this.output_richbox.Size = new System.Drawing.Size(418, 268);
            this.output_richbox.TabIndex = 0;
            this.output_richbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTTP Shell Backdoor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox url_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox key_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label status_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button execute_button;
        private System.Windows.Forms.TextBox cmd_textbox;
        private System.Windows.Forms.RichTextBox output_richbox;
    }
}

