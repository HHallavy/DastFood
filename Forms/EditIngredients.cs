using DastFood;
using DastFood.forms;
using System.Drawing;
using System.Windows.Forms;
using DastFood.Classes;
using DastFood.Classes.SQLite;
using DastFood.Classes.Types;

namespace DastFood.forms
{
    public partial class EditIngredients : Form
    {
        private ScaleSelector scaleSelector;
        private DateSelector dateSelector;
        public Ingredient IngToEdit { set; get; }

        public EditIngredients(Ingredient IngToEdit)
        {
            InitializeComponent();
            this.IngToEdit = IngToEdit;
            IngName.Text = this.IngToEdit.name;
            IngScale.Text = this.IngToEdit.scale;
            IngQuantity.Text = this.IngToEdit.quantity.ToString();
            IngExpireDate.Text = Converter.ToShamsi(this.IngToEdit.expireDate);
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
                dateSelector = new DateSelector();
            dateSelector.OK.Click += delegate 
            { 
                if(dateSelector.DateIsOK())
                    IngExpireDate.Text = dateSelector.manualDate.Text;
            };
            dateSelector.Show();
            UIHelper.MakeFormAboveButton(btnSelectDate, dateSelector);
        }
        private void OK_Click(object sender, System.EventArgs e)
        {
            if (!ControlsOK()) return;
            if (IngToEdit == default)
            { 
                MessageBox.Show("شمارنده ماده اولیه مقدار دهی نشده!",
                    "Ingredient ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading
                    );
                return;
            }
            int errorCode = FoodDB.EditIngredient(
                id: IngToEdit.id,
                Name: IngName.Text,
                Scale: IngScale.Text,
                Quantity: float.Parse(IngQuantity.Text),
                ExpireDate: Converter.ToMiladi(IngExpireDate.Text)
                );
            if (errorCode == 0)
            {
                ViewIngredientInventory caller = (ViewIngredientInventory)Owner;
                caller.FillList();
                Close();
            }
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

        private void EditIngredients_Load(object sender, System.EventArgs e)
        {

        }
    }
}
