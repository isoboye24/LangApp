using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace LangApp.DAL.DAO
{
    public class GraphDAO:LangContext
    {
        public string getAllPartsOfSpeechQueryYearly(int year)
        {
            string allPartsOfSpeechQueryYearly = "SELECT PARTS_OF_SPEECH.partsOfSpeechName, COUNT(WORD)\r\n" +
            "FROM WORD \r\n" +
            "JOIN PARTS_OF_SPEECH ON WORD.partOfSpeechID = PARTS_OF_SPEECH.partOfSpeechID \r\n" +
            "WHERE WORD.year = @year AND WORD.isDeleted = 0 \r\n" +
            "GROUP BY PARTS_OF_SPEECH.partsOfSpeechName\r\n" +
            "ORDER BY PARTS_OF_SPEECH.partsOfSpeechName ASC";
            return allPartsOfSpeechQueryYearly.Replace("@year", year.ToString());
        }

        public string getAllPartsOfSpeechQueryMonthly(int month, int year)
        {
            string allPartsOfSpeechQueryMonthly = "SELECT PARTS_OF_SPEECH.partsOfSpeechName, COUNT(WORD)\r\n" +
            "FROM WORD \r\n" +
            "JOIN PARTS_OF_SPEECH ON WORD.partOfSpeechID = PARTS_OF_SPEECH.partOfSpeechID \r\n" +
            "WHERE WORD.year = @year AND WORD.MonthID = @month AND WORD.isDeleted = 0 \r\n" +
            "GROUP BY PARTS_OF_SPEECH.partsOfSpeechName\r\n" +
            "ORDER BY PARTS_OF_SPEECH.partsOfSpeechName ASC";

            return allPartsOfSpeechQueryMonthly.Replace("@year", year.ToString())
                                               .Replace("@month", month.ToString());
        }

        public string getSinglePartsOfSpeechQuery(int year)
        {
            string singlePartsOfSpeechQuery = "SELECT MONTH.monthID, COUNT(WORD) \r\n" +
            "FROM WORD \r\n" +
            "JOIN PARTS_OF_SPEECH ON WORD.partOfSpeechID = PARTS_OF_SPEECH.partOfSpeechID \r\n" +
            "JOIN MONTH ON WORD.monthID = MONTH.monthID \r\n" +
            "WHERE WORD.year = @year AND WORD.isDeleted = 0 AND PARTS_OF_SPEECH.partsOfSpeechName = @partOfSpeech \r\n" +
            "GROUP BY MONTH.monthID\r\n" +
            "ORDER BY MONTH.monthID ASC";
            return singlePartsOfSpeechQuery.Replace("@year", year.ToString());
        }
    }
}
