using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class LanguagesDAO : LangContext
    {
        public List<LanguagesDetailDTO> Select()
        {
			try
			{
                List<LanguagesDetailDTO> languages = new List<LanguagesDetailDTO>();
                var list = db.LANGUAGE_LIST.OrderBy(x=>x.languageName).ToList();
                foreach (var item in list)
                {
                    LanguagesDetailDTO dto = new LanguagesDetailDTO();
                    dto.LanguageID = item.languageListID;
                    dto.Language = item.languageName;
                    languages.Add(dto);
                }
                return languages;
            }
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
