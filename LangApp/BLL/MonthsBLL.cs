using LangApp.DAL.DAO;
using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.BLL
{
    public class MonthsBLL
    {
        MonthDAO dao = new MonthDAO();
        public MonthDTO Select()
        {
            MonthDTO dto = new MonthDTO();
            dto.Months = dao.Select();
            return dto;
        }
    }
}
