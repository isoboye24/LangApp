using LangApp.DAL.DAO;
using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.BLL
{
    public class PartOfSpeechBLL
    {
        PartOfSpeechDAO dao = new PartOfSpeechDAO();
        public PartOfSpeechDTO Select()
        {
            PartOfSpeechDTO dto = new PartOfSpeechDTO();
            dto.PartsOfSpeech = dao.Select();
            return dto;
        }
    }
}
