using System.Drawing;
using System.Windows.Forms;

namespace DastFood
{
    static class UIHelper
    {
        public static void MakeFormAboveButton(Button button, Form form)
        {
            form.Left = button.FindForm().Left + button.Left;
            form.Top = button.FindForm().Top + button.Top;
            form.Focus();
        }
        public static bool DateControlOK(TextBox Day,ComboBox Month,TextBox Year)
        {
            int yearNumber,dayNumber;
            bool DayIsNumric = int.TryParse(Day.Text, out dayNumber);
            bool YearIsNumric = int.TryParse(Year.Text,out yearNumber);

            if(!YearIsNumric || yearNumber <= 1200){
                Year.BackColor = Color.PaleVioletRed;
                return false;
            }
            else
            {
                Year.BackColor = Color.White;
            }
            if(!DayIsNumric || !ValidDayShamsi(dayNumber, Month.SelectedIndex + 1, yearNumber)){
                Day.BackColor = Color.PaleVioletRed;
                return false;
            }
            else
            {
                Day.BackColor = Color.White;
            }
            return true;
        }
        public static bool DateOK(int Day, int Month, int Year)
        {
            return (Year > 1200 && ValidDayShamsi(Day, Month, Year));
        }

        private static bool ValidDayShamsi(int _Day, int _Month, int _Year)
        {
            switch (_Month)
            {
                case 1:case 2:case 3:case 4:case 5:case 6:
                    if (_Day > 0 && _Day <= 31) return true;
                    break;
                case 11:case 7:case 8:case 9:case 10:
                    if(_Day > 0 && _Day <= 30) return true;
                    break;
                case 12:
                    switch(_Year % 33)
                    {
                        case 1:case 5:case 9:case 13:case 17:case 22:case 26:case 30:
                            if (_Day > 0 && _Day <= 30) return true;
                            break;
                        default:
                            if (_Day > 0 && _Day <= 29) return true;
                            break;
                    }
                    break;
            }
            return false;
        }
    }
}
