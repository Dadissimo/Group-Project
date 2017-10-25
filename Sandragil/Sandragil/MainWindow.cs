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
    public partial class MainWindow : Form
    {
        public List<User> Users;
        public User Active;

        public MainWindow(List<User> users, User active_user)
        {
            InitializeComponent();
            Users = users;
            Active = active_user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Active.Name);
        }
    }
}
