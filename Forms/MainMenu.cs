using DastFood.Classes.SQLite;
using DastFood.forms;
using System;
using System.Windows.Forms;
namespace DastFood
{
    public partial class MainMenuForm : Form
    {
        private Ingredients ingredients;
        private Foods foods;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            if(ingredients == null || ingredients.IsDisposed)
                ingredients = new Ingredients();
            ingredients.Show();
            UIHelper.MakeFormAboveButton(btnIngredients,ingredients);
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // Testing  Testing ...
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            if (foods == null || foods.IsDisposed)
                foods = new Foods();
            foods.Show();
            UIHelper.MakeFormAboveButton(btnFoods, foods);
        }
    }
}
