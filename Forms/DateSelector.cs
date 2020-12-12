using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace DastFood.forms
{
    public partial class DateSelector : Form
    {
        public DateSelector()
        {
            InitializeComponent();
        }

        private void day_DoubleClick(object sender, EventArgs e)
        {
            day.Text = "";
        }

        private void year_DoubleClick(object sender, EventArgs e)
        {
            year.Text = "";
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)|| char.IsControl(e.KeyChar));
        }
        private void DateInput_Changed(object sender, EventArgs e)
        {
            if (UIHelper.
                    DateControlOK(day,month,year))
            {
                manualDate.Text = year.Text.PadLeft(4,'0') + "/" + (month.SelectedIndex + 1).ToString("00") + "/" + day.Text.PadLeft(2,'0');
            }
            else
            {
                manualDate.BackColor = Color.PaleVioletRed;
            }
        }

        private void DateSelector_Load(object sender, EventArgs e)
        {
            PersianCalendar Shamsi = new PersianCalendar();
            DateTime Now = DateTime.Now;
            year.Text = Shamsi.GetYear(Now).ToString();
            month.SelectedIndex = Shamsi.GetMonth(Now)-1 /*Index Starts At 0*/;
            day.Text = Shamsi.GetDayOfMonth(Now).ToString();
        }

        private void manualDate_TextChanged(object sender, EventArgs e)
        {
            if (!manualDate.MaskFull) return;

            int _day, _month, _year;
            string[] dateEntities = manualDate.Text.Split('/');
            _year = int.Parse(dateEntities[0]);
            _month = int.Parse(dateEntities[1]);
            _day = int.Parse(dateEntities[2]);

            manualDate.BackColor = UIHelper.DateOK(_day, _month, _year) ?
                                    Color.White : Color.PaleVioletRed;
        }
        public bool DateIsOK()
        {
            return manualDate.BackColor != Color.PaleVioletRed;
        }
        private void OK_Click(object sender, EventArgs e)
        {
            if (DateIsOK()) Close();
        }

        private void DateSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!DateIsOK()) 
                MessageBox.Show(
                    text: "ورودی ها درست وارد نشدند. تاریخ جدید اعمال نمی شود",
                    caption: "ورودی نامعتبر",
                    buttons: MessageBoxButtons.OK,
                    defaultButton: MessageBoxDefaultButton.Button1,
                    icon: MessageBoxIcon.Warning,
                    options: MessageBoxOptions.RtlReading);
        }
    }
}