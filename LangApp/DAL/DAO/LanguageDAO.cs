using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class LanguageDAO : LangContext, IDAO<LanguageDetailDTO, LANGUAGE>
    {
        public bool Delete(LANGUAGE entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(LANGUAGE entity)
        {
            try
            {
                db.LANGUAGEs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LanguageDetailDTO> Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(LANGUAGE entity)
        {
            throw new NotImplementedException();
        }

        internal List<LanguageDetailDTO> SelectUserLanguages(int ID)
        {
            try
            {
                List<LanguageDetailDTO> languages = new List<LanguageDetailDTO>();
                var list = (from l in db.LANGUAGEs.Where(x => x.isDeleted == false && x.userID == ID)
                            join ll in db.LANGUAGE_LIST on l.languageListID equals ll.languageListID
                            select new
                            {
                                languageID = l.languageID,
                                languageListID = l.languageListID,
                                UserID = l.userID,
                                LanguageName = ll.languageName,
                            }).OrderBy(x => x.LanguageName).ToList();
                foreach (var item in list)
                {
                    LanguageDetailDTO dto = new LanguageDetailDTO();
                    dto.LanguageListID = item.languageListID;
                    dto.LanguageID = item.languageID;
                    dto.LanguageName = item.LanguageName;
                    dto.UserID = item.UserID;
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
