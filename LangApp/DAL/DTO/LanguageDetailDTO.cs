using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DTO
{
    public class LanguageDetailDTO
    {
        public int LanguageID { get; set; } = 1;
        public int LanguageListID { get; set; }
        public string LanguageName { get; set; }
        public int UserID { get; set; }
    }
}
