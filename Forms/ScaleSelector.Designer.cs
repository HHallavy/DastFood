namespace DastFood.forms
{
    partial class ScaleSelector
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
            this.biggerScale = new System.Windows.Forms.Button();
            this.smallerScale = new System.Windows.Forms.Button();
            this.ingScale = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // biggerScale
            // 
            this.biggerScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.biggerScale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.biggerScale.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.biggerScale.Location = new System.Drawing.Point(12, 50);
            this.biggerScale.Name = "biggerScale";
            this.biggerScale.Size = new System.Drawing.Size(95, 34);
            this.biggerScale.TabIndex = 0;
            this.biggerScale.Text = "واحد بزرگتر";
            this.biggerScale.UseVisualStyleBackColor = false;
            this.biggerScale.Click += new System.EventHandler(this.biggerScale_Click);
            // 
            // smallerScale
            // 
            this.smallerScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.smallerScale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.smallerScale.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.smallerScale.Location = new System.Drawing.Point(118, 50);
            this.smallerScale.Name = "smallerScale";
            this.smallerScale.Size = new System.Drawing.Size(95, 34);
            this.smallerScale.TabIndex = 1;
            this.smallerScale.Text = "واحد کوچکتر";
            this.smallerScale.UseVisualStyleBackColor = false;
            this.smallerScale.Click += new System.EventHandler(this.smallerScale_Click);
            // 
            // ingScale
            // 
            this.ingScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ingScale.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ingScale.FormattingEnabled = true;
            this.ingScale.Items.AddRange(new object[] {
            "دانه",
            "کیلوگرم",
            "گرم",
            "لیتر",
            "میلی لیتر",
            "بسته 5 تایی",
            "بسته"});
            this.ingScale.Location = new System.Drawing.Point(12, 12);
            this.ingScale.Name = "ingScale";
            this.ingScale.Size = new System.Drawing.Size(201, 32);
            this.ingScale.TabIndex = 2;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OK.Location = new System.Drawing.Point(12, 101);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(70, 34);
            this.OK.TabIndex = 3;
            this.OK.Text = "تایید";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ScaleSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(225, 147);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.ingScale);
            this.Controls.Add(this.smallerScale);
            this.Controls.Add(this.biggerScale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScaleSelector";
            this.Text = "انتخاب واحد شمارش";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button biggerScale;
        private System.Windows.Forms.Button smallerScale;
        private System.Windows.Forms.ComboBox ingScale;
        private System.Windows.Forms.Button OK;
    }
}