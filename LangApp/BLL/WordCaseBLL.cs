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
    public class WordCaseBLL : IBLL<WordCaseDTO, WordCaseDetailDTO>
    {
        WordCaseDAO dao = new WordCaseDAO();
        public bool Delete(WordCaseDetailDTO entity)
        {
            WORD_CASES wordCase = new WORD_CASES();
            wordCase.caseID = entity.WordCaseID;
            return dao.Delete(wordCase);
        }

        public bool GetBack(WordCaseDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(WordCaseDetailDTO entity)
        {
            WORD_CASES wordCase = new WORD_CASES();
            wordCase.languageID = entity.LanguageID;
            wordCase.caseName = entity.WordCaseName;
            return dao.Insert(wordCase);
        }
        public int checkWord(string word, int ID)
        {
            return dao.checkWord(word, ID);
        }

        public WordCaseDTO Select()
        {
            throw new NotImplementedException();
        }
        public WordCaseDTO Select(int ID)
        {
            WordCaseDTO dto = new WordCaseDTO();
            dto.WordCases = dao.Select(ID);
            return dto;
        }

        public bool Update(WordCaseDetailDTO entity)
        {
            WORD_CASES wordCase = new WORD_CASES();
            wordCase.caseID = entity.WordCaseID;
            wordCase.languageID = entity.LanguageID;
            wordCase.caseName = entity.WordCaseName;
            return dao.Update(wordCase);
        }
    }
}
