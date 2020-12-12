namespace DastFood.forms
{
    partial class ChangeStock
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
            this.slider = new System.Windows.Forms.TrackBar();
            this.manualAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.increase = new System.Windows.Forms.CheckBox();
            this.decrease = new System.Windows.Forms.CheckBox();
            this.OK = new System.Windows.Forms.Button();
            this.IngName = new System.Windows.Forms.Label();
            this.IngScale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // slider
            // 
            this.slider.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.slider.LargeChange = 100;
            this.slider.Location = new System.Drawing.Point(12, 59);
            this.slider.Maximum = 1000;
            this.slider.Name = "slider";
            this.slider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.slider.Size = new System.Drawing.Size(225, 45);
            this.slider.SmallChange = 20;
            this.slider.TabIndex = 0;
            this.slider.TickFrequency = 100;
            this.slider.Scroll += new System.EventHandler(this.slider_Scroll);
            // 
            // manualAmount
            // 
            this.manualAmount.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.manualAmount.Location = new System.Drawing.Point(12, 103);
            this.manualAmount.MaxLength = 19;
            this.manualAmount.Multiline = true;
            this.manualAmount.Name = "manualAmount";
            this.manualAmount.Size = new System.Drawing.Size(179, 33);
            this.manualAmount.TabIndex = 1;
            this.manualAmount.TextChanged += new System.EventHandler(this.manualAmount_TextChanged);
            this.manualAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.manualAmount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(197, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "دستی";
            // 
            // increase
            // 
            this.increase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.increase.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.increase.Checked = true;
            this.increase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.increase.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.increase.ForeColor = System.Drawing.Color.Green;
            this.increase.Location = new System.Drawing.Point(129, 153);
            this.increase.Name = "increase";
            this.increase.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.increase.Size = new System.Drawing.Size(98, 28);
            this.increase.TabIndex = 3;
            this.increase.Text = "اضافه کردن";
            this.increase.UseVisualStyleBackColor = false;
            this.increase.CheckedChanged += new System.EventHandler(this.increase_CheckedChanged);
            // 
            // decrease
            // 
            this.decrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.decrease.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.decrease.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.decrease.ForeColor = System.Drawing.Color.Maroon;
            this.decrease.Location = new System.Drawing.Point(129, 187);
            this.decrease.Name = "decrease";
            this.decrease.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decrease.Size = new System.Drawing.Size(98, 28);
            this.decrease.TabIndex = 3;
            this.decrease.Text = "کم کردن";
            this.decrease.UseVisualStyleBackColor = false;
            this.decrease.CheckedChanged += new System.EventHandler(this.decrease_CheckedChanged);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold);
            this.OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OK.Location = new System.Drawing.Point(12, 183);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(74, 32);
            this.OK.TabIndex = 5;
            this.OK.Text = "تایید";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // IngName
            // 
            this.IngName.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.IngName.Location = new System.Drawing.Point(12, 9);
            this.IngName.Name = "IngName";
            this.IngName.Size = new System.Drawing.Size(225, 37);
            this.IngName.TabIndex = 6;
            this.IngName.Text = "«ماده اولیه»";
            this.IngName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IngScale
            // 
            this.IngScale.AutoSize = true;
            this.IngScale.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.IngScale.Location = new System.Drawing.Point(13, 139);
            this.IngScale.Name = "IngScale";
            this.IngScale.Size = new System.Drawing.Size(91, 23);
            this.IngScale.TabIndex = 2;
            this.IngScale.Text = "«واحد شمارش»";
            // 
            // ChangeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(249, 226);
            this.Controls.Add(this.IngName);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.decrease);
            this.Controls.Add(this.increase);
            this.Controls.Add(this.IngScale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manualAmount);
            this.Controls.Add(this.slider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeStock";
            this.Text = "تغییر موجودی";
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.TextBox manualAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox increase;
        private System.Windows.Forms.CheckBox decrease;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label IngName;
        private System.Windows.Forms.Label IngScale;
    }
}