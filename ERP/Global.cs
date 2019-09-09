using ERP.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace ERP
{
    public static class Global
    {
        //用户数据行对象
        public static DataRow user;

        //当前活动窗体对象
        public static Form _form;

        public static Form form
        {
            get
            {   
                return _form;
            }
            set
            {
                _form = value;
                //设置窗体图标
                _form.Icon = new Icon(Application.StartupPath + @"\Resources\ERP.ico");
                //设置窗体透明度
                _form.Opacity = 1.00;
            }
        }

        /// <summary>
        /// 对控件进行设置
        /// </summary>
        /// <param name="controls">控件集合</param>
        public static void SetControls(ControlCollection controls)
        {
            //遍历设置控件
            foreach (Control control in controls)
            {
                //下拉框
                if (control.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)control).FlatStyle = FlatStyle.Flat;

                }
                //文本框
                else if (control.GetType() == typeof(TextBox))
                {
                    // ((TextBox)control).BorderStyle = BorderStyle.None;
                    // ((TextBox)control).Font = new Font("宋体", 15);

                }
                //时间选择器
                else if (control.GetType() == typeof(DateTimePicker))
                {

                }
                //按钮
                else if (control.GetType() == typeof(Button))
                {
                    ((Button)control).BackColor = Color.DodgerBlue;
                    ((Button)control).ForeColor = Color.White;
                    ((Button)control).FlatStyle = FlatStyle.Flat;
                    ((Button)control).FlatAppearance.BorderSize = 1;
                    ((Button)control).FlatAppearance.BorderColor = Color.DodgerBlue;

                }
                //分组框
                else if (control.GetType() == typeof(GroupBox))
                {
                    SetControls(control.Controls);
                }
                //面板
                else if (control.GetType() == typeof(Panel))
                {
                    SetControls(control.Controls);
                }
                //标签
                else if (control.GetType() == typeof(Label))
                {
                    ((Label)control).ForeColor = System.Drawing.Color.SlateGray;
                }
                //单选按钮
                else if (control.GetType() == typeof(RadioButton))
                {
                    
                }
                //复选框
                else if (control.GetType() == typeof(CheckBox))
                {
                    
                }


            }


        }

        /// <summary>
        /// 清空控件
        /// </summary>
        /// <param name="controls">控件集合</param>
        public static void ResetControls(ControlCollection controls)
        {
            //遍历设置控件
            foreach (Control control in controls)
            {
                //下拉框
                if (control.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)control).SelectedIndex = -1;

                }
                //文本框
                else if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).Text = "";

                }
                //时间选择器
                else if (control.GetType() == typeof(DateTimePicker))
                {

                }
                //按钮
                else if (control.GetType() == typeof(Button))
                {


                }
                //分组框
                else if (control.GetType() == typeof(GroupBox))
                {
                    ResetControls(control.Controls);
                }
                //标签
                else if (control.GetType() == typeof(Label))
                {



                }
                //单选按钮
                else if (control.GetType() == typeof(RadioButton))
                {
                    ((RadioButton)control).Checked = false;
                }

            }

        }

        /// <summary>
        /// 导出到Excel文件
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="path">保存路径</param>
        /// <returns></returns>
        public static bool ExportExcelWithAspose(System.Data.DataTable dt, string path)
        {

            
            bool succeed = false;
            if (dt != null)
            {
                try
                {
                    Aspose.Cells.License li = new Aspose.Cells.License();
                    //设置破解DLL的许可证
                    li.SetLicense(Application.StartupPath+ @"\Resources\License.lic");
                    Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook();
                    Aspose.Cells.Worksheet cellSheet = workbook.Worksheets[0];

                    cellSheet.Name = dt.TableName;

                    int rowIndex = 0;
                    int colIndex = 0;
                    int colCount = dt.Columns.Count;
                    int rowCount = dt.Rows.Count;

                    //列名的处理
                    for (int i = 0; i < colCount; i++)
                    {
                        cellSheet.Cells[rowIndex, colIndex].PutValue(dt.Columns[i].ColumnName);
                        cellSheet.Cells[rowIndex, colIndex].Style.Font.IsBold = true;
                        cellSheet.Cells[rowIndex, colIndex].Style.Font.Name = "宋体";
                        colIndex++;
                    }

                    Aspose.Cells.Style style = workbook.Styles[workbook.Styles.Add()];
                    style.Font.Name = "Arial";
                    style.Font.Size = 10;
                    Aspose.Cells.StyleFlag styleFlag = new Aspose.Cells.StyleFlag();
                    cellSheet.Cells.ApplyStyle(style, styleFlag);

                    rowIndex++;

                    for (int i = 0; i < rowCount; i++)
                    {
                        colIndex = 0;
                        for (int j = 0; j < colCount; j++)
                        {
                            cellSheet.Cells[rowIndex, colIndex].PutValue(dt.Rows[i][j].ToString());
                            colIndex++;
                        }
                        rowIndex++;
                    }
                    cellSheet.AutoFitColumns();

                    path = Path.GetFullPath(path);
                    workbook.Save(path);
                    succeed = true;
                }
                catch (Exception)
                {
                    succeed = false;
                }
            }

            return succeed;
        }


















    }
}
