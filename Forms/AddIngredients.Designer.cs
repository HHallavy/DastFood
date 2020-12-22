namespace DastFood.forms
{
    partial class AddIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngredients));
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Mitra", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(3)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(199, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام ماده اولیه";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Mitra", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(3)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(199, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "مقدار";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Mitra", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(3)))));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(199, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "واحد شمارش ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Mitra", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(3)))));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(199, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "تاریخ انقضا";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IngName
            // 
            this.IngName.BackColor = System.Drawing.Color.White;
            this.IngName.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.IngName.ForeColor = System.Drawing.Color.Black;
            this.IngName.Location = new System.Drawing.Point(115, 122);
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
            this.IngScale.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.IngScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IngScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngScale.Font = new System.Drawing.Font("Samim", 11F);
            this.IngScale.ForeColor = System.Drawing.Color.Black;
            this.IngScale.Location = new System.Drawing.Point(115, 194);
            this.IngScale.Name = "IngScale";
            this.IngScale.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.IngScale.Size = new System.Drawing.Size(151, 34);
            this.IngScale.TabIndex = 5;
            this.IngScale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectScale
            // 
            this.btnSelectScale.BackColor = System.Drawing.Color.White;
            this.btnSelectScale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectScale.Font = new System.Drawing.Font("Samim", 11F);
            this.btnSelectScale.ForeColor = System.Drawing.Color.Black;
            this.btnSelectScale.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectScale.Image")));
            this.btnSelectScale.Location = new System.Drawing.Point(115, 194);
            this.btnSelectScale.Name = "btnSelectScale";
            this.btnSelectScale.Size = new System.Drawing.Size(27, 34);
            this.btnSelectScale.TabIndex = 6;
            this.btnSelectScale.UseVisualStyleBackColor = false;
            this.btnSelectScale.Click += new System.EventHandler(this.btnSelectScale_Click);
            // 
            // IngQuantity
            // 
            this.IngQuantity.BackColor = System.Drawing.Color.White;
            this.IngQuantity.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.IngQuantity.ForeColor = System.Drawing.Color.Black;
            this.IngQuantity.Location = new System.Drawing.Point(115, 272);
            this.IngQuantity.MaxLength = 35;
            this.IngQuantity.Multiline = true;
            this.IngQuantity.Name = "IngQuantity";
            this.IngQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IngQuantity.ShortcutsEnabled = false;
            this.IngQuantity.Size = new System.Drawing.Size(151, 34);
            this.IngQuantity.TabIndex = 7;
            this.IngQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IngQuantity.TextChanged += new System.EventHandler(this.IngQuantity_TextChanged);
            this.IngQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngQuantity_KeyPress);
            // 
            // IngExpireDate
            // 
            this.IngExpireDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.IngExpireDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IngExpireDate.Font = new System.Drawing.Font("Samim", 11F);
            this.IngExpireDate.ForeColor = System.Drawing.Color.Black;
            this.IngExpireDate.Location = new System.Drawing.Point(115, 344);
            this.IngExpireDate.Name = "IngExpireDate";
            this.IngExpireDate.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.IngExpireDate.Size = new System.Drawing.Size(151, 35);
            this.IngExpireDate.TabIndex = 8;
            this.IngExpireDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectDate
            // 
            this.btnSelectDate.BackColor = System.Drawing.Color.White;
            this.btnSelectDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectDate.Font = new System.Drawing.Font("Samim", 11F);
            this.btnSelectDate.ForeColor = System.Drawing.Color.Black;
            this.btnSelectDate.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectDate.Image")));
            this.btnSelectDate.Location = new System.Drawing.Point(115, 344);
            this.btnSelectDate.Name = "btnSelectDate";
            this.btnSelectDate.Size = new System.Drawing.Size(27, 35);
            this.btnSelectDate.TabIndex = 9;
            this.btnSelectDate.UseVisualStyleBackColor = false;
            this.btnSelectDate.Click += new System.EventHandler(this.btnSelectDate_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Font = new System.Drawing.Font("Samim", 14F);
            this.OK.ForeColor = System.Drawing.Color.Black;
            this.OK.Image = ((System.Drawing.Image)(resources.GetObject("OK.Image")));
            this.OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OK.Location = new System.Drawing.Point(12, 432);
            this.OK.Name = "OK";
            this.OK.Padding = new System.Windows.Forms.Padding(3);
            this.OK.Size = new System.Drawing.Size(104, 42);
            this.OK.TabIndex = 10;
            this.OK.Text = "تایـیـد";
            this.OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // AddIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(389, 486);
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
            this.Name = "AddIngredients";
            this.Text = "اضافه کردن ماده اولیه";
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