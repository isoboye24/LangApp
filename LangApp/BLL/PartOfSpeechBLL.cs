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
    public class PartOfSpeechBLL:IBLL<PartOfSpeechDTO, PartOfSpeechDetailDTO>
    {
        PartOfSpeechDAO dao = new PartOfSpeechDAO();

        public bool Delete(PartOfSpeechDetailDTO entity)
        {
            PARTS_OF_SPEECH partOfSpeech = new PARTS_OF_SPEECH();
            partOfSpeech.partOfSpeechID = entity.PartOfSpeechID;
            return dao.Delete(partOfSpeech);
        }

        public bool GetBack(PartOfSpeechDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PartOfSpeechDetailDTO entity)
        {
            PARTS_OF_SPEECH partOfSpeech = new PARTS_OF_SPEECH();
            partOfSpeech.LanguageID = entity.LanguageID;
            partOfSpeech.partsOfSpeechName = entity.PartOfSpeechName;
            return dao.Insert(partOfSpeech);
        }

        public PartOfSpeechDTO Select()
        {
            PartOfSpeechDTO dto = new PartOfSpeechDTO();
            dto.PartsOfSpeech = dao.Select();
            return dto;
        }

        public bool Update(PartOfSpeechDetailDTO entity)
        {
            PARTS_OF_SPEECH partOfSpeech = new PARTS_OF_SPEECH();
            partOfSpeech.partOfSpeechID = entity.PartOfSpeechID;
            partOfSpeech.partsOfSpeechName = entity.PartOfSpeechName;
            partOfSpeech.LanguageID = entity.LanguageID;
            return dao.Update(partOfSpeech);
        }
    }
}
