using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DTO
{
    public class WordGroupDetailDTO
    {
        public int WordGroupID { get; set; }
        public string WordGroupName { get; set; }
        public int PartOfSpeechID { get; set; }
        public string PartOfSpeechName { get; set; }
        public int LanguageID { get; set; } = 1;
    }
}
