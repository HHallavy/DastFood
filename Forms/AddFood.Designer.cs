namespace DastFood.forms
{
    partial class AddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.FoodName = new System.Windows.Forms.TextBox();
            this.chooseIngredients = new System.Windows.Forms.Button();
            this.FoodSelfService = new System.Windows.Forms.CheckBox();
            this.FoodCategory = new System.Windows.Forms.ComboBox();
            this.FoodDetails = new System.Windows.Forms.TextBox();
            this.listIngredients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(151, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام غذا";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(151, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "مواد اولیه";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(151, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "جزییات";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(151, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "نام دسته";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold);
            this.OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OK.Location = new System.Drawing.Point(-4, 454);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(82, 35);
            this.OK.TabIndex = 4;
            this.OK.Text = "تایید";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // FoodName
            // 
            this.FoodName.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            this.FoodName.Location = new System.Drawing.Point(78, 47);
            this.FoodName.Multiline = true;
            this.FoodName.Name = "FoodName";
            this.FoodName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoodName.Size = new System.Drawing.Size(158, 32);
            this.FoodName.TabIndex = 5;
            // 
            // chooseIngredients
            // 
            this.chooseIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chooseIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseIngredients.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold);
            this.chooseIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chooseIngredients.Location = new System.Drawing.Point(27, 124);
            this.chooseIngredients.Name = "chooseIngredients";
            this.chooseIngredients.Size = new System.Drawing.Size(45, 28);
            this.chooseIngredients.TabIndex = 7;
            this.chooseIngredients.Text = "تغییر";
            this.chooseIngredients.UseVisualStyleBackColor = false;
            this.chooseIngredients.Click += new System.EventHandler(this.chooseIngredients_Click);
            // 
            // FoodSelfService
            // 
            this.FoodSelfService.AutoSize = true;
            this.FoodSelfService.BackColor = System.Drawing.Color.Transparent;
            this.FoodSelfService.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FoodSelfService.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold);
            this.FoodSelfService.ForeColor = System.Drawing.Color.White;
            this.FoodSelfService.Location = new System.Drawing.Point(12, 206);
            this.FoodSelfService.Name = "FoodSelfService";
            this.FoodSelfService.Size = new System.Drawing.Size(95, 25);
            this.FoodSelfService.TabIndex = 8;
            this.FoodSelfService.Text = "سلف سرویس";
            this.FoodSelfService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FoodSelfService.UseVisualStyleBackColor = false;
            // 
            // FoodCategory
            // 
            this.FoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FoodCategory.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.FoodCategory.FormattingEnabled = true;
            this.FoodCategory.Location = new System.Drawing.Point(40, 266);
            this.FoodCategory.Name = "FoodCategory";
            this.FoodCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoodCategory.Size = new System.Drawing.Size(196, 34);
            this.FoodCategory.TabIndex = 9;
            // 
            // FoodDetails
            // 
            this.FoodDetails.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FoodDetails.Location = new System.Drawing.Point(40, 335);
            this.FoodDetails.MaxLength = 170;
            this.FoodDetails.Multiline = true;
            this.FoodDetails.Name = "FoodDetails";
            this.FoodDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoodDetails.Size = new System.Drawing.Size(196, 99);
            this.FoodDetails.TabIndex = 11;
            // 
            // listIngredients
            // 
            this.listIngredients.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.ItemHeight = 24;
            this.listIngredients.Location = new System.Drawing.Point(78, 124);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listIngredients.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listIngredients.Size = new System.Drawing.Size(158, 76);
            this.listIngredients.TabIndex = 12;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(293, 489);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.chooseIngredients);
            this.Controls.Add(this.listIngredients);
            this.Controls.Add(this.FoodDetails);
            this.Controls.Add(this.FoodCategory);
            this.Controls.Add(this.FoodSelfService);
            this.Controls.Add(this.FoodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddFood";
            this.Text = "اضافه کردن غذا";
            this.Load += new System.EventHandler(this.AddFood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox FoodName;
        private System.Windows.Forms.Button chooseIngredients;
        private System.Windows.Forms.CheckBox FoodSelfService;
        private System.Windows.Forms.ComboBox FoodCategory;
        private System.Windows.Forms.TextBox FoodDetails;
        public  System.Windows.Forms.ListBox listIngredients;
    }
}