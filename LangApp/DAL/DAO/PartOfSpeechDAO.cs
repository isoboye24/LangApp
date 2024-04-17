using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class PartOfSpeechDAO:LangContext
    {
        public List<PartOfSpeechDetailDTO> Select()
        {
            try
            {
                List<PartOfSpeechDetailDTO> partsofSpeech = new List<PartOfSpeechDetailDTO>();
                var list = db.PARTS_OF_SPEECH.OrderBy(x => x.partsOfSpeechName).ToList();
                foreach (var item in list)
                {
                    PartOfSpeechDetailDTO dto = new PartOfSpeechDetailDTO();
                    dto.PartOfSpeechID = item.partOfSpeechID;
                    dto.PartOfSpeechName = item.partsOfSpeechName;
                    partsofSpeech.Add(dto);
                }
                return partsofSpeech;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
