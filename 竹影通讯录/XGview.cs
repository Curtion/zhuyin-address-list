using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static 竹影通讯录.Program;

namespace 竹影通讯录
{
    public partial class XGview : Skin_Metro
    {
        public string TName;
        public string Phone;
        public string Email;
        public string QQ;
        public string Weixin;
        public string Info;
        private static SqlHelp sql;
        public string name;
        public string phone;
        public string email;
        public string qq;
        public string weixin;
        public string beizhu;
        public string fenlei;
        public XGview()
        {
            InitializeComponent();
            tname.Text = InfoClass.TName;
            tphone.Text = InfoClass.Phone;
            temail.Text = InfoClass.Email;
            tqq.Text = InfoClass.QQ;
            tweixin.Text = InfoClass.Weixin;
            tbeizhu.Text = InfoClass.Info;
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

        private void XGview_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (tfenlei.Text.Trim().Length == 0)
            {
                MessageBox.Show("请务必选择分组");
            }
            else
            {
                name = tname.Text;
                if (tphone.Text.Trim() != "")
                {
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
                sql.UpdateValues("tongxunlu", new string[] { "Name","Phone","Groups","Email","QQ","Weixin","Info" }, new string[] { name, phone, fenlei, email, qq,weixin, beizhu }, "Name", InfoClass.TName);
                sql.CloseConnection();
                this.Close();
            }
        }
    }
}
