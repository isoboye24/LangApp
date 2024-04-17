using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class WordCaseDAO : LangContext, IDAO<WordCaseDetailDTO, WORD_CASES>
    {
        public bool Delete(WORD_CASES entity)
        {
           
            try
            {
                WORD_CASES wordCase = db.WORD_CASES.First(x=>x.caseID == entity.caseID);
                wordCase.isDeleted = true;
                wordCase.deletedDate = DateTime.Today;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(WORD_CASES entity)
        {
            try
            {
                db.WORD_CASES.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int checkWord(string word, int ID)
        {
            try
            {
                int wordCount = db.WORD_CASES.Count(x => x.isDeleted == false && x.caseName == word && x.languageID == ID);                
                return wordCount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<WordCaseDetailDTO> Select()
        {
            throw new NotImplementedException();
        }
        public List<WordCaseDetailDTO> Select(int ID)
        {
            try
            {
                List<WordCaseDetailDTO> wordCases = new List<WordCaseDetailDTO>();
                var list = db.WORD_CASES.Where(x => x.isDeleted == false && x.languageID == ID);
                foreach (var item in list)
                {
                    WordCaseDetailDTO dto = new WordCaseDetailDTO();
                    dto.WordCaseID = item.caseID;
                    dto.WordCaseName = item.caseName;
                    dto.LanguageID = item.languageID;
                    wordCases.Add(dto);
                }
                return wordCases;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(WORD_CASES entity)
        {
            try
            {
                WORD_CASES wordCase = db.WORD_CASES.First(x=>x.caseID == entity.caseID);
                wordCase.caseName = entity.caseName;
                wordCase.languageID = entity.languageID;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
