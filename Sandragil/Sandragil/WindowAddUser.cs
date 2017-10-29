using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandragil
{
    public partial class WindowAddUser : Form
    {
        public List<User> Users { get; set; }

        public WindowAddUser()
        {
            InitializeComponent();
        }
        public WindowAddUser(List<User> users)
        {
            InitializeComponent();
            Users = users;
        }

   

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var username = UsernameTextbox.Text;
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\Users.txt";

            File.AppendAllText(file, username);

            var password = PasswordTextBox.Text;


            File.AppendAllText(file, password);
        }
    }
}
