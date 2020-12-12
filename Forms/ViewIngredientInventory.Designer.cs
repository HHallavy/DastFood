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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InventoryTable = new System.Windows.Forms.DataGridView();
            this.IngId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnEditIngredient = new System.Windows.Forms.Button();
            this.btnChangeStock = new System.Windows.Forms.Button();
            this.btnPrintInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryTable
            // 
            this.InventoryTable.AllowUserToAddRows = false;
            this.InventoryTable.AllowUserToDeleteRows = false;
            this.InventoryTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.InventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngId,
            this.IngName,
            this.IngQuantity});
            this.InventoryTable.Location = new System.Drawing.Point(8, 8);
            this.InventoryTable.MultiSelect = false;
            this.InventoryTable.Name = "InventoryTable";
            this.InventoryTable.ReadOnly = true;
            this.InventoryTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InventoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryTable.Size = new System.Drawing.Size(359, 367);
            this.InventoryTable.TabIndex = 0;
            this.InventoryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryTable_CellContentClick);
            // 
            // IngId
            // 
            this.IngId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.IngId.DefaultCellStyle = dataGridViewCellStyle10;
            this.IngId.HeaderText = "کد";
            this.IngId.Name = "IngId";
            this.IngId.ReadOnly = true;
            this.IngId.Width = 48;
            // 
            // IngName
            // 
            this.IngName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            this.IngName.DefaultCellStyle = dataGridViewCellStyle11;
            this.IngName.HeaderText = "نام ماده اولیه";
            this.IngName.Name = "IngName";
            this.IngName.ReadOnly = true;
            // 
            // IngQuantity
            // 
            this.IngQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            this.IngQuantity.DefaultCellStyle = dataGridViewCellStyle12;
            this.IngQuantity.HeaderText = "مقدار موجود";
            this.IngQuantity.Name = "IngQuantity";
            this.IngQuantity.ReadOnly = true;
            this.IngQuantity.Width = 94;
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteIngredient.Location = new System.Drawing.Point(373, 67);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(118, 37);
            this.btnDeleteIngredient.TabIndex = 1;
            this.btnDeleteIngredient.Text = "حذف ماده اولیه";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditIngredient.Location = new System.Drawing.Point(373, 24);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(118, 37);
            this.btnEditIngredient.TabIndex = 2;
            this.btnEditIngredient.Text = "ویرایش ماده اولیه";
            this.btnEditIngredient.UseVisualStyleBackColor = true;
            this.btnEditIngredient.Click += new System.EventHandler(this.btnEditIngredient_Click);
            // 
            // btnChangeStock
            // 
            this.btnChangeStock.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnChangeStock.Location = new System.Drawing.Point(371, 190);
            this.btnChangeStock.Name = "btnChangeStock";
            this.btnChangeStock.Size = new System.Drawing.Size(118, 37);
            this.btnChangeStock.TabIndex = 3;
            this.btnChangeStock.Text = "تغییر مقدار";
            this.btnChangeStock.UseVisualStyleBackColor = true;
            this.btnChangeStock.Click += new System.EventHandler(this.btnChangeStock_Click);
            // 
            // btnPrintInventory
            // 
            this.btnPrintInventory.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrintInventory.Location = new System.Drawing.Point(371, 233);
            this.btnPrintInventory.Name = "btnPrintInventory";
            this.btnPrintInventory.Size = new System.Drawing.Size(118, 37);
            this.btnPrintInventory.TabIndex = 3;
            this.btnPrintInventory.Text = "چاپ موجودی";
            this.btnPrintInventory.UseVisualStyleBackColor = true;
            this.btnPrintInventory.Click += new System.EventHandler(this.btnPrintInventory_Click);
            // 
            // ViewIngredientInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 382);
            this.Controls.Add(this.btnPrintInventory);
            this.Controls.Add(this.btnChangeStock);
            this.Controls.Add(this.btnEditIngredient);
            this.Controls.Add(this.btnDeleteIngredient);
            this.Controls.Add(this.InventoryTable);
            this.Name = "ViewIngredientInventory";
            this.Text = "مشاهده موجودی";
            this.Load += new System.EventHandler(this.ViewIngredientInventory_Load);
            this.Resize += new System.EventHandler(this.ViewIngredientInventory_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryTable;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnEditIngredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngQuantity;
        private System.Windows.Forms.Button btnChangeStock;
        private System.Windows.Forms.Button btnPrintInventory;
    }
}