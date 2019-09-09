using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form_设备列表 : Form
    {
        

        public DataTable CompleteDT;

        public Form_设备列表()
        {
            InitializeComponent();
        }

        private void Form_设备列表_Load(object sender, EventArgs e)
        {
            //将当前窗体对象指向字段
            Global.form = this;
            //统一设置控件样式
            Global.SetControls(Controls);


            //加载客户下拉框控件
            cmbCID.DisplayMember = "Name";
            cmbCID.ValueMember = "CID";
            cmbCID.DataSource = DBHelper.GetDataTable("select * from T_Customer");
            cmbCID.SelectedIndex = -1;

            //加载研发部工程师下拉框控件
            cmbUID.DisplayMember = "Name";
            cmbUID.ValueMember = "UID";
            cmbUID.DataSource = DBHelper.GetDataTable("select * from T_UserInfo where Department='研发部' and Post like '%工程师'");
            cmbUID.SelectedIndex = -1;

            Bind();
        }
        private void Bind()
        {
            //加载设备数据列表
            dgvEquipment.DataSource = DBHelper.GetDataTable("select EID,Date,c.Name,Model,SN,u.Name,UseDuration from T_Equipment e join T_Customer c on c.CID=e.CID  join T_UserInfo u on e.UID=u.UID");
            CompleteDT = DBHelper.GetDataTable("select EID 编号,Date 日期,c.Name 客户名称,Model 型号,SN 序列号,u.Name 安装工程师,UseDuration 使用期限,HardwareOperate 硬件操作情况反馈,SoftwareOperate 软件操作情况反馈,FaultOperate 故障操作情况反馈,UseSuggestions 使用建议和意见,Other 其他情况描述 from T_Equipment e join T_Customer c on c.CID=e.CID join T_UserInfo u on e.UID=u.UID");
        }



        /// <summary>
        /// 用户双击单元格中的任意位置时发生。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagridview1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //点了标题列
            if (e.RowIndex == -1) return;

            new Form_出厂设置(int.Parse(dgvEquipment.Rows[e.RowIndex].Cells["eid"].Value.ToString())).ShowDialog();
            Bind();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sn = txtSN.Text;
            string cid = cmbCID.Text;
            string uid = cmbUID.Text;

            string sql = "select EID,Date,c.Name,Model,SN,u.Name,UseDuration from T_Equipment e join T_Customer c on c.CID=e.CID  join T_UserInfo u on e.UID=u.UID where 1=1";

            if (sn != "")
            {
                sql = sql + " and SN like '%" + sn + "%'";
            }

            if (cid != "")
            {
                sql = sql + " and c.Name like '%" + cid + "%'";
            }

            if (uid != "")
            {
                sql = sql + " and u.Name like '%" + uid + "%'";
            }

            dgvEquipment.DataSource = DBHelper.GetDataTable(sql);
            CompleteDT = DBHelper.GetDataTable(sql.Replace("EID,Date,c.Name,Model,SN,u.Name,UseDuration", "EID 编号,Date 日期,c.Name 客户名称,Model 型号,SN 序列号,u.Name 安装工程师,UseDuration 使用期限,HardwareOperate 硬件操作情况反馈,SoftwareOperate 软件操作情况反馈,FaultOperate 故障操作情况反馈,UseSuggestions 使用建议和意见,Other 其他情况描述"));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel表格文件|*.xls";
            sfd.FileName = "设备列表.xls";
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
