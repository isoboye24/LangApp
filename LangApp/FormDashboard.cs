using FontAwesome.Sharp;
using LangApp.AllForms;
using LangApp.BLL;
using LangApp.General_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangApp
{
    public partial class FormDashboard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public string title;
        public string dashboard;
        public string words;
        public string nouns;
        public string verbs;
        public string adjectives;
        public string phrases;
        public string nounsCard;
        public string verbsCard;
        public string adjectivesCard;
        public string phrasesCard;
        public string reports;
        public string monthlyReport;
        public string yearlyReports;
        public string TotalReport;
        public string monthly;
        public string lastMonthly;
        public string yearly;
        public string deletedData;

        public bool isEnglish = false;
        public bool isGerman = false;
        public bool isRussian = false;

        public FormDashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 40);
            panelSidebar.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        private struct RBGColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.YellowGreen;
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(245, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color normal = Color.MidnightBlue;
        }
        // Button Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Brown;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left Border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Maroon;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro; ;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        // Drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            labelTitleChildForm.Text = "Vocabulary App";
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = childForm.Text;
        }
        WordBLL bll = new WordBLL();
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            labelLogo.Text = dashboard;
            labelTitleChildForm.Text = title;
            btnWords.Text = "         " + words;
            btnNoun.Text = "         " + nouns;
            btnVerbs.Text = "         " + verbs;
            btnAdjectives.Text = "         " + adjectives;
            btnPhrases.Text = "         " + phrases;
            label3.Text = reports;
            btnMonthlyReports.Text = "         " + monthlyReport;
            btnYearlyReports.Text = "         " + yearlyReports;
            btnTotalReports.Text = "         " + TotalReport;
            btnDeletedData.Text = "         " + deletedData;
            label8.Text = monthly;
            label12.Text = lastMonthly;
            label4.Text = yearly;
            label2.Text = nounsCard;
            label5.Text = verbsCard;
            label7.Text = adjectivesCard;
            label16.Text = phrasesCard;
            label14.Text = nounsCard;
            label6.Text = verbsCard;
            label13.Text = adjectivesCard;
            label15.Text = phrasesCard;
            label9.Text = nounsCard;
            label11.Text = verbsCard;
            label10.Text = adjectivesCard;
            label18.Text = phrasesCard;

            RefreshCards();
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.BorderStyle = BorderStyle.None;
            picProfile.BackColor = Color.Green;
            picProfile.Width = picProfile.Height = 30;
            picProfile.Paint += new PaintEventHandler(picProfile_Paint);
        }

        private void picProfile_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, picProfile.Width - 1, picProfile.Height - 1);
            Region rg = new Region(gp);
            picProfile.Region = rg;
        }

        private void RefreshCards()
        {
            labelNoOfAdjectives.Text = bll.WordCount(StaticUser.UserID, StaticUser.LanguageID, "Adjective", DateTime.Today.Month, DateTime.Today.Year).ToString();
            labelNoOfNouns.Text = bll.WordCount(StaticUser.UserID, StaticUser.LanguageID, "Noun", DateTime.Today.Month, DateTime.Today.Year).ToString();
            labelNoOfPhrases.Text = bll.WordCount(StaticUser.UserID, StaticUser.LanguageID, "Phrase or Idiom", DateTime.Today.Month, DateTime.Today.Year).ToString();
            labelNoOfVerbs.Text = bll.WordCount(StaticUser.UserID, StaticUser.LanguageID, "Verb", DateTime.Today.Month, DateTime.Today.Year).ToString();
            
            labelYearlyAdjectives.Text = bll.WordCountYearly(StaticUser.UserID, StaticUser.LanguageID, "Adjective",  DateTime.Today.Year).ToString();
            labelYearlyNouns.Text = bll.WordCountYearly(StaticUser.UserID, StaticUser.LanguageID, "Noun",  DateTime.Today.Year).ToString();
            labelYearlyPhrases.Text = bll.WordCountYearly(StaticUser.UserID, StaticUser.LanguageID, "Phrase or Idiom",  DateTime.Today.Year).ToString();
            labelYearlyVerbs.Text = bll.WordCountYearly(StaticUser.UserID, StaticUser.LanguageID, "Verb",  DateTime.Today.Year).ToString();
            int lastMonth = DateTime.Today.Month - 1;
            int yearOfLastMonth = DateTime.Today.Year;

            if (lastMonth - 1 == 0)
            {
                lastMonth = 12;
                yearOfLastMonth -= 1;
            }
            labelNoOfLastMonthAdjectives.Text = bll.WordCount(StaticUser.UserID, StaticUser.LanguageID, "Adjective", lastMonth, yearOfLastMonth).ToString();
            labelNoOfLastMonthNouns.Text = bll.WordCount(StaticUser.UserID, StaticUser.LanguageID, "Noun", lastMonth, yearOfLastMonth).ToString();
            labelNoOfLastMonthPhrases.Text = bll.WordCount(StaticUser.UserID, StaticUser.LanguageID, "Phrase or Idiom", lastMonth, yearOfLastMonth).ToString();
            labelNoOfLastMonthVerbs.Text = bll.WordCount(StaticUser.UserID, StaticUser.LanguageID, "Verb", lastMonth, yearOfLastMonth).ToString();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private bool buttonWasClicked = false;

        private void btnWords_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormWordsList());
        }

        private void btnNoun_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormNouns());
        }

        public void btnAdjectives_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormAdjectives());
        }

        private void btnVerbs_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormVerbs());
        }

        private void btnPhrases_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormPhrases());
        }

        private void btnMonthlyReports_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormMonthlyReportList());
        }

        private void btnYearlyReports_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormYearlyReportList());
        }

        private void btnTotalReports_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormTotalReportList());
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void labelLogo_Click(object sender, EventArgs e)
        {
            if (buttonWasClicked)
            {
                currentChildForm.Close();
                Reset();
                RefreshCards();
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            OpenChildForm(new FormSettings());
        }

        private void btnSentences_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormSentences());
        }
    }
}
