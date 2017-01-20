using System;
using System.Collections.Generic;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace BatteryCharge
{
   

    public partial class View : Form, IView
    {
        #region Элементы управления
        private TextBox batteryStatusBox;
        private TextBox powerStatusBox;
        private TextBox dateTimeBox;
        private Timer timer;
        private System.ComponentModel.IContainer components;
        private PictureBox diagrammaPictureBox;
        private TextBox batteryPercentBox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button exportButton;
        private RadioButton radioButton3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private SaveFileDialog saveFileDialog1;
        private Panel panel1;
        private PictureBox timeAndValuePictureBox;
        private NotifyIcon notifyIcon1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.batteryPercentBox = new System.Windows.Forms.TextBox();
            this.batteryStatusBox = new System.Windows.Forms.TextBox();
            this.powerStatusBox = new System.Windows.Forms.TextBox();
            this.dateTimeBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.diagrammaPictureBox = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.exportButton = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeAndValuePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.diagrammaPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeAndValuePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // batteryPercentBox
            // 
            this.batteryPercentBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batteryPercentBox.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.batteryPercentBox.Location = new System.Drawing.Point(20, 76);
            this.batteryPercentBox.Name = "batteryPercentBox";
            this.batteryPercentBox.ReadOnly = true;
            this.batteryPercentBox.Size = new System.Drawing.Size(150, 20);
            this.batteryPercentBox.TabIndex = 0;
            this.batteryPercentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // batteryStatusBox
            // 
            this.batteryStatusBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batteryStatusBox.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.batteryStatusBox.Location = new System.Drawing.Point(20, 156);
            this.batteryStatusBox.Name = "batteryStatusBox";
            this.batteryStatusBox.ReadOnly = true;
            this.batteryStatusBox.Size = new System.Drawing.Size(150, 20);
            this.batteryStatusBox.TabIndex = 1;
            this.batteryStatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // powerStatusBox
            // 
            this.powerStatusBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.powerStatusBox.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerStatusBox.Location = new System.Drawing.Point(20, 116);
            this.powerStatusBox.Name = "powerStatusBox";
            this.powerStatusBox.ReadOnly = true;
            this.powerStatusBox.Size = new System.Drawing.Size(150, 20);
            this.powerStatusBox.TabIndex = 2;
            this.powerStatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimeBox.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeBox.Location = new System.Drawing.Point(20, 196);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.ReadOnly = true;
            this.dateTimeBox.Size = new System.Drawing.Size(150, 20);
            this.dateTimeBox.TabIndex = 3;
            this.dateTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // diagrammaPictureBox
            // 
            this.diagrammaPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diagrammaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diagrammaPictureBox.Location = new System.Drawing.Point(3, 3);
            this.diagrammaPictureBox.Name = "diagrammaPictureBox";
            this.diagrammaPictureBox.Size = new System.Drawing.Size(430, 161);
            this.diagrammaPictureBox.TabIndex = 5;
            this.diagrammaPictureBox.TabStop = false;
            this.diagrammaPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.diagrammaPictureBox_Paint);
            this.diagrammaPictureBox.MouseEnter += new System.EventHandler(this.diagrammaPictureBox_MouseEnter);
            this.diagrammaPictureBox.MouseLeave += new System.EventHandler(this.diagrammaPictureBox_MouseLeave);
            this.diagrammaPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.diagrammaPictureBox_MouseMove);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Батарея";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(227, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 18);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Все данные";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(325, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(131, 18);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "За последний час";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportButton.Location = new System.Drawing.Point(20, 18);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(150, 36);
            this.exportButton.TabIndex = 9;
            this.exportButton.Text = "Экспортировать данные в Excel";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(471, 27);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 18);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "За сутки";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Заряд батареи";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Подключение к сети";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Состояние батареи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Время снятия показаний";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.diagrammaPictureBox);
            this.panel1.Location = new System.Drawing.Point(199, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 191);
            this.panel1.TabIndex = 15;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            // 
            // timeAndValuePictureBox
            // 
            this.timeAndValuePictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeAndValuePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeAndValuePictureBox.Location = new System.Drawing.Point(202, 59);
            this.timeAndValuePictureBox.Name = "timeAndValuePictureBox";
            this.timeAndValuePictureBox.Size = new System.Drawing.Size(430, 26);
            this.timeAndValuePictureBox.TabIndex = 16;
            this.timeAndValuePictureBox.TabStop = false;
            this.timeAndValuePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.timeAndValuePictureBox_Paint);
            // 
            // View
            // 
            this.ClientSize = new System.Drawing.Size(654, 287);
            this.Controls.Add(this.timeAndValuePictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimeBox);
            this.Controls.Add(this.powerStatusBox);
            this.Controls.Add(this.batteryStatusBox);
            this.Controls.Add(this.batteryPercentBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 325);
            this.Name = "View";
            this.Text = "Батарея";
            this.Load += new System.EventHandler(this.View_Load);
            this.Resize += new System.EventHandler(this.View_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.diagrammaPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeAndValuePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private List<DataTableType> currentTable;
        private int moveX = -1, moveY = -1;
        private bool mouseLife = false;
        private Style style = new Style();
        private float indentX = 20, indentY = 25;

        public View()
        {
            InitializeComponent();
        }

        #region Интерфейс
        public event EventHandler<EventArgs> Tick;
        public event EventHandler<EventArgs> ChangeSelect;
        
        public void SetBatteryPercent(float value)
        {
            batteryPercentBox.Text = (value * 100).ToString("N2") + "%";
        }

        public void SetBatteryStatus(string value)
        {
            batteryStatusBox.Text = value;
        }

        public void SetPowerStatus(string value)
        {
            powerStatusBox.Text = value;
        }

        public void SetCurrent(DateTime value)
        {
            dateTimeBox.Text = value.ToString("F", CultureInfo.CreateSpecificCulture("ru-RU"));
        }

        public void SetListDataBattery(List<DataTableType> listTable)
        {
            currentTable = listTable;
            diagrammaPictureBox.Invalidate();
            timeAndValuePictureBox.Invalidate();
            exportButton.Enabled = true;
        }

        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Tick != null)
                Tick(this, e);
        }

        private void View_Load(object sender, EventArgs e)
        {

            notifyIcon1.Visible = false;
            timer.Start();
            exportButton.Enabled = false;
        }


        private void diagrammaPictureBox_Paint(object sender, PaintEventArgs e)
        {
            
            float OXx1, OXx2, OXy;
            OXx1 = 2;
            OXx2 = diagrammaPictureBox.Width - indentX;
            OXy = diagrammaPictureBox.Height - indentY;
            e.Graphics.DrawLine(style.axis, OXx1, OXy, OXx2, OXy);

            float OYy1, OYy2, OYx;
            OYx = indentX - 1;
            OYy1 = 15;
            OYy2 = diagrammaPictureBox.Height - indentY / 2;
            e.Graphics.DrawLine(style.axis, OYx, OYy1, OYx, OYy2);

            PointF s1 = new PointF(3, 5);
            PointF s2 = new PointF(diagrammaPictureBox.Width - 20, diagrammaPictureBox.Height - indentY);

            e.Graphics.DrawString("%", style.axisText, style.colorAxisText, s1);
            e.Graphics.DrawString("t", style.axisText, style.colorAxisText, s2);

            Pen penPower;
            float OY0 = diagrammaPictureBox.Height - indentY - 1;

            if (currentTable != null)
            {
                if (currentTable.Count + indentX * 2 >= diagrammaPictureBox.Width)
                    diagrammaPictureBox.Width += (currentTable.Count + (int)indentX * 2) - diagrammaPictureBox.Width;
                else
                    diagrammaPictureBox.Width = 430;
                for (int j = 0; j < currentTable.Count; j++)
                {
                    if (currentTable[j].PowerStatus == PowerLineStatus.Offline.ToString())
                    {
                        penPower = new Pen(Color.Red);
                    }
                    else if (currentTable[j].PowerStatus == PowerLineStatus.Online.ToString())
                    {
                        penPower = new Pen(Color.Green);
                    }
                    else
                    {
                        penPower = new Pen(Color.Gray);
                    }
                    e.Graphics.DrawLine(penPower, j + indentX, OY0, j + indentX, OY0 - currentTable[j].BatteryPercent * 100);
                }
                
                OXy = OY0 - 101;
                e.Graphics.DrawLine(style.maxPrPen, OXx1, OXy, OXx2, OXy);

                PointF s3 = new PointF(diagrammaPictureBox.Width / 2, OXy - 15);
                e.Graphics.DrawString("100%", style.maxPrText, style.colorMaxPrText, s3);
                if (mouseLife)
                {
                    e.Graphics.DrawLine(style.mouseAxis, 0, moveY, diagrammaPictureBox.Width, moveY);
                    e.Graphics.DrawLine(style.mouseAxis, moveX, 0, moveX, diagrammaPictureBox.Height);
                    
                }

            }
        }

        private void timeAndValuePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (currentTable != null)
            {
                if ((moveX - indentX) >= 0 && (moveX - indentX) < currentTable.Count)
                {
                    PointF point = new PointF(70, 5);
                    e.Graphics.DrawString(
                        currentTable[moveX - (int)indentX].Current.ToString("F", CultureInfo.CreateSpecificCulture("ru-RU")) +
                        ", заряд - " + (currentTable[moveX - (int)indentX].BatteryPercent * 100).ToString("N2") + "%",
                        style.valueText, style.colorValueText, point);
                }
            }
        }

        private void View_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            ShowInTaskbar = false;
            WindowState = FormWindowState.Normal;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                if (ChangeSelect != null)
                {
                    ChangeSelect(0, e);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                if (ChangeSelect != null)
                {
                    ChangeSelect(1, e);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                if (ChangeSelect != null)
                {
                    ChangeSelect(2, e);
                }
            }
        }

        private void diagrammaPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            moveX = e.X;
            moveY = e.Y;
            diagrammaPictureBox.Invalidate();
            timeAndValuePictureBox.Invalidate();
        }

        private void diagrammaPictureBox_MouseEnter(object sender, EventArgs e)
        {
            mouseLife = true;
        }

        private void diagrammaPictureBox_MouseLeave(object sender, EventArgs e)
        {
            mouseLife = false;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ExportDate();
        }

        private void ExportDate()
        {
            saveFileDialog1.Title = "Save file";
            saveFileDialog1.Filter = "Excel file|*.xls|All file|*.*";
            string filename = "Данные_с_" + currentTable[0].Current.ToString(
                    "F", CultureInfo.CreateSpecificCulture("ru-RU")
                    ).Replace(' ', '_').Replace('.','_').Replace(':', '-') + "_по_" + currentTable[currentTable.Count - 1].Current.ToString(
                   "F", CultureInfo.CreateSpecificCulture("ru-RU")
                   ).Replace(' ', '_').Replace('.', '_').Replace(':', '-') + ".xls";
            saveFileDialog1.FileName = filename;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                
                Excel.Application App = new Excel.Application();
                Excel.Workbook workBook;
                Excel.Worksheet workSheet;
                object misValue = System.Reflection.Missing.Value;
                //Книга.
                workBook = App.Workbooks.Add(misValue);
                //Таблица.
                workSheet = (Excel.Worksheet)workBook.Worksheets.Item[1];
                
                workSheet.Cells[1, 1] = "Время снятия показаний";
                workSheet.Cells[1, 2] = "Заряд батареи";
                workSheet.Cells[1, 3] = "Состояние батареи";
                workSheet.Cells[1, 4] = "Подключение к сети";
                for (int i = 0; i < currentTable.Count; i++)
                {
                    //Значения [y - строка,x - столбец]
                    workSheet.Cells[i + 2, 1] = currentTable[i].Current.ToString("F", CultureInfo.CreateSpecificCulture("ru-RU"));
                    workSheet.Cells[i + 2, 2] = (currentTable[i].BatteryPercent * 100).ToString("N2") + "%";
                    workSheet.Cells[i + 2, 3] = currentTable[i].BatteryStatus;
                    workSheet.Cells[i + 2, 4] = currentTable[i].PowerStatus;
                }
                workSheet.Columns.AutoFit();
                workBook.Saved = true;
                App.DisplayAlerts = false;
                workBook.SaveAs(filename,
                    misValue, misValue, misValue, misValue, misValue,
                    Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);


                workBook.Close(true, misValue, misValue);
                App.Quit();

                Marshal.ReleaseComObject(workSheet);
                Marshal.ReleaseComObject(workBook);
                Marshal.ReleaseComObject(App);
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            diagrammaPictureBox.Invalidate();
        }     
    }

    public class Style
    {
        public Font axisText;
        public Font maxPrText;
        public Font valueText;
        public Pen axis;
        public Pen maxPrPen;
        public Pen mouseAxis;
        public Brush colorValueText;
        public Brush colorAxisText;
        public Brush colorMaxPrText;
        public Style()
        {
            axisText = new Font("Georgia", 10, FontStyle.Bold | FontStyle.Italic);
            maxPrText = new Font("Georgia", 8, FontStyle.Italic);
            valueText = new Font("Georgia", 8);
            axis = new Pen(Color.Black);
            maxPrPen = new Pen(Color.Black);
            maxPrPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            mouseAxis = new Pen(Color.Gray);
            colorValueText = new SolidBrush(Color.Black);
            colorAxisText = new SolidBrush(Color.Black);
            colorMaxPrText = new SolidBrush(Color.Black);
        }
    }
}
