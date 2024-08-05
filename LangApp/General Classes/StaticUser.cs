using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.General_Classes
{
    public static class StaticUser
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int LanguageID { get; set; } = 1;
    }
}
