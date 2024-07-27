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

namespace LangApp.AllForms
{
    public partial class FormWordsList : Form
    {
        public FormWordsList()
        {
            InitializeComponent();
        }
        WordBLL bll = new WordBLL();
        WordDTO dto = new WordDTO();

        private void FormWords_Load(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            cmbPartsOfSpeech.DataSource = dto.PartsOfSpeech;
            General.ComboBoxProps(cmbPartsOfSpeech, "PartOfSpeechName", "PartOfSpeechID");
            cmbMonth.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonth, "MonthName", "MonthID");

            dataGridView1.DataSource = dto.Words;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Word";
            dataGridView1.Columns[9].HeaderText = "Group";
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormWord open = new FormWord();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            ClearFilters();
        }
        private void ClearFilters()
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            dataGridView1.DataSource = dto.Words;
            txtWord.Clear();
            txtYear.Clear();
            cmbPartsOfSpeech.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1;
            RefreshCounts();
        }
        private void RefreshCounts()
        {
            labelTotalWords.Text = dataGridView1.RowCount.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.WordID == 0)
            {
                MessageBox.Show("Please select a word from the table");
            }
            else
            {
                FormWord open = new FormWord();
                open.isUpdate = true;
                open.detail = detail;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                ClearFilters();
            }            
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
            txtExplanation.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete now?","Warning!",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (bll.Delete(detail))
                {
                    MessageBox.Show("Word was deleted successfully!");
                    ClearFilters();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Words;
            list = list.Where(x => x.Word.Contains(txtWord.Text.Trim())).ToList();
            dataGridView1.DataSource = list;
            RefreshCounts();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            List<WordDetailDTO> list = dto.Words;
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
            List<WordDetailDTO> list = dto.Words;
            if (cmbMonth.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonth.SelectedValue)).ToList();
            }
            else if (cmbPartsOfSpeech.SelectedIndex != -1)
            {
                list = list.Where(x => x.PartOfSpeechID == Convert.ToInt32(cmbPartsOfSpeech.SelectedValue)).ToList();
            }
            dataGridView1.DataSource = list;
            RefreshCounts();
        }
    }
}
