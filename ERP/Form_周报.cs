using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form_周报 : Form
    {
        private int wid=0;
        public Form_周报()
        {
            InitializeComponent();
        }


        public Form_周报(int wid)
        {
            InitializeComponent();
            this.wid = wid;
            Text = "周报查看";
            btnEnter.Visible = false;

            string sql = "select * from T_Weekly where WID='" + wid + "'";

            DataRow dr = DBHelper.GetDataTable(sql).Rows[0];

            txtThisWeek.Text = dr["This"].ToString();
            txtNextWeek.Text = dr["Next"].ToString();
            txtNote.Text = dr["Note"].ToString();
            

           


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtThisWeek.Text != "" && txtNextWeek.Text != ""
                && DBHelper.ExecuteNonQuery(string.Format("insert T_Weekly values({0},'{1}','{2}','{3}','{4}')", Global.user["UID"].ToString(), txtThisWeek.Text, txtNextWeek.Text, txtNote.Text, DateTime.Now.ToLocalTime())) > 0)
            {
                MessageBox.Show("写周报成功");
                Global.ResetControls(Controls);

            }
            else MessageBox.Show("请输入内容");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNote_KeyUp(object sender, KeyEventArgs e)
        {

    }

        //实现Ctrl+A全选
        private void txtThisWeek_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }

        }

        private void Form_周报_Load(object sender, EventArgs e)
        {
            //将当前窗体对象指向字段
            Global.form = this;
            //统一设置控件样式
            Global.SetControls(Controls);
        }
    }
}
