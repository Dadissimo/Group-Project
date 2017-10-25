using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandragil
{
    public partial class LoginWindow : Form
    {
        public List<User> Users;

        public LoginWindow(List<User> users)
        {
            InitializeComponent();
            this.Users = users;
        }

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool sucess = false;
            foreach (var user in Users)
            {
                if ((user.Name == UsernameBox.Text) && (user.Password == PasswordBox.Text))
                {
                    sucess = true;
                    MessageBox.Show("Login complete!");
                    new MainWindow(Users,user).ShowDialog();
                    break;
                }
            }
            if (sucess == false)
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LoginButton_Click(sender,e);
            }
        }
    }
}
