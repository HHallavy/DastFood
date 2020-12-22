namespace DastFood.forms
{
    partial class IngredientsReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsReport));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChangeStartDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listOfIngredients = new System.Windows.Forms.ListView();
            this.IngName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeEndDate = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.changeChartView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.chart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 1D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.Interval = 1D;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Samim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.MajorGrid.Interval = 0D;
            chartArea1.AxisX2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Samim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Samim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Samim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Samim", 9F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "chart";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(524, 428);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // btnChangeStartDate
            // 
            this.btnChangeStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.btnChangeStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeStartDate.Font = new System.Drawing.Font("Samim", 10F);
            this.btnChangeStartDate.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeStartDate.Image")));
            this.btnChangeStartDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeStartDate.Location = new System.Drawing.Point(553, 213);
            this.btnChangeStartDate.Name = "btnChangeStartDate";
            this.btnChangeStartDate.Padding = new System.Windows.Forms.Padding(3);
            this.btnChangeStartDate.Size = new System.Drawing.Size(102, 35);
            this.btnChangeStartDate.TabIndex = 1;
            this.btnChangeStartDate.Text = "تعیین";
            this.btnChangeStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeStartDate.UseVisualStyleBackColor = false;
            this.btnChangeStartDate.Click += new System.EventHandler(this.btnChangeStartDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Samim", 10F);
            this.label1.Location = new System.Drawing.Point(600, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "شروع گزارش";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Samim", 10F);
            this.label2.Location = new System.Drawing.Point(600, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "پایان گزارش";
            // 
            // listOfIngredients
            // 
            this.listOfIngredients.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listOfIngredients.CheckBoxes = true;
            this.listOfIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IngName});
            this.listOfIngredients.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listOfIngredients.FullRowSelect = true;
            this.listOfIngredients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listOfIngredients.HideSelection = false;
            this.listOfIngredients.Location = new System.Drawing.Point(542, 35);
            this.listOfIngredients.Name = "listOfIngredients";
            this.listOfIngredients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listOfIngredients.RightToLeftLayout = true;
            this.listOfIngredients.Size = new System.Drawing.Size(141, 126);
            this.listOfIngredients.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listOfIngredients.TabIndex = 8;
            this.listOfIngredients.UseCompatibleStateImageBehavior = false;
            this.listOfIngredients.View = System.Windows.Forms.View.Details;
            this.listOfIngredients.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listOfIngredients_ItemChecked);
            // 
            // IngName
            // 
            this.IngName.Text = "";
            this.IngName.Width = 137;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Samim", 10F);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(496, 400);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(3);
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 10;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Samim", 10F);
            this.label3.Location = new System.Drawing.Point(620, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "مواد اولیه";
            // 
            // btnChangeEndDate
            // 
            this.btnChangeEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.btnChangeEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeEndDate.Font = new System.Drawing.Font("Samim", 10F);
            this.btnChangeEndDate.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeEndDate.Image")));
            this.btnChangeEndDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeEndDate.Location = new System.Drawing.Point(553, 304);
            this.btnChangeEndDate.Name = "btnChangeEndDate";
            this.btnChangeEndDate.Padding = new System.Windows.Forms.Padding(3);
            this.btnChangeEndDate.Size = new System.Drawing.Size(102, 35);
            this.btnChangeEndDate.TabIndex = 1;
            this.btnChangeEndDate.Text = "تعیین";
            this.btnChangeEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeEndDate.UseVisualStyleBackColor = false;
            this.btnChangeEndDate.Click += new System.EventHandler(this.btnChangeEndDate_Click);
            // 
            // startDate
            // 
            this.startDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.startDate.Font = new System.Drawing.Font("Samim", 10F);
            this.startDate.Location = new System.Drawing.Point(553, 184);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(102, 29);
            this.startDate.TabIndex = 3;
            this.startDate.Text = "«شروع گزارش»";
            this.startDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startDate.TextChanged += new System.EventHandler(this.startDate_TextChanged);
            // 
            // endDate
            // 
            this.endDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.endDate.Font = new System.Drawing.Font("Samim", 10F);
            this.endDate.Location = new System.Drawing.Point(553, 274);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(102, 29);
            this.endDate.TabIndex = 6;
            this.endDate.Text = "«پایان گزارش»";
            this.endDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endDate.TextChanged += new System.EventHandler(this.endDate_TextChanged);
            // 
            // changeChartView
            // 
            this.changeChartView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.changeChartView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeChartView.Font = new System.Drawing.Font("Samim", 10F);
            this.changeChartView.Image = ((System.Drawing.Image)(resources.GetObject("changeChartView.Image")));
            this.changeChartView.Location = new System.Drawing.Point(455, 400);
            this.changeChartView.Name = "changeChartView";
            this.changeChartView.Padding = new System.Windows.Forms.Padding(3);
            this.changeChartView.Size = new System.Drawing.Size(35, 35);
            this.changeChartView.TabIndex = 10;
            this.changeChartView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeChartView.UseVisualStyleBackColor = false;
            this.changeChartView.Click += new System.EventHandler(this.changeChartView_Click);
            // 
            // IngredientsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 452);
            this.Controls.Add(this.changeChartView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listOfIngredients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeEndDate);
            this.Controls.Add(this.btnChangeStartDate);
            this.Controls.Add(this.chart);
            this.Name = "IngredientsReport";
            this.Text = "گزارش مواد اولیه";
            this.Load += new System.EventHandler(this.IngredientsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnChangeStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listOfIngredients;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeEndDate;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.ColumnHeader IngName;
        private System.Windows.Forms.Button changeChartView;
    }
}