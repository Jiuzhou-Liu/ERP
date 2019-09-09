using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            //将当前窗体对象指向字段
            Global.form = this;

            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);

            string name = Configuration.Get("Login", "Name");
            string pass = Configuration.Get("Login", "Password");
            txtName.Text = name != "" ? name : "用户名";
            if (pass != "")
            {
                txtPass.Text = pass;
                txtPass.UseSystemPasswordChar = true;
            }
            else txtPass.Text = "密码";



        }

        private void button_登录_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "用户名" || txtName.Text == "" || txtPass.Text == "密码" || txtPass.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空");
                return;
            }
            try
            {
                DataRow user = DBHelper.GetDataTable("select * from T_UserInfo where Name='" + txtName.Text + "' and Password='" + txtPass.Text + "'").Rows[0];
                Global.user = user;

                //保存用户名和密码
                Configuration.Set("Login", "Name", Global.user["Name"].ToString());
                Configuration.Set("Login", "Password", Global.user["Password"].ToString());

                new Form_Home().Show();
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("登录失败, 请检查用户名和密码");
            }



        }

        private void button_退出_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtName_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Test");
        }

        private void Form_Login_Enter(object sender, EventArgs e)
        {


        }

        private void Form_Login_Leave(object sender, EventArgs e)
        {


        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "用户名")
            {
                ((TextBox)sender).Text = "";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "用户名";
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "密码")
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "密码";
                ((TextBox)sender).UseSystemPasswordChar = false;
            }
        }

        private void Form_Login_Click(object sender, EventArgs e)
        {
        }

        private void button_登录_Enter(object sender, EventArgs e)
        {

        }






        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);





    }
}
