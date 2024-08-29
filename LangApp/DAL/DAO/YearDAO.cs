using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DAO
{
    public class YearDAO:LangContext
    {
        public List<YearDetailDTO> Select()
        {
            try
            {
                List<int> yearsCollection = new List<int>();
                List<int> years = new List<int>();                
                List<YearDetailDTO> collectedYears = new List<YearDetailDTO>();                

                var words = db.WORDs.Where(x => x.isDeleted == false).ToList();
                foreach (var word in words)
                {
                    yearsCollection.Add(word.year);
                }
                years = yearsCollection.Distinct().OrderByDescending(year => year).ToList();
                foreach (var year in years)
                {
                    YearDetailDTO dto = new YearDetailDTO();
                    dto.YearID +=1;
                    dto.Year = year;
                    collectedYears.Add(dto);
                }
                return collectedYears;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
