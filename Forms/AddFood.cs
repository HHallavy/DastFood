﻿using System;
using System.Drawing;
using System.Windows.Forms;
using DastFood.Classes.SQLite;

namespace DastFood.forms
{
    public partial class AddFood : Form
    {
        private IngredientSelector ingredientSelector;

        public AddFood()
        {
            InitializeComponent();
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
            int errorCode = FoodDB.AddFood(
                Name: FoodName.Text,
                Ingredients: RecipeString,
                SelfService: FoodSelfService.Checked,
                Category: FoodCategory.Text,
                Details: FoodDetails.Text
                );
            if(errorCode == 0) Close();
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

        private void AddFood_Load(object sender, EventArgs e)
        {
            FoodCategory.Items.AddRange(FoodDB.GetFoodCategories());
        }
    }
}
