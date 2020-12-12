namespace DastFood.forms
{
    partial class ShowAllFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.FoodTable = new System.Windows.Forms.DataGridView();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodSelfService = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FoodDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodIngredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listIngredients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintFood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FoodTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditFood
            // 
            this.btnEditFood.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditFood.Location = new System.Drawing.Point(377, 302);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(118, 37);
            this.btnEditFood.TabIndex = 5;
            this.btnEditFood.Text = "ویرایش غذا";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteFood.Location = new System.Drawing.Point(377, 345);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(118, 37);
            this.btnDeleteFood.TabIndex = 4;
            this.btnDeleteFood.Text = "حذف غذا";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // FoodTable
            // 
            this.FoodTable.AllowUserToAddRows = false;
            this.FoodTable.AllowUserToDeleteRows = false;
            this.FoodTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FoodTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FoodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.FoodName,
            this.FoodCategory,
            this.FoodSelfService,
            this.FoodDetails,
            this.FoodIngredients});
            this.FoodTable.Location = new System.Drawing.Point(12, 12);
            this.FoodTable.MultiSelect = false;
            this.FoodTable.Name = "FoodTable";
            this.FoodTable.ReadOnly = true;
            this.FoodTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoodTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FoodTable.Size = new System.Drawing.Size(359, 367);
            this.FoodTable.TabIndex = 3;
            this.FoodTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodTable_RowEnter);
            // 
            // FoodId
            // 
            this.FoodId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FoodId.DefaultCellStyle = dataGridViewCellStyle2;
            this.FoodId.HeaderText = "کد";
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            this.FoodId.Width = 48;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            this.FoodName.DefaultCellStyle = dataGridViewCellStyle3;
            this.FoodName.HeaderText = "نام غذا";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            this.FoodName.Width = 70;
            // 
            // FoodCategory
            // 
            this.FoodCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            this.FoodCategory.DefaultCellStyle = dataGridViewCellStyle4;
            this.FoodCategory.HeaderText = "دسته";
            this.FoodCategory.Name = "FoodCategory";
            this.FoodCategory.ReadOnly = true;
            this.FoodCategory.Width = 62;
            // 
            // FoodSelfService
            // 
            this.FoodSelfService.HeaderText = "س.س";
            this.FoodSelfService.Name = "FoodSelfService";
            this.FoodSelfService.ReadOnly = true;
            this.FoodSelfService.ToolTipText = "سلف سرویس";
            this.FoodSelfService.Width = 50;
            // 
            // FoodDetails
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FoodDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.FoodDetails.HeaderText = "جزئیات";
            this.FoodDetails.Name = "FoodDetails";
            this.FoodDetails.ReadOnly = true;
            // 
            // FoodIngredients
            // 
            this.FoodIngredients.HeaderText = "مواداولیه غذا _مخفی";
            this.FoodIngredients.Name = "FoodIngredients";
            this.FoodIngredients.ReadOnly = true;
            this.FoodIngredients.Visible = false;
            // 
            // listIngredients
            // 
            this.listIngredients.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.ItemHeight = 24;
            this.listIngredients.Location = new System.Drawing.Point(377, 37);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listIngredients.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listIngredients.Size = new System.Drawing.Size(210, 244);
            this.listIngredients.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(528, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "مواد اولیه";
            // 
            // btnPrintFood
            // 
            this.btnPrintFood.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintFood.Location = new System.Drawing.Point(501, 302);
            this.btnPrintFood.Name = "btnPrintFood";
            this.btnPrintFood.Size = new System.Drawing.Size(80, 80);
            this.btnPrintFood.TabIndex = 15;
            this.btnPrintFood.Text = "چاپ غذا";
            this.btnPrintFood.UseVisualStyleBackColor = true;
            this.btnPrintFood.Click += new System.EventHandler(this.btnPrintFood_Click);
            // 
            // ShowAllFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 400);
            this.Controls.Add(this.btnPrintFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listIngredients);
            this.Controls.Add(this.btnEditFood);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.FoodTable);
            this.Name = "ShowAllFood";
            this.Text = "نمایش همه غذا ها";
            this.Load += new System.EventHandler(this.ShowAllFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.DataGridView FoodTable;
        public System.Windows.Forms.ListBox listIngredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodCategory;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FoodSelfService;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodIngredients;
        private System.Windows.Forms.Button btnPrintFood;
    }
}