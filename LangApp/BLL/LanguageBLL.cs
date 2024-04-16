using LangApp.DAL;
using LangApp.DAL.DAO;
using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.BLL
{
    public class LanguageBLL : IBLL<LanguageDTO, LanguageDetailDTO>
    {
        LanguageDAO dao = new LanguageDAO();
        public bool Delete(LanguageDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(LanguageDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(LanguageDetailDTO entity)
        {
            LANGUAGE chosenLang = new LANGUAGE();
            chosenLang.languageID = entity.LanguageID;
            chosenLang.languageListID = entity.LanguageListID;
            chosenLang.userID = entity.UserID;
            return dao.Insert(chosenLang);
        }

        public LanguageDTO Select()
        {
            throw new NotImplementedException();
        }

        public LanguageDTO SelectUserLanguages(int ID)
        {
            LanguageDTO dto = new LanguageDTO();
            dto.LanguagesFromList = dao.SelectUserLanguages(ID);
            return dto;
        }

        public bool Update(LanguageDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        internal List<LanguageDetailDTO> CheckLanguage(int ID, string language)
        {
            return dao.CheckLanguage(ID, language);
        }
    }
}
