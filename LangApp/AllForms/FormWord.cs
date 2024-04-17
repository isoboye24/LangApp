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
        public bool isUpdate = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtWord.Text.Trim() == "")
            {
                MessageBox.Show("Word is empty");
            }
            else if (cmbPartsOfSpeech.SelectedIndex == -1)
            {
                MessageBox.Show("Select a category");
            }
            else
            {
                if (!isUpdate)
                {
                    WordDetailDTO word = new WordDetailDTO();
                    word.Word = txtWord.Text.Trim();
                    word.Explanation = txtMeaning.Text.Trim();
                    word.categoryID = Convert.ToInt32(cmbPartsOfSpeech.SelectedValue);
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
                        cmbPartsOfSpeech.SelectedIndex = -1;
                    }
                }
            }
        }
    }
}
