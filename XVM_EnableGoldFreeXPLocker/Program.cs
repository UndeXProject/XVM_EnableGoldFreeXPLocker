using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XVM_EnableGoldFreeXPLocker
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new main();
            form.Text = "XMV Gold and Free XP locker (" + Application.ProductVersion + ")";

            string[] paths = { @"C:\Games\World_of_Tanks_RU", @"D:\Games\World_of_Tanks_RU" };
            foreach (string path in paths)
            {
                if (Directory.Exists(path)) form.path = path;
            }
            var copy = (AssemblyCopyrightAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false)[0];
            form.copy.Text = copy.Copyright;
            Application.Run(form);
        }
    }
}
