using LangApp.BLL;
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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LangApp.AllForms
{
    public partial class FormSentences : Form
    {
        public FormSentences()
        {
            InitializeComponent();
        }
        WordBLL bll = new WordBLL();
        WordDTO dto = new WordDTO();
        private void FormSentences_Load(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            cmbGroup.DataSource = dto.WordGroups;
            General.ComboBoxProps(cmbGroup, "WordGroupName", "WordGroupID");
            cmbMonth.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonth, "MonthName", "MonthID");

            List<WordDetailDTO> list = dto.Sentences;
            list = list.Where(x => x.Year == DateTime.Today.Year && x.MonthID == DateTime.Today.Month).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "No.";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Sentences";
            dataGridView1.Columns[9].HeaderText = "Group";
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].HeaderText = "Month";
            dataGridView1.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[14].HeaderText = "Year";
            dataGridView1.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[15].Visible = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            RefreshCounts();
            btnLastMonthsSentences.Text = General.ConventIntToMonthGerman(DateTime.Today.Month - 1);
            btnThisMonthsSentences.Text = General.ConventIntToMonthGerman(DateTime.Today.Month);
        }
        private void RefreshCounts()
        {
            labelTotalWords.Text = dataGridView1.RowCount.ToString();
        }
        WordDetailDTO detail = new WordDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new WordDetailDTO();
            detail.WordsCount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.WordID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detail.UserID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.LanguageID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            detail.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            detail.PartOfSpeechID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            detail.WordCaseID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            detail.WordGroupID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            detail.Word = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            detail.WordGroupName = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            detail.PartOfSpeechName = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            detail.WordCaseName = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            detail.Day = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            detail.MonthName = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            detail.Year = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
            detail.Explanation = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();            
        }
        private bool isLastMonth = false;
        private bool isThisMonth = false;
        private void ClearFilters()
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            List<WordDetailDTO> list = dto.Sentences;
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
                dataGridView1.DataSource = list;
            }
            else if (isThisMonth)
            {
                list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year).ToList();
                dataGridView1.DataSource = list;
            }
            else
            {
                dataGridView1.DataSource = list;
            }
            txtSentence.Clear();
            txtYear.Clear();
            cmbGroup.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1;
            RefreshCounts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void txtSentence_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Sentences;
            if (isLastMonth)
            {
                int month = DateTime.Today.Month - 1;
                int year = DateTime.Today.Year;
                if (month == 12)
                {
                    year -= 1;
                    list = list.Where(x => x.MonthID == month && x.Year == year && x.Word.Contains(txtSentence.Text.Trim())).ToList();
                }
                else
                {
                    list = list.Where(x => x.MonthID == month && x.Year == year && x.Word.Contains(txtSentence.Text.Trim())).ToList();
                }
            }
            else if (isThisMonth)
            {
                list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.Word.Contains(txtSentence.Text.Trim())).ToList();
            }
            else
            {
                list = list.Where(x => x.Word.Contains(txtSentence.Text.Trim())).ToList();
            }
            dataGridView1.DataSource = list;
            RefreshCounts();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Sentences;
            list = list.Where(x => x.Year.ToString().Contains(txtYear.Text.Trim())).ToList();
            dataGridView1.DataSource = list;
            RefreshCounts();
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            List<WordDetailDTO> list = dto.Sentences;
            if (cmbMonth.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonth.SelectedValue)).ToList();
            }
            else if (cmbGroup.SelectedIndex != -1)
            {
                if (isLastMonth)
                {
                    int month = DateTime.Today.Month - 1;
                    int year = DateTime.Today.Year;
                    if (month == 12)
                    {
                        year -= 1;
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroup.SelectedValue)).ToList();
                    }
                    else
                    {
                        list = list.Where(x => x.MonthID == month && x.Year == year && x.WordGroupID == Convert.ToInt32(cmbGroup.SelectedValue)).ToList();
                    }
                }
                else if (isThisMonth)
                {
                    list = list.Where(x => x.MonthID == DateTime.Today.Month && x.Year == DateTime.Today.Year && x.WordGroupID == Convert.ToInt32(cmbGroup.SelectedValue)).ToList();
                }
                else
                {
                    list = list.Where(x => x.WordGroupID == Convert.ToInt32(cmbGroup.SelectedValue)).ToList();
                }
            }
            dataGridView1.DataSource = list;
            RefreshCounts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (detail.WordID == 0)
            {
                MessageBox.Show("Please select a word from the table");
            }
            else
            {
                FormWord open = new FormWord();
                open.detail = detail;
                open.isUpdate = true;
                this.Close();
                open.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnLastMonthsSentences_Click(object sender, EventArgs e)
        {
            isThisMonth = false;
            isLastMonth = true;
            ClearFilters();
        }

        private void btnAllSentences_Click(object sender, EventArgs e)
        {
            isThisMonth = false;
            isLastMonth = false;
            ClearFilters();
        }

        private void btnThisMonthsSentences_Click(object sender, EventArgs e)
        {
            isLastMonth = false;
            isThisMonth = true;
            ClearFilters();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (detail.WordID == 0)
            {
                MessageBox.Show("Please select a word from the table");
            }
            else
            {
                FormViewSentence open = new FormViewSentence();
                open.detail = detail;
                this.Close();
                open.ShowDialog();
                this.Visible = true;
            }
        }
    }
}
