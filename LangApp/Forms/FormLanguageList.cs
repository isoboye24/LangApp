using LangApp.BLL;
using LangApp.DAL.DAO;
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
    public partial class FormLanguageList : Form
    {
        public FormLanguageList()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);

        LanguageBLL bll = new LanguageBLL();
        LanguageDTO dto = new LanguageDTO();
        private void FormLanguageList_Load(object sender, EventArgs e)
        {
            //dto = bll.Select();
            //dataGridView1.DataSource = dto.LanguagesFromList;
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Name = "Select Language";
            //dataGridView1.RowHeadersVisible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormLanguage open = new FormLanguage();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
