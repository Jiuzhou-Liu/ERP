namespace ERP
{
    partial class Form_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.button_登录 = new System.Windows.Forms.Button();
            this.button_退出 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_登录
            // 
            this.button_登录.BackColor = System.Drawing.Color.Transparent;
            this.button_登录.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_登录.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_登录.Location = new System.Drawing.Point(171, 288);
            this.button_登录.Name = "button_登录";
            this.button_登录.Size = new System.Drawing.Size(73, 30);
            this.button_登录.TabIndex = 0;
            this.button_登录.Text = "登录";
            this.button_登录.UseVisualStyleBackColor = false;
            this.button_登录.Click += new System.EventHandler(this.button_登录_Click);
            this.button_登录.Enter += new System.EventHandler(this.button_登录_Enter);
            // 
            // button_退出
            // 
            this.button_退出.BackColor = System.Drawing.Color.Transparent;
            this.button_退出.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_退出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_退出.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_退出.Location = new System.Drawing.Point(292, 288);
            this.button_退出.Name = "button_退出";
            this.button_退出.Size = new System.Drawing.Size(73, 30);
            this.button_退出.TabIndex = 3;
            this.button_退出.Text = "退出";
            this.button_退出.UseVisualStyleBackColor = false;
            this.button_退出.Click += new System.EventHandler(this.button_退出_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.Location = new System.Drawing.Point(171, 160);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 30);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "用户名";
            this.txtName.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.txtName_HelpRequested);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPass.Location = new System.Drawing.Point(171, 214);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(194, 30);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "密码";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // Form_Login
            // 
            this.AcceptButton = this.button_登录;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::ERP.Properties.Resources.LoginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_退出;
            this.ClientSize = new System.Drawing.Size(535, 354);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_退出);
            this.Controls.Add(this.button_登录);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 392);
            this.MinimumSize = new System.Drawing.Size(551, 392);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.Click += new System.EventHandler(this.Form_Login_Click);
            this.Enter += new System.EventHandler(this.Form_Login_Enter);
            this.Leave += new System.EventHandler(this.Form_Login_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_登录;
        private System.Windows.Forms.Button button_退出;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
    }
}

