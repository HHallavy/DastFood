using DastFood.Classes;
using DastFood.Classes.SQLite;
using DastFood.Classes.Types;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DastFood.forms
{
    public partial class ChangeStock : Form
    {
        ToolTip ToolTip = new ToolTip();
        Ingredient ingredientToReport;
        public ChangeStock(Ingredient ingredientToReport)
        {
            InitializeComponent();
            ToolTip.InitialDelay = 10;
            this.ingredientToReport = ingredientToReport;
            IngName.Text = ingredientToReport.name;
            IngScale.Text = ingredientToReport.scale;
        }

        private void slider_Scroll(object sender, EventArgs e)
        {
            manualAmount.Text = slider.Value.ToString();
        }

        private void manualAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(
                   char.IsDigit(e.KeyChar)
                || (e.KeyChar.ToString() == "." && !manualAmount.Text.Contains("."))
                || char.IsControl(e.KeyChar)
                );
        }

        private void manualAmount_TextChanged(object sender, EventArgs e)
        {
            double amount;
            if (double.TryParse(manualAmount.Text,out amount))
            {
                ToolTip.SetToolTip(manualAmount, Horof.toHorof(manualAmount.Text));
                if (amount >= slider.Minimum && amount <= slider.Maximum)
                    slider.Value = (int)amount;
            }
        }

        private void increase_CheckedChanged(object sender, EventArgs e)
        {
            decrease.Checked = !increase.Checked;
        }

        private void decrease_CheckedChanged(object sender, EventArgs e)
        {
            increase.Checked = !decrease.Checked;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            double amount;
            bool ValidNumber = double.TryParse(manualAmount.Text, out amount);
            manualAmount.BackColor = ValidNumber ? Color.White : Color.PaleVioletRed;
            
            if (!ValidNumber) return;

            int errorCode = 
                FoodDB.AddIngredientChangeRecord(
                    id: ingredientToReport.id,
                    changeAmount: increase.Checked ? amount : -amount,
                    date: DateTime.Now);
            if (errorCode != 0)
            {
                MessageBox.Show(
                    text: "خطا در هنگام وارد کردن گزارش",
                    caption: "خطا",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Exclamation,
                    defaultButton: MessageBoxDefaultButton.Button1,
                    options: MessageBoxOptions.RtlReading);
            }
            else
            {
                (Owner as ViewIngredientInventory).FillList();
                Close();
            }
        }
    }
}
