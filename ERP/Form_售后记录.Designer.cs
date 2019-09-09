namespace ERP
{
    partial class Form_售后记录
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAfterSales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfterSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAfterSales
            // 
            this.dgvAfterSales.AllowUserToAddRows = false;
            this.dgvAfterSales.AllowUserToDeleteRows = false;
            this.dgvAfterSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAfterSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAfterSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvAfterSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAfterSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAfterSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAfterSales.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAfterSales.Location = new System.Drawing.Point(-2, 43);
            this.dgvAfterSales.MultiSelect = false;
            this.dgvAfterSales.Name = "dgvAfterSales";
            this.dgvAfterSales.ReadOnly = true;
            this.dgvAfterSales.RowHeadersVisible = false;
            this.dgvAfterSales.RowTemplate.Height = 23;
            this.dgvAfterSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAfterSales.Size = new System.Drawing.Size(1369, 699);
            this.dgvAfterSales.TabIndex = 1;
            // 
            // Form_售后记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 743);
            this.Controls.Add(this.dgvAfterSales);
            this.Name = "Form_售后记录";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "售后";
            this.Load += new System.EventHandler(this.Form_售后记录_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfterSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAfterSales;
    }
}