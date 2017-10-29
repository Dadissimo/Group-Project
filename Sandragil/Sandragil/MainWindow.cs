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
<<<<<<< HEAD
            richTextBox1.AppendText(Active.Name);//hallo test
            var pRun = System.Diagnostics.Process.Start(@"C:\Users\shaas\Documents\GitHub\Group-Project\Sandragil\Sandragil\Herpes.exe");
            pRun.WaitForExit();

=======
            richTextBox1.AppendText(Active.Name);//hallo
>>>>>>> ab15b4f8789522d1c5a905b42eeff54661265145
        }
    }
}
