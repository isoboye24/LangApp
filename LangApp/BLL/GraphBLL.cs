using LangApp.DAL.DAO;
using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection.Emit;

namespace LangApp.BLL
{
    public class GraphBLL
    {
        MonthDAO monthDAO = new MonthDAO();
        YearDAO yearDAO = new YearDAO();
        GraphDAO dao = new GraphDAO();
        PartOfSpeechDAO partsOfSpeechDAO = new PartOfSpeechDAO();
        public GraphDTO Select()
        {
            GraphDTO dto = new GraphDTO();
            dto.Months = monthDAO.Select();
            dto.Years = yearDAO.Select();
            dto.PartsOfSpeech = partsOfSpeechDAO.Select();
            return dto;
        }

        public void ShowAllPartsOfSpeechYearly(int newYear, Chart newChart, System.Windows.Forms.Label title)
        {
            string allPartOfSpeechQueryYearly = dao.getAllPartsOfSpeechQueryYearly(newYear);
            SqlParameter[] allPartOfSpeechQueryYearlyParameters = new SqlParameter[]
            {
                new SqlParameter("@year", SqlDbType.VarChar) { Value = newYear}
            };
            General.CreateChart(newChart, allPartOfSpeechQueryYearly, allPartOfSpeechQueryYearlyParameters, SeriesChartType.Column, "Hours", "");
            title.Text = newYear + " Berichten";
        }

        public void ShowAllPartsOfSpeechMonthly(int month, int year, Chart newChart, System.Windows.Forms.Label title)
        {
            string allPartOfSpeechQueryMonthly = dao.getAllPartsOfSpeechQueryMonthly(month, year);
            SqlParameter[] allPartOfSpeechQueryMonthlyParameters = new SqlParameter[]
            {
                new SqlParameter("@year", SqlDbType.VarChar) { Value = year },
                new SqlParameter("@month", SqlDbType.VarChar) { Value = month}
            };
            title.Text = General.ConventIntToMonthGerman(Convert.ToInt32(month)) + " " + year + " Berichten";
            General.CreateChart(newChart, allPartOfSpeechQueryMonthly, allPartOfSpeechQueryMonthlyParameters, SeriesChartType.Column, "Hours", "");

        }

        public void ShowSinglePartsOfSpeechYearly(int newYear, int PartOfSpeechID, Chart newChart, System.Windows.Forms.Label title)
        {
            string singlePartOfSpeechQuery = dao.getSinglePartsOfSpeechQuery(newYear);
            string newPartOfSpeech;
            newPartOfSpeech = General.ConventIntToPartsOfSpeech(PartOfSpeechID);
            SqlParameter[] singlePartsOfSpeechParameters = new SqlParameter[]
            {
                new SqlParameter("@year", SqlDbType.VarChar) { Value = newYear},
                new SqlParameter("@partOfSpeech", SqlDbType.VarChar) { Value = newPartOfSpeech }
            };
            newPartOfSpeech = General.ConventEngToGerman(newPartOfSpeech);
            title.Text = newPartOfSpeech + " " + newYear + " Berichten";
            General.CreateChart(newChart, singlePartOfSpeechQuery, singlePartsOfSpeechParameters, SeriesChartType.Column, "Hours", "");
        }

    }
}
