using System;
using System.Windows.Forms;

namespace DastFood.forms
{
    public partial class Ingredients : Form
    {
        private AddIngredients addIngredient;
        private ViewIngredientInventory viewInventory;

        public Ingredients()
        {
            InitializeComponent();
        }

        private void btnAddNewIngredient_Click(object sender, EventArgs e)
        {
            if(addIngredient == null || addIngredient.IsDisposed)
                addIngredient = new AddIngredients();
            addIngredient.Show();
            Hide();
        }

        private void btnEditIngredients_Click(object sender, EventArgs e)
        {
            if(viewInventory == null || viewInventory.IsDisposed)
                viewInventory = new ViewIngredientInventory();
            viewInventory.Show();
            Hide();
        }
    }
}
