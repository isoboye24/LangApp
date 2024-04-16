using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class CategoryDAO:LangContext
    {
        public List<CategoryDetailDTO> Select()
        {
            try
            {
                List<CategoryDetailDTO> categories = new List<CategoryDetailDTO>();
                var list = db.TOPICs.OrderBy(x => x.topic1).ToList();
                foreach (var item in list)
                {
                    CategoryDetailDTO dto = new CategoryDetailDTO();
                    dto.CategoryID = item.topicID;
                    dto.CategoryName = item.topic1;
                    categories.Add(dto);
                }
                return categories;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
