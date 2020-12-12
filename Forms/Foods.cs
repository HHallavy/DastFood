using System;
using System.Windows.Forms;

namespace DastFood.forms
{
    public partial class Foods : Form
    {
        private AddFood addFood;
        private ShowAllFood showAllFood;

        public Foods()
        {
            InitializeComponent();
        }

        private void btnNewFood_Click(object sender, EventArgs e)
        {
            if(addFood == null || addFood.IsDisposed)
                addFood = new AddFood();
            addFood.Show();
            Hide();
        }

        private void btnEditFoods_Click(object sender, EventArgs e)
        {
            if (showAllFood == null || showAllFood.IsDisposed)
                showAllFood = new ShowAllFood();
            showAllFood.Show();
            Hide();
        }
    }
}
