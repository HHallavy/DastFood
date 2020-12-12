using DastFood.Classes;
using DastFood.Classes.SQLite;
using DastFood.Classes.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DastFood.forms
{
    public partial class ShowAllFood : Form
    {
        private EditFood editFood;
        private Food foodToPrint;
        private string rLine;

        public ShowAllFood()
        {
            InitializeComponent();
        }

        private void ShowAllFood_Load(object sender, EventArgs e)
        {
            FillList();
        }

        public void FillList()
        {
            FoodTable.Rows.Clear();

            List<object[]> FoodList = FoodDB.GetFoodList();
            foreach (object[] food in FoodList)
            {
                FoodTable.Rows.Add(food);
            }
        }

        public void FoodTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (FoodTable.CurrentRow == null)
            {
                listIngredients.Items.Clear();
                return;
            }

            listIngredients.Items.Clear();

            string RecipeString = FoodTable.CurrentRow.Cells[FoodIngredients.Index].Value.ToString();
            List<RecipeIngredient> ingredients = Converter.ToRecipeList(RecipeString);
            foreach (RecipeIngredient Ing in ingredients)
            {
                listIngredients.Items.Add(FoodDB.GetIngredient(Ing.IngId).name + " - " + Ing.IngAmount + " " + Ing.IngScale);
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            if (FoodTable.CurrentRow == null) return;
            long FoodID = long.Parse(FoodTable.CurrentRow.Cells[FoodId.Index].Value.ToString());

            if (editFood == null || editFood.IsDisposed)
            {
                editFood = new EditFood(FoodDB.GetFood(FoodID));
                editFood.Owner = this;
            }
            editFood.Show();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (FoodTable.SelectedRows.Count == 0) return;

            DialogResult dialogResult = MessageBox.Show(
                            "آیا مطمئنید می خواهید " + FoodTable.SelectedRows.Count.ToString() + " غذا را حذف کنید؟",
                            "حذف غذا",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2,
                            MessageBoxOptions.RtlReading
                            );
            if (dialogResult == DialogResult.No) return;

            foreach (DataGridViewRow row in FoodTable.SelectedRows)
            {
                FoodDB.DeleteFood(long.Parse(row.Cells[FoodId.Index].Value.ToString()));
            }
            FillList();
            FoodTable_RowEnter(null, null);
        }

        private void btnPrintFood_Click(object sender, EventArgs e)
        {
            if (FoodTable.SelectedRows.Count == 0) return;

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            foodToPrint = FoodDB.GetFood(long.Parse(FoodTable.CurrentRow.Cells[FoodId.Index].Value.ToString()));

            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog(this);
            printDocument.PrinterSettings = printDialog.PrinterSettings;

            printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            // Create font and brush.
            Font FoodTitleFont = new Font("B Titr", 18, FontStyle.Regular, GraphicsUnit.Point);
            Font FoodCategoryFont = new Font("B Karim", 14, FontStyle.Bold, GraphicsUnit.Point);
            Font IngredientsFont = new Font("B Mitra", 12, FontStyle.Bold, GraphicsUnit.Point);
            Font IngFont = new Font("B Nazanin", 12, FontStyle.Regular, GraphicsUnit.Point);

            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            RectangleF titleRect = new RectangleF(
                   x: e.MarginBounds.Right - TextRenderer.MeasureText(foodToPrint.Name, FoodTitleFont).Width,
                   y: e.MarginBounds.Top,
                   width: TextRenderer.MeasureText(foodToPrint.Name, FoodTitleFont).Width + 10.0f,
                   height: TextRenderer.MeasureText("ل", FoodTitleFont).Height
                );
            RectangleF categoryRect = new RectangleF(
                   x: titleRect.Left + TextRenderer.MeasureText(foodToPrint.Category, FoodCategoryFont).Width / 2,
                   y: titleRect.Bottom + 2.0f,
                   width: TextRenderer.MeasureText(foodToPrint.Category, FoodCategoryFont).Width,
                   height: TextRenderer.MeasureText("ل", FoodCategoryFont).Height
                );
            RectangleF ingredientsRect = new RectangleF(
                   x: titleRect.X, // Center
                   y: categoryRect.Bottom + 3.0f,
                   width: TextRenderer.MeasureText("مواد لازم:", IngredientsFont).Width,
                   height: TextRenderer.MeasureText("ل", IngredientsFont).Height
                );
            RectangleF ingsRect = new RectangleF(
                   x: e.MarginBounds.Left,
                   y: ingredientsRect.Bottom + 2.0f,
                   width: ingredientsRect.Right - e.MarginBounds.Left,
                   height: e.MarginBounds.Bottom - (ingredientsRect.Bottom + 20.0f)
                );
            string todayShamsi = "تاریخ: " + Converter.ToShamsi(DateTime.Now);
            RectangleF dateRect = new RectangleF(
                   x: e.MarginBounds.Left,
                   y: e.MarginBounds.Top,
                   width: TextRenderer.MeasureText(todayShamsi, IngredientsFont).Width + 5,
                   height: TextRenderer.MeasureText(todayShamsi, IngredientsFont).Height
                );
            RectangleF detailsRect = new RectangleF(
                   x: dateRect.Right,
                   y: titleRect.Y + 2.0f,
                   width: titleRect.Left - dateRect.Right,
                   height: titleRect.Height
                );

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Near;
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            // Draw string to the page.
            e.Graphics.DrawString(foodToPrint.Name, FoodTitleFont, drawBrush, titleRect, drawFormat);
            e.Graphics.DrawString(foodToPrint.Category, FoodCategoryFont, drawBrush, categoryRect, drawFormat);
            e.Graphics.DrawString("مواد لازم:", IngredientsFont, drawBrush, ingredientsRect, drawFormat);

            // Print recipe one by one for each ingredient.
            List<RecipeIngredient> Recipe = Converter.ToRecipeList(foodToPrint.RecipeString);
            rLine = "";
            foreach (RecipeIngredient Ing in Recipe)
            {
                rLine += FoodDB.GetIngredient(Ing.IngId).name + " - " + Ing.IngAmount + " " + Ing.IngScale + "\n";
            }
            e.Graphics.DrawString(rLine, IngFont, drawBrush, ingsRect, drawFormat);
            e.Graphics.DrawString(todayShamsi, IngredientsFont, drawBrush, dateRect, drawFormat);
            e.Graphics.DrawString(foodToPrint.Details, FoodCategoryFont, drawBrush, detailsRect, drawFormat);
        }
    }
}
