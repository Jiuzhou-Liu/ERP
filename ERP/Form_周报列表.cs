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
    public partial class Form_周报列表 : Form
    {

        public string department = Global.user["Department"].ToString();

        public Form_周报列表()
        {
            InitializeComponent();
        }

        private void Form_周报列表_Load(object sender, EventArgs e)
        {
            //将当前窗体对象指向字段
            Global.form = this;
            //统一设置控件样式
            Global.SetControls(Controls);
            Bind();
        }
        private void Bind()
        {

            //根据用户组权限执行
            if (Global.user["GID"].ToString() == "1")
            {
                //加载所有周报数据列表
                dgvWeekly.DataSource = DBHelper.GetDataTable("select WID,Name,This,Next,Note,DateTime from T_Weekly w inner join T_UserInfo u on w.UID=u.UID");
            }
            else
            {
                //加载自己部门周报数据列表
                dgvWeekly.DataSource = DBHelper.GetDataTable("select WID,Name,This,Next,Note,DateTime from T_Weekly w inner join T_UserInfo u on w.UID=u.UID where Department='" + department + "'");
            }
        }



        /// <summary>
        /// 用户双击单元格中的任意位置时发生。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvWeekly_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //点了标题列
            if (e.RowIndex == -1) return;

            Form_周报 form_周报 = new Form_周报(int.Parse(dgvWeekly.Rows[e.RowIndex].Cells["wid"].Value.ToString()));
            form_周报.ShowDialog();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder sql;
            //根据用户组权限执行
            if (Global.user["GID"].ToString() == "1")
            {
                //搜索所有周报数据列表
                sql = new StringBuilder("select WID,Name,This,Next,Note,DateTime from T_Weekly w inner join T_UserInfo u on w.UID=u.UID");
            }
            else
            {
                //搜索自己部门周报数据列表
                sql = new StringBuilder("select WID,Name,This,Next,Note,DateTime from T_Weekly w inner join T_UserInfo u on w.UID=u.UID where Department='" + department + "'");
            }
            string name = txtName.Text;
            string note = txtNote.Text;
            string beginDate = dtpBegin.Value.ToString("yyyy/MM/dd 00:00:00");
            string endDate = dtpEnd.Value.ToString("yyyy/MM/dd 23:59:59");

            if (name != "") sql.Append(" and Name like '%" + name + "%'");
            if (note != "") sql.Append(" and Note like '%" + note + "%'");
            sql.Append(" and DateTime between '" + beginDate + "' and '" + endDate + "'");
            dgvWeekly.DataSource = DBHelper.GetDataTable(sql.ToString());

        }

        private void dgvWeekly_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvWeekly_MouseUp(object sender, MouseEventArgs e)
        {
            //根据用户组权限执行
            if (Global.user["GID"].ToString() == "3" || Global.user["GID"].ToString() == "4") return;

            if (e.Button == MouseButtons.Right && dgvWeekly.SelectedRows.Count > 0)
            {
                string wid = dgvWeekly.SelectedRows[0].Cells["wid"].Value.ToString();

                if (MessageBox.Show("是否删除编号为 " + wid + " 的周报?", "删除周报", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sql = "delete T_Weekly where WID='" + wid + "'";
                    if (DBHelper.ExecuteNonQuery(sql) > 0) MessageBox.Show("删除成功");
                    Bind();
                }
            }

        }
    }
}
