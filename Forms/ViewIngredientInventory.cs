using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DastFood.Classes.SQLite;
using DastFood.Classes.Types;
using DGVPrinterHelper;

namespace DastFood.forms
{
    public partial class ViewIngredientInventory : Form
    {
        private const int littleSpace = 10;
        private ChangeStock changeStock;

        public ViewIngredientInventory()
        {
            InitializeComponent();
        }

        private void ViewIngredientInventory_Load(object sender, EventArgs e)
        {
            FillList();
        }

        public void FillList()
        {
            InventoryTable.Rows.Clear();
            List<object[]> IngList = FoodDB.GetIngredientList();
            foreach (var Ingredient in IngList)
            {
                int addedRow = InventoryTable.Rows.Add(Ingredient);
                if (InventoryTable.Rows[addedRow].Cells[2].Value.ToString().StartsWith("0"))
                {
                    InventoryTable.Rows[addedRow].DefaultCellStyle.BackColor = Color.Pink;
                }
            }
        }

        private void InventoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewIngredientInventory_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) return;
            InventoryTable.Width = Width - InventoryTable.Left - btnEditIngredient.Width - (4 * littleSpace);
            InventoryTable.Height = Height - (6 * littleSpace);
            btnEditIngredient.Left = InventoryTable.Right + littleSpace;
            btnDeleteIngredient.Left = InventoryTable.Right + littleSpace;
            btnChangeStock.Left = InventoryTable.Right + littleSpace;
            btnPrintInventory.Left = btnPrintInventory.Right + littleSpace;
        }

        private void btnEditIngredient_Click(object sender, EventArgs e)
        {
            if (InventoryTable.SelectedRows.Count > 1)
            {
                DialogResult dialogResult = MessageBox.Show(
                                "آیا مطمئنید می خواهید " + InventoryTable.SelectedRows.Count.ToString() + " ماده اولیه را ویرایش کنید؟",
                                "ویرایش ماده اولیه",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2,
                                MessageBoxOptions.RtlReading
                                );
                if (dialogResult == DialogResult.No) return;
            }
            Ingredient ing;
            foreach (DataGridViewRow row in InventoryTable.SelectedRows)
            {
                ing = FoodDB.GetIngredient(long.Parse(row.Cells["IngId"].Value.ToString()));
                EditIngredients edit = new EditIngredients(ing);
                edit.Owner = this;
                edit.Show();
            }
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            if (InventoryTable.SelectedRows.Count == 0) return;

            DialogResult dialogResult = MessageBox.Show(
                            "آیا مطمئنید می خواهید " + InventoryTable.SelectedRows.Count.ToString() + " ماده اولیه را حذف کنید؟",
                            "حذف ماده اولیه",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2,
                            MessageBoxOptions.RtlReading
                            );
            if (dialogResult == DialogResult.No) return;

            foreach (DataGridViewRow row in InventoryTable.SelectedRows)
            {
                FoodDB.DeleteIngredient(long.Parse(row.Cells[IngId.Index].Value.ToString()));
            }
            FillList();
        }

        private void btnChangeStock_Click(object sender, EventArgs e)
        {
            if (InventoryTable.SelectedRows.Count != 1) return;

            foreach (DataGridViewRow row in InventoryTable.SelectedRows)
            {
                changeStock = new ChangeStock(FoodDB.GetIngredient(long.Parse(row.Cells[IngId.Index].Value.ToString())));
                changeStock.Owner = this;
                changeStock.Show();
            }
        }

        private void btnPrintInventory_Click(object sender, EventArgs e)
        {
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.PrintDataGridView(InventoryTable);
        }
    }
}
