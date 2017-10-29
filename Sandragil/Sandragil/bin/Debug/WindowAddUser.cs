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

namespace Sandragil
{
    public partial class WindowAddUser : Form
    {
        public List<User> Users { get; set; }
        public WindowAddUser(List<User> users)
        {
            InitializeComponent();
            Users = users;
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            var username = UsernameTextbox.Text;
            var password = PasswordTextbox.Text;
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\Users.txt";

            File.AppendAllText(file, username);
            File.AppendAllText(file, password);
        }
    }
}
