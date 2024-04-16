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
    public class UserBLL : IBLL<UserDTO, UserDetailDTO>
    {
        UserDAO dao = new UserDAO();
        public bool Delete(UserDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(UserDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(UserDetailDTO entity)
        {
            REGISTER user = new REGISTER();
            user.username = entity.Username;
            user.password = entity.Password;
            user.surname = entity.Surname;
            user.name = entity.Name;
            user.email = entity.Email;
            user.imagePath = entity.ImagePath;
            user.day = entity.Day;
            user.monthID = entity.MonthID;
            user.year = entity.Year;
            return dao.Insert(user);
        }

        public UserDTO Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(UserDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public List<REGISTER> CheckUser(string password, string username)
        {
            return dao.CheckUser(password, username);
        }
    }
}
