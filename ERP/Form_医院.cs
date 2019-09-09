using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ERP
{
    public partial class Form_医院 : Form
    {
        
        public DataTable CompleteDT;

        public Form_医院()
        {
            InitializeComponent();
        }



        private void Form_医院_Load(object sender, EventArgs e)
        {
            //将当前窗体对象指向字段
            Global.form = this;
            //统一设置控件样式
            Global.SetControls(Controls);

            Bind();
        }
        private void Bind()
        {
            //加载医院数据列表
            dgvCustomer.DataSource = DBHelper.GetDataTable("select CID,Name,Address from T_Customer where Type='医院'");
            //加载出完整数据保存起来
            CompleteDT = DBHelper.GetDataTable("select CID 编号,Name 名称,Address 地址 from T_Customer where Type='医院'");
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
            if (Global.user["GID"].ToString() == "3" && (bool)Global.user["CUpd"] == false) return;
            //修改医院
            new Form_新增客户(int.Parse(dgvCustomer.Rows[e.RowIndex].Cells["cid"].Value.ToString())).ShowDialog();
            Bind();

        }

        private void dgvCustomer_MouseUp(object sender, MouseEventArgs e)
        {
            //根据用户组权限执行
            if (Global.user["GID"].ToString() == "3" && (bool)Global.user["CDel"] == false) return;

            if (e.Button == MouseButtons.Right && dgvCustomer.SelectedRows.Count > 0)
            {
                string cid = dgvCustomer.SelectedRows[0].Cells["cid"].Value.ToString();

                if (MessageBox.Show("是否删除编号为 " + cid + " 的医院?", "删除医院", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sql = "delete T_Customer where CID='" + cid + "'";
                    if (DBHelper.ExecuteNonQuery(sql) > 0) MessageBox.Show("删除成功");
                    Bind();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;


            string sql = "select CID,Name,Address from T_Customer where Type='医院'";

            if (name != "")
            {
                sql = sql + " and Name like '%" + name + "%'";
            }

            if (address != "")
            {
                sql = sql + " and Address like '%" + address + "%'";
            }

            dgvCustomer.DataSource = DBHelper.GetDataTable(sql);
            CompleteDT = DBHelper.GetDataTable(sql.Replace("CID,Name,Address", "CID 编号,Name 名称,Address 地址"));
        }






        private void btnExport_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel表格文件|*.xls";
            sfd.FileName = "医院.xls";
            //设置初始目录
            sfd.InitialDirectory = "E:\\";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                if (Global.ExportExcelWithAspose(CompleteDT, sfd.FileName))
                {
                    MessageBox.Show("导出成功");
                }
                else MessageBox.Show("导出失败");

            }
        }
    }
}
