using sanciyuandehundan_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using musical;

namespace musical
{
    internal static class Program
    {
        public static Form1 form;
        public static Form2 form2;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            form.base_controls = form.Controls.Count-1;
            Application.Run(form);
        }
    }
}
