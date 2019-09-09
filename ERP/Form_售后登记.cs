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
    public partial class Form_售后登记 : Form
    {
        public Form_售后登记()
        {
            InitializeComponent();
        }
        
        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_售后登记_Load(object sender, EventArgs e)
        {
            //加载医院
            cmbHospital.DisplayMember = "Name";
            cmbHospital.ValueMember = "CID";
            cmbHospital.DataSource = DBHelper.GetDataTable("select * from T_Customer where Type='医院'");
            cmbHospital.SelectedIndex = -1;
            
            //加载设备序列号
            cmbUID.DisplayMember = "SN";
            cmbUID.ValueMember = "EID";
            cmbUID.DataSource = DBHelper.GetDataTable("select * from T_Equipment");
            cmbUID.SelectedIndex = -1;

            //加载研发部工程师
            cmbUID.DataSource = DBHelper.GetDataTable("select * from T_UserInfo where Department='研发部' and Post like '%工程师'");
            cmbUID.DisplayMember = "Name";
            cmbUID.ValueMember = "UID";
            cmbUID.SelectedIndex = -1;
        }
    }
}
