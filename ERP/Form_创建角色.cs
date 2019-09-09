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
    public partial class Form_创建角色 : Form
    {

        int uid = 0;

        public Form_创建角色()
        {
            InitializeComponent();
        }

        public Form_创建角色(int uid)
        {
            InitializeComponent();

            this.uid = uid;

            
        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPass.Text == "" || cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("请检查必填项");
                return;
            }

            bool CIns = cbxCIns.Checked;
            bool CDel = cbxCDel.Checked;
            bool CUpd = cbxCUpd.Checked;
            bool UIns = cbxUIns.Checked;
            bool UDel = cbxUDel.Checked;
            bool UUpd = cbxUUpd.Checked;

            if (uid != 0)
            {

                string sql = string.Format("update T_UserInfo set GID='{0}',Name='{1}',Password='{2}',Sex='{3}',Department='{4}',Post='{5}',CIns='{6}',CDel='{7}',CUpd='{8}',UIns='{9}',UDel='{10}',UUpd='{11}' where UID='{12}'", cmbGID.SelectedValue, txtName.Text, txtPass.Text, radioButton1.Checked ? "男" : "女", cmbDepartment.Text, cmbPost.Text, CIns, CDel, CUpd, UIns, UDel, UUpd, uid);

                if (DBHelper.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("修改角色成功");
                }
            }
            else
            {

                string sql = string.Format("insert T_UserInfo values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", cmbGID.SelectedValue, txtName.Text, txtPass.Text, radioButton1.Checked ? "男" : "女", cmbDepartment.Text, cmbPost.Text, CIns, CDel, CUpd, UIns, UDel, UUpd);

                if (DBHelper.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("创建角色成功");
                    Global.ResetControls(Controls);
                    cmbGID.SelectedIndex = 2;
                }
            }




        }

        private void Form_创建角色_Load(object sender, EventArgs e)
        {
            //将当前窗体对象指向字段
            Global.form = this;
            //统一设置控件样式
            Global.SetControls(Controls);

            DataTable dt = DBHelper.GetDataTable("select * from T_Group");

            //加载身份列表到下拉框
            cmbGID.DisplayMember = "Name";
            cmbGID.ValueMember = "GID";
            cmbGID.DataSource = dt;
            //默认创建普通员工
            cmbGID.SelectedIndex = 2;

            if (uid != 0)
            {
              


                string sql = "select * from T_UserInfo where UID='" + uid + "'";

                DataRow dr = DBHelper.GetDataTable(sql).Rows[0];

                cmbGID.SelectedValue = dr["GID"].ToString();
                txtName.Text = dr["Name"].ToString();
                txtPass.Text = dr["Password"].ToString();
                if (dr["Sex"].ToString() == "男") radioButton1.Checked = true;
                else radioButton2.Checked = true;
                cmbDepartment.Text = dr["Department"].ToString();
                cmbPost.Text = dr["Post"].ToString();

                try
                {
                    cbxCIns.Checked = (bool)dr["CIns"];
                    cbxCDel.Checked = (bool)dr["CDel"];
                    cbxCUpd.Checked = (bool)dr["CUpd"];
                    cbxUIns.Checked = (bool)dr["UIns"];
                    cbxUDel.Checked = (bool)dr["UDel"];
                    cbxUUpd.Checked = (bool)dr["UUpd"];
                }
                catch (Exception)
                {

                    cbxCIns.Checked =
                    cbxCDel.Checked =
                    cbxCUpd.Checked =
                    cbxUIns.Checked =
                    cbxUDel.Checked =
                    cbxUUpd.Checked = false;

                }


                btnCreate.Text = Text = "修改角色";

            }



           




        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbGID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //选了普通员工
            if (((ComboBox)sender).SelectedIndex == 2)
            {
                panel1.Visible = true;
            }
            else panel1.Visible = false;
        }
    }
}
