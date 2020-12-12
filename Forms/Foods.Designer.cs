namespace DastFood.forms
{
    partial class Foods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foods));
            this.btnNewFood = new System.Windows.Forms.Button();
            this.btnEditFoods = new System.Windows.Forms.Button();
            this.btnPrintMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewFood
            // 
            this.btnNewFood.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewFood.Image = ((System.Drawing.Image)(resources.GetObject("btnNewFood.Image")));
            this.btnNewFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewFood.Location = new System.Drawing.Point(11, 12);
            this.btnNewFood.Name = "btnNewFood";
            this.btnNewFood.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNewFood.Size = new System.Drawing.Size(182, 61);
            this.btnNewFood.TabIndex = 0;
            this.btnNewFood.Text = "غذای جدید";
            this.btnNewFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewFood.UseVisualStyleBackColor = true;
            this.btnNewFood.Click += new System.EventHandler(this.btnNewFood_Click);
            // 
            // btnEditFoods
            // 
            this.btnEditFoods.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditFoods.Image = ((System.Drawing.Image)(resources.GetObject("btnEditFoods.Image")));
            this.btnEditFoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFoods.Location = new System.Drawing.Point(11, 81);
            this.btnEditFoods.Name = "btnEditFoods";
            this.btnEditFoods.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditFoods.Size = new System.Drawing.Size(182, 61);
            this.btnEditFoods.TabIndex = 1;
            this.btnEditFoods.Text = "ویرایش غذاها";
            this.btnEditFoods.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditFoods.UseVisualStyleBackColor = true;
            this.btnEditFoods.Click += new System.EventHandler(this.btnEditFoods_Click);
            // 
            // btnPrintMenu
            // 
            this.btnPrintMenu.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrintMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintMenu.Image")));
            this.btnPrintMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintMenu.Location = new System.Drawing.Point(11, 150);
            this.btnPrintMenu.Name = "btnPrintMenu";
            this.btnPrintMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrintMenu.Size = new System.Drawing.Size(182, 61);
            this.btnPrintMenu.TabIndex = 2;
            this.btnPrintMenu.Text = "چاپ منوی غذا";
            this.btnPrintMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintMenu.UseVisualStyleBackColor = true;
            this.btnPrintMenu.Visible = false;
            // 
            // Foods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(205, 221);
            this.Controls.Add(this.btnPrintMenu);
            this.Controls.Add(this.btnEditFoods);
            this.Controls.Add(this.btnNewFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Foods";
            this.Text = "غذا ها";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewFood;
        private System.Windows.Forms.Button btnEditFoods;
        private System.Windows.Forms.Button btnPrintMenu;
    }
}