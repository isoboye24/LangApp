using LangApp.DAL.DAO;
using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.BLL
{
    public class GraphBLL
    {
        MonthDAO monthDAO = new MonthDAO();
        YearDAO yearDAO = new YearDAO();
        PartOfSpeechDAO partsOfSpeechDAO = new PartOfSpeechDAO();
        public GraphDTO Select()
        {
            GraphDTO dto = new GraphDTO();
            dto.Months = monthDAO.Select();
            dto.Years = yearDAO.Select();
            dto.PartsOfSpeech = partsOfSpeechDAO.Select();
            return dto;
        }
    }
}
