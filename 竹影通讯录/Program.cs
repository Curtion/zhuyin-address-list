using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 竹影通讯录
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
        public class InfoClass
        {
            public static string TName { get; set; }
            public static string Phone { get; set; }
            public static string Email { get; set; }
            public static string QQ { get; set; }
            public static string Weixin { get; set; }
            public static string Info { get; set; }
        }
    }
}
