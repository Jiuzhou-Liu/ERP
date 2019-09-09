namespace ERP
{
    partial class Form_创建角色
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbxCIns = new System.Windows.Forms.CheckBox();
            this.cbxCDel = new System.Windows.Forms.CheckBox();
            this.cbxCUpd = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxUIns = new System.Windows.Forms.CheckBox();
            this.cbxUDel = new System.Windows.Forms.CheckBox();
            this.cbxUUpd = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(259, 292);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 30);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "创建角色";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEsc.Location = new System.Drawing.Point(366, 292);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 30);
            this.btnEsc.TabIndex = 7;
            this.btnEsc.Text = "取消";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(181, 99);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(121, 21);
            this.txtPass.TabIndex = 2;
            // 
            // cmbPost
            // 
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Items.AddRange(new object[] {
            ".NET开发工程师",
            ".NET实施工程师"});
            this.cmbPost.Location = new System.Drawing.Point(181, 209);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(121, 20);
            this.cmbPost.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "性别:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "职位:";
            // 
            // cmbGID
            // 
            this.cmbGID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGID.FormattingEnabled = true;
            this.cmbGID.Location = new System.Drawing.Point(182, 38);
            this.cmbGID.Name = "cmbGID";
            this.cmbGID.Size = new System.Drawing.Size(121, 20);
            this.cmbGID.TabIndex = 5;
            this.cmbGID.SelectedIndexChanged += new System.EventHandler(this.cmbGID_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "身份:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "研发部",
            "生产部",
            "市场部",
            "销售部",
            "品质部",
            "财务部"});
            this.cmbDepartment.Location = new System.Drawing.Point(181, 174);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 20);
            this.cmbDepartment.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "部门:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(182, 140);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(267, 140);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbxCIns
            // 
            this.cbxCIns.AutoSize = true;
            this.cbxCIns.Location = new System.Drawing.Point(54, 6);
            this.cbxCIns.Name = "cbxCIns";
            this.cbxCIns.Size = new System.Drawing.Size(36, 16);
            this.cbxCIns.TabIndex = 9;
            this.cbxCIns.Text = "增";
            this.cbxCIns.UseVisualStyleBackColor = true;
            // 
            // cbxCDel
            // 
            this.cbxCDel.AutoSize = true;
            this.cbxCDel.Location = new System.Drawing.Point(96, 6);
            this.cbxCDel.Name = "cbxCDel";
            this.cbxCDel.Size = new System.Drawing.Size(36, 16);
            this.cbxCDel.TabIndex = 10;
            this.cbxCDel.Text = "删";
            this.cbxCDel.UseVisualStyleBackColor = true;
            // 
            // cbxCUpd
            // 
            this.cbxCUpd.AutoSize = true;
            this.cbxCUpd.Location = new System.Drawing.Point(138, 6);
            this.cbxCUpd.Name = "cbxCUpd";
            this.cbxCUpd.Size = new System.Drawing.Size(36, 16);
            this.cbxCUpd.TabIndex = 10;
            this.cbxCUpd.Text = "改";
            this.cbxCUpd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "权限:";
            // 
            // cbxUIns
            // 
            this.cbxUIns.AutoSize = true;
            this.cbxUIns.Location = new System.Drawing.Point(54, 28);
            this.cbxUIns.Name = "cbxUIns";
            this.cbxUIns.Size = new System.Drawing.Size(36, 16);
            this.cbxUIns.TabIndex = 9;
            this.cbxUIns.Text = "增";
            this.cbxUIns.UseVisualStyleBackColor = true;
            // 
            // cbxUDel
            // 
            this.cbxUDel.AutoSize = true;
            this.cbxUDel.Location = new System.Drawing.Point(96, 28);
            this.cbxUDel.Name = "cbxUDel";
            this.cbxUDel.Size = new System.Drawing.Size(36, 16);
            this.cbxUDel.TabIndex = 10;
            this.cbxUDel.Text = "删";
            this.cbxUDel.UseVisualStyleBackColor = true;
            // 
            // cbxUUpd
            // 
            this.cbxUUpd.AutoSize = true;
            this.cbxUUpd.Location = new System.Drawing.Point(138, 28);
            this.cbxUUpd.Name = "cbxUUpd";
            this.cbxUUpd.Size = new System.Drawing.Size(36, 16);
            this.cbxUUpd.TabIndex = 10;
            this.cbxUUpd.Text = "改";
            this.cbxUUpd.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "客户";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "员工";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbxCIns);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbxCDel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbxUIns);
            this.panel1.Controls.Add(this.cbxUUpd);
            this.panel1.Controls.Add(this.cbxUDel);
            this.panel1.Controls.Add(this.cbxCUpd);
            this.panel1.Location = new System.Drawing.Point(125, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 48);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // Form_创建角色
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnEsc;
            this.ClientSize = new System.Drawing.Size(453, 335);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.cmbPost);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_创建角色";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "创建角色";
            this.Load += new System.EventHandler(this.Form_创建角色_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox cbxCIns;
        private System.Windows.Forms.CheckBox cbxCDel;
        private System.Windows.Forms.CheckBox cbxCUpd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxUIns;
        private System.Windows.Forms.CheckBox cbxUDel;
        private System.Windows.Forms.CheckBox cbxUUpd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}