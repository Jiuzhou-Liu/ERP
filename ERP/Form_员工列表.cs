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
    public partial class Form_员工列表 : Form
    {
        public Form_员工列表()
        {
            InitializeComponent();
        }

        private void Form_员工_Load(object sender, EventArgs e)
        {
            //将当前窗体对象指向字段
            Global.form = this;
            //统一设置控件样式
            Global.SetControls(Controls);

            //绑定数据
            Bind();
        }

        private void Bind()
        {
            //加载员工数据列表
            dgvEmployees.DataSource = DBHelper.GetDataTable("select UID,g.Name GName,u.Name,Sex,Department,Post from T_UserInfo u join T_Group g on u.GID=g.GID where u.GID='3' or u.GID='2' ");
        }
        /// <summary>
        /// 用户双击单元格中的任意位置时发生。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //点了标题列
            if (e.RowIndex == -1) return;
            int uid=int.Parse(dgvEmployees.Rows[e.RowIndex].Cells["uid"].Value.ToString());
            string gname = dgvEmployees.SelectedRows[0].Cells["gname"].Value.ToString();
            string gid = DBHelper.GetDataTable("select GID from T_Group where Name='" + gname + "'").Rows[0]["GID"].ToString();

            //根据用户组权限执行
            if (Global.user["GID"].ToString() == "3" && Global.user["UUpd"].ToString() == "False") return;
            //普通员工不能修改管理员
            if (Global.user["GID"].ToString() == "3" && gid != "3") return;
            //普通员工不能修改自己
            if (Global.user["GID"].ToString() == "3" && uid.ToString() == Global.user["UID"].ToString()) return;


            Form_创建角色 form_创建角色 = new Form_创建角色(uid);
            form_创建角色.ShowDialog();

            //重新绑定数据
            Bind();

        }

        private void dgvEmployees_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            string sql = "select UID,g.Name GName,u.Name,Sex,Department,Post from T_UserInfo u join T_Group g on u.GID=g.GID where (u.GID='3' or u.GID='2')";

            if (name != "") {
                sql = sql + " and u.Name like '%" + name + "%'";
            }

            dgvEmployees.DataSource = DBHelper.GetDataTable(sql);
        }

        private void dgvEmployees_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && dgvEmployees.SelectedRows.Count > 0)
            {
                string uid = dgvEmployees.SelectedRows[0].Cells["uid"].Value.ToString();

                string gname = dgvEmployees.SelectedRows[0].Cells["gname"].Value.ToString();
                string gid = DBHelper.GetDataTable("select GID from T_Group where Name='"+gname+"'").Rows[0]["GID"].ToString();

                //根据用户组权限执行
                if (Global.user["GID"].ToString() == "3" && Global.user["UDel"].ToString() == "False") return;
                //普通员工不能删除管理员
                if (Global.user["GID"].ToString() == "3" && gid != "3") return;

                if (MessageBox.Show("是否删除编号为 " + uid + " 的员工?", "删除员工", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sql = "delete T_UserInfo where UID='" + uid + "'";
                    if (DBHelper.ExecuteNonQuery(sql) > 0) MessageBox.Show("删除成功");
                    Bind();
                }
            }
        }
    }
}
