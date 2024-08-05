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
using System.Windows.Forms;

namespace LangApp.AllForms
{
    public partial class FormWord : Form
    {        
        public FormWord()
        {
            InitializeComponent();
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        WordBLL bll = new WordBLL();
        WordDTO dto = new WordDTO();
        public bool isUpdate = false;
        private bool isSameGroup = false;
        public WordDetailDTO detail = new WordDetailDTO();

        private void FormWord_Load(object sender, EventArgs e)
        {
            dto = bll.Select(StaticUser.UserID, StaticUser.LanguageID);
            cmbCase.DataSource = dto.WordCases;
            General.ComboBoxProps(cmbCase, "WordCaseName", "WordCaseID");
            cmbWordGroup.DataSource = dto.WordGroups;
            General.ComboBoxProps(cmbWordGroup, "WordGroupName", "WordGroupID");
            cmbPartsOfSpeech.DataSource = dto.PartsOfSpeech;
            General.ComboBoxProps(cmbPartsOfSpeech, "PartOfSpeechName", "PartOfSpeechID");
            if (isUpdate)
            {
                txtMeaning.Text = detail.Explanation;
                txtWord.Text = detail.Word;
                cmbCase.SelectedValue = detail.WordCaseID;
                cmbPartsOfSpeech.SelectedValue = detail.PartOfSpeechID;
                cmbWordGroup.SelectedValue = detail.WordGroupID;
                labelTitle.Text = "Edit Word";
                label2.Text = "Edit Word";
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
             List<WORD> checkWord = bll.CheckThisWord(StaticUser.UserID, StaticUser.LanguageID, txtWord.Text.Trim(), Convert.ToInt32(cmbWordGroup.SelectedValue), Convert.ToInt32(cmbCase.SelectedValue), Convert.ToInt32(cmbPartsOfSpeech.SelectedValue));
            if (txtWord.Text.Trim() == "")
            {
                MessageBox.Show("Word is empty");
            }
            else if (cmbPartsOfSpeech.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Part of speech");
            }
            else if (cmbCase.SelectedIndex == -1)
            {
                MessageBox.Show("Select word case");
            }
            else if (cmbWordGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Select word group");
            }
            else if (checkWord.Count > 0)
            {
                WORD savedWord = new WORD();
                savedWord = checkWord.First();
                MessageBox.Show(txtWord.Text.Trim() + " was saved on " + savedWord.day +"."+savedWord.monthID +"."+savedWord.year);
            }
            else
            {
                if (!isUpdate)
                {
                    WordDetailDTO word = new WordDetailDTO();
                    word.Word = txtWord.Text.Trim();
                    word.Explanation = txtMeaning.Text.Trim();
                    word.PartOfSpeechID = Convert.ToInt32(cmbPartsOfSpeech.SelectedValue);
                    word.WordCaseID = Convert.ToInt32(cmbCase.SelectedValue);
                    word.WordGroupID = Convert.ToInt32(cmbWordGroup.SelectedValue);
                    word.UserID = StaticUser.UserID;
                    word.LanguageID = StaticUser.LanguageID;
                    word.Day = DateTime.Today.Day;
                    word.MonthID = DateTime.Today.Month;
                    word.Year = DateTime.Today.Year;
                    if (bll.Insert(word))
                    {
                        MessageBox.Show("Word added successfully!");
                        txtMeaning.Clear();
                        txtWord.Clear();
                        if (!isSameGroup)
                        {                            
                            cmbPartsOfSpeech.SelectedIndex = -1;
                            cmbWordGroup.SelectedIndex = -1;
                            cmbCase.SelectedIndex = -1;
                        }                        
                    }
                }
                else if (isUpdate)
                {
                    if (detail.Word == txtWord.Text.Trim() && detail.Explanation == txtMeaning.Text.Trim() 
                        && detail.PartOfSpeechID == Convert.ToInt32(cmbPartsOfSpeech.SelectedValue)
                        && detail.WordCaseID == Convert.ToInt32(cmbCase.SelectedValue)
                        && detail.WordGroupID == Convert.ToInt32(cmbWordGroup.SelectedValue))
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        detail.Word = txtWord.Text.Trim();
                        detail.Explanation = txtMeaning.Text.Trim();
                        detail.PartOfSpeechID = Convert.ToInt32(cmbPartsOfSpeech.SelectedValue);
                        detail.WordCaseID = Convert.ToInt32(cmbCase.SelectedValue);
                        detail.WordGroupID = Convert.ToInt32(cmbWordGroup.SelectedValue);
                        detail.UserID = detail.UserID;
                        detail.LanguageID = detail.LanguageID;
                        detail.Day = detail.Day;
                        detail.MonthID = detail.MonthID;
                        detail.Year = detail.Year;
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Word was updated successfully!");
                            this.Close();                            
                        }
                    }
                }
            }
        }

        private void btnSameWordGroup_Click(object sender, EventArgs e)
        {
            isSameGroup = !isSameGroup;
            if (isSameGroup)
            {
                btnSameWordGroup.Text = "Adding to same group";
            }
            else
            {
                btnSameWordGroup.Text = "Add to same group";
            }
        }        
    }
}
