using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login_App
{
    public partial class LoginApp : Form
    {
        private List<User> users;

        public LoginApp(List<User> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void Button1_click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            foreach (User user in users)
            {
                if((user.name == username) && (user.pw == password))
                {
                    richTextBox1.Text = "Login sucessfull!";
                    break;
                }
                else
                {
                    richTextBox1.Text = "Login failed! Username or pasword wrong!";
                }
            }
        }
    }
}
