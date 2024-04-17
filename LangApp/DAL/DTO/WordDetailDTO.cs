using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DTO
{
    public class WordDetailDTO
    {
        public int WordID { get; set; }
        public int UserID { get; set; }
        public int LanguageID { get; set; }
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public string Word { get; set; }
        public int Day { get; set; }
        public int MonthID { get; set; }
        public string MonthName { get; set; }
        public int Year { get; set; }
        public string Explanation { get; set; }
    }
}
