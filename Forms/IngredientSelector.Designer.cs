namespace DastFood.forms
{
    partial class IngredientSelector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientSelector));
            this.AllIngredients = new System.Windows.Forms.DataGridView();
            this.IngId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basketOfIngredients = new System.Windows.Forms.DataGridView();
            this.basketIngId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basketIngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basketIngAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basketIngScale = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.addToBasket = new System.Windows.Forms.Button();
            this.removeFromBasket = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketOfIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // AllIngredients
            // 
            this.AllIngredients.AllowUserToAddRows = false;
            this.AllIngredients.AllowUserToDeleteRows = false;
            this.AllIngredients.AllowUserToResizeRows = false;
            this.AllIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AllIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngId,
            this.IngName,
            this.IngQuantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllIngredients.DefaultCellStyle = dataGridViewCellStyle2;
            this.AllIngredients.Location = new System.Drawing.Point(12, 12);
            this.AllIngredients.Name = "AllIngredients";
            this.AllIngredients.ReadOnly = true;
            this.AllIngredients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllIngredients.Size = new System.Drawing.Size(373, 180);
            this.AllIngredients.TabIndex = 0;
            this.AllIngredients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllIngredients_CellDoubleClick);
            // 
            // IngId
            // 
            this.IngId.HeaderText = "کد";
            this.IngId.Name = "IngId";
            this.IngId.ReadOnly = true;
            this.IngId.Width = 49;
            // 
            // IngName
            // 
            this.IngName.HeaderText = "نام ماده اولیه";
            this.IngName.Name = "IngName";
            this.IngName.ReadOnly = true;
            this.IngName.Width = 101;
            // 
            // IngQuantity
            // 
            this.IngQuantity.HeaderText = "مقدار موجودی";
            this.IngQuantity.Name = "IngQuantity";
            this.IngQuantity.ReadOnly = true;
            this.IngQuantity.Width = 110;
            // 
            // basketOfIngredients
            // 
            this.basketOfIngredients.AllowUserToAddRows = false;
            this.basketOfIngredients.AllowUserToResizeRows = false;
            this.basketOfIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.basketOfIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.basketOfIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketOfIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.basketIngId,
            this.basketIngName,
            this.basketIngAmount,
            this.basketIngScale});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.basketOfIngredients.DefaultCellStyle = dataGridViewCellStyle6;
            this.basketOfIngredients.Location = new System.Drawing.Point(12, 215);
            this.basketOfIngredients.Name = "basketOfIngredients";
            this.basketOfIngredients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.basketOfIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.basketOfIngredients.Size = new System.Drawing.Size(373, 180);
            this.basketOfIngredients.TabIndex = 1;
            this.basketOfIngredients.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.basketOfIngredients_CellMouseUp);
            this.basketOfIngredients.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.basketOfIngredients_EditingControlShowing);
            // 
            // basketIngId
            // 
            this.basketIngId.HeaderText = "کد";
            this.basketIngId.Name = "basketIngId";
            this.basketIngId.ReadOnly = true;
            this.basketIngId.Width = 49;
            // 
            // basketIngName
            // 
            this.basketIngName.HeaderText = "نام ماده اولیه";
            this.basketIngName.Name = "basketIngName";
            this.basketIngName.ReadOnly = true;
            this.basketIngName.Width = 101;
            // 
            // basketIngAmount
            // 
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = "0.0";
            this.basketIngAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.basketIngAmount.HeaderText = "میزان لازم";
            this.basketIngAmount.MaxInputLength = 12;
            this.basketIngAmount.Name = "basketIngAmount";
            this.basketIngAmount.Width = 88;
            // 
            // basketIngScale
            // 
            dataGridViewCellStyle5.NullValue = "کیلوگرم";
            this.basketIngScale.DefaultCellStyle = dataGridViewCellStyle5;
            this.basketIngScale.HeaderText = "واحد";
            this.basketIngScale.Items.AddRange(new object[] {
            "بسته",
            "بسته 5 تایی",
            "دانه",
            "کیلوگرم",
            "گرم",
            "لیتر",
            "میلی لیتر"});
            this.basketIngScale.Name = "basketIngScale";
            this.basketIngScale.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.basketIngScale.Sorted = true;
            this.basketIngScale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.basketIngScale.Width = 60;
            // 
            // addToBasket
            // 
            this.addToBasket.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addToBasket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addToBasket.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            this.addToBasket.ForeColor = System.Drawing.Color.Navy;
            this.addToBasket.Image = ((System.Drawing.Image)(resources.GetObject("addToBasket.Image")));
            this.addToBasket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addToBasket.Location = new System.Drawing.Point(391, 12);
            this.addToBasket.Name = "addToBasket";
            this.addToBasket.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.addToBasket.Size = new System.Drawing.Size(46, 64);
            this.addToBasket.TabIndex = 5;
            this.addToBasket.Text = "اضافه";
            this.addToBasket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addToBasket.UseVisualStyleBackColor = false;
            this.addToBasket.Click += new System.EventHandler(this.addToBasket_Click);
            // 
            // removeFromBasket
            // 
            this.removeFromBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeFromBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.removeFromBasket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeFromBasket.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.removeFromBasket.ForeColor = System.Drawing.Color.Red;
            this.removeFromBasket.Image = ((System.Drawing.Image)(resources.GetObject("removeFromBasket.Image")));
            this.removeFromBasket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeFromBasket.Location = new System.Drawing.Point(391, 331);
            this.removeFromBasket.Name = "removeFromBasket";
            this.removeFromBasket.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.removeFromBasket.Size = new System.Drawing.Size(46, 64);
            this.removeFromBasket.TabIndex = 6;
            this.removeFromBasket.Text = "حذف";
            this.removeFromBasket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.removeFromBasket.UseVisualStyleBackColor = false;
            this.removeFromBasket.Click += new System.EventHandler(this.removeFromBasket_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OK.Location = new System.Drawing.Point(12, 401);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(72, 31);
            this.OK.TabIndex = 6;
            this.OK.Text = "تایید";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // IngredientSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 442);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.removeFromBasket);
            this.Controls.Add(this.addToBasket);
            this.Controls.Add(this.basketOfIngredients);
            this.Controls.Add(this.AllIngredients);
            this.Name = "IngredientSelector";
            this.Text = "انتخاب مواد اولیه";
            this.Load += new System.EventHandler(this.IngredientSelector_Load);
            this.Resize += new System.EventHandler(this.IngredientSelector_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.AllIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketOfIngredients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllIngredients;
        private System.Windows.Forms.DataGridView basketOfIngredients;
        private System.Windows.Forms.Button addToBasket;
        private System.Windows.Forms.Button removeFromBasket;
        public  System.Windows.Forms.Button OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn basketIngId;
        private System.Windows.Forms.DataGridViewTextBoxColumn basketIngName;
        private System.Windows.Forms.DataGridViewTextBoxColumn basketIngAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn basketIngScale;
    }
}
