﻿namespace Form_BaoCaoDoanhThu
{
    partial class Form_Baocaodoanhthu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_Doannthu = new Label();
            lb_thang = new Label();
            cbbox_thang = new ComboBox();
            lv_DS = new ListView();
            STT = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // lb_Doannthu
            // 
            lb_Doannthu.BackColor = SystemColors.ActiveCaption;
            lb_Doannthu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Doannthu.Location = new Point(105, 11);
            lb_Doannthu.Name = "lb_Doannthu";
            lb_Doannthu.Size = new Size(413, 23);
            lb_Doannthu.TabIndex = 0;
            lb_Doannthu.Text = "Báo Cáo Doanh Thu Theo Loại Phòng";
            lb_Doannthu.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb_thang
            // 
            lb_thang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_thang.Location = new Point(175, 45);
            lb_thang.Name = "lb_thang";
            lb_thang.Size = new Size(100, 23);
            lb_thang.TabIndex = 1;
            lb_thang.Text = "Tháng :";
            lb_thang.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbbox_thang
            // 
            cbbox_thang.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_thang.FormattingEnabled = true;
            cbbox_thang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbbox_thang.Location = new Point(258, 45);
            cbbox_thang.Name = "cbbox_thang";
            cbbox_thang.Size = new Size(121, 28);
            cbbox_thang.TabIndex = 2;
            // 
            // lv_DS
            // 
            lv_DS.Columns.AddRange(new ColumnHeader[] { STT, columnHeader2, columnHeader3, columnHeader4 });
            lv_DS.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lv_DS.GridLines = true;
            lv_DS.Location = new Point(0, 84);
            lv_DS.Name = "lv_DS";
            lv_DS.Size = new Size(625, 333);
            lv_DS.TabIndex = 3;
            lv_DS.UseCompatibleStateImageBehavior = false;
            lv_DS.View = View.Details;
            // 
            // STT
            // 
            STT.Text = "STT";
            STT.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Loại Phòng";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Doanh Thu";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tỉ Lệ";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 200;
            // 
            // Form_Baocaodoanhthu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 430);
            Controls.Add(lv_DS);
            Controls.Add(cbbox_thang);
            Controls.Add(lb_thang);
            Controls.Add(lb_Doannthu);
            Name = "Form_Baocaodoanhthu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lb_Doannthu;
        private Label lb_thang;
        private ComboBox cbbox_thang;
        private ListView lv_DS;
        private ColumnHeader STT;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
