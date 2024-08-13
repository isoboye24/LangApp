using LangApp.BLL;
using LangApp.DAL;
using LangApp.DAL.DTO;
using LangApp.General_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LangApp.AllForms
{
    public partial class FormPartsOfSpeech : Form
    {
        public FormPartsOfSpeech()
        {
            InitializeComponent();
        }
        WordBLL bll = new WordBLL();
        WordDTO dto = new WordDTO();
        private void FormPartsOfSpeech_Load(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            // comboBoxes
            #region
            cmbCasesPageAdj.DataSource = dto.WordCases;
            General.ComboBoxProps(cmbCasesPageAdj, "WordCaseName", "WordCaseID");
            cmbMonthPageAdj.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonthPageAdj, "MonthName", "MonthID");
            cmbGroupPageAdj.DataSource = dto.WordGroups;
            General.ComboBoxProps(cmbGroupPageAdj, "WordGroupName", "WordGroupID");

            cmbCasesPageAdv.DataSource = dto.WordCases;
            General.ComboBoxProps(cmbCasesPageAdv, "WordCaseName", "WordCaseID");
            cmbMonthPageAdv.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonthPageAdv, "MonthName", "MonthID");
            cmbGroupPageAdv.DataSource = dto.WordGroups;
            General.ComboBoxProps(cmbGroupPageAdv, "WordGroupName", "WordGroupID");

            cmbCasesPageConj.DataSource = dto.WordCases;
            General.ComboBoxProps(cmbCasesPageConj, "WordCaseName", "WordCaseID");
            cmbMonthPageConj.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonthPageConj, "MonthName", "MonthID");
            cmbGroupPageConj.DataSource = dto.WordGroups;
            General.ComboBoxProps(cmbGroupPageConj, "WordGroupName", "WordGroupID");

            cmbCasesPageNoun.DataSource = dto.WordCases;
            General.ComboBoxProps(cmbCasesPageNoun, "WordCaseName", "WordCaseID");
            cmbMonthPageNoun.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonthPageNoun, "MonthName", "MonthID");
            cmbGroupPageNoun.DataSource = dto.WordGroups;
            General.ComboBoxProps(cmbGroupPageNoun, "WordGroupName", "WordGroupID");

            cmbCasesPagePhrase.DataSource = dto.WordCases;
            General.ComboBoxProps(cmbCasesPagePhrase, "WordCaseName", "WordCaseID");
            cmbMonthPagePhrase.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonthPagePhrase, "MonthName", "MonthID");
            cmbGroupPagePhrase.DataSource = dto.WordGroups;
            General.ComboBoxProps(cmbGroupPagePhrase, "WordGroupName", "WordGroupID");

            cmbCasesPageSentence.DataSource = dto.WordCases;
            General.ComboBoxProps(cmbCasesPageSentence, "WordCaseName", "WordCaseID");
            cmbMonthPageSentence.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonthPageSentence, "MonthName", "MonthID");
            cmbGroupPageSentence.DataSource = dto.WordGroups;
            General.ComboBoxProps(cmbGroupPageSentence, "WordGroupName", "WordGroupID");

            cmbCasesPageVerb.DataSource = dto.WordCases;
            General.ComboBoxProps(cmbCasesPageVerb, "WordCaseName", "WordCaseID");
            cmbMonthPageVerb.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonthPageVerb, "MonthName", "MonthID");
            cmbGroupPageVerb.DataSource = dto.WordGroups;
            General.ComboBoxProps(cmbGroupPageVerb, "WordGroupName", "WordGroupID");
            #endregion

            // lists
            #region
            List<WordDetailDTO> listAdj = dto.Adjectives;
            listAdj = listAdj.Where(x => x.Year == DateTime.Today.Year && x.MonthID == DateTime.Today.Month).ToList();
            dataGridViewAdj.DataSource = listAdj;
            dataGridViewAdj.Columns[0].HeaderText = "No.";
            dataGridViewAdj.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewAdj.Columns[1].Visible = false;
            dataGridViewAdj.Columns[2].Visible = false;
            dataGridViewAdj.Columns[3].Visible = false;
            dataGridViewAdj.Columns[4].Visible = false;
            dataGridViewAdj.Columns[5].Visible = false;
            dataGridViewAdj.Columns[6].Visible = false;
            dataGridViewAdj.Columns[7].Visible = false;
            dataGridViewAdj.Columns[8].HeaderText = "Adjectiven";
            dataGridViewAdj.Columns[9].Visible = false;
            dataGridViewAdj.Columns[10].Visible = false;
            dataGridViewAdj.Columns[11].HeaderText = "Kasus";
            dataGridViewAdj.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewAdj.Columns[12].Visible = false;
            dataGridViewAdj.Columns[13].HeaderText = "Monat";
            dataGridViewAdj.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewAdj.Columns[14].HeaderText = "Jahr";
            dataGridViewAdj.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewAdj.Columns[15].Visible = false;
            foreach (DataGridViewColumn column in dataGridViewAdj.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            #endregion

            #region
            List<WordDetailDTO> listAdv = dto.Adverbs;
            listAdv = listAdv.Where(x => x.Year == DateTime.Today.Year && x.MonthID == DateTime.Today.Month).ToList();
            dataGridViewAdv.DataSource = listAdv;
            dataGridViewAdv.Columns[0].HeaderText = "No.";
            dataGridViewAdv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewAdv.Columns[1].Visible = false;
            dataGridViewAdv.Columns[2].Visible = false;
            dataGridViewAdv.Columns[3].Visible = false;
            dataGridViewAdv.Columns[4].Visible = false;
            dataGridViewAdv.Columns[5].Visible = false;
            dataGridViewAdv.Columns[6].Visible = false;
            dataGridViewAdv.Columns[7].Visible = false;
            dataGridViewAdv.Columns[8].HeaderText = "Adverben";
            dataGridViewAdv.Columns[9].Visible = false;
            dataGridViewAdv.Columns[10].Visible = false;
            dataGridViewAdv.Columns[11].HeaderText = "Kasus";
            dataGridViewAdv.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewAdv.Columns[12].Visible = false;
            dataGridViewAdv.Columns[13].HeaderText = "Monat";
            dataGridViewAdv.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewAdv.Columns[14].HeaderText = "Jahr";
            dataGridViewAdv.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewAdv.Columns[15].Visible = false;
            foreach (DataGridViewColumn column in dataGridViewAdv.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            #endregion

            #region
            List<WordDetailDTO> listConj = dto.Conjunction;
            listConj = listConj.Where(x => x.Year == DateTime.Today.Year && x.MonthID == DateTime.Today.Month).ToList();
            dataGridViewConj.DataSource = listConj;
            dataGridViewConj.Columns[0].HeaderText = "No.";
            dataGridViewConj.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewConj.Columns[1].Visible = false;
            dataGridViewConj.Columns[2].Visible = false;
            dataGridViewConj.Columns[3].Visible = false;
            dataGridViewConj.Columns[4].Visible = false;
            dataGridViewConj.Columns[5].Visible = false;
            dataGridViewConj.Columns[6].Visible = false;
            dataGridViewConj.Columns[7].Visible = false;
            dataGridViewConj.Columns[8].HeaderText = "Konjunktionen";
            dataGridViewConj.Columns[9].Visible = false;
            dataGridViewConj.Columns[10].Visible = false;
            dataGridViewConj.Columns[11].HeaderText = "Kasus";
            dataGridViewConj.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewConj.Columns[12].Visible = false;
            dataGridViewConj.Columns[13].HeaderText = "Monat";
            dataGridViewConj.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewConj.Columns[14].HeaderText = "Jahr";
            dataGridViewConj.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewConj.Columns[15].Visible = false;
            foreach (DataGridViewColumn column in dataGridViewConj.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            #endregion

            #region
            List<WordDetailDTO> listNoun = dto.Nouns;
            listNoun = listNoun.Where(x => x.Year == DateTime.Today.Year && x.MonthID == DateTime.Today.Month).ToList();
            dataGridViewNoun.DataSource = listNoun;
            dataGridViewNoun.Columns[0].HeaderText = "No.";
            dataGridViewNoun.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNoun.Columns[1].Visible = false;
            dataGridViewNoun.Columns[2].Visible = false;
            dataGridViewNoun.Columns[3].Visible = false;
            dataGridViewNoun.Columns[4].Visible = false;
            dataGridViewNoun.Columns[5].Visible = false;
            dataGridViewNoun.Columns[6].Visible = false;
            dataGridViewNoun.Columns[7].Visible = false;
            dataGridViewNoun.Columns[8].HeaderText = "Phrasen or Idioms";
            dataGridViewNoun.Columns[9].Visible = false;
            dataGridViewNoun.Columns[10].Visible = false;
            dataGridViewNoun.Columns[11].HeaderText = "Kasus";
            dataGridViewNoun.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNoun.Columns[12].Visible = false;
            dataGridViewNoun.Columns[13].HeaderText = "Monat";
            dataGridViewNoun.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNoun.Columns[14].HeaderText = "Jahr";
            dataGridViewNoun.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNoun.Columns[15].Visible = false;
            foreach (DataGridViewColumn column in dataGridViewNoun.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            #endregion

            #region
            List<WordDetailDTO> listPhrase = dto.PhraseWords;
            listPhrase = listPhrase.Where(x => x.Year == DateTime.Today.Year && x.MonthID == DateTime.Today.Month).ToList();
            dataGridViewPhrase.DataSource = listPhrase;
            dataGridViewPhrase.Columns[0].HeaderText = "No.";
            dataGridViewPhrase.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPhrase.Columns[1].Visible = false;
            dataGridViewPhrase.Columns[2].Visible = false;
            dataGridViewPhrase.Columns[3].Visible = false;
            dataGridViewPhrase.Columns[4].Visible = false;
            dataGridViewPhrase.Columns[5].Visible = false;
            dataGridViewPhrase.Columns[6].Visible = false;
            dataGridViewPhrase.Columns[7].Visible = false;
            dataGridViewPhrase.Columns[8].HeaderText = "Phrasen or Idioms";
            dataGridViewPhrase.Columns[9].Visible = false;
            dataGridViewPhrase.Columns[10].Visible = false;
            dataGridViewPhrase.Columns[11].HeaderText = "Kasus";
            dataGridViewPhrase.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPhrase.Columns[12].Visible = false;
            dataGridViewPhrase.Columns[13].HeaderText = "Monat";
            dataGridViewPhrase.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPhrase.Columns[14].HeaderText = "Jahr";
            dataGridViewPhrase.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPhrase.Columns[15].Visible = false;
            foreach (DataGridViewColumn column in dataGridViewPhrase.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            #endregion

            #region
            List<WordDetailDTO> listSentence = dto.Sentences;
            listSentence = listSentence.Where(x => x.Year == DateTime.Today.Year && x.MonthID == DateTime.Today.Month).ToList();
            dataGridViewSentence.DataSource = listSentence;
            dataGridViewSentence.Columns[0].HeaderText = "No.";
            dataGridViewSentence.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSentence.Columns[1].Visible = false;
            dataGridViewSentence.Columns[2].Visible = false;
            dataGridViewSentence.Columns[3].Visible = false;
            dataGridViewSentence.Columns[4].Visible = false;
            dataGridViewSentence.Columns[5].Visible = false;
            dataGridViewSentence.Columns[6].Visible = false;
            dataGridViewSentence.Columns[7].Visible = false;
            dataGridViewSentence.Columns[8].HeaderText = "Sätze";
            dataGridViewSentence.Columns[9].Visible = false;
            dataGridViewSentence.Columns[10].Visible = false;
            dataGridViewSentence.Columns[11].HeaderText = "Kasus";
            dataGridViewSentence.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSentence.Columns[12].Visible = false;
            dataGridViewSentence.Columns[13].HeaderText = "Monat";
            dataGridViewSentence.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSentence.Columns[14].HeaderText = "Jahr";
            dataGridViewSentence.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSentence.Columns[15].Visible = false;
            foreach (DataGridViewColumn column in dataGridViewSentence.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            #endregion

            #region
            List<WordDetailDTO> listVerb = dto.Verbs;
            listVerb = listVerb.Where(x => x.Year == DateTime.Today.Year && x.MonthID == DateTime.Today.Month).ToList();
            dataGridViewVerb.DataSource = listVerb;
            dataGridViewVerb.Columns[0].HeaderText = "No.";
            dataGridViewVerb.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewVerb.Columns[1].Visible = false;
            dataGridViewVerb.Columns[2].Visible = false;
            dataGridViewVerb.Columns[3].Visible = false;
            dataGridViewVerb.Columns[4].Visible = false;
            dataGridViewVerb.Columns[5].Visible = false;
            dataGridViewVerb.Columns[6].Visible = false;
            dataGridViewVerb.Columns[7].Visible = false;
            dataGridViewVerb.Columns[8].HeaderText = "Verben";
            dataGridViewVerb.Columns[9].Visible = false;
            dataGridViewVerb.Columns[10].Visible = false;
            dataGridViewVerb.Columns[11].HeaderText = "Kasus";
            dataGridViewVerb.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewVerb.Columns[12].Visible = false;
            dataGridViewVerb.Columns[13].HeaderText = "Monat";
            dataGridViewVerb.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewVerb.Columns[14].HeaderText = "Jahr";
            dataGridViewVerb.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewVerb.Columns[15].Visible = false;
            foreach (DataGridViewColumn column in dataGridViewVerb.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            #endregion

            RefreshCounts();

            // Monthly filters
            #region
            iconLastMonthAdj.Text = General.ConventIntToMonthGerman(DateTime.Today.Month - StaticUser.LanguageID);
            iconThisMonthAdj.Text = General.ConventIntToMonthGerman(DateTime.Today.Month);
            iconLastMonthAdv.Text = General.ConventIntToMonthGerman(DateTime.Today.Month - StaticUser.LanguageID);
            iconThisMonthAdv.Text = General.ConventIntToMonthGerman(DateTime.Today.Month);
            iconLastMonthConj.Text = General.ConventIntToMonthGerman(DateTime.Today.Month - StaticUser.LanguageID);
            iconThisMonthConj.Text = General.ConventIntToMonthGerman(DateTime.Today.Month);
            iconLastMonthNoun.Text = General.ConventIntToMonthGerman(DateTime.Today.Month - StaticUser.LanguageID);
            iconThisMonthNoun.Text = General.ConventIntToMonthGerman(DateTime.Today.Month);
            iconLastMonthPhrase.Text = General.ConventIntToMonthGerman(DateTime.Today.Month - StaticUser.LanguageID);
            iconThisMonthPhrase.Text = General.ConventIntToMonthGerman(DateTime.Today.Month);
            iconLastMonthSentence.Text = General.ConventIntToMonthGerman(DateTime.Today.Month - StaticUser.LanguageID);
            iconThisMonthSentence.Text = General.ConventIntToMonthGerman(DateTime.Today.Month);
            iconLastMonthVerb.Text = General.ConventIntToMonthGerman(DateTime.Today.Month - StaticUser.LanguageID);
            iconThisMonthVerb.Text = General.ConventIntToMonthGerman(DateTime.Today.Month);
            #endregion
        }
        private void RefreshCounts()
        {
            labelTotalWordsAdj.Text = dataGridViewAdj.RowCount.ToString();
            labelTotalWordsAdv.Text = dataGridViewAdv.RowCount.ToString();
            labelTotalWordsConj.Text = dataGridViewConj.RowCount.ToString();
            labelTotalWordsNoun.Text = dataGridViewNoun.RowCount.ToString();
            labelTotalWordsPhrase.Text = dataGridViewPhrase.RowCount.ToString();
            labelTotalWordsSentence.Text = dataGridViewSentence.RowCount.ToString();
            labelTotalWordsVerb.Text = dataGridViewVerb.RowCount.ToString();
        }
        WordDetailDTO detailAdj = new WordDetailDTO();
        private void dataGridViewAdj_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detailAdj = new WordDetailDTO();
            detailAdj.WordsCount = Convert.ToInt32(dataGridViewAdj.Rows[e.RowIndex].Cells[0].Value);
            detailAdj.WordID = Convert.ToInt32(dataGridViewAdj.Rows[e.RowIndex].Cells[1].Value);
            detailAdj.UserID = Convert.ToInt32(dataGridViewAdj.Rows[e.RowIndex].Cells[2].Value);
            detailAdj.LanguageID = Convert.ToInt32(dataGridViewAdj.Rows[e.RowIndex].Cells[3].Value);
            detailAdj.MonthID = Convert.ToInt32(dataGridViewAdj.Rows[e.RowIndex].Cells[4].Value);
            detailAdj.PartOfSpeechID = Convert.ToInt32(dataGridViewAdj.Rows[e.RowIndex].Cells[5].Value);
            detailAdj.WordCaseID = Convert.ToInt32(dataGridViewAdj.Rows[e.RowIndex].Cells[6].Value);
            detailAdj.WordGroupID = Convert.ToInt32(dataGridViewAdj.Rows[e.RowIndex].Cells[7].Value);
            detailAdj.Word = dataGridViewAdj.Rows[e.RowIndex].Cells[8].Value.ToString();
            detailAdj.WordGroupName = dataGridViewAdj.Rows[e.RowIndex].Cells[9].Value.ToString();
            detailAdj.PartOfSpeechName = dataGridViewAdj.Rows[e.RowIndex].Cells[10].Value.ToString();
            detailAdj.WordCaseName = dataGridViewAdj.Rows[e.RowIndex].Cells[11].Value.ToString();
            detailAdj.Day = Convert.ToInt32(dataGridViewAdj.Rows[e.RowIndex].Cells[12].Value);
            detailAdj.MonthName = dataGridViewAdj.Rows[e.RowIndex].Cells[13].Value.ToString();
            detailAdj.Year = Convert.ToInt32(dataGridViewAdj.Rows[e.RowIndex].Cells[14].Value);
            detailAdj.Explanation = dataGridViewAdj.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtExplanationAdj.Text = dataGridViewAdj.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        private bool isLastMonth = false;
        private bool isThisMonth = false;
        private bool isAll = false;

        string adjectives = "Adjectives";
        string adverbs = "Adverbs";
        string conjunction = "Conjunctions";
        string nouns = "Nouns";
        string phrase = "Phrases";
        string sentence = "Sentences";
        string verb = "Verbs";
        private void ClearFilters(string partOfSpeech)
        {
            if (partOfSpeech == "Adjectives")
            {
                dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
                List<WordDetailDTO> list = dto.Adjectives;
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == DateTime.Today.Year - 1).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year).ToList();
                    }
                    dataGridViewAdj.DataSource = list;
                    isLastMonth = false;
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewAdj.DataSource = list;
                    isThisMonth = false;
                }                
                else if (isAll)
                {
                    dataGridViewAdj.DataSource = list;
                    isAll = false;

                }
                else
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewAdj.DataSource = list;
                }

                txtWordPageAdj.Clear();
                txtYearPageAdj.Clear();
                cmbCasesPageAdj.SelectedIndex = -1;
                cmbMonthPageAdj.SelectedIndex = -1;
                cmbGroupPageAdj.SelectedIndex = -1;
            }
            else if (partOfSpeech == "Adverbs")
            {
                List<WordDetailDTO> listAdv = dto.Adverbs;
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        listAdv = listAdv.Where(x => x.MonthID == month && x.Year == DateTime.Today.Year - 1).ToList();
                    }
                    else
                    {
                        listAdv = listAdv.Where(x => x.MonthID == month && x.Year == year).ToList();
                    }
                    dataGridViewAdv.DataSource = listAdv;
                    isLastMonth = false;
                }
                else if (isThisMonth)
                {
                    listAdv = listAdv.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewAdv.DataSource = listAdv;
                    isThisMonth = false;
                }
                else if (isAll)
                {
                    dataGridViewAdv.DataSource = listAdv;
                    isAll = false;
                }
                else
                {
                    listAdv = listAdv.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewAdv.DataSource = listAdv;
                }

                txtWordPageAdv.Clear();
                txtYearPageAdv.Clear();
                cmbCasesPageAdv.SelectedIndex = -1;
                cmbMonthPageAdv.SelectedIndex = -1;
                cmbGroupPageAdv.SelectedIndex = -1;
            }
            else if (partOfSpeech == "Conjunctions")
            {
                List<WordDetailDTO> listConj = dto.Conjunction;
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        listConj = listConj.Where(x => x.MonthID == month && x.Year == DateTime.Today.Year - 1).ToList();
                    }
                    else
                    {
                        listConj = listConj.Where(x => x.MonthID == month && x.Year == year).ToList();
                    }
                    dataGridViewConj.DataSource = listConj;
                    isLastMonth = false;
                }
                else if (isThisMonth)
                {
                    listConj = listConj.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewConj.DataSource = listConj;
                    isThisMonth = false;
                }
                else if (isAll)
                {
                    dataGridViewConj.DataSource = listConj;
                    isAll = false;
                }
                else
                {
                    listConj = listConj.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewConj.DataSource = listConj;
                }

                txtWordPageConj.Clear();
                txtYearPageConj.Clear();
                cmbCasesPageConj.SelectedIndex = -1;
                cmbMonthPageConj.SelectedIndex = -1;
                cmbGroupPageConj.SelectedIndex = -1;
            }
            else if (partOfSpeech == "Nouns")
            {
                List<WordDetailDTO> listNouns = dto.Nouns;
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        listNouns = listNouns.Where(x => x.MonthID == month && x.Year == DateTime.Today.Year - 1).ToList();
                    }
                    else
                    {
                        listNouns = listNouns.Where(x => x.MonthID == month && x.Year == year).ToList();
                    }
                    dataGridViewNoun.DataSource = listNouns;
                    isLastMonth = false;
                }
                else if (isThisMonth)
                {
                    listNouns = listNouns.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewNoun.DataSource = listNouns;
                    isThisMonth = false;
                }
                else if(isAll)
                {                    
                    dataGridViewNoun.DataSource = listNouns;
                    isAll = false;
                }
                else
                {
                    listNouns = listNouns.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewNoun.DataSource = listNouns;
                }
                txtWordPageNoun.Clear();
                txtYearPageNoun.Clear();
                cmbCasesPageNoun.SelectedIndex = -1;
                cmbMonthPageNoun.SelectedIndex = -1;
                cmbGroupPageNoun.SelectedIndex = -1;
            }
            else if (partOfSpeech == "Phrases")
            {
                List<WordDetailDTO> listPhrase = dto.PhraseWords;
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        listPhrase = listPhrase.Where(x => x.MonthID == month && x.Year == DateTime.Today.Year - 1).ToList();
                    }
                    else
                    {
                        listPhrase = listPhrase.Where(x => x.MonthID == month && x.Year == year).ToList();
                    }
                    dataGridViewPhrase.DataSource = listPhrase;
                    isLastMonth = false;
                }
                else if (isThisMonth)
                {
                    listPhrase = listPhrase.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewPhrase.DataSource = listPhrase;
                    isThisMonth = false;
                }
                else if (isAll)
                {
                    dataGridViewPhrase.DataSource = listPhrase;
                    isAll = false;
                }
                else
                {
                    listPhrase = listPhrase.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewPhrase.DataSource = listPhrase;
                }
                txtWordPagePhrase.Clear();
                txtYearPagePhrase.Clear();
                cmbCasesPagePhrase.SelectedIndex = -1;
                cmbMonthPagePhrase.SelectedIndex = -1;
                cmbGroupPagePhrase.SelectedIndex = -1;
            }
            else if (partOfSpeech == "Sentences")
            {
                List<WordDetailDTO> listSentence = dto.Sentences;
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        listSentence = listSentence.Where(x => x.MonthID == month && x.Year == DateTime.Today.Year - 1).ToList();
                    }
                    else
                    {
                        listSentence = listSentence.Where(x => x.MonthID == month && x.Year == year).ToList();
                    }
                    dataGridViewSentence.DataSource = listSentence;
                    isLastMonth = false;
                }
                else if (isThisMonth)
                {
                    listSentence = listSentence.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewSentence.DataSource = listSentence;
                    isThisMonth = false;
                }
                else if (isAll)
                {
                    dataGridViewSentence.DataSource = listSentence;
                    isAll = false;
                }
                else
                {
                    listSentence = listSentence.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewSentence.DataSource = listSentence;
                }
                txtWordPageSentence.Clear();
                txtYearPageSentence.Clear();
                cmbCasesPageSentence.SelectedIndex = -1;
                cmbMonthPageSentence.SelectedIndex = -1;
                cmbGroupPageSentence.SelectedIndex = -1;
            }
            else if (partOfSpeech == "Verbs")
            {
                List<WordDetailDTO> listVerb = dto.Verbs;
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        listVerb = listVerb.Where(x => x.MonthID == month && x.Year == DateTime.Today.Year - 1).ToList();
                    }
                    else
                    {
                        listVerb = listVerb.Where(x => x.MonthID == month && x.Year == year).ToList();
                    }
                    dataGridViewVerb.DataSource = listVerb;
                    isLastMonth = false;
                }
                else if (isThisMonth)
                {
                    listVerb = listVerb.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewVerb.DataSource = listVerb;
                    isThisMonth = false;
                }
                else if (isAll)
                {
                    dataGridViewVerb.DataSource = listVerb;
                    isAll = false;
                }
                else
                {
                    listVerb = listVerb.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                    dataGridViewVerb.DataSource = listVerb;
                }
                txtWordPageVerb.Clear();
                txtYearPageVerb.Clear();
                cmbCasesPageVerb.SelectedIndex = -1;
                cmbMonthPageVerb.SelectedIndex = -1;
                cmbGroupPageVerb.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Unknown action!");
            }
            RefreshCounts();
        }

        private void txtWordPageAdj_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Adjectives;
            list = list.Where(x => x.Word.Contains(txtWordPageAdj.Text.Trim()) || x.Explanation.Contains(txtWordPageAdj.Text.Trim())).ToList();
            dataGridViewAdj.DataSource = list;
            RefreshCounts();
        }

        private void txtYearPageAdj_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Adjectives;
            list = list.Where(x => x.Year.ToString().Contains(txtYearPageAdj.Text.Trim())).ToList();
            dataGridViewAdj.DataSource = list;
            RefreshCounts();
        }

        private void txtYearPageAdj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void iconSearchPageAdj_Click(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            List<WordDetailDTO> list = dto.Adjectives;
            if (cmbMonthPageAdj.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonthPageAdj.SelectedValue)).ToList();
            }
            else if (cmbCasesPageAdj.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageAdj.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageAdj.SelectedValue)).ToList();
                    }
                }                
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordCaseID == Convert.ToInt32(cmbCasesPageAdj.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordCaseID == Convert.ToInt32(cmbCasesPageAdj.SelectedValue)).ToList();
                }
            }
            else if (cmbGroupPageAdj.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageAdj.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageAdj.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordGroupID == Convert.ToInt32(cmbGroupPageAdj.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordGroupID == Convert.ToInt32(cmbGroupPageAdj.SelectedValue)).ToList();
                }
            }
            dataGridViewAdj.DataSource = list;
            RefreshCounts();
        }

        private void ThisMonth(string partsOfSpeech)
        {
            isLastMonth = false;
            isAll = false;
            isThisMonth = true;
            ClearFilters(partsOfSpeech);
        }

        private void LastMonth(string partsOfSpeech)
        {
            isThisMonth = false;
            isAll = false;
            isLastMonth = true;
            ClearFilters(partsOfSpeech);
        }

        private void AllMonths(string partsOfSpeech)
        {
            isThisMonth = false;
            isLastMonth = false;
            isAll = true;
            ClearFilters(partsOfSpeech);
        }

        
        private void iconLastMonthAdj_Click(object sender, EventArgs e)
        {
            LastMonth(adjectives);
        }

        private void iconThisMonthAdj_Click(object sender, EventArgs e)
        {
            ThisMonth(adjectives);
        }

        private void iconEditPageAdj_Click(object sender, EventArgs e)
        {
            if (detailAdj.WordID == 0)
            {
                MessageBox.Show("Please select a word from the table");
            }
            else
            {
                FormWord open = new FormWord();
                open.detail = detailAdj;
                open.isUpdate = true;
                this.Close();
                open.ShowDialog();
                this.Visible = true;
            }
        }

        private void iconClearPageAdj_Click(object sender, EventArgs e)
        {
            ClearFilters(adjectives);
        }

        private void iconAllAdj_Click(object sender, EventArgs e)
        {
            AllMonths(adjectives);
        }
        
        private void txtWordPageAdv_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Adverbs;
            list = list.Where(x => x.Word.Contains(txtWordPageAdv.Text.Trim()) || x.Explanation.Contains(txtWordPageAdv.Text.Trim())).ToList();
            dataGridViewAdv.DataSource = list;
            RefreshCounts();
        }

        private void txtYearPageAdv_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Adverbs;
            list = list.Where(x => x.Year.ToString().Contains(txtYearPageAdv.Text.Trim())).ToList();
            dataGridViewAdv.DataSource = list;
            RefreshCounts();
        }

        private void iconSearchPageAdv_Click(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            List<WordDetailDTO> list = dto.Adverbs;
            if (cmbMonthPageAdv.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonthPageAdv.SelectedValue)).ToList();
            }
            else if (cmbCasesPageAdv.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageAdv.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageAdv.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordCaseID == Convert.ToInt32(cmbCasesPageAdv.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordCaseID == Convert.ToInt32(cmbCasesPageAdv.SelectedValue)).ToList();
                }
            }
            else if (cmbGroupPageAdv.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageAdv.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageAdv.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordGroupID == Convert.ToInt32(cmbGroupPageAdv.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordGroupID == Convert.ToInt32(cmbGroupPageAdv.SelectedValue)).ToList();
                }
            }
            dataGridViewAdv.DataSource = list;
            RefreshCounts();
        }

        private void txtYearPageAdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void iconClearPageAdv_Click(object sender, EventArgs e)
        {
            ClearFilters(adverbs);
        }

        private void iconThisMonthAdv_Click(object sender, EventArgs e)
        {
            ThisMonth(adverbs);
        }

        private void iconAllAdv_Click(object sender, EventArgs e)
        {
            AllMonths(adverbs);
        }

        private void iconLastMonthAdv_Click(object sender, EventArgs e)
        {
            LastMonth(adverbs);
        }

        private void iconEditPageAdv_Click(object sender, EventArgs e)
        {
            if (detailAdv.WordID == 0)
            {
                MessageBox.Show("Please select a word from the table");
            }
            else
            {
                FormWord open = new FormWord();
                open.detail = detailAdv;
                open.isUpdate = true;
                this.Close();
                open.ShowDialog();
                this.Visible = true;
            }
        }

        WordDetailDTO detailAdv = new WordDetailDTO();
        private void dataGridViewAdv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detailAdv = new WordDetailDTO();
            detailAdv.WordsCount = Convert.ToInt32(dataGridViewAdv.Rows[e.RowIndex].Cells[0].Value);
            detailAdv.WordID = Convert.ToInt32(dataGridViewAdv.Rows[e.RowIndex].Cells[1].Value);
            detailAdv.UserID = Convert.ToInt32(dataGridViewAdv.Rows[e.RowIndex].Cells[2].Value);
            detailAdv.LanguageID = Convert.ToInt32(dataGridViewAdv.Rows[e.RowIndex].Cells[3].Value);
            detailAdv.MonthID = Convert.ToInt32(dataGridViewAdv.Rows[e.RowIndex].Cells[4].Value);
            detailAdv.PartOfSpeechID = Convert.ToInt32(dataGridViewAdv.Rows[e.RowIndex].Cells[5].Value);
            detailAdv.WordCaseID = Convert.ToInt32(dataGridViewAdv.Rows[e.RowIndex].Cells[6].Value);
            detailAdv.WordGroupID = Convert.ToInt32(dataGridViewAdv.Rows[e.RowIndex].Cells[7].Value);
            detailAdv.Word = dataGridViewAdv.Rows[e.RowIndex].Cells[8].Value.ToString();
            detailAdv.WordGroupName = dataGridViewAdv.Rows[e.RowIndex].Cells[9].Value.ToString();
            detailAdv.PartOfSpeechName = dataGridViewAdv.Rows[e.RowIndex].Cells[10].Value.ToString();
            detailAdv.WordCaseName = dataGridViewAdv.Rows[e.RowIndex].Cells[11].Value.ToString();
            detailAdv.Day = Convert.ToInt32(dataGridViewAdv.Rows[e.RowIndex].Cells[12].Value);
            detailAdv.MonthName = dataGridViewAdv.Rows[e.RowIndex].Cells[13].Value.ToString();
            detailAdv.Year = Convert.ToInt32(dataGridViewAdv.Rows[e.RowIndex].Cells[14].Value);
            detailAdv.Explanation = dataGridViewAdv.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtExplanationAdv.Text = dataGridViewAdv.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        WordDetailDTO detailConj = new WordDetailDTO();
        private void dataGridViewConj_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detailConj = new WordDetailDTO();
            detailConj.WordsCount = Convert.ToInt32(dataGridViewConj.Rows[e.RowIndex].Cells[0].Value);
            detailConj.WordID = Convert.ToInt32(dataGridViewConj.Rows[e.RowIndex].Cells[1].Value);
            detailConj.UserID = Convert.ToInt32(dataGridViewConj.Rows[e.RowIndex].Cells[2].Value);
            detailConj.LanguageID = Convert.ToInt32(dataGridViewConj.Rows[e.RowIndex].Cells[3].Value);
            detailConj.MonthID = Convert.ToInt32(dataGridViewConj.Rows[e.RowIndex].Cells[4].Value);
            detailConj.PartOfSpeechID = Convert.ToInt32(dataGridViewConj.Rows[e.RowIndex].Cells[5].Value);
            detailConj.WordCaseID = Convert.ToInt32(dataGridViewConj.Rows[e.RowIndex].Cells[6].Value);
            detailConj.WordGroupID = Convert.ToInt32(dataGridViewConj.Rows[e.RowIndex].Cells[7].Value);
            detailConj.Word = dataGridViewConj.Rows[e.RowIndex].Cells[8].Value.ToString();
            detailConj.WordGroupName = dataGridViewConj.Rows[e.RowIndex].Cells[9].Value.ToString();
            detailConj.PartOfSpeechName = dataGridViewConj.Rows[e.RowIndex].Cells[10].Value.ToString();
            detailConj.WordCaseName = dataGridViewConj.Rows[e.RowIndex].Cells[11].Value.ToString();
            detailConj.Day = Convert.ToInt32(dataGridViewConj.Rows[e.RowIndex].Cells[12].Value);
            detailConj.MonthName = dataGridViewConj.Rows[e.RowIndex].Cells[13].Value.ToString();
            detailConj.Year = Convert.ToInt32(dataGridViewConj.Rows[e.RowIndex].Cells[14].Value);
            detailConj.Explanation = dataGridViewConj.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtExplanationConj.Text = dataGridViewConj.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        private void txtWordPageConj_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Conjunction;
            list = list.Where(x => x.Word.Contains(txtWordPageConj.Text.Trim()) || x.Explanation.Contains(txtWordPageConj.Text.Trim())).ToList();
            dataGridViewConj.DataSource = list;
            RefreshCounts();
        }

        private void txtYearPageConj_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Conjunction;
            list = list.Where(x => x.Year.ToString().Contains(txtYearPageConj.Text.Trim())).ToList();
            dataGridViewConj.DataSource = list;
            RefreshCounts();
        }

        private void iconSearchPageConj_Click(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            List<WordDetailDTO> list = dto.Conjunction;
            if (cmbMonthPageConj.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonthPageConj.SelectedValue)).ToList();
            }
            else if (cmbCasesPageConj.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageConj.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageConj.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordCaseID == Convert.ToInt32(cmbCasesPageConj.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordCaseID == Convert.ToInt32(cmbCasesPageConj.SelectedValue)).ToList();
                }
            }
            else if (cmbGroupPageConj.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageConj.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageConj.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordGroupID == Convert.ToInt32(cmbGroupPageConj.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordGroupID == Convert.ToInt32(cmbGroupPageConj.SelectedValue)).ToList();
                }
            }
            dataGridViewConj.DataSource = list;
            RefreshCounts();
        }

        private void iconClearPageConj_Click(object sender, EventArgs e)
        {
            ClearFilters(conjunction);
        }

        private void iconThisMonthConj_Click(object sender, EventArgs e)
        {
            ThisMonth(conjunction);
        }

        private void iconAllConj_Click(object sender, EventArgs e)
        {
            AllMonths(conjunction);
        }

        private void iconLastMonthConj_Click(object sender, EventArgs e)
        {
            LastMonth(conjunction);
        }

        private void iconEditPageConj_Click(object sender, EventArgs e)
        {
            if (detailConj.WordID == 0)
            {
                MessageBox.Show("Please select a word from the table");
            }
            else
            {
                FormWord open = new FormWord();
                open.detail = detailConj;
                open.isUpdate = true;
                this.Close();
                open.ShowDialog();
                this.Visible = true;
            }
        }

        private void txtWordPageNoun_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Nouns;
            list = list.Where(x => x.Word.Contains(txtWordPageNoun.Text.Trim()) || x.Explanation.Contains(txtWordPageNoun.Text.Trim())).ToList();
            dataGridViewNoun.DataSource = list;
            RefreshCounts();
        }
        WordDetailDTO detailNoun = new WordDetailDTO();
        private void dataGridViewNoun_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detailNoun = new WordDetailDTO();
            detailNoun.WordsCount = Convert.ToInt32(dataGridViewNoun.Rows[e.RowIndex].Cells[0].Value);
            detailNoun.WordID = Convert.ToInt32(dataGridViewNoun.Rows[e.RowIndex].Cells[1].Value);
            detailNoun.UserID = Convert.ToInt32(dataGridViewNoun.Rows[e.RowIndex].Cells[2].Value);
            detailNoun.LanguageID = Convert.ToInt32(dataGridViewNoun.Rows[e.RowIndex].Cells[3].Value);
            detailNoun.MonthID = Convert.ToInt32(dataGridViewNoun.Rows[e.RowIndex].Cells[4].Value);
            detailNoun.PartOfSpeechID = Convert.ToInt32(dataGridViewNoun.Rows[e.RowIndex].Cells[5].Value);
            detailNoun.WordCaseID = Convert.ToInt32(dataGridViewNoun.Rows[e.RowIndex].Cells[6].Value);
            detailNoun.WordGroupID = Convert.ToInt32(dataGridViewNoun.Rows[e.RowIndex].Cells[7].Value);
            detailNoun.Word = dataGridViewNoun.Rows[e.RowIndex].Cells[8].Value.ToString();
            detailNoun.WordGroupName = dataGridViewNoun.Rows[e.RowIndex].Cells[9].Value.ToString();
            detailNoun.PartOfSpeechName = dataGridViewNoun.Rows[e.RowIndex].Cells[10].Value.ToString();
            detailNoun.WordCaseName = dataGridViewNoun.Rows[e.RowIndex].Cells[11].Value.ToString();
            detailNoun.Day = Convert.ToInt32(dataGridViewNoun.Rows[e.RowIndex].Cells[12].Value);
            detailNoun.MonthName = dataGridViewNoun.Rows[e.RowIndex].Cells[13].Value.ToString();
            detailNoun.Year = Convert.ToInt32(dataGridViewNoun.Rows[e.RowIndex].Cells[14].Value);
            detailNoun.Explanation = dataGridViewNoun.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtExplanationNoun.Text = dataGridViewNoun.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        private void txtYearPageNoun_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Nouns;
            list = list.Where(x => x.Year.ToString().Contains(txtYearPageNoun.Text.Trim())).ToList();
            dataGridViewNoun.DataSource = list;
            RefreshCounts();
        }

        private void iconSearchPageNoun_Click(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            List<WordDetailDTO> list = dto.Nouns;
            if (cmbMonthPageNoun.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonthPageNoun.SelectedValue)).ToList();
            }
            else if (cmbCasesPageNoun.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageNoun.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageNoun.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordCaseID == Convert.ToInt32(cmbCasesPageNoun.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordCaseID == Convert.ToInt32(cmbCasesPageNoun.SelectedValue)).ToList();
                }
            }
            else if (cmbGroupPageNoun.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageNoun.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageNoun.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordGroupID == Convert.ToInt32(cmbGroupPageNoun.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordGroupID == Convert.ToInt32(cmbGroupPageNoun.SelectedValue)).ToList();
                }
            }
            dataGridViewNoun.DataSource = list;
            RefreshCounts();
        }

        private void iconClearPageNoun_Click(object sender, EventArgs e)
        {
            ClearFilters(nouns);
        }

        private void iconThisMonthNoun_Click(object sender, EventArgs e)
        {
            ThisMonth(nouns);
        }

        private void iconAllNoun_Click(object sender, EventArgs e)
        {
            AllMonths(nouns);
        }

        private void iconLastMonthNoun_Click(object sender, EventArgs e)
        {
            LastMonth(nouns);
        }
        private void iconEditPageNoun_Click(object sender, EventArgs e)
        {
            if (detailNoun.WordID == 0)
            {
                MessageBox.Show("Please select a word from the table");
            }
            else
            {
                FormWord open = new FormWord();
                open.detail = detailNoun;
                open.isUpdate = true;
                this.Close();
                open.ShowDialog();
                this.Visible = true;
            }
        }
        WordDetailDTO detailPhrase = new WordDetailDTO();
        private void dataGridViewPhrase_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detailPhrase = new WordDetailDTO();
            detailPhrase.WordsCount = Convert.ToInt32(dataGridViewPhrase.Rows[e.RowIndex].Cells[0].Value);
            detailPhrase.WordID = Convert.ToInt32(dataGridViewPhrase.Rows[e.RowIndex].Cells[1].Value);
            detailPhrase.UserID = Convert.ToInt32(dataGridViewPhrase.Rows[e.RowIndex].Cells[2].Value);
            detailPhrase.LanguageID = Convert.ToInt32(dataGridViewPhrase.Rows[e.RowIndex].Cells[3].Value);
            detailPhrase.MonthID = Convert.ToInt32(dataGridViewPhrase.Rows[e.RowIndex].Cells[4].Value);
            detailPhrase.PartOfSpeechID = Convert.ToInt32(dataGridViewPhrase.Rows[e.RowIndex].Cells[5].Value);
            detailPhrase.WordCaseID = Convert.ToInt32(dataGridViewPhrase.Rows[e.RowIndex].Cells[6].Value);
            detailPhrase.WordGroupID = Convert.ToInt32(dataGridViewPhrase.Rows[e.RowIndex].Cells[7].Value);
            detailPhrase.Word = dataGridViewPhrase.Rows[e.RowIndex].Cells[8].Value.ToString();
            detailPhrase.WordGroupName = dataGridViewPhrase.Rows[e.RowIndex].Cells[9].Value.ToString();
            detailPhrase.PartOfSpeechName = dataGridViewPhrase.Rows[e.RowIndex].Cells[10].Value.ToString();
            detailPhrase.WordCaseName = dataGridViewPhrase.Rows[e.RowIndex].Cells[11].Value.ToString();
            detailPhrase.Day = Convert.ToInt32(dataGridViewPhrase.Rows[e.RowIndex].Cells[12].Value);
            detailPhrase.MonthName = dataGridViewPhrase.Rows[e.RowIndex].Cells[13].Value.ToString();
            detailPhrase.Year = Convert.ToInt32(dataGridViewPhrase.Rows[e.RowIndex].Cells[14].Value);
            detailPhrase.Explanation = dataGridViewPhrase.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtExplanationPhrase.Text = dataGridViewPhrase.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        private void txtWordPagePhrase_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.PhraseWords;
            list = list.Where(x => x.Word.Contains(txtWordPagePhrase.Text.Trim()) || x.Explanation.Contains(txtWordPagePhrase.Text.Trim())).ToList();
            dataGridViewPhrase.DataSource = list;
            RefreshCounts();
        }

        private void iconClearPagePhrase_Click(object sender, EventArgs e)
        {
            ClearFilters(phrase);
        }

        private void txtYearPagePhrase_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.PhraseWords;
            list = list.Where(x => x.Year.ToString().Contains(txtYearPagePhrase.Text.Trim())).ToList();
            dataGridViewPhrase.DataSource = list;
            RefreshCounts();
        }

        private void txtYearPagePhrase_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void iconSearchPagePhrase_Click(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            List<WordDetailDTO> list = dto.PhraseWords;
            if (cmbMonthPagePhrase.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonthPagePhrase.SelectedValue)).ToList();
            }
            else if (cmbCasesPagePhrase.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPagePhrase.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPagePhrase.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordCaseID == Convert.ToInt32(cmbCasesPagePhrase.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordCaseID == Convert.ToInt32(cmbCasesPagePhrase.SelectedValue)).ToList();
                }
            }
            else if (cmbGroupPagePhrase.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPagePhrase.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPagePhrase.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordGroupID == Convert.ToInt32(cmbGroupPagePhrase.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordGroupID == Convert.ToInt32(cmbGroupPagePhrase.SelectedValue)).ToList();
                }
            }
            dataGridViewPhrase.DataSource = list;
            RefreshCounts();
        }

        private void iconThisMonthPhrase_Click(object sender, EventArgs e)
        {
            ThisMonth(phrase);
        }

        private void iconAllPhrase_Click(object sender, EventArgs e)
        {
            AllMonths(phrase);
        }

        private void iconLastMonthPhrase_Click(object sender, EventArgs e)
        {
            LastMonth(phrase);
        }

        private void iconEditPagePhrase_Click(object sender, EventArgs e)
        {
            if (detailPhrase.WordID == 0)
            {
                MessageBox.Show("Please select a phrase or an idiom from the table");
            }
            else
            {
                FormWord open = new FormWord();
                open.detail = detailPhrase;
                open.isUpdate = true;
                this.Close();
                open.ShowDialog();
                this.Visible = true;
            }
        }

        private void txtWordPageSentence_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Sentences;
            list = list.Where(x => x.Word.ToString().Contains(txtWordPageSentence.Text.Trim())).ToList();
            dataGridViewSentence.DataSource = list;
            RefreshCounts();
        }

        private void txtYearPageSentence_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Sentences;
            list = list.Where(x => x.Year.ToString().Contains(txtYearPageSentence.Text.Trim())).ToList();
            dataGridViewSentence.DataSource = list;
            RefreshCounts();
        }

        private void iconSearchPageSentence_Click(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            List<WordDetailDTO> list = dto.Sentences;
            if (cmbMonthPageSentence.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonthPageSentence.SelectedValue)).ToList();
            }
            else if (cmbCasesPageSentence.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageSentence.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageSentence.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordCaseID == Convert.ToInt32(cmbCasesPageSentence.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordCaseID == Convert.ToInt32(cmbCasesPageSentence.SelectedValue)).ToList();
                }
            }
            else if (cmbGroupPageSentence.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageSentence.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageSentence.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordGroupID == Convert.ToInt32(cmbGroupPageSentence.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordGroupID == Convert.ToInt32(cmbGroupPageSentence.SelectedValue)).ToList();
                }
            }
            dataGridViewSentence.DataSource = list;
            RefreshCounts();
        }

        private void iconClearPageSentence_Click(object sender, EventArgs e)
        {
            ClearFilters(sentence);
        }

        private void iconThisMonthSentence_Click(object sender, EventArgs e)
        {
            ThisMonth(sentence);
        }

        private void iconAllSentence_Click(object sender, EventArgs e)
        {
            AllMonths(sentence);
        }

        private void iconLastMonthSentence_Click(object sender, EventArgs e)
        {
            LastMonth(sentence);
        }

        private void iconEditPageSentence_Click(object sender, EventArgs e)
        {
            if (detailSentence.WordID == 0)
            {
                MessageBox.Show("Please select a sentence from the table");
            }
            else
            {
                FormWord open = new FormWord();
                open.detail = detailSentence;
                open.isUpdate = true;
                this.Close();
                open.ShowDialog();
                this.Visible = true;
            }
        }
        WordDetailDTO detailSentence = new WordDetailDTO();
        private void dataGridViewSentence_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detailSentence = new WordDetailDTO();
            detailSentence.WordsCount = Convert.ToInt32(dataGridViewSentence.Rows[e.RowIndex].Cells[0].Value);
            detailSentence.WordID = Convert.ToInt32(dataGridViewSentence.Rows[e.RowIndex].Cells[1].Value);
            detailSentence.UserID = Convert.ToInt32(dataGridViewSentence.Rows[e.RowIndex].Cells[2].Value);
            detailSentence.LanguageID = Convert.ToInt32(dataGridViewSentence.Rows[e.RowIndex].Cells[3].Value);
            detailSentence.MonthID = Convert.ToInt32(dataGridViewSentence.Rows[e.RowIndex].Cells[4].Value);
            detailSentence.PartOfSpeechID = Convert.ToInt32(dataGridViewSentence.Rows[e.RowIndex].Cells[5].Value);
            detailSentence.WordCaseID = Convert.ToInt32(dataGridViewSentence.Rows[e.RowIndex].Cells[6].Value);
            detailSentence.WordGroupID = Convert.ToInt32(dataGridViewSentence.Rows[e.RowIndex].Cells[7].Value);
            detailSentence.Word = dataGridViewSentence.Rows[e.RowIndex].Cells[8].Value.ToString();
            detailSentence.WordGroupName = dataGridViewSentence.Rows[e.RowIndex].Cells[9].Value.ToString();
            detailSentence.PartOfSpeechName = dataGridViewSentence.Rows[e.RowIndex].Cells[10].Value.ToString();
            detailSentence.WordCaseName = dataGridViewSentence.Rows[e.RowIndex].Cells[11].Value.ToString();
            detailSentence.Day = Convert.ToInt32(dataGridViewSentence.Rows[e.RowIndex].Cells[12].Value);
            detailSentence.MonthName = dataGridViewSentence.Rows[e.RowIndex].Cells[13].Value.ToString();
            detailSentence.Year = Convert.ToInt32(dataGridViewSentence.Rows[e.RowIndex].Cells[14].Value);
            detailSentence.Explanation = dataGridViewSentence.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtExplanationSentence.Text = dataGridViewSentence.Rows[e.RowIndex].Cells[15].Value.ToString();
        }
        WordDetailDTO detailVerb = new WordDetailDTO();
        private void dataGridViewVerb_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detailVerb = new WordDetailDTO();
            detailVerb.WordsCount = Convert.ToInt32(dataGridViewVerb.Rows[e.RowIndex].Cells[0].Value);
            detailVerb.WordID = Convert.ToInt32(dataGridViewVerb.Rows[e.RowIndex].Cells[1].Value);
            detailVerb.UserID = Convert.ToInt32(dataGridViewVerb.Rows[e.RowIndex].Cells[2].Value);
            detailVerb.LanguageID = Convert.ToInt32(dataGridViewVerb.Rows[e.RowIndex].Cells[3].Value);
            detailVerb.MonthID = Convert.ToInt32(dataGridViewVerb.Rows[e.RowIndex].Cells[4].Value);
            detailVerb.PartOfSpeechID = Convert.ToInt32(dataGridViewVerb.Rows[e.RowIndex].Cells[5].Value);
            detailVerb.WordCaseID = Convert.ToInt32(dataGridViewVerb.Rows[e.RowIndex].Cells[6].Value);
            detailVerb.WordGroupID = Convert.ToInt32(dataGridViewVerb.Rows[e.RowIndex].Cells[7].Value);
            detailVerb.Word = dataGridViewVerb.Rows[e.RowIndex].Cells[8].Value.ToString();
            detailVerb.WordGroupName = dataGridViewVerb.Rows[e.RowIndex].Cells[9].Value.ToString();
            detailVerb.PartOfSpeechName = dataGridViewVerb.Rows[e.RowIndex].Cells[10].Value.ToString();
            detailVerb.WordCaseName = dataGridViewVerb.Rows[e.RowIndex].Cells[11].Value.ToString();
            detailVerb.Day = Convert.ToInt32(dataGridViewVerb.Rows[e.RowIndex].Cells[12].Value);
            detailVerb.MonthName = dataGridViewVerb.Rows[e.RowIndex].Cells[13].Value.ToString();
            detailVerb.Year = Convert.ToInt32(dataGridViewVerb.Rows[e.RowIndex].Cells[14].Value);
            detailVerb.Explanation = dataGridViewVerb.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtExplanationVerb.Text = dataGridViewVerb.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        private void txtWordPageVerb_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Verbs;
            list = list.Where(x => x.Word.Contains(txtWordPageVerb.Text.Trim()) || x.Explanation.Contains(txtWordPageVerb.Text.Trim())).ToList();
            dataGridViewVerb.DataSource = list;
            RefreshCounts();
        }

        private void txtYearPageVerb_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Verbs;
            list = list.Where(x => x.Year.ToString().Contains(txtYearPageVerb.Text.Trim())).ToList();
            dataGridViewVerb.DataSource = list;
            RefreshCounts();
        }

        private void iconSearchPageVerb_Click(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            List<WordDetailDTO> list = dto.Verbs;
            if (cmbMonthPageVerb.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonthPageVerb.SelectedValue)).ToList();
            }
            else if (cmbCasesPageVerb.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageVerb.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordCaseID == Convert.ToInt32(cmbCasesPageVerb.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordCaseID == Convert.ToInt32(cmbCasesPageVerb.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordCaseID == Convert.ToInt32(cmbCasesPageVerb.SelectedValue)).ToList();
                }
            }
            else if (cmbGroupPageVerb.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageVerb.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroupPageVerb.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordGroupID == Convert.ToInt32(cmbGroupPageVerb.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordGroupID == Convert.ToInt32(cmbGroupPageVerb.SelectedValue)).ToList();
                }
            }
            dataGridViewVerb.DataSource = list;
            RefreshCounts();
        }

        private void iconClearPageVerb_Click(object sender, EventArgs e)
        {
            ClearFilters(verb);
        }

        private void iconThisMonthVerb_Click(object sender, EventArgs e)
        {
            ThisMonth(verb);
        }

        private void iconAllVerb_Click(object sender, EventArgs e)
        {
            AllMonths(verb);
        }

        private void iconLastMonthVerb_Click(object sender, EventArgs e)
        {
            LastMonth(verb);
        }

        private void iconEditPageVerb_Click(object sender, EventArgs e)
        {
            if (detailVerb.WordID == 0)
            {
                MessageBox.Show("Please select a word from the table");
            }
            else
            {
                FormWord open = new FormWord();
                open.detail = detailVerb;
                open.isUpdate = true;
                this.Close();
                open.ShowDialog();
                this.Visible = true;
            }
        }

        private void iconViewPageSentence_Click(object sender, EventArgs e)
        {
            if (detailSentence.WordID == 0)
            {
                MessageBox.Show("Please select a sentence from the table");
            }
            else
            {
                FormViewSentence open = new FormViewSentence();
                open.detail = detailSentence;
                this.Close();
                open.ShowDialog();
                this.Visible = true;
            }
        }
    }
}
