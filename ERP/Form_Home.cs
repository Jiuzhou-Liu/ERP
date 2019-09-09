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
    public partial class Form_Home : Form
    {

        public Form_Home()
        {
            InitializeComponent();
        }

        private void 设备出厂登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_出厂设置 ccsz = new Form_出厂设置();
            ccsz.ShowDialog();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            //将当前窗体对象指向字段
            Global.form = this;
            //显示用户名、部门、职位
            lab_name.Text = Global.user["Name"].ToString();
            lab_department.Text = Global.user["Department"].ToString();
            lab_post.Text = Global.user["Post"].ToString();

            //根据用户组隐藏模块 3普通员工
            if (Global.user["GID"].ToString() == "3" && (bool)Global.user["CIns"] == false)
            {
                新增客户ToolStripMenuItem.Visible = false;
            }
            if (Global.user["GID"].ToString() == "3" && (bool)Global.user["UIns"] == false)
            {
                创建角色ToolStripMenuItem.Visible = false;
            }

        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_密码修改().ShowDialog();
        }

        private void 创建角色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_创建角色().ShowDialog();
        }

        private void Form_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void 退出系统ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出系统吗", "退出", MessageBoxButtons.OKCancel) == DialogResult.OK) Application.Exit();
        }

        private void 周报ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_周报().ShowDialog();
        }

        private void 实施跟进ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_员工列表().ShowDialog();
        }

        private void 周报管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_周报列表().ShowDialog();
        }

        private void 医院ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_医院().ShowDialog();
        }

        private void 经销商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_经销商().ShowDialog();
        }

        private void 新增客户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_新增客户().ShowDialog();
        }

        private void 设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_设备列表().ShowDialog();
        }

        private void 申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_出差().ShowDialog();
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_出差记录().ShowDialog();
        }

        private void lab_name_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否切换用户?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new Form_Login().Show();
                Hide();

            }
        }

        private void 查看ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form_售后记录().ShowDialog();
        }

        private void 登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_售后登记().ShowDialog();

        }
    }
}
