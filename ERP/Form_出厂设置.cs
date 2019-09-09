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
    public partial class Form_出厂设置 : Form
    {
        public int eid = 0;

        public Form_出厂设置()
        {
            InitializeComponent();
        }


        public Form_出厂设置(int eid)
        {
            this.eid = eid;
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_清空_Click(object sender, EventArgs e)
        {

            Global.ResetControls(Controls);
            return; 

        }

        private void Form_出厂设置_Load(object sender, EventArgs e)
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

            //若当前登录用户是研发部工程师就默认选中
            foreach (DataRowView drv in cmbUID.Items)
            {
                if (drv.Row["Name"].ToString() == Global.user["Name"].ToString()) {
                    cmbUID.SelectedItem = drv;
                }
            }


            if (eid != 0)
            {


                DataRow dr = DBHelper.GetDataTable("select * from T_Equipment where EID='" + eid + "'").Rows[0];
                dtpDate.Value = DateTime.Parse(dr["date"].ToString());
                cmbCID.SelectedValue = dr["CID"].ToString();
                cmbModel.SelectedText = dr["Model"].ToString();
                txtSN.Text = dr["SN"].ToString();
                cmbUID.SelectedValue = dr["UID"].ToString();
                txtUseDuration.Text = dr["UseDuration"].ToString();
                txtHardwareOperate.Text = dr["HardwareOperate"].ToString();
                txtSoftwareOperate.Text = dr["SoftwareOperate"].ToString();
                txtFaultOperate.Text = dr["FaultOperate"].ToString();
                txtDefectCondition.Text = dr["DefectCondition"].ToString();
                txtUseSuggestions.Text = dr["UseSuggestions"].ToString();
                txtOther.Text = dr["Other"].ToString();

               // button_提交.Enabled = false;

            }



        }

        private void button_退出_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_提交_Click(object sender, EventArgs e)
        {
            if (cmbCID.SelectedValue == null)
            {
                MessageBox.Show("请选择客户");
                return;
            }

            string sql;

            if (eid != 0)
            {
                  sql = string.Format("update T_Equipment set Date='{0}',cid='{1}',Model='{2}',SN='{3}',UID='{4}',UseDuration='{5}',HardwareOperate='{6}',SoftwareOperate='{7}',FaultOperate='{8}',Defectcondition='{9}',UseSuggestions='{10}',Other='{11}' where EID='"+eid+"'",
                   dtpDate.Value, cmbCID.SelectedValue, cmbModel.Text, txtSN.Text, cmbUID.SelectedValue, txtUseDuration.Text, txtHardwareOperate.Text, txtSoftwareOperate.Text, txtFaultOperate.Text, txtDefectCondition.Text, txtUseSuggestions.Text, txtOther.Text
                   );
                if (DBHelper.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("修改成功");
                }
            }
            else
            {

               sql = string.Format("insert T_Equipment values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                    dtpDate.Value, cmbCID.SelectedValue, cmbModel.Text, txtSN.Text, cmbUID.SelectedValue, txtUseDuration.Text, txtHardwareOperate.Text, txtSoftwareOperate.Text, txtFaultOperate.Text, txtDefectCondition.Text, txtUseSuggestions.Text, txtOther.Text
                    );
                if (DBHelper.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("登记成功");
                    Global.ResetControls(Controls);
                }
            }

            
        }
    }
}
