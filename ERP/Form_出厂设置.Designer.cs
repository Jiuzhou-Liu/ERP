namespace ERP
{
    partial class Form_出厂设置
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.txtUseDuration = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCID = new System.Windows.Forms.ComboBox();
            this.cmbUID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHardwareOperate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUseSuggestions = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDefectCondition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFaultOperate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoftwareOperate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_退出 = new System.Windows.Forms.Button();
            this.button_清空 = new System.Windows.Forms.Button();
            this.button_提交 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(473, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备出厂登记汇总一览表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "出货日期：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtSN);
            this.groupBox1.Controls.Add(this.cmbModel);
            this.groupBox1.Controls.Add(this.txtUseDuration);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbCID);
            this.groupBox1.Controls.Add(this.cmbUID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(24, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1295, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息填写";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1050, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "+";
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(1074, 49);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(122, 26);
            this.txtSN.TabIndex = 3;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "玻片打码机",
            "包埋盒打码机"});
            this.cmbModel.Location = new System.Drawing.Point(901, 49);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(139, 24);
            this.cmbModel.TabIndex = 2;
            // 
            // txtUseDuration
            // 
            this.txtUseDuration.Location = new System.Drawing.Point(504, 97);
            this.txtUseDuration.Name = "txtUseDuration";
            this.txtUseDuration.Size = new System.Drawing.Size(200, 26);
            this.txtUseDuration.TabIndex = 5;
            this.txtUseDuration.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(405, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "使用期限：";
            // 
            // cmbCID
            // 
            this.cmbCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCID.FormattingEnabled = true;
            this.cmbCID.Location = new System.Drawing.Point(504, 46);
            this.cmbCID.Name = "cmbCID";
            this.cmbCID.Size = new System.Drawing.Size(200, 24);
            this.cmbCID.TabIndex = 1;
            // 
            // cmbUID
            // 
            this.cmbUID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUID.FormattingEnabled = true;
            this.cmbUID.Location = new System.Drawing.Point(131, 97);
            this.cmbUID.Name = "cmbUID";
            this.cmbUID.Size = new System.Drawing.Size(200, 24);
            this.cmbUID.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "安装工程师：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(772, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "设备型号+序号：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHardwareOperate);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtOther);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtUseSuggestions);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtDefectCondition);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtFaultOperate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSoftwareOperate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(23, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1247, 270);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设备试用状况";
            // 
            // txtHardwareOperate
            // 
            this.txtHardwareOperate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHardwareOperate.Location = new System.Drawing.Point(201, 23);
            this.txtHardwareOperate.Name = "txtHardwareOperate";
            this.txtHardwareOperate.Size = new System.Drawing.Size(979, 26);
            this.txtHardwareOperate.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "硬件操作情况反馈：";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(201, 229);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(979, 26);
            this.txtOther.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "其 他 情况 描述：";
            // 
            // txtUseSuggestions
            // 
            this.txtUseSuggestions.Location = new System.Drawing.Point(201, 187);
            this.txtUseSuggestions.Name = "txtUseSuggestions";
            this.txtUseSuggestions.Size = new System.Drawing.Size(979, 26);
            this.txtUseSuggestions.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "使用 建议和意见：";
            // 
            // txtDefectCondition
            // 
            this.txtDefectCondition.Location = new System.Drawing.Point(201, 145);
            this.txtDefectCondition.Name = "txtDefectCondition";
            this.txtDefectCondition.Size = new System.Drawing.Size(979, 26);
            this.txtDefectCondition.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "缺 陷 情况 反馈：";
            // 
            // txtFaultOperate
            // 
            this.txtFaultOperate.Location = new System.Drawing.Point(201, 103);
            this.txtFaultOperate.Name = "txtFaultOperate";
            this.txtFaultOperate.Size = new System.Drawing.Size(979, 26);
            this.txtFaultOperate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "故障操作情况反馈：";
            // 
            // txtSoftwareOperate
            // 
            this.txtSoftwareOperate.Location = new System.Drawing.Point(201, 62);
            this.txtSoftwareOperate.Name = "txtSoftwareOperate";
            this.txtSoftwareOperate.Size = new System.Drawing.Size(979, 26);
            this.txtSoftwareOperate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "软件操作情况反馈：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "客    户：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(131, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_退出);
            this.groupBox2.Controls.Add(this.button_清空);
            this.groupBox2.Controls.Add(this.button_提交);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(24, 500);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1295, 115);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息操作";
            // 
            // button_退出
            // 
            this.button_退出.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_退出.Location = new System.Drawing.Point(945, 54);
            this.button_退出.Name = "button_退出";
            this.button_退出.Size = new System.Drawing.Size(95, 30);
            this.button_退出.TabIndex = 14;
            this.button_退出.Text = "关 闭";
            this.button_退出.UseVisualStyleBackColor = true;
            this.button_退出.Click += new System.EventHandler(this.button_退出_Click);
            // 
            // button_清空
            // 
            this.button_清空.Location = new System.Drawing.Point(594, 54);
            this.button_清空.Name = "button_清空";
            this.button_清空.Size = new System.Drawing.Size(95, 30);
            this.button_清空.TabIndex = 13;
            this.button_清空.Text = "清  空";
            this.button_清空.UseVisualStyleBackColor = true;
            this.button_清空.Click += new System.EventHandler(this.button_清空_Click);
            // 
            // button_提交
            // 
            this.button_提交.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_提交.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_提交.Location = new System.Drawing.Point(186, 54);
            this.button_提交.Name = "button_提交";
            this.button_提交.Size = new System.Drawing.Size(95, 30);
            this.button_提交.TabIndex = 12;
            this.button_提交.Text = "提  交";
            this.button_提交.UseVisualStyleBackColor = false;
            this.button_提交.Click += new System.EventHandler(this.button_提交_Click);
            // 
            // Form_出厂设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.button_退出;
            this.ClientSize = new System.Drawing.Size(1331, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_出厂设置";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "出厂设置";
            this.Load += new System.EventHandler(this.Form_出厂设置_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_退出;
        private System.Windows.Forms.Button button_清空;
        private System.Windows.Forms.Button button_提交;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.TextBox txtUseDuration;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbUID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHardwareOperate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUseSuggestions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDefectCondition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFaultOperate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoftwareOperate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCID;
    }
}