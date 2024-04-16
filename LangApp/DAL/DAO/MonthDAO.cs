using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class MonthDAO:LangContext
    {
        public List<MonthDetailDTO> Select()
        {
            try
            {
                List<MonthDetailDTO> months = new List<MonthDetailDTO>();
                var list = db.MONTHs.OrderBy(x => x.monthID).ToList();
                foreach (var item in list)
                {
                    MonthDetailDTO dto = new MonthDetailDTO();
                    dto.MonthID = item.monthID;
                    dto.MonthName = item.monthName;
                    months.Add(dto);
                }
                return months;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
