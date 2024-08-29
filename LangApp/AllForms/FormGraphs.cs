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

        private void getUpdate()
        {
            bll.ShowAllPartsOfSpeechYearly(currYear, chartAllPartsYearly, labelGraphTitleAllPartsYearly);
            bll.ShowAllPartsOfSpeechMonthly(currMonth, currYear, chartAllPartsMonthly, labelGraphTitleAllPartsMonthly);
            bll.ShowSinglePartsOfSpeechYearly(currYear, 2, chartSingleParts, labelTitleSingleParts);            
        }

        private void btnClearAllPartsYearly_Click(object sender, EventArgs e)
        {
            txtYearAllPartsYearly.Clear();
            getUpdate();
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
                bll.ShowSinglePartsOfSpeechYearly(Convert.ToInt32(txtYearSingleParts.Text.Trim()), Convert.ToInt32(cmbPartOfSpeechSingle.SelectedValue), chartSingleParts, labelTitleSingleParts);
            }
            else
            {
                MessageBox.Show("Please enter year and select a part of speech from the dropdown.");
            }
        }

        private void btnShowAllPartsYearly_Click(object sender, EventArgs e)
        {
            if (txtYearAllPartsYearly.Text.Trim() != "")
            {
                bll.ShowAllPartsOfSpeechYearly(Convert.ToInt32(txtYearAllPartsYearly.Text.Trim()), chartAllPartsYearly, labelGraphTitleAllPartsYearly);
            }
            else
            {
                MessageBox.Show("Please enter year.");
            }
            
        }

        private void btnShowAllPartsMonthly_Click(object sender, EventArgs e)
        {

            if (cmbMonthAllPartsMonthly.SelectedIndex != -1 && txtYearAllPartsMonthly.Text.Trim() != "")
            {
                bll.ShowAllPartsOfSpeechMonthly(Convert.ToInt32(cmbMonthAllPartsMonthly.SelectedValue), Convert.ToInt32(txtYearAllPartsMonthly.Text.Trim()), chartAllPartsMonthly, labelGraphTitleAllPartsMonthly);
            }
            else
            {
                MessageBox.Show("Please enter year and select month from the dropdowns.");
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
