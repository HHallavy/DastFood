using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DastFood.Classes;
using DastFood.Classes.SQLite;
using DastFood.Classes.Types;

namespace DastFood.forms
{
    public partial class EditFood : Form
    {
        private IngredientSelector ingredientSelector;
        public Food FoodToEdit { get; internal set; }
        public EditFood(Food FoodToEdit)
        {
            InitializeComponent();
            if (FoodToEdit == null) Close();
            
            FoodCategory.Items.AddRange(FoodDB.GetFoodCategories());

            this.FoodToEdit = FoodToEdit;
            FoodName.Text = FoodToEdit.Name;

            FoodCategory.Text = FoodToEdit.Category;

            FoodSelfService.Checked = FoodToEdit.isSelfService;
            FoodDetails.Text = FoodToEdit.Details;
            
            RecipeString = FoodToEdit.RecipeString;
            List<RecipeIngredient> ingredients = Converter.ToRecipeList(RecipeString);
            foreach (RecipeIngredient Ing in ingredients)
            {
                listIngredients.Items.Add(FoodDB.GetIngredient(Ing.IngId).name + " - " + Ing.IngAmount);
            }
        }

        public string RecipeString { get; internal set; }

        private void chooseIngredients_Click(object sender, EventArgs e)
        {
            if (ingredientSelector == null || ingredientSelector.IsDisposed)
            {
                ingredientSelector = new IngredientSelector();
                ingredientSelector.Owner = this;
            }
            ingredientSelector.Show();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (!ControlsOK()) return;
            int errorCode = FoodDB.EditFood(
                id: FoodToEdit.Id,
                Name: FoodName.Text,
                Ingredients: RecipeString,
                SelfService: FoodSelfService.Checked,
                Category: FoodCategory.Text,
                Details: FoodDetails.Text
                );
            if(errorCode == 0)
            {
                ShowAllFood showAllFood = (ShowAllFood)Owner;
                showAllFood.FillList();
                showAllFood.FoodTable_RowEnter(null, null);
                Close();
            }
        }

        private bool ControlsOK()
        {
            FoodName.BackColor = FoodName.Text == "" ? Color.PaleVioletRed : Color.White;
            listIngredients.BackColor = listIngredients.Items.Count == 0 ? Color.PaleVioletRed : Color.White;
            FoodCategory.BackColor = FoodCategory.Text == "" ? Color.PaleVioletRed : Color.White;

            return FoodName.Text != ""
                && FoodCategory.Text != ""
                && listIngredients.Items.Count != 0
                && RecipeString != "";
        }
    }
}
