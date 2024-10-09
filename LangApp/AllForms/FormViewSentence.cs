using LangApp.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangApp.AllForms
{
    public partial class FormViewSentence : Form
    {
        public bool isSentence = false;
        public bool isUsefulPhrase = false;
        public FormViewSentence()
        {
            InitializeComponent();
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public WordDetailDTO detail = new WordDetailDTO();
        private void FormViewSentence_Load(object sender, EventArgs e)
        {
            if (isSentence)
            {
                label1.Text = "Sentence on " + detail.Day + "." + detail.MonthID + "." + detail.Year;
                label2.Text = "Sentence Group";
                labelSentGroupName.Text = detail.WordGroupName;
                txtSentence.Text = detail.Word;
            }
            if (isUsefulPhrase)
            {
                label1.Text = "Useful phrase on " + detail.Day + "." + detail.MonthID + "." + detail.Year;
                label2.Text = "Useful Phrase Group";
                labelSentGroupName.Text = detail.WordGroupName;
                txtSentence.Text = detail.Word;
            }
        }
    }
}
