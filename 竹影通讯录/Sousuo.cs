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

namespace 竹影通讯录
{
    public partial class Sousuo : Skin_Metro
    {
        private static SqlHelp sql;
        public Sousuo()
        {
            InitializeComponent();
            SouContent.Items.Insert(0,"姓名");
            SouContent.Items.Insert(1,"手机号");
            SouContent.Items.Insert(2,"邮箱");
            SouContent.Items.Insert(3,"QQ");
            SouContent.Items.Insert(4,"微信");
        }

        private void SouOK_Click(object sender, EventArgs e)
        {
            if (SouContent.Text.Trim().Length == 0)
            {
                MessageBox.Show("请务必选择分组");
            }
            else
            {
                string SouFenzu = SouContent.SelectedItem.ToString();
                if(SouFenzu == "姓名")
                {
                    SouFenzu = "Name";
                }
                if (SouFenzu == "手机号")
                {
                    SouFenzu = "Phone";
                }
                if (SouFenzu == "邮箱")
                {
                    SouFenzu = "Email";
                }
                if (SouFenzu == "QQ")
                {
                    SouFenzu = "QQ";
                }
                if (SouFenzu == "微信")
                {
                    SouFenzu = "Weixin";
                }
                sql = new SqlHelp("data source=mydb.db");
                //string strsql = "SELECT  FROM tongxunlu WHERE " + SouFenzu + "=" + "'" + SuoContent.Text + "'";
                //不会写，最后干脆线搜索全表，显示需要的信息，反正数据不多！
                SQLiteDataReader reader = sql.ReadFullTable("tongxunlu");
                bool tf = false;
                while (reader.Read())
                {
                    if (reader.GetString(reader.GetOrdinal(SouFenzu)) == SuoContent.Text)
                    {
                        MessageBox.Show("（姓名：" + reader.GetString(reader.GetOrdinal("Name")) + "）" + "（手机号：" + reader.GetString(reader.GetOrdinal("Phone")) + "）" + "（邮箱：" + reader.GetString(reader.GetOrdinal("Email")) + "）" + "（QQ：" + reader.GetString(reader.GetOrdinal("QQ")) + "）" + "（微信：" + reader.GetString(reader.GetOrdinal("Weixin")) + "）");
                        tf = true;
                    }
                }
                if (!tf)
                {
                    MessageBox.Show("没有查询到内容！");
                }
                sql.CloseConnection();
            }
        }
    }
}
