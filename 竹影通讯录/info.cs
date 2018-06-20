using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 竹影通讯录
{
    public partial class info : Skin_Metro
    {
        public info()
        {
            InitializeComponent();
            Guanyu.Text = "西华大学";
            Guanyu2.Text = "博客：https://blog.3gxk.net";
            Guanyu3.Text = "项目地址请查看博客文章";
        }
    }
}
