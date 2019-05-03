using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebcamSecurity
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            username = textBox1.Text.ToString();
            password = textBox2.Text.ToString();
            if (username == "kiran" && password == "kiran")
            {
                this.Hide();
                MainForm a = new MainForm();
                a.Show();
            }
            else
            {
                label4.Text = "Incorrect username or password";
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!textBox1.AcceptsReturn)
                {
                    button2.PerformClick();
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!textBox2.AcceptsReturn)
                {
                    button2.PerformClick();
                }
            }
        }
    }
}
