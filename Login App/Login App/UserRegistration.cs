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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void HidePasswordCheck(object sender, EventArgs e)
        {
            if(HidePassword.Checked)
            {
                NewPassword.UseSystemPasswordChar = true;
                RepeatPassword.UseSystemPasswordChar = true;
            }
            else
            {
                NewPassword.UseSystemPasswordChar = false;
                RepeatPassword.UseSystemPasswordChar = false;
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (NewPassword.Text == RepeatPassword.Text)
            {
                StreamWriter stream = new StreamWriter("C:\\Users\\Dragan\\source\\repos\\Login App\\Users.txt",true);
                stream.WriteLine(NewUsername.Text);
                stream.WriteLine(NewPassword.Text);
                MessageBox.Show($"User {NewUsername.Text} has been added!");
                stream.Close();
                Close();
            }
            else
            {
                MessageBox.Show("The passwords you have entered do not match!");
            }

        }

        private void LoginByEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmButton_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }
    }
}
