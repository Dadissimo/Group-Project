using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Login_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginApp(LoadDatabase()));
        }

        static List<User> LoadDatabase()
        {
            /// <summary>
            /// Reading username and passwords from a .txt file
            /// </summary>
            StreamReader stream = new StreamReader("C:\\Users\\Dragan\\source\\repos\\Login App\\Users.txt");
            List<User> users = new List<User>();
            string username;
            while ((username = stream.ReadLine()) != null)
            {
                var password = stream.ReadLine();
                users.Add(new User(username, password));
            }
            stream.Close();
            return users;
        }
    }
}
