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
    public class WordGroupBLL : IBLL<WordGroupDTO, WordGroupDetailDTO>
    {
        WordGroupDAO dao = new WordGroupDAO();

        PartOfSpeechDAO partDAO = new PartOfSpeechDAO();
        public bool Delete(WordGroupDetailDTO entity)
        {
            WORD_GROUP wordGroup = new WORD_GROUP();
            wordGroup.wordGroupID = entity.WordGroupID;
            return dao.Delete(wordGroup);
        }

        public bool GetBack(WordGroupDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(WordGroupDetailDTO entity)
        {
            WORD_GROUP wordGroup = new WORD_GROUP();
            wordGroup.wordGroupName = entity.WordGroupName;
            wordGroup.partOfSpeechID = entity.PartOfSpeechID;
            wordGroup.languageID = entity.LanguageID;
            return dao.Insert(wordGroup);
        }

        public WordGroupDTO Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(WordGroupDetailDTO entity)
        {
            WORD_GROUP wordGroup = new WORD_GROUP();
            wordGroup.wordGroupID = entity.WordGroupID;
            wordGroup.wordGroupName = entity.WordGroupName;
            wordGroup.partOfSpeechID = entity.PartOfSpeechID;
            wordGroup.languageID = entity.LanguageID;
            return dao.Update(wordGroup);
        }

        public int checkGroup(string group, int languageID)
        {
            return dao.checkGroup(group, languageID);
        }

        public WordGroupDTO Select(int languageID)
        {
            WordGroupDTO dto = new WordGroupDTO();
            dto.WordGroups = dao.Select(languageID);
            dto.PartsOfSpeech = partDAO.Select();
            return dto;
        }
    }
}
