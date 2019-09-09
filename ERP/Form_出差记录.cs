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
    public partial class  Form_出差记录 : Form
    {
        public int uid = (int)Global.user["UID"];

        public  Form_出差记录()
        {
            InitializeComponent();
        }

        private void  Form_出差记录_Load(object sender, EventArgs e)
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
            if (Global.user["GID"].ToString() == "1" || Global.user["GID"].ToString() == "2")
            {
                //加载所有人的出差记录
                dgvBusinessTrip.DataSource = DBHelper.GetDataTable("select BID 编号,u.Name 用户名,c.Name 客户,Date 申请日期,Place 地点,Reason 事由 from T_BusinessTrip b join T_Customer c on b.CID=c.CID join T_UserInfo u on u.UID=b.uid");
            }
            else
            {
                //加载个人的出差记录
                dgvBusinessTrip.DataSource = DBHelper.GetDataTable("select BID 编号,u.Name 用户名,c.Name 客户,Date 申请日期,Place 地点,Reason 事由 from T_BusinessTrip b join T_Customer c on b.CID=c.CID join T_UserInfo u on u.UID=b.uid where b.UID='" + uid + "'");
            }

        }



        /// <summary>
        /// 用户双击单元格中的任意位置时发生。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvWeekly_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void dgvCustomer_MouseUp(object sender, MouseEventArgs e)
        {

            //根据用户组权限执行
            if (Global.user["GID"].ToString() == "3" || Global.user["GID"].ToString() == "4") return;

            if (e.Button == MouseButtons.Right && dgvBusinessTrip.SelectedRows.Count > 0)
            {
                string bid = dgvBusinessTrip.SelectedRows[0].Cells["编号"].Value.ToString();

                if (MessageBox.Show("是否删除编号为 " + bid + " 的出差记录?", "删除出差记录", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sql = "delete T_BusinessTrip where BID='" + bid + "'";
                    if (DBHelper.ExecuteNonQuery(sql) > 0) MessageBox.Show("删除成功");
                    Bind();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string address = txtAddress.Text;
            string reason = txtReason.Text;
            string sql;
            //根据用户组权限执行
            if (Global.user["GID"].ToString() == "1" || Global.user["GID"].ToString() == "2")
            {
                //搜索所有人的
                 sql = "select BID 编号,u.Name 用户名,c.Name 客户,Date 申请日期,Place 地点,Reason 事由 from T_BusinessTrip b join T_Customer c on b.CID=c.CID join T_UserInfo u on u.UID=b.uid where 1=1";
            }
            else {
                //搜索个人的
                 sql = "select BID 编号,u.Name 用户名,c.Name 客户,Date 申请日期,Place 地点,Reason 事由 from T_BusinessTrip b join T_Customer c on b.CID=c.CID join T_UserInfo u on u.UID=b.uid where b.UID='" + uid + "'";
            }

            if (address != "")
            {
                sql = sql + " and Address like '%" + address + "%'";
            }

            if (reason != "")
            {
                sql = sql + " and Reason like '%" + reason + "%'";
            }

            dgvBusinessTrip.DataSource = DBHelper.GetDataTable(sql);
         

        }

        private void btnExport_Click(object sender, EventArgs e)
        {


        }
    }
}
