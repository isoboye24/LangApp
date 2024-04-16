using LangApp.BLL;
using LangApp.DAL;
using LangApp.DAL.DAO;
using LangApp.DAL.DTO;
using LangApp.General_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            FillButtonsPanel();
        }
        private void FillButtonsPanel()
        {
            LoadButtonsFromDatabase();
        }
        int buttonHeight = 40;
        int buttonSpacing = 20;
        private void LoadButtonsFromDatabase()
        {
            string connectionString = "Server=localhost\\sqlexpress;Database=LangDB;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT languageName FROM LANGUAGE_LIST " +
                    "INNER JOIN LANGUAGE ON LANGUAGE.languageListID = LANGUAGE_LIST.languageListID " +
                    "WHERE LANGUAGE.userID = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int i = 0;                
                int maxButtonsPerColumn = 10;
                int buttonsPerColumn = 0;
                int panelHeight = buttonsPanel.Height; // Initial panel height
                while (reader.Read())
                {
                    string buttonText = reader["languageName"].ToString();

                    Button button = new Button();
                    button.Text = buttonText;
                    button.Height = buttonHeight;
                    button.Width = 120;
                    button.BackColor = Color.DarkGreen;
                    button.ForeColor = Color.WhiteSmoke;
                    button.FlatStyle = FlatStyle.Popup;
                    button.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    button.Location = new Point(50, 20 + i * (buttonHeight + buttonSpacing));
                    button.Click += Button_Click;

                    // Create delete button dynamically
                    Button deleteButton = new Button();
                    deleteButton.Text = "Del";
                    deleteButton.Tag = button;
                    button.FlatStyle = FlatStyle.Popup;
                    deleteButton.Width = 60;
                    deleteButton.Height = buttonHeight;
                    deleteButton.BackColor = Color.DarkRed;
                    deleteButton.ForeColor = Color.WhiteSmoke;
                    deleteButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    deleteButton.Location = new Point(button.Right + 10, button.Top);
                    deleteButton.Click += DeleteButton_Click;

                    buttonsPanel.Controls.Add(button);
                    buttonsPanel.Controls.Add(deleteButton);
                    buttonsPerColumn++;
                    i++;

                    if (buttonsPerColumn >= maxButtonsPerColumn)
                    {
                        panelHeight += maxButtonsPerColumn * (buttonHeight + buttonSpacing);
                        buttonsPerColumn = 0;
                    }
                }
                reader.Close();
                buttonsPanel.Height = panelHeight;
                tableLayoutPanelContainingButtonsPanel.RowStyles[1].Height = panelHeight;
                this.Height = tableLayoutPanelContainingButtonsPanel.Top + tableLayoutPanelContainingButtonsPanel.Height + 50;
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            FormDashboard open = new FormDashboard();
            Button clickedButton = (Button)sender;
            if (clickedButton.Text == "English")
            {
                int ID = StaticUser.UserID;
                List<LanguageDetailDTO> languageList = bll.CheckLanguage(ID, clickedButton.Text);
                if (StaticUser.LanguageID == 0)
                {
                    MessageBox.Show("Invalid language!");
                }
                else
                {
                    open.title = "Vocabulary App";
                    open.dashboard = "DASHBOARD";
                    open.words = "    Words";
                    open.nouns = "    Nouns";
                    open.verbs = "    Verbs";
                    open.adjectives = "    Adjectives";
                    open.phrases = "    Phrases";
                    open.reports = "Reports";
                    open.monthly = "In " + General.ConventIntToMonth(DateTime.Today.Month);
                    int checkMonth = DateTime.Today.Month - 1;
                    if (checkMonth == 0)
                    {
                        open.lastMonthly = "In " + General.ConventIntToMonth(12) + " " + (DateTime.Today.Year - 1);
                    }
                    else
                    {
                        open.lastMonthly = "In " + General.ConventIntToMonth(DateTime.Today.Month - 1);
                    }
                    open.yearly = "In " + DateTime.Today.Year;
                    open.monthlyReport = "Monthly Reports";
                    open.yearlyReports = "Yearly Reports";
                    open.TotalReport = "Total Report";
                    open.deletedData = "Deleted Data";
                    open.nounsCard = "Nouns";
                    open.verbsCard = "Verbs";
                    open.adjectivesCard = "Adjectives";
                    open.phrasesCard = "Phrases";
                    open.isEnglish = true;
                    this.Hide();
                    open.ShowDialog();
                    this.Visible = true;
                }
                
            }
            else if (clickedButton.Text == "German")
            {
                int ID = StaticUser.UserID;
                List<LanguageDetailDTO> languageList = bll.CheckLanguage(ID, clickedButton.Text);
                if (StaticUser.LanguageID == 0)
                {
                    MessageBox.Show("Invalid language!");
                }
                else
                {                   
                    open.title = "Vocabulary App";
                    open.dashboard = "DASHBOARD";
                    open.words = "Wörter";
                    open.nouns = "Nomen";
                    open.verbs = "Verben";
                    open.adjectives = "Adjektive";
                    open.phrases = "Phrasen";
                    open.reports = "Berichten";
                    open.monthly = "Im " + General.ConventIntToMonthGerman(DateTime.Today.Month);
                    int checkMonth = DateTime.Today.Month - 1;
                    if (checkMonth == 0)
                    {
                        open.lastMonthly = "Im " + General.ConventIntToMonthGerman(12) + " " + (DateTime.Today.Year - 1);
                    }
                    else
                    {
                        open.lastMonthly = "Im " + General.ConventIntToMonthGerman(DateTime.Today.Month - 1);
                    }
                    open.yearly = "Im " + DateTime.Today.Year;
                    open.monthlyReport = "Monatlich";
                    open.yearlyReports = "Jahrlich";
                    open.TotalReport = "Insgesamt";
                    open.deletedData = "gelöschte Datei";
                    open.nounsCard = "Nomen";
                    open.verbsCard = "Verben";
                    open.adjectivesCard = "Adjektive";
                    open.phrasesCard = "Phrasen";
                    open.isGerman = true;
                    this.Hide();
                    open.ShowDialog();
                    this.Visible = true;
                }                
            }
            else if (clickedButton.Text == "Russian")
            {
                int ID = StaticUser.UserID;
                List<LanguageDetailDTO> languageList = bll.CheckLanguage(ID, clickedButton.Text);
                if (StaticUser.LanguageID == 0)
                {
                    MessageBox.Show("Invalid language!");
                }
                else
                {
                    open.title = "Vocabulary App";
                    open.dashboard = "ДОСКА";
                    open.words = "Слова";
                    open.nouns = "Существительны";
                    open.verbs = "Глаголы";
                    open.adjectives = "Прилагательны";
                    open.phrases = "Фразы";
                    open.reports = "Отчеты";
                    open.monthly = General.ConventIntToMonthRussian(DateTime.Today.Month);
                    int checkMonth = DateTime.Today.Month - 1;
                    if (checkMonth == 0)
                    {
                        open.lastMonthly = General.ConventIntToMonthRussian(12) + " " + (DateTime.Today.Year - 1);
                    }
                    else
                    {
                        open.lastMonthly = General.ConventIntToMonthRussian(DateTime.Today.Month - 1);
                    }
                    open.yearly = "В " + DateTime.Today.Year;
                    open.monthlyReport = "Месячно";
                    open.yearlyReports = "Годовой";
                    open.TotalReport = "Итог";
                    open.deletedData = "Удалённые Данные";
                    open.nounsCard = "Существительны";
                    open.verbsCard = "Глаголы";
                    open.adjectivesCard = "Прилагательны";
                    open.phrasesCard = "Фразы";
                    open.isRussian = true;
                    this.Hide();
                    open.ShowDialog();
                    this.Visible = true;
                }                
            }
            else
            {
                MessageBox.Show("Незнакомый язык");
            }            
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            Button buttonToDelete = (Button)deleteButton.Tag;

            // Remove the button and its corresponding delete button from the panel
            buttonsPanel.Controls.Remove(buttonToDelete);
            buttonsPanel.Controls.Remove(deleteButton);

            // Adjust positions of remaining buttons in the panel
            for (int i = 0; i < buttonsPanel.Controls.Count; i++)
            {
                Button button = buttonsPanel.Controls[i] as Button;
                if (button != null)
                {
                    button.Location = new Point(50, 20 + i * (buttonHeight + buttonSpacing));
                }
            }
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
            FillButtonsPanel();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
