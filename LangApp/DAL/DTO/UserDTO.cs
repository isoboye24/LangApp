using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DTO
{
    public class UserDTO
    {
        public List<UserDetailDTO> Users { get; set; }
        public List<MonthDetailDTO> Months { get; set; }
    }
}
