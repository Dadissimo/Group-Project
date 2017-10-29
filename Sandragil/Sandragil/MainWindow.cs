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

        private void Start_Herpes(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\Herpes.exe";
            var pRun = System.Diagnostics.Process.Start(file);
            pRun.WaitForExit();
        }

        private void Start_Wizzard(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\Wizzard.exe";
            var pRun = System.Diagnostics.Process.Start(file);
            pRun.WaitForExit();
        }
    }
}
