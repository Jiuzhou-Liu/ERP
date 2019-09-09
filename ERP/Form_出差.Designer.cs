namespace ERP
{
    partial class Form_出差
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
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTool = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.dtpDateBegin = new System.Windows.Forms.DateTimePicker();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.dtpSetOutDate = new System.Windows.Forms.DateTimePicker();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnEsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(189, 72);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(282, 21);
            this.txtPlace.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "出差日期 *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "出差地点 *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "医院名称 *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "出发时间 *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "出差工具";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "所需费用";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "出差事由 *";
            // 
            // txtTool
            // 
            this.txtTool.Location = new System.Drawing.Point(189, 147);
            this.txtTool.Name = "txtTool";
            this.txtTool.Size = new System.Drawing.Size(282, 21);
            this.txtTool.TabIndex = 0;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(189, 226);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(62, 21);
            this.txtCost.TabIndex = 0;
            this.txtCost.Leave += new System.EventHandler(this.txtCost_Leave);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(189, 277);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(282, 126);
            this.txtReason.TabIndex = 0;
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.CustomFormat = "yyyy/MM/dd HH时";
            this.dtpDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBegin.Location = new System.Drawing.Point(189, 38);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Size = new System.Drawing.Size(131, 21);
            this.dtpDateBegin.TabIndex = 2;
            this.dtpDateBegin.Value = new System.DateTime(2019, 5, 24, 14, 48, 16, 0);
            // 
            // cmbHospital
            // 
            this.cmbHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHospital.Location = new System.Drawing.Point(189, 110);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(282, 20);
            this.cmbHospital.TabIndex = 3;
            // 
            // dtpSetOutDate
            // 
            this.dtpSetOutDate.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpSetOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSetOutDate.Location = new System.Drawing.Point(189, 185);
            this.dtpSetOutDate.Name = "dtpSetOutDate";
            this.dtpSetOutDate.Size = new System.Drawing.Size(148, 21);
            this.dtpSetOutDate.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(388, 434);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 30);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "提交";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "-";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.CustomFormat = "yyyy/MM/dd HH时";
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateEnd.Location = new System.Drawing.Point(343, 38);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(128, 21);
            this.dtpDateEnd.TabIndex = 2;
            this.dtpDateEnd.Value = new System.DateTime(2019, 5, 24, 14, 48, 16, 0);
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(478, 434);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 30);
            this.btnEsc.TabIndex = 6;
            this.btnEsc.Text = "关闭";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // Form_出差
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnEsc;
            this.ClientSize = new System.Drawing.Size(572, 483);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cmbHospital);
            this.Controls.Add(this.dtpSetOutDate);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.dtpDateBegin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtTool);
            this.Controls.Add(this.txtPlace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_出差";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "出差";
            this.Load += new System.EventHandler(this.Form_出差_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTool;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.DateTimePicker dtpDateBegin;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.DateTimePicker dtpSetOutDate;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Button btnEsc;
    }
}