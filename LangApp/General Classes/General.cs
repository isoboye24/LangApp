using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangApp
{
    public class General
    {
        public static bool isNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void ComboBoxProps(ComboBox cmb, string name, string ID)
        {
            cmb.DisplayMember = name;
            cmb.ValueMember = ID;
            cmb.SelectedIndex = -1;
        }
        public static string ConventIntToMonth(int month)
        {
            if (month == 1)
            {
                return "January";
            }
            else if (month == 2)
            {
                return "February";
            }
            else if (month == 3)
            {
                return "March";
            }
            else if (month == 4)
            {
                return "April";
            }
            else if (month == 5)
            {
                return "May";
            }
            else if (month == 6)
            {
                return "June";
            }
            else if (month == 7)
            {
                return "July";
            }
            else if (month == 8)
            {
                return "August";
            }
            else if (month == 9)
            {
                return "September";
            }
            else if (month == 10)
            {
                return "October";
            }
            else if (month == 11)
            {
                return "November";
            }
            else if (month == 12)
            {
                return "December";
            }
            else
            {
                return "Unknown month";
            }
        }

        public static string ConventIntToMonthGerman(int month)
        {
            if (month == 1)
            {
                return "Januar";
            }
            else if (month == 2)
            {
                return "Februar";
            }
            else if (month == 3)
            {
                return "März";
            }
            else if (month == 4)
            {
                return "April";
            }
            else if (month == 5)
            {
                return "Mai";
            }
            else if (month == 6)
            {
                return "Juni";
            }
            else if (month == 7)
            {
                return "Juli";
            }
            else if (month == 8)
            {
                return "August";
            }
            else if (month == 9)
            {
                return "September";
            }
            else if (month == 10)
            {
                return "Oktober";
            }
            else if (month == 11)
            {
                return "November";
            }
            else if (month == 12)
            {
                return "Dezember";
            }
            else
            {
                return "Unbekannter Monat";
            }
        }

        public static string ConventIntToMonthRussian(int month)
        {
            if (month == 1)
            {
                return "Январь";
            }
            else if (month == 2)
            {
                return "Фeвраль";
            }
            else if (month == 3)
            {
                return "Марта";
            }
            else if (month == 4)
            {
                return "Апрель";
            }
            else if (month == 5)
            {
                return "Maй";
            }
            else if (month == 6)
            {
                return "Июнь";
            }
            else if (month == 7)
            {
                return "Июль";
            }
            else if (month == 8)
            {
                return "Август";
            }
            else if (month == 9)
            {
                return "Сентябрь";
            }
            else if (month == 10)
            {
                return "Октябрь";
            }
            else if (month == 11)
            {
                return "Ноябрь";
            }
            else if (month == 12)
            {
                return "Декабрь";
            }
            else
            {
                return "Такова месяца нету";
            }
        }
    }
}
