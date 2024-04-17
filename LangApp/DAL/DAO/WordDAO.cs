using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class WordDAO : LangContext, IDAO<WordDetailDTO, WORD>
    {
        public bool Delete(WORD entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(WORD entity)
        {
            throw new NotImplementedException();
        }

        public List<WordDetailDTO> Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(WORD entity)
        {
            throw new NotImplementedException();
        }
    }
}
