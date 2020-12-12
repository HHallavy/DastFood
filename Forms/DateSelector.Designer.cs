namespace DastFood.forms
{
    partial class DateSelector
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
            this.day = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.manualDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            this.day.Location = new System.Drawing.Point(200, 23);
            this.day.MaxLength = 2;
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(56, 31);
            this.day.TabIndex = 0;
            this.day.Text = "روز";
            this.day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day.TextChanged += new System.EventHandler(this.DateInput_Changed);
            this.day.DoubleClick += new System.EventHandler(this.day_DoubleClick);
            this.day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            this.year.Location = new System.Drawing.Point(12, 23);
            this.year.MaxLength = 4;
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(56, 31);
            this.year.TabIndex = 1;
            this.year.Text = "سال";
            this.year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.year.TextChanged += new System.EventHandler(this.DateInput_Changed);
            this.year.DoubleClick += new System.EventHandler(this.year_DoubleClick);
            this.year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // month
            // 
            this.month.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.month.FormattingEnabled = true;
            this.month.Items.AddRange(new object[] {
            "1-فروردین",
            "2-اردیبهشت",
            "3-خرداد",
            "4-تیر",
            "5-مرداد",
            "6-شهریور",
            "7-مهر",
            "8-آبان",
            "9-آذر",
            "10-دی",
            "11-بهمن",
            "12-اسفند"});
            this.month.Location = new System.Drawing.Point(74, 23);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(121, 32);
            this.month.TabIndex = 2;
            this.month.SelectedIndexChanged += new System.EventHandler(this.DateInput_Changed);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OK.Location = new System.Drawing.Point(12, 88);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(70, 34);
            this.OK.TabIndex = 5;
            this.OK.Text = "تایید";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // manualDate
            // 
            this.manualDate.AsciiOnly = true;
            this.manualDate.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.manualDate.Location = new System.Drawing.Point(115, 83);
            this.manualDate.Mask = "####/##/##";
            this.manualDate.Name = "manualDate";
            this.manualDate.Size = new System.Drawing.Size(96, 28);
            this.manualDate.TabIndex = 6;
            this.manualDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.manualDate.TextChanged += new System.EventHandler(this.manualDate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(217, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "دستی";
            // 
            // DateSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(268, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manualDate);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.day);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DateSelector";
            this.Text = "انتخاب تاریخ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DateSelector_FormClosed);
            this.Load += new System.EventHandler(this.DateSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.ComboBox month;
        public  System.Windows.Forms.Button OK;
        public  System.Windows.Forms.MaskedTextBox manualDate;
        private System.Windows.Forms.Label label1;
    }
}