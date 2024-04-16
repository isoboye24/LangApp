using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DTO
{
    public class UserDetailDTO
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public int Day { get; set; }
        public int MonthID { get; set; }
        public int MonthName { get; set; }
        public int Year { get; set; }
    }
}
