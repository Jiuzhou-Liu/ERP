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
    public partial class Form_密码修改 : Form
    {
        public Form_密码修改()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == Global.user["Password"].ToString())
            {
                if (txtNewPass.Text == txtNewPass2.Text)
                {
                    if (DBHelper.ExecuteNonQuery("update T_UserInfo set Password='" + txtNewPass.Text + "' where UID='" + Global.user["UID"].ToString() + "'") > 0)
                    {
                        MessageBox.Show("修改成功");
                    }

                }
                else
                {
                    MessageBox.Show("两次输入的密码不一致");
                }
            }
            else
            {
                MessageBox.Show("旧密码输入错误");
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_密码修改_Load(object sender, EventArgs e)
        {
            //将当前窗体对象指向字段
            Global.form = this;
            //统一设置控件样式
            Global.SetControls(Controls);
        }
    }
}
