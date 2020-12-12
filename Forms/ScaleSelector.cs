using System;
using System.Windows.Forms;
using DastFood.forms;

namespace DastFood.forms
{
    public partial class ScaleSelector : Form
    {
        public ScaleSelector()
        {
            InitializeComponent();
        }

        private void biggerScale_Click(object sender, EventArgs e)
        {
            switch (ingScale.Text)
            {
                case "گرم":
                    ingScale.Text = "کیلوگرم";
                    break;
                case "میلی لیتر":
                    ingScale.Text = "لیتر";
                    break;
                case "بسته":
                    ingScale.Text = "بسته 5 تایی";
                    break;
            }
        }
        private void smallerScale_Click(object sender, EventArgs e)
        {
            switch (ingScale.Text)
            {
                case "کیلوگرم":
                    ingScale.Text = "گرم";
                    break;
                case "لیتر":
                    ingScale.Text = "میلی لیتر";
                    break;
                case "بسته 5 تایی":
                    ingScale.Text = "بسته";
                    break;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(Owner is AddIngredients)
                (Owner as AddIngredients).IngScale.Text = ingScale.Text;
            if (Owner is EditIngredients)
                (Owner as EditIngredients).IngScale.Text = ingScale.Text;
            Close();
        }
    }
}
