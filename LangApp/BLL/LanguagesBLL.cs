using LangApp.DAL.DAO;
using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.BLL
{
    public class LanguagesBLL
    {
        LanguagesDAO dao = new LanguagesDAO();
        public LanguagesDTO Select()
        {
            LanguagesDTO dto = new LanguagesDTO();
            dto.Languages = dao.Select();
            return dto;
        }
    }
}
