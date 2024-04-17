using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class WordGroupDAO : LangContext, IDAO<WordGroupDetailDTO, WORD_GROUP>
    {
        public bool Delete(WORD_GROUP entity)
        {
            WORD_GROUP wordGroup = db.WORD_GROUP.First(x=>x.wordGroupID == entity.wordGroupID);
            wordGroup.isDeleted = true;
            wordGroup.deletedDate = DateTime.Today;
            db.SaveChanges();
            return true;
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(WORD_GROUP entity)
        {
            try
            {
                db.WORD_GROUP.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<WordGroupDetailDTO> Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(WORD_GROUP entity)
        {
            try
            {
                WORD_GROUP wordGroup = db.WORD_GROUP.First(x=>x.wordGroupID == entity.wordGroupID);
                wordGroup.wordGroupName = entity.wordGroupName;
                wordGroup.partOfSpeechID = entity.partOfSpeechID;
                wordGroup.languageID = entity.languageID;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int checkGroup(string group, int languageID)
        {
            try
            {
                int groupCout = db.WORD_GROUP.Count(x=>x.isDeleted == false && x.wordGroupName == group && x.languageID == languageID);
                return groupCout;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        internal List<WordGroupDetailDTO> Select(int languageID)
        {
            try
            {
                List<WordGroupDetailDTO> wordGroups = new List<WordGroupDetailDTO>();
                var list = (from wg in db.WORD_GROUP.Where(x => x.isDeleted == false && x.languageID == languageID)
                            join p in db.PARTS_OF_SPEECH on wg.partOfSpeechID equals p.partOfSpeechID
                            select new
                            {
                                wordGroupID = wg.wordGroupID,
                                wordGroupName = wg.wordGroupName,
                                partOfSpeechID = wg.partOfSpeechID,
                                partOfSpeechName = p.partsOfSpeechName,
                                languageID = wg.languageID,
                            }).OrderBy(x => x.wordGroupName).ToList();
                foreach (var item in list)
                {
                    WordGroupDetailDTO dto = new WordGroupDetailDTO();
                    dto.WordGroupID = item.wordGroupID;
                    dto.WordGroupName = item.wordGroupName;
                    dto.PartOfSpeechID = item.partOfSpeechID;
                    dto.PartOfSpeechName = item.partOfSpeechName;
                    dto.LanguageID = item.languageID;
                    wordGroups.Add(dto);
                }
                return wordGroups;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
