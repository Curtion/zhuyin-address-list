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
    public partial class Newfenlei : Skin_Metro
    {
        private static SqlHelp sql;
        public Newfenlei()
        {
            InitializeComponent();
        }

        private void NewOK_Click(object sender, EventArgs e)
        {
            if (NewContent.Text != "")
            {
                sql = new SqlHelp("data source=mydb.db");
                sql.CreateTable("fenzu", new string[] { "Name"}, new string[] { "TEXT"});
                sql.InsertValues("fenzu", new string[] { NewContent.Text });
                sql.CloseConnection();
                MessageBox.Show("添加成功！");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("分组名称不能为空！");
            }
        }
    }
}
