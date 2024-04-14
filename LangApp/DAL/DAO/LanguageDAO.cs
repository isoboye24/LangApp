using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class LanguageDAO : LangContext, IDAO<LanguageDetailDTO, LANGUAGE>
    {
        public bool Delete(LANGUAGE entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(LANGUAGE entity)
        {
            try
            {
                db.LANGUAGEs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LanguageDetailDTO> Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(LANGUAGE entity)
        {
            throw new NotImplementedException();
        }
    }
}
