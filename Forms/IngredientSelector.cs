using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DastFood.Classes;
using DastFood.Classes.SQLite;

namespace DastFood.forms
{
    public partial class IngredientSelector : Form
    {
        private const int littleSpace = 10;

        public IngredientSelector()
        {
            InitializeComponent();
        }
        private void IngredientSelector_Load(object sender, EventArgs e)
        {
            FillList();
        }
        public void FillList()
        {
            AllIngredients.Rows.Clear();
            List<object[]> IngList = FoodDB.GetIngredientList();
            foreach (var Ingredient in IngList)
            {
                int addedRow = AllIngredients.Rows.Add(Ingredient);
                if (AllIngredients.Rows[addedRow].Cells[2].Value.ToString().StartsWith("0"))
                {
                    AllIngredients.Rows[addedRow].DefaultCellStyle.BackColor = Color.Pink;
                }
            }
        }
        private void basketOfIngredients_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += Control_KeyPress;
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(
                   char.IsDigit(e.KeyChar)
                || (e.KeyChar.ToString() == "." && !basketOfIngredients.EditingControl.Text.Contains("."))
                || char.IsControl(e.KeyChar)
                );
        }

        private void IngredientSelector_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) return;

            AllIngredients.Width = Width - AllIngredients.Left - addToBasket.Width - (4 * littleSpace);
            AllIngredients.Height = (Height - AllIngredients.Top - (10 * littleSpace))/2;
            addToBasket.Left = AllIngredients.Right + littleSpace;

            basketOfIngredients.Width = AllIngredients.Width;
            basketOfIngredients.Top = AllIngredients.Bottom + AllIngredients.Top;
            basketOfIngredients.Height = AllIngredients.Height;
            removeFromBasket.Left = addToBasket.Left;
            removeFromBasket.Top = basketOfIngredients.Bottom - removeFromBasket.Height;

            OK.Top = basketOfIngredients.Bottom + (littleSpace);
        }

        private void addToBasket_Click(object sender, EventArgs e)
        {
            if (AllIngredients.SelectedRows.Count == 0) return;

            bool wasAddedBefore = false;
            foreach (DataGridViewRow row in AllIngredients.SelectedRows)
            {
                foreach (DataGridViewRow basketRow in basketOfIngredients.Rows)
                {
                    wasAddedBefore = (basketRow.Cells[0/*IngId*/].Value.ToString() == row.Cells[0/*IngId*/].Value.ToString());
                    if (wasAddedBefore)
                    {
                        MessageBox.Show(
                            "«" + row.Cells[1/*IngId*/].Value.ToString() + "» قبلاً اضافه شده",
                            "اضافه کردن مورد تکراری",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading
                            );
                        break;
                    }
                }
                if (!wasAddedBefore)
                {
                    basketOfIngredients.Rows.Add(new object[] {
                        row.Cells[0/*IngId*/].Value.ToString(),
                        row.Cells[1/*IngName*/].Value.ToString()
                    });
                }
            }
        }

        private void removeFromBasket_Click(object sender, EventArgs e)
        {
            if (basketOfIngredients.SelectedRows.Count == 0) return;

            DialogResult dialogResult = MessageBox.Show(
                            "آیا مطمئنید می خواهید " + basketOfIngredients.SelectedRows.Count.ToString() + " ماده اولیه را حذف کنید؟",
                            "حذف مواد اولیه",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2,
                            MessageBoxOptions.RtlReading
                            );
            if (dialogResult == DialogResult.Yes)
            {
                foreach(DataGridViewRow row in basketOfIngredients.SelectedRows)
                {
                    basketOfIngredients.Rows.Remove(row);
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (basketOfIngredients.IsCurrentCellInEditMode)
                basketOfIngredients.EndEdit();

            if (!AllRowsAreOK()) return;

            if (Owner is AddFood)
                ReturnResults((AddFood)Owner);
            else if (Owner is EditFood)
                ReturnResults((EditFood)Owner);
            
        }

        private void ReturnResults(EditFood owner)
        {
            owner.RecipeString = Converter.ToRecipeString(basketOfIngredients.Rows);

            // Adds chosen ingredients to AddFood form to show user
            owner.listIngredients.Items.Clear();
            foreach (DataGridViewRow row in basketOfIngredients.Rows)
            {

                owner.listIngredients.Items.Add(
                    row.Cells[1/*IngName*/].Value.ToString() + " - "
                    + row.Cells[2/*IngAmount*/].Value.ToString() + " "
                    + row.Cells[3/*IngScale*/].Value.ToString()
                    );
            }
            Close();
        }

        private void ReturnResults(AddFood owner)
        {
            owner.RecipeString = Converter.ToRecipeString(basketOfIngredients.Rows);

            // Adds chosen ingredients to AddFood form to show user
            owner.listIngredients.Items.Clear();
            foreach (DataGridViewRow row in basketOfIngredients.Rows)
            {
                owner.listIngredients.Items.Add(
                    row.Cells[1/*IngName*/].Value.ToString() + " - "
                    + row.Cells[2/*IngAmount*/].Value.ToString() + " "
                    + row.Cells[3/*IngScale*/].Value.ToString()
                    );
            }
            Close();
        }

        private bool AllRowsAreOK()
        {
            foreach (DataGridViewRow row in basketOfIngredients.Rows)
            {

                row.Cells[2].Value = row.Cells[2].Value == null ? "0.0" : row.Cells[2].Value.ToString();
                row.Cells[3].Value = row.Cells[3].Value == null ? "کیلوگرم" : row.Cells[3].Value.ToString();

                bool rowOK = double.TryParse(row.Cells[2].Value.ToString(), out _);
                row.DefaultCellStyle.BackColor = rowOK ? Color.White : Color.Red;

                if (!rowOK)
                {
                    MessageBox.Show(
                            "یکی از مقادیر درست وارد نشده",
                            "ورودی نامعتبر",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading
                            );
                    return false;
                }
            }
            return true;
        }

        private void AllIngredients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addToBasket_Click(null, null);
        }

        private void basketOfIngredients_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                removeFromBasket_Click(null, null);
        }
    }
}
