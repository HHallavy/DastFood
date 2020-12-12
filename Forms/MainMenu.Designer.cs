namespace DastFood
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.btnIngredients = new System.Windows.Forms.Button();
            this.btnFoods = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngredients
            // 
            this.btnIngredients.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnIngredients.Image = ((System.Drawing.Image)(resources.GetObject("btnIngredients.Image")));
            this.btnIngredients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngredients.Location = new System.Drawing.Point(12, 25);
            this.btnIngredients.Name = "btnIngredients";
            this.btnIngredients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIngredients.Size = new System.Drawing.Size(182, 61);
            this.btnIngredients.TabIndex = 0;
            this.btnIngredients.Text = "مواد اولیه";
            this.btnIngredients.UseVisualStyleBackColor = true;
            this.btnIngredients.Click += new System.EventHandler(this.btnIngredients_Click);
            // 
            // btnFoods
            // 
            this.btnFoods.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFoods.Image = ((System.Drawing.Image)(resources.GetObject("btnFoods.Image")));
            this.btnFoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoods.Location = new System.Drawing.Point(12, 106);
            this.btnFoods.Name = "btnFoods";
            this.btnFoods.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFoods.Size = new System.Drawing.Size(182, 61);
            this.btnFoods.TabIndex = 1;
            this.btnFoods.Text = "غذاها";
            this.btnFoods.UseVisualStyleBackColor = true;
            this.btnFoods.Click += new System.EventHandler(this.btnFoods_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(12, 187);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(182, 61);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "گزارش ها";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Visible = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 271);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnFoods);
            this.Controls.Add(this.btnIngredients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "منو اصلی";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngredients;
        private System.Windows.Forms.Button btnFoods;
        private System.Windows.Forms.Button btnReports;
    }
}

