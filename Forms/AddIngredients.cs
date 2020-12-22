using System.Drawing;
using System.Windows.Forms;
using DastFood.Classes;
using DastFood.Classes.SQLite;

namespace DastFood.forms
{
    public partial class AddIngredients : Form
    {
        private ScaleSelector scaleSelector;
        private DateSelector dateSelector;

        public AddIngredients()
        {
            InitializeComponent();
        }
        private void IngQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(
                   char.IsDigit(e.KeyChar)
                ||(e.KeyChar.ToString() == "." && ! IngQuantity.Text.Contains(".")) 
                || char.IsControl(e.KeyChar)
                );
        }
        private void btnSelectScale_Click(object sender, System.EventArgs e)
        {
            if (scaleSelector == null || scaleSelector.IsDisposed)
                scaleSelector = new ScaleSelector();
            scaleSelector.Owner = this;
            scaleSelector.Show();
            UIHelper.MakeFormAboveButton(btnSelectScale, scaleSelector);
        }
        private void btnSelectDate_Click(object sender, System.EventArgs e)
        {
            if(dateSelector == null || dateSelector.IsDisposed)
            {
                dateSelector = new DateSelector();
                dateSelector.OK.Click += delegate
                {
                    if (dateSelector.DateIsOK())
                        IngExpireDate.Text = dateSelector.manualDate.Text;
                };
            }
            dateSelector.Show();
            UIHelper.MakeFormAboveButton(btnSelectDate, dateSelector);
        }
        private void OK_Click(object sender, System.EventArgs e)
        {
            if (!ControlsOK()) return;
            int errorCode = FoodDB.AddIngredient(
                Name: IngName.Text,
                Scale: IngScale.Text,
                Quantity: float.Parse(IngQuantity.Text),
                ExpireDate: Converter.ToMiladi(IngExpireDate.Text)
                );
            if(errorCode == 0) Close();
        }

        private bool ControlsOK()
        {
            // Other controls have fixed or unlimited value
            bool QuantityIsOK = float.TryParse(IngQuantity.Text, out _);
            IngName.BackColor = IngName.Text != "" ? Color.White : Color.PaleVioletRed;
            IngQuantity.BackColor = QuantityIsOK ? Color.White : Color.PaleVioletRed;
            return QuantityIsOK
                    && IngName.Text != ""
                    && IngQuantity.Text != ""
                    && IngScale.Text != ""
                    && IngExpireDate.Text != "";
        }

        private void IngQuantity_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
