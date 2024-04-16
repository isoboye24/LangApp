using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class UserDAO : LangContext, IDAO<UserDetailDTO, REGISTER>
    {
        public bool Delete(REGISTER entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(REGISTER entity)
        {
            try
            {
                db.REGISTERs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<UserDetailDTO> Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(REGISTER entity)
        {
            throw new NotImplementedException();
        }

        internal List<REGISTER> CheckUser(string password, string username)
        {
            try
            {
                var list = db.REGISTERs.Where(x=>x.isDeleted == false && x.username == username && x.password == password).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
