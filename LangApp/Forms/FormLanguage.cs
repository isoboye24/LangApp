using LangApp.BLL;
using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangApp.Forms
{
    public partial class FormLanguage : Form
    {
        public FormLanguage()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        LanguagesBLL bll = new LanguagesBLL();
        LanguagesDTO dto = new LanguagesDTO();
        LanguageBLL chosenLangBLL = new LanguageBLL();
        private void FormLanguage_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbLanguages.DataSource = dto.Languages;
            General.ComboBoxProps(cmbLanguages, "Language", "LanguageID");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbLanguages.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a language");
            }
            else
            {
                LanguageDetailDTO langChosen = new LanguageDetailDTO();
                langChosen.LanguageListID = Convert.ToInt32(cmbLanguages.SelectedValue);
                langChosen.UserID = 1;
                if (chosenLangBLL.Insert(langChosen))
                {
                    MessageBox.Show("Language was added");
                    cmbLanguages.SelectedIndex = -1;
                }
            }
        }
    }
}
