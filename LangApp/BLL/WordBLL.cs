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
    public class WordBLL : IBLL<WordDTO, WordDetailDTO>
    {
        PartOfSpeechDAO partsDAO = new PartOfSpeechDAO();
        WordCaseDAO caseDAO = new WordCaseDAO();
        WordGroupDAO groupDAO = new WordGroupDAO();
        WordDAO dao = new WordDAO();
        MonthDAO monthDAO = new MonthDAO();
        public bool Delete(WordDetailDTO entity)
        {
            WORD word = new WORD();
            word.wordID = entity.WordID;
            return dao.Delete(word);
        }

        public bool GetBack(WordDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(WordDetailDTO entity)
        {
            WORD word = new WORD();
            word.userID = entity.UserID;
            word.caseID = entity.WordCaseID;
            word.wordGroupID = entity.WordGroupID;
            word.languageID = entity.LanguageID;
            word.monthID = entity.MonthID;
            word.partOfSpeechID = entity.PartOfSpeechID;
            word.word1 = entity.Word;
            word.explanation = entity.Explanation;
            word.day = entity.Day;
            word.year = entity.Year;
            return dao.Insert(word);
        }

        public WordDTO Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(WordDetailDTO entity)
        {
            WORD word = new WORD();
            word.wordID = entity.WordID;
            word.userID = entity.UserID;
            word.caseID = entity.WordCaseID;
            word.wordGroupID = entity.WordGroupID;
            word.languageID = entity.LanguageID;
            word.monthID = entity.MonthID;
            word.partOfSpeechID = entity.PartOfSpeechID;
            word.word1 = entity.Word;
            word.explanation = entity.Explanation;
            word.day = entity.Day;
            word.year = entity.Year;
            return dao.Update(word);
        }

        public List<WORD> CheckThisWord(int userID, int languageID, string word, int wordGroup, int wordCase, int partOfSpeech)
        {
            return dao.CheckThisWord(userID, languageID, word, wordGroup, wordCase, partOfSpeech);
        }

        public WordDTO Select(int userID, int languageID)
        {
            WordDTO dto = new WordDTO();
            dto.WordCases = caseDAO.Select(languageID);
            dto.WordGroups = groupDAO.Select(languageID);
            dto.PartsOfSpeech = partsDAO.Select();
            dto.Months = monthDAO.Select();
            dto.Words = dao.Select(userID, languageID);
            dto.PhraseWords = dao.SelectSpecificWords(userID, languageID, "Phrase or Idiom");
            dto.Nouns = dao.SelectSpecificWords(userID, languageID, "Noun");
            dto.Adjectives = dao.SelectSpecificWords(userID, languageID, "Adjective");
            dto.Verbs = dao.SelectSpecificWords(userID, languageID, "Verb");
            dto.Sentences = dao.SelectSpecificWords(userID, languageID, "Sentence");
            return dto;
        }

        internal int SelectTotalWords(int userID, int languageID)
        {
            return dao.SelectTotalWords(userID, languageID);
        }
        internal int WordCount(int userID, int language, string parts, int month, int year)
        {
            return dao.WordCount(userID, language, parts, month, year);
        }
        internal int WordCountYearly(int userID, int language, string parts, int year)
        {
            return dao.WordCountYearly(userID, language, parts, year);
        }
    }
}
