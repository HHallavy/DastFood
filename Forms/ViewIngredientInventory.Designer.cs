namespace DastFood.forms
{
    partial class ViewIngredientInventory
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
            this.InventoryTable = new System.Windows.Forms.DataGridView();
            this.IngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryTable
            // 
            this.InventoryTable.AllowUserToAddRows = false;
            this.InventoryTable.AllowUserToDeleteRows = false;
            this.InventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngName,
            this.IngQuantity,
            this.IngExpireDate});
            this.InventoryTable.Location = new System.Drawing.Point(12, 12);
            this.InventoryTable.Name = "InventoryTable";
            this.InventoryTable.ReadOnly = true;
            this.InventoryTable.Size = new System.Drawing.Size(359, 354);
            this.InventoryTable.TabIndex = 0;
            this.InventoryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryTable_CellContentClick);
            // 
            // IngName
            // 
            this.IngName.HeaderText = "نام ماده اولیه";
            this.IngName.Name = "IngName";
            this.IngName.ReadOnly = true;
            // 
            // IngQuantity
            // 
            this.IngQuantity.HeaderText = "موجودی";
            this.IngQuantity.Name = "IngQuantity";
            this.IngQuantity.ReadOnly = true;
            // 
            // IngExpireDate
            // 
            this.IngExpireDate.HeaderText = "تاریخ انقضاء";
            this.IngExpireDate.Name = "IngExpireDate";
            this.IngExpireDate.ReadOnly = true;
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteIngredient.Location = new System.Drawing.Point(251, 382);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(120, 37);
            this.btnDeleteIngredient.TabIndex = 1;
            this.btnDeleteIngredient.Text = "حذف ماده اولیه";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(12, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "ویرایش ماده اولیه";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ViewIngredientInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteIngredient);
            this.Controls.Add(this.InventoryTable);
            this.Name = "ViewIngredientInventory";
            this.Text = "مشاهده موجودی";
            this.Load += new System.EventHandler(this.ViewIngredientInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngExpireDate;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button button1;
    }
}