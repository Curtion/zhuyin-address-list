using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using CCWin;
using static 竹影通讯录.Program;

namespace 竹影通讯录
{
    public partial class Main : Skin_Metro
    {
        private static SqlHelp sql;

        public Main()
        {
            InitializeComponent();
            sql = new SqlHelp("data source=mydb.db");//初始化加分组
            SQLiteDataReader reader = sql.ReadFullTable("fenzu");
            while (reader.Read())
            {
                Listfenzu.Items.Add(reader.GetString(reader.GetOrdinal("Name")));
            }
            sql.CloseConnection();

        }
        static void Log(string s)
        {
            Console.WriteLine("" + s);
        }

        private void SCButton_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.SCButton, "删除选中的通讯录");
        }

        private void CZButton_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.CZButton, "搜索数据库中的数据");
        }

        private void XGButton_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.XGButton, "修改选中的数据");
        }

        private void XJButton_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.XJButton, "新建一个数据到数据库");
        }

        private void XJButton_MouseDown(object sender, MouseEventArgs e)
        {
        }

        public void Main_Load(object sender, EventArgs e)//初始化加载
        {
            sql = new SqlHelp("data source=mydb.db");
            sql.CreateTable("tongxunlu", new string[] { "Name", "Phone", "Groups", "Email", "QQ", "Weixin", "Info" }, new string[] { "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT" });
            //读取整张表
            SQLiteDataReader reader = sql.ReadFullTable("tongxunlu");
            this.ListView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = reader.GetString(reader.GetOrdinal("Name"));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Phone")));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Groups")));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Email")));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("QQ")));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Weixin")));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Info")));
                this.ListView.Items.Add(lvi);

            }
            this.ListView.EndUpdate();  //结束数据处理，UI界面一次性绘制。 sql.CloseConnection(); 
            sql.CloseConnection();
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 35);//分别是宽和高
            ListView.SmallImageList = imgList;
        }

        private void XJButton_Click(object sender, EventArgs e)//新建通讯录
        {
            Add f2 = new Add();
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                ListView.Items.Clear();
                sql = new SqlHelp("data source=mydb.db");
                //读取整张表
                SQLiteDataReader reader = sql.ReadFullTable("tongxunlu");
                this.ListView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = reader.GetString(reader.GetOrdinal("Name"));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Phone")));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Groups")));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Email")));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("QQ")));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Weixin")));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Info")));
                    this.ListView.Items.Add(lvi);

                }
                this.ListView.EndUpdate();  //结束数据处理，UI界面一次性绘制。 sql.CloseConnection(); 
                sql.CloseConnection();
                ImageList imgList = new ImageList();
                imgList.ImageSize = new Size(1, 35);//分别是宽和高
                ListView.SmallImageList = imgList;
            }
        }

        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void SCButton_Click(object sender, EventArgs e)//删除通讯录
        {
            sql = new SqlHelp("data source=mydb.db");
            if(ListView.SelectedItems.Count > 0)
            {
                string name = this.ListView.FocusedItem.SubItems[0].Text;
                sql.DeleteValuesAND("tongxunlu", new string[] { "Name" }, new string[] { name }, new string[] { "=" });
                               ListView.Items.Clear();
                //读取整张表
                SQLiteDataReader reader = sql.ReadFullTable("tongxunlu");
                this.ListView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = reader.GetString(reader.GetOrdinal("Name"));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Phone")));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Groups")));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Email")));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("QQ")));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Weixin")));
                    lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Info")));
                    this.ListView.Items.Add(lvi);

                }
                this.ListView.EndUpdate();  //结束数据处理，UI界面一次性绘制。 sql.CloseConnection(); 
                sql.CloseConnection();
                ImageList imgList = new ImageList();
                imgList.ImageSize = new Size(1, 35);//分别是宽和高
                ListView.SmallImageList = imgList;
                MessageBox.Show("删除成功");
            }

        }

        private void Newfenlei_Click(object sender, EventArgs e)//添加分组
        {
            Newfenlei f = new Newfenlei();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                Listfenzu.Items.Clear();
                sql = new SqlHelp("data source=mydb.db");
                SQLiteDataReader reader = sql.ReadFullTable("fenzu");
                while (reader.Read())
                {
                    Listfenzu.Items.Add(reader.GetString(reader.GetOrdinal("Name")));
                }
                sql.CloseConnection();
            }
        }

        private void Delfenlei_Click(object sender, EventArgs e)//删除分组
        {
            sql = new SqlHelp("data source=mydb.db");
            sql.DeleteValuesAND("fenzu", new string[] { "Name" }, new string[] { Listfenzu.SelectedItem.ToString() }, new string[] { "=" });
            Listfenzu.Items.Clear();
            SQLiteDataReader reader = sql.ReadFullTable("fenzu");
            while (reader.Read())
            {
                Listfenzu.Items.Add(reader.GetString(reader.GetOrdinal("Name")));
            }
            sql.CloseConnection();
            MessageBox.Show("删除成功");
        }

        private void CZButton_Click(object sender, EventArgs e)
        {
            Sousuo f = new Sousuo();
            f.ShowDialog();
        }

        private void XGButton_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count > 0)
            {
                InfoClass.TName = ListView.FocusedItem.SubItems[0].Text;
                InfoClass.Phone = ListView.FocusedItem.SubItems[1].Text;
                InfoClass.Email = ListView.FocusedItem.SubItems[3].Text;
                InfoClass.QQ = ListView.FocusedItem.SubItems[4].Text;
                InfoClass.Weixin = ListView.FocusedItem.SubItems[5].Text;
                InfoClass.Info = ListView.FocusedItem.SubItems[6].Text;
                XGview f = new XGview();
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    sql = new SqlHelp("data source=mydb.db");
                    ListView.Items.Clear();
                    //读取整张表
                    SQLiteDataReader reader = sql.ReadFullTable("tongxunlu");
                    this.ListView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = reader.GetString(reader.GetOrdinal("Name"));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Phone")));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Groups")));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Email")));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("QQ")));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Weixin")));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Info")));
                        this.ListView.Items.Add(lvi);

                    }
                    this.ListView.EndUpdate();  //结束数据处理，UI界面一次性绘制。 sql.CloseConnection(); 
                    sql.CloseConnection();
                    ImageList imgList = new ImageList();
                    imgList.ImageSize = new Size(1, 35);//分别是宽和高
                    ListView.SmallImageList = imgList;
                    MessageBox.Show("修改成功");
                }
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info f = new info();
            f.ShowDialog();
        }

        private void Listfenzu_Click(object sender, EventArgs e)
        {
            if (this.Listfenzu.SelectedItems.Count > 0)
            {
                sql = new SqlHelp("data source=mydb.db");
                ListView.Items.Clear();
                SQLiteDataReader reader = sql.ReadFullTable("tongxunlu");
                this.ListView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
                while (reader.Read())
                {
                    if (reader.GetString(reader.GetOrdinal("Groups")) == Listfenzu.SelectedItem.ToString())
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = reader.GetString(reader.GetOrdinal("Name"));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Phone")));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Groups")));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Email")));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("QQ")));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Weixin")));
                        lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Info")));
                        this.ListView.Items.Add(lvi);
                    }
                }
                this.ListView.EndUpdate();  //结束数据处理，UI界面一次性绘制。 sql.CloseConnection(); 
                sql.CloseConnection();
                ImageList imgList = new ImageList();
                imgList.ImageSize = new Size(1, 35);//分别是宽和高
                ListView.SmallImageList = imgList;
            }
        }
    }
}