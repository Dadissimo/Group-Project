using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sandragil
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\Users.txt";

            StreamReader stream = new StreamReader(file);
            List<User> users = new List<User>();
            string username;
            string password;
            int id = 1;

            while((username = stream.ReadLine()) != null)
            {
                password = stream.ReadLine();                
                users.Add(new User(id, username, password));
                id++;
            }
            stream.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginWindow(users));
        }
    }
}
