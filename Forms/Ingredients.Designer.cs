namespace DastFood.forms
{
    partial class Ingredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingredients));
            this.btnEditIngredients = new System.Windows.Forms.Button();
            this.btnAddNewIngredient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditIngredients
            // 
            this.btnEditIngredients.Font = new System.Drawing.Font("B Mitra", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditIngredients.Image = ((System.Drawing.Image)(resources.GetObject("btnEditIngredients.Image")));
            this.btnEditIngredients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditIngredients.Location = new System.Drawing.Point(12, 79);
            this.btnEditIngredients.Name = "btnEditIngredients";
            this.btnEditIngredients.Padding = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.btnEditIngredients.Size = new System.Drawing.Size(199, 61);
            this.btnEditIngredients.TabIndex = 0;
            this.btnEditIngredients.Text = "ویرایش مواد اولیه";
            this.btnEditIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditIngredients.UseVisualStyleBackColor = true;
            this.btnEditIngredients.Click += new System.EventHandler(this.btnEditIngredients_Click);
            // 
            // btnAddNewIngredient
            // 
            this.btnAddNewIngredient.Font = new System.Drawing.Font("B Mitra", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddNewIngredient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewIngredient.Image")));
            this.btnAddNewIngredient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewIngredient.Location = new System.Drawing.Point(12, 12);
            this.btnAddNewIngredient.Name = "btnAddNewIngredient";
            this.btnAddNewIngredient.Padding = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.btnAddNewIngredient.Size = new System.Drawing.Size(199, 61);
            this.btnAddNewIngredient.TabIndex = 1;
            this.btnAddNewIngredient.Text = "اضافه کردن ماده اولیه";
            this.btnAddNewIngredient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewIngredient.UseVisualStyleBackColor = true;
            this.btnAddNewIngredient.Click += new System.EventHandler(this.btnAddNewIngredient_Click);
            // 
            // Ingredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 152);
            this.Controls.Add(this.btnAddNewIngredient);
            this.Controls.Add(this.btnEditIngredients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ingredients";
            this.Text = "مواد اولیه";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditIngredients;
        private System.Windows.Forms.Button btnAddNewIngredient;
    }
}