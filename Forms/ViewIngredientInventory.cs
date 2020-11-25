using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DastFood.forms
{
    public partial class ViewIngredientInventory : Form
    {
        public ViewIngredientInventory()
        {
            InitializeComponent();
        }

        private void ViewIngredientInventory_Load(object sender, EventArgs e)
        {
            InventoryTable.Rows.Add(new object[] { "Pickles","1231","hsdfhj" });
        }

        private void InventoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
