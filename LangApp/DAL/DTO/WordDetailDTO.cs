using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DTO
{
    public class WordDetailDTO
    {
        public int WordsCount { get; set; }
        public int WordID { get; set; }
        public int UserID { get; set; }
        public int LanguageID { get; set; }
        public int MonthID { get; set; }
        public int PartOfSpeechID { get; set; }
        public int WordCaseID { get; set; }
        public int WordGroupID { get; set; }
        public string Word { get; set; }
        public string WordGroupName { get; set; }
        public string PartOfSpeechName { get; set; }
        public string WordCaseName { get; set; }
        public int Day { get; set; }
        public string MonthName { get; set; }
        public int Year { get; set; }
        public string Explanation { get; set; }
    }
}
