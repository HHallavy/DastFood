using DastFood.Classes;
using DastFood.Classes.SQLite;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DastFood.forms
{
    public partial class IngredientsReport : Form
    {
        private bool isFilling;
        private DateSelector startDateSelector, endDateSelector;

        public IngredientsReport()
        {
            InitializeComponent();
        }

        private void IngredientsReport_Load(object sender, EventArgs e)
        {
            FillListOfIngredients();
        }

        private void FillListOfIngredients()
        {
            isFilling = true;

            chart.Series.Clear();
            List<object[]> ingredients = FoodDB.GetIngredientList();
            foreach (var ing in ingredients)
            {
                listOfIngredients.Items.Add(text: ing[1/*name*/].ToString()).Tag = ing[0/*id*/].ToString();
            }

            isFilling = false;
        }

        private void listOfIngredients_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (isFilling) return;
            if (e.Item.Checked)
            {
                if(startDate.Text == "«شروع گزارش»" || endDate.Text == "«پایان گزارش»")
                {
                    chart.Series.Add(FoodDB.GetIngredientReportChartAtMonth(long.Parse(e.Item.Tag.ToString()), DateTime.Now));
                }
                else
                {
                    DateTime dateA, dateB;
                    dateA = Converter.ToMiladi(startDate.Text);
                    dateB = Converter.ToMiladi(endDate.Text);
                    chart.Series.Add(FoodDB.GetIngredientReportChartA_B(long.Parse(e.Item.Tag.ToString()), dateA,dateB));
                }
            }
            else
            {
                chart.Series.Remove(chart.Series[e.Item.Text]);
            }
        }
        private void changeChartView_Click(object sender, EventArgs e)
        {
            foreach (Series sr in chart.Series)
            {
                switch (sr.ChartType)
                {
                    case SeriesChartType.Line:
                        sr.ChartType = SeriesChartType.Column;
                        break;
                    case SeriesChartType.Column:
                        sr.ChartType = SeriesChartType.Line;
                        break;
                }
            }

        }

        private void btnChangeStartDate_Click(object sender, EventArgs e)
        {
            if (startDateSelector == null || startDateSelector.IsDisposed)
            {
                startDateSelector = new DateSelector();
                startDateSelector.OK.Click += delegate
                {
                    if (startDateSelector.DateIsOK())
                        startDate.Text = startDateSelector.manualDate.Text;
                };
            }
            startDateSelector.Show();
            UIHelper.MakeFormAboveButton(btnChangeStartDate, startDateSelector);
        }

        private void startDate_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("start date changed");
            if (startDate.Text == "«شروع گزارش»") return;
            foreach (ListViewItem item in listOfIngredients.CheckedItems)
            {
                item.Checked = !item.Checked;
                item.Checked = !item.Checked;
            }
        }

        private void endDate_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("end date changed");
            if (endDate.Text == "«پایان گزارش»") return;
            foreach (ListViewItem item in listOfIngredients.CheckedItems)
            {
                item.Checked = !item.Checked;
                item.Checked = !item.Checked;
            }
        }

        private void btnChangeEndDate_Click(object sender, EventArgs e)
        {
            if (endDateSelector == null || endDateSelector.IsDisposed)
            {
                endDateSelector = new DateSelector();
                endDateSelector.OK.Click += delegate
                {
                    if (endDateSelector.DateIsOK())
                        endDate.Text = endDateSelector.manualDate.Text;
                };
            }
            endDateSelector.Show();
            UIHelper.MakeFormAboveButton(btnChangeEndDate, endDateSelector);
        }
    }
}
