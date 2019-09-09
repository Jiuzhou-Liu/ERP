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
    public partial class Form_新增客户 : Form
    {
        public int cid = 0;
        public Form_新增客户()
        {
            InitializeComponent();
        }

        public Form_新增客户(int cid)
        {
            InitializeComponent();
            this.cid = cid;

            string sql = "select * from T_Customer where cid='" + cid + "'";

            DataRow dr = DBHelper.GetDataTable(sql).Rows[0];


            txtName.Text = dr["Name"].ToString();

            if (dr["Type"].ToString() == "医院")
            {
                radioButton1.Checked = true;
                btnEnter.Text = Text = "修改医院";
            }
            else {
                radioButton2.Checked = true;
                btnEnter.Text = Text = "修改经销商";
            }

            txtAddress.Text = dr["Address"].ToString();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (txtName.Text != "" && (radioButton1.Checked || radioButton2.Checked) && txtAddress.Text != "")
            {
                if (cid != 0)
                {
                    string type = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;

                    if (DBHelper.ExecuteNonQuery("update T_Customer set Name='" + txtName.Text + "',Type='" + type + "',Address='" + txtAddress.Text + "' where cid='"+cid+"'") > 0)
                    {
                        MessageBox.Show("修改成功");
                    }
                }
                else
                {
                    string type = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;

                    if (DBHelper.ExecuteNonQuery("insert T_Customer values('" + txtName.Text + "','" + type + "','" + txtAddress.Text + "')") > 0)
                    {
                        MessageBox.Show("新增成功");
                        Global.ResetControls(Controls);

                    }
                }
            }
            else
            {
                MessageBox.Show("必填项不能为空");
            }

        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_新增客户_Load(object sender, EventArgs e)
        {

        }

        private void Form_新增客户_Load_1(object sender, EventArgs e)
        {
            //将当前窗体对象指向字段
            Global.form = this;
            //统一设置控件样式
            Global.SetControls(Controls);


        }
    }
}
