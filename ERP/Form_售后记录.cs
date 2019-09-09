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
    public partial class Form_售后记录 : Form
    {
        public Form_售后记录()
        {
            InitializeComponent();
        }

        private void Form_售后记录_Load(object sender, EventArgs e)
        {
            dgvAfterSales.DataSource = DBHelper.GetDataTable("select AID 编号,c.Name 客户,e.SN 设备序列号,u.Name 工程师,Feedback 反馈信息,FeedbackDate 反馈时间,Reason 问题原因,Processing 处理情况,ProcessingCompletedDate 处理完成时间 from T_AfterSales a,T_Customer c,T_Equipment e,T_UserInfo u where a.CID=c.CID and a.EID=e.EID and a.UID=u.UID");

        }
    }
}
