namespace DastFood.forms
{
    partial class EditIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditIngredients));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IngName = new System.Windows.Forms.TextBox();
            this.IngScale = new System.Windows.Forms.Label();
            this.btnSelectScale = new System.Windows.Forms.Button();
            this.IngQuantity = new System.Windows.Forms.TextBox();
            this.IngExpireDate = new System.Windows.Forms.Label();
            this.btnSelectDate = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(192, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام ماده اولیه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(240, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "مقدار";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(184, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "واحد شمارش ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(202, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "تاریخ انقضا";
            // 
            // IngName
            // 
            this.IngName.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.IngName.Location = new System.Drawing.Point(12, 28);
            this.IngName.MaxLength = 100;
            this.IngName.Multiline = true;
            this.IngName.Name = "IngName";
            this.IngName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IngName.Size = new System.Drawing.Size(151, 34);
            this.IngName.TabIndex = 4;
            this.IngName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IngScale
            // 
            this.IngScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IngScale.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.IngScale.ForeColor = System.Drawing.Color.Black;
            this.IngScale.Location = new System.Drawing.Point(111, 165);
            this.IngScale.Name = "IngScale";
            this.IngScale.Size = new System.Drawing.Size(176, 34);
            this.IngScale.TabIndex = 5;
            this.IngScale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectScale
            // 
            this.btnSelectScale.BackColor = System.Drawing.Color.Lime;
            this.btnSelectScale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectScale.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectScale.ForeColor = System.Drawing.Color.Black;
            this.btnSelectScale.Location = new System.Drawing.Point(39, 164);
            this.btnSelectScale.Name = "btnSelectScale";
            this.btnSelectScale.Size = new System.Drawing.Size(75, 36);
            this.btnSelectScale.TabIndex = 6;
            this.btnSelectScale.Text = "انتخاب";
            this.btnSelectScale.UseVisualStyleBackColor = false;
            this.btnSelectScale.Click += new System.EventHandler(this.btnSelectScale_Click);
            // 
            // IngQuantity
            // 
            this.IngQuantity.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.IngQuantity.Location = new System.Drawing.Point(12, 242);
            this.IngQuantity.MaxLength = 35;
            this.IngQuantity.Multiline = true;
            this.IngQuantity.Name = "IngQuantity";
            this.IngQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IngQuantity.ShortcutsEnabled = false;
            this.IngQuantity.Size = new System.Drawing.Size(151, 34);
            this.IngQuantity.TabIndex = 7;
            this.IngQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IngQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngQuantity_KeyPress);
            // 
            // IngExpireDate
            // 
            this.IngExpireDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.IngExpireDate.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.IngExpireDate.ForeColor = System.Drawing.Color.Black;
            this.IngExpireDate.Location = new System.Drawing.Point(111, 363);
            this.IngExpireDate.Name = "IngExpireDate";
            this.IngExpireDate.Size = new System.Drawing.Size(171, 35);
            this.IngExpireDate.TabIndex = 8;
            this.IngExpireDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectDate
            // 
            this.btnSelectDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSelectDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectDate.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectDate.ForeColor = System.Drawing.Color.Black;
            this.btnSelectDate.Location = new System.Drawing.Point(39, 363);
            this.btnSelectDate.Name = "btnSelectDate";
            this.btnSelectDate.Size = new System.Drawing.Size(75, 36);
            this.btnSelectDate.TabIndex = 9;
            this.btnSelectDate.Text = "انتخاب";
            this.btnSelectDate.UseVisualStyleBackColor = false;
            this.btnSelectDate.Click += new System.EventHandler(this.btnSelectDate_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OK.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.OK.Location = new System.Drawing.Point(12, 444);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(78, 30);
            this.OK.TabIndex = 10;
            this.OK.Text = "ویرایش";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // EditIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(307, 486);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.btnSelectDate);
            this.Controls.Add(this.IngExpireDate);
            this.Controls.Add(this.IngQuantity);
            this.Controls.Add(this.btnSelectScale);
            this.Controls.Add(this.IngScale);
            this.Controls.Add(this.IngName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditIngredients";
            this.Text = "ویرایش مواد اولیه";
            this.Load += new System.EventHandler(this.EditIngredients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IngName;
        public System.Windows.Forms.Label IngScale;
        private System.Windows.Forms.Button btnSelectScale;
        private System.Windows.Forms.TextBox IngQuantity;
        private System.Windows.Forms.Label IngExpireDate;
        private System.Windows.Forms.Button btnSelectDate;
        private System.Windows.Forms.Button OK;
    }
}