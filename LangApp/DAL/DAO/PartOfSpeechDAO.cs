using LangApp.DAL.DTO;
using LangApp.General_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class PartOfSpeechDAO:LangContext, IDAO<PartOfSpeechDetailDTO, PARTS_OF_SPEECH>
    {
        public bool Delete(PARTS_OF_SPEECH entity)
        {
            try
            {
                PARTS_OF_SPEECH partOfSpeech = db.PARTS_OF_SPEECH.First(x=>x.partOfSpeechID == entity.partOfSpeechID);
                partOfSpeech.isDeleted = true;
                partOfSpeech.deletedDate = DateTime.Today;
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

        public bool Insert(PARTS_OF_SPEECH entity)
        {
            try
            {
                db.PARTS_OF_SPEECH.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PartOfSpeechDetailDTO> Select()
        {
            try
            {
                List<PartOfSpeechDetailDTO> partsofSpeech = new List<PartOfSpeechDetailDTO>();
                var list = db.PARTS_OF_SPEECH.Where(x=>x.isDeleted == false && x.LanguageID == StaticUser.LanguageID).OrderBy(x => x.partsOfSpeechName).ToList();
                foreach (var item in list)
                {
                    PartOfSpeechDetailDTO dto = new PartOfSpeechDetailDTO();
                    dto.PartOfSpeechID = item.partOfSpeechID;
                    dto.PartOfSpeechName = item.partsOfSpeechName;
                    dto.LanguageID = item.LanguageID;
                    partsofSpeech.Add(dto);
                }
                return partsofSpeech;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(PARTS_OF_SPEECH entity)
        {
            try
            {
                PARTS_OF_SPEECH partOfSpeech = db.PARTS_OF_SPEECH.First(x => x.partOfSpeechID == entity.partOfSpeechID);
                partOfSpeech.partsOfSpeechName = entity.partsOfSpeechName;
                partOfSpeech.LanguageID = entity.LanguageID;
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
