using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangApp.DAL.DAO
{
    public class WordDAO : LangContext, IDAO<WordDetailDTO, WORD>
    {
        public bool Delete(WORD entity)
        {
            try
            {
                WORD word = db.WORDs.First(x=>x.wordID == entity.wordID);
                word.isDeleted = true;
                word.deletedDate = DateTime.Today;
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

        public bool Insert(WORD entity)
        {
            try
            {
                db.WORDs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<WordDetailDTO> Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(WORD entity)
        {
            try
            {
                WORD word = db.WORDs.First(x=>x.wordID==entity.wordID);
                word.wordID = entity.wordID;
                word.userID = entity.userID;
                word.caseID = entity.caseID;
                word.wordGroupID = entity.wordGroupID;
                word.languageID = entity.languageID;
                word.monthID = entity.monthID;
                word.partOfSpeechID = entity.partOfSpeechID;
                word.word1 = entity.word1;
                word.explanation = entity.explanation;
                word.day = entity.day;
                word.year = entity.year;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<WORD> CheckThisWord(int userID, int languageID, string word, int wordGroup, int wordCase, int partOfSpeech)
        {
            try
            {
                var list = db.WORDs.Where(x=>x.isDeleted == false && x.userID==userID && x.languageID==languageID && x.word1==word && x.wordGroupID == wordGroup && x.caseID == wordCase && x.partOfSpeechID==partOfSpeech).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int WordCount(int userID, int language, string parts, int month, int year)
        {
            try
            {
                int count = 0;
                var list = (from w in db.WORDs.Where(x => x.isDeleted == false && x.userID == userID && x.languageID == language && x.monthID == month && x.year == year)
                            join p in db.PARTS_OF_SPEECH.Where(x=>x.partsOfSpeechName==parts) on w.partOfSpeechID equals p.partOfSpeechID
                            select new
                            {
                                wordID = w.wordID,
                                partOfSpeech = p.partsOfSpeechName,
                            }).ToList();
                foreach (var item in list)
                {
                    count++;
                }
                int totalWords = count;
                return totalWords;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
        public int WordCountYearly(int userID, int language, string parts, int year)
        {
            try
            {
                int count = 0;
                var list = (from w in db.WORDs.Where(x => x.isDeleted == false && x.userID == userID && x.languageID == language && x.year == year)
                            join p in db.PARTS_OF_SPEECH.Where(x => x.partsOfSpeechName == parts) on w.partOfSpeechID equals p.partOfSpeechID
                            select new
                            {
                                wordID = w.wordID,
                                partOfSpeech = p.partsOfSpeechName,
                            }).ToList();
                foreach (var item in list)
                {
                    count++;
                }
                int totalWords = count;
                return totalWords;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal List<WordDetailDTO> Select(int userID, int languageID)
        {
            try
            {
                List<WordDetailDTO> words = new List<WordDetailDTO>();
                var list = (from w in db.WORDs.Where(x => x.isDeleted == false && x.userID == userID && x.languageID == languageID)
                            join p in db.PARTS_OF_SPEECH on w.partOfSpeechID equals p.partOfSpeechID
                            join m in db.MONTHs on w.monthID equals m.monthID
                            join wc in db.WORD_CASES.Where(x => x.isDeleted == false) on w.caseID equals wc.caseID
                            join wg in db.WORD_GROUP.Where(x => x.isDeleted == false) on w.wordGroupID equals wg.wordGroupID
                            select new
                            {
                                wordID = w.wordID,
                                word = w.word1,
                                userID = w.userID,
                                languageID = w.languageID,
                                monthID = w.monthID,
                                monthName = m.monthName,
                                partOfSpeechID = w.partOfSpeechID,
                                partOfSpeechName = p.partsOfSpeechName,
                                caseID = w.caseID,
                                caseName = wc.caseName,
                                groupID = w.wordGroupID,
                                groupName = wg.wordGroupName,
                                day = w.day,
                                year = w.year,
                                explanation = w.explanation,
                            }).OrderByDescending(x => x.year).ThenByDescending(x => x.monthID).ThenByDescending(x => x.day).ThenBy(x => x.word).ToList();
                foreach (var item in list)
                {
                    WordDetailDTO dto = new WordDetailDTO();
                    dto.WordID = item.wordID;
                    dto.Word = item.word;
                    dto.UserID = item.userID;
                    dto.LanguageID = item.languageID;
                    dto.MonthID = item.monthID;
                    dto.MonthName = item.monthName;
                    dto.PartOfSpeechID = item.partOfSpeechID;
                    dto.PartOfSpeechName = item.partOfSpeechName;
                    dto.WordCaseID = item.caseID;
                    dto.WordCaseName = item.caseName;
                    dto.WordGroupID = item.groupID;
                    dto.WordGroupName = item.groupName;
                    dto.Day = item.day;
                    dto.Year = item.year;
                    dto.Explanation = item.explanation;
                    words.Add(dto);
                }
                return words;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal int SelectTotalWords(int userID, int languageID)
        {
            try
            {
                int wordsCount = db.WORDs.Count(x => x.isDeleted == false && x.userID == userID && x.languageID == languageID);
                return wordsCount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal List<WordDetailDTO> SelectSpecificWords(int userID, int languageID, string specificWords)
        {
            try
            {
                int wordsCount = 0;
                List<WordDetailDTO> words = new List<WordDetailDTO>();
                var list = (from w in db.WORDs.Where(x => x.isDeleted == false && x.userID == userID && x.languageID == languageID)
                            join p in db.PARTS_OF_SPEECH.Where(x=>x.partsOfSpeechName == specificWords) on w.partOfSpeechID equals p.partOfSpeechID
                            join m in db.MONTHs on w.monthID equals m.monthID
                            join wc in db.WORD_CASES.Where(x => x.isDeleted == false) on w.caseID equals wc.caseID
                            join wg in db.WORD_GROUP.Where(x => x.isDeleted == false) on w.wordGroupID equals wg.wordGroupID
                            select new
                            {
                                wordID = w.wordID,
                                word = w.word1,
                                userID = w.userID,
                                languageID = w.languageID,
                                monthID = w.monthID,
                                monthName = m.monthName,
                                partOfSpeechID = w.partOfSpeechID,
                                partOfSpeechName = p.partsOfSpeechName,
                                caseID = w.caseID,
                                caseName = wc.caseName,
                                groupID = w.wordGroupID,
                                groupName = wg.wordGroupName,
                                day = w.day,
                                year = w.year,
                                explanation = w.explanation,
                            }).OrderByDescending(x => x.year).ThenByDescending(x => x.monthID).ThenBy(x => x.word).ToList();
                foreach (var item in list)
                {
                    WordDetailDTO dto = new WordDetailDTO();
                    wordsCount++;
                    dto.WordsCount = wordsCount;
                    dto.WordID = item.wordID;
                    dto.Word = item.word;
                    dto.UserID = item.userID;
                    dto.LanguageID = item.languageID;
                    dto.MonthID = item.monthID;
                    dto.MonthName = item.monthName;
                    dto.PartOfSpeechID = item.partOfSpeechID;
                    dto.PartOfSpeechName = item.partOfSpeechName;
                    dto.WordCaseID = item.caseID;
                    dto.WordCaseName = item.caseName;
                    dto.WordGroupID = item.groupID;
                    dto.WordGroupName = item.groupName;
                    dto.Day = item.day;
                    dto.Year = item.year;
                    dto.Explanation = item.explanation;
                    words.Add(dto);
                }
                return words;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
