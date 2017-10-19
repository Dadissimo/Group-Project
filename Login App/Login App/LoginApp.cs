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

        private void LoginButton_click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            bool sucess = false;
            foreach (User user in users)
            {
                if((user.name == username) && (user.pw == password))
                {
                    MessageBox.Show("Login sucessfull!");
                    textBox1.Clear();
                    textBox2.Clear();
                    Hide();
                    new UserInterface().ShowDialog();
                    Show();
                    sucess = true;
                    break;
                }
            }
            if (!sucess)
            {
                MessageBox.Show("Login failed! Username or pasword wrong!");
            }
        }

        private void LoginByEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginButton_click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }
    }
}
