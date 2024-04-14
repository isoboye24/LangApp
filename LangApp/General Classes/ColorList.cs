using LangApp.General_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangApp
{
    public class ColorList
    {
        public static ColorProperty Colors(string colorName)
        {
            string textColor = "#f2eeed";
            if (colorName == "Blue")
            {
                ColorProperty properties = new ColorProperty();
                properties.BackColor = "#16077A";
                properties.ForeColor = textColor;
                return properties;
            }
            else if (colorName == "Red")
            {
                ColorProperty properties = new ColorProperty();
                properties.BackColor = "#7A0722";
                properties.ForeColor = textColor;
                return properties;
            }
            else if (colorName == "Green")
            {
                ColorProperty properties = new ColorProperty();
                properties.BackColor = "#083D11";
                properties.ForeColor = textColor;
                return properties;
            }            
            else
            {
                ColorProperty properties = new ColorProperty();
                properties.BackColor = "#f2ebeb";
                properties.ForeColor = "#0d0d0c";
                return properties;
            }
        }
    }    
}
