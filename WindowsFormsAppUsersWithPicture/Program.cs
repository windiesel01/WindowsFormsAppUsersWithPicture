using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppUsersWithPicture
{
    internal static class Program
    {
        public static Form1 mainForm = new Form1();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(mainForm);
        }
    }
}
