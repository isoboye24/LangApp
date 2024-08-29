using LangApp.BLL;
using LangApp.DAL;
using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LangApp.AllForms
{
    public partial class FormGraphs : Form
    {
        public FormGraphs()
        {
            InitializeComponent();
        }
        GraphBLL bll = new GraphBLL();
        GraphDTO dto = new GraphDTO();
        
        private void FontSizes()
        {
            cmbPartOfSpeechSingle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbMonthAllPartsMonthly.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            btnClearAllPartsYearly.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnClearAllPartsMonthly.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnClearSingleParts.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnShowAllPartsYearly.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnShowAllPartsMonthly.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnShowSingleParts.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            txtYearAllPartsMonthly.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtYearAllPartsYearly.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtYearSingleParts.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            label2.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label4.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label5.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label6.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label8.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelTitleSingleParts.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelGraphTitleAllPartsYearly.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelGraphTitleAllPartsMonthly.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        int currYear = DateTime.Today.Year;
        int currMonth = DateTime.Today.Month;

        private string getAllPartsOfSpeechQueryYearly(int year)
        {
            string allPartsOfSpeechQueryYearly = "SELECT PARTS_OF_SPEECH.partsOfSpeechName, COUNT(WORD)\r\n" +
            "FROM WORD \r\n" +
            "JOIN PARTS_OF_SPEECH ON WORD.partOfSpeechID = PARTS_OF_SPEECH.partOfSpeechID \r\n" +
            "WHERE WORD.year = @year AND WORD.isDeleted = 0 \r\n" +
            "GROUP BY PARTS_OF_SPEECH.partsOfSpeechName\r\n" +
            "ORDER BY PARTS_OF_SPEECH.partsOfSpeechName ASC";
            return allPartsOfSpeechQueryYearly.Replace("@year", year.ToString());
        }

        private string getAllPartsOfSpeechQueryMonthly(int month, int year)
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

        private string getSinglePartsOfSpeechQuery(int year)
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

        private void ShowAllPartsOfSpeechYearly(int newYear)
        {
            string allPartOfSpeechQueryYearly = getAllPartsOfSpeechQueryYearly(newYear);
            SqlParameter[] allPartOfSpeechQueryYearlyParameters = new SqlParameter[]
            {
                new SqlParameter("@year", SqlDbType.VarChar) { Value = newYear}
            };
            General.CreateChart(chartAllPartsYearly, allPartOfSpeechQueryYearly, allPartOfSpeechQueryYearlyParameters, SeriesChartType.Column, "Hours", "");
            labelGraphTitleAllPartsYearly.Text = newYear + " Berichten";
        }

        private void ShowAllPartsOfSpeechMonthly(int month, int year)
        {
            string allPartOfSpeechQueryMonthly = getAllPartsOfSpeechQueryMonthly(month, year);
            SqlParameter[] allPartOfSpeechQueryMonthlyParameters = new SqlParameter[]
            {
                    new SqlParameter("@year", SqlDbType.VarChar) { Value = year },
                    new SqlParameter("@month", SqlDbType.VarChar) { Value = month}
            };
            labelGraphTitleAllPartsMonthly.Text = General.ConventIntToMonthGerman(Convert.ToInt32(month)) + " " + year + " Berichten";
            General.CreateChart(chartAllPartsMonthly, allPartOfSpeechQueryMonthly, allPartOfSpeechQueryMonthlyParameters, SeriesChartType.Column, "Hours", "");

        }

        private void ShowSinglePartsOfSpeechYearly(int newYear, int PartOfSpeechID)
        {
            string singlePartOfSpeechQuery = getSinglePartsOfSpeechQuery(newYear);
            string newPartOfSpeech;

            newPartOfSpeech = General.ConventIntToPartsOfSpeech(PartOfSpeechID);

            SqlParameter[] singlePartsOfSpeechParameters = new SqlParameter[]
            {
                    new SqlParameter("@year", SqlDbType.VarChar) { Value = newYear},
                    new SqlParameter("@partOfSpeech", SqlDbType.VarChar) { Value = newPartOfSpeech }
            };
            newPartOfSpeech = General.ConventEngToGerman(newPartOfSpeech);
            labelTitleSingleParts.Text = newPartOfSpeech + " " + newYear + " Berichten";
            General.CreateChart(chartSingleParts, singlePartOfSpeechQuery, singlePartsOfSpeechParameters, SeriesChartType.Column, "Hours", "");
        }

        private void getUpdate()
        {
            ShowAllPartsOfSpeechYearly(currYear);
            ShowAllPartsOfSpeechMonthly(currMonth, currYear);
            ShowSinglePartsOfSpeechYearly(currYear, 2);            
        }

        private void btnClearAllPartsYearly_Click(object sender, EventArgs e)
        {
            labelGraphTitleAllPartsYearly.Text = currYear + " Berichten";
            txtYearAllPartsYearly.Clear();
            ShowAllPartsOfSpeechYearly(currYear);
        }

        private void FormGraphs_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbPartOfSpeechSingle.DataSource = dto.PartsOfSpeech;
            General.ComboBoxProps(cmbPartOfSpeechSingle, "PartOfSpeechName", "PartOfSpeechID");
            cmbMonthAllPartsMonthly.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonthAllPartsMonthly, "MonthName", "MonthID");           

            FontSizes();
            getUpdate();
        }

        private void btnShowSingleParts_Click(object sender, EventArgs e)
        {
            if (cmbPartOfSpeechSingle.SelectedIndex != -1 && txtYearSingleParts.Text.Trim() != "")
            {
                ShowSinglePartsOfSpeechYearly(Convert.ToInt32(txtYearSingleParts.Text.Trim()), Convert.ToInt32(cmbPartOfSpeechSingle.SelectedValue));
            }
            else
            {
                MessageBox.Show("Please select a part of speech from the dropdown.");
            }
        }

        private void btnShowAllPartsYearly_Click(object sender, EventArgs e)
        {
            ShowAllPartsOfSpeechYearly(Convert.ToInt32(txtYearAllPartsYearly.Text.Trim()));
        }

        private void btnShowAllPartsMonthly_Click(object sender, EventArgs e)
        {

            if (cmbMonthAllPartsMonthly.SelectedIndex != -1 && txtYearAllPartsMonthly.Text.Trim() != "")
            {
                ShowAllPartsOfSpeechMonthly(Convert.ToInt32(cmbMonthAllPartsMonthly.SelectedValue), Convert.ToInt32(txtYearAllPartsMonthly.Text.Trim()));
            }
            else
            {
                MessageBox.Show("Please select month and year from the dropdowns.");
            }
        }

        private void btnClearAllPartsMonthly_Click(object sender, EventArgs e)
        {            
            txtYearAllPartsMonthly.Clear();
            cmbMonthAllPartsMonthly.SelectedIndex = -1;
            getUpdate();
        }

        private void btnClearSingleParts_Click(object sender, EventArgs e)
        {
            cmbPartOfSpeechSingle.SelectedIndex = -1;
            txtYearSingleParts.Clear();
            getUpdate();
        }

        private void txtYearAllPartsYearly_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtYearAllPartsMonthly_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtYearSingleParts_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
    }
}
