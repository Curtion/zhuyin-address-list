using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 竹影通讯录
{
    public partial class Add : Skin_Metro
    {
        private static SqlHelp sql;
        public string name;
        public string phone;
        public string email;
        public string qq;
        public string weixin;
        public string beizhu;
        public string fenlei;
        public Add()
        {
            InitializeComponent();
            sql = new SqlHelp("data source=mydb.db");
            SQLiteDataReader reader = sql.ReadFullTable("fenzu");
            while (reader.Read())
            {
                int i = 0;  
                tfenlei.Items.Insert(i, reader.GetString(reader.GetOrdinal("Name")));
                i++;
            }
            sql.CloseConnection();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (tname.Text.Trim() == "") {
                MessageBox.Show("姓名不能为空！");
            }
            else if (tfenlei.Text.Trim().Length == 0)
            {
                MessageBox.Show("请务必选择分组");
            }
            else
            {
                name = tname.Text;
                if (tphone.Text.Trim() != "") {
                    phone = tphone.Text;
                }
                if (temail.Text.Trim() != "")
                {
                    email = temail.Text;
                }
                if (tqq.Text.Trim() != "")
                {
                    qq = tqq.Text;
                }
                if (tweixin.Text.Trim() != "")
                {
                    weixin = tweixin.Text;
                }
                if (tbeizhu.Text.Trim() != "")
                {
                    beizhu = tbeizhu.Text;
                }
                fenlei = tfenlei.SelectedItem.ToString();
                sql = new SqlHelp("data source=mydb.db");
                sql.InsertValues("tongxunlu", new string[] { name, phone, fenlei,email, qq,weixin,beizhu });
                MessageBox.Show("添加成功");
                sql.CloseConnection();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            //MessageBox.Show(name);
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
