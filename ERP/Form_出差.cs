using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ERP
{
    public partial class Form_出差 : Form
    {
        public Form_出差()
        {
            InitializeComponent();
        }

        private void Form_出差_Load(object sender, EventArgs e)
        {
            //将当前窗体对象指向字段
            Global.form = this;
            //统一设置控件样式
            Global.SetControls(Controls);

            DataTable dt = DBHelper.GetDataTable("select * from t_customer where type='医院'");
            //加载医院列表到下拉框
            cmbHospital.ValueMember = "CID";
            cmbHospital.DisplayMember = "Name";
            cmbHospital.DataSource = dt;
            //设置下拉框默认为空
            cmbHospital.SelectedIndex = -1;

            //时间框控件默认赋值为当前时间
            dtpDateBegin.Value = dtpDateEnd.Value = dtpSetOutDate.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPlace.Text == "" || cmbHospital.SelectedIndex == -1 || txtReason.Text == "")
            {
                MessageBox.Show("必填项不能为空");
                return;
            }
            try
            {
                if (DBHelper.ExecuteNonQuery(string.Format("insert T_BusinessTrip values('{0}',{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", int.Parse(Global.user["UID"].ToString()), int.Parse(cmbHospital.SelectedValue.ToString()), DateTime.Now.ToLocalTime().ToString(), dtpDateBegin.Value, dtpDateEnd.Value, txtPlace.Text, txtTool.Text, dtpSetOutDate.Value, txtCost.Text, txtReason.Text)) > 0)
                {
                    MessageBox.Show("出差成功, 祝您旅途愉快");
                    Global.ResetControls(Controls);
                }
            }
            catch
            {
                MessageBox.Show("输入格式有误");
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 当控件不再是窗体的活动控件时发生。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCost_Leave(object sender, EventArgs e)
        {
            //控件失去焦点后根据情况判断添加尾号
            string cost = ((TextBox)sender).Text;
            if (!Regex.IsMatch(cost, @"\.\d{2}$") && cost!="")
            {
                if (Regex.IsMatch(cost, @"\.\d{1}$"))
                {
                    ((TextBox)sender).Text += "0";
                }else ((TextBox)sender).Text += ".00";
            }
                       
        }
    }
}
