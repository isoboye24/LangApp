using LangApp.BLL;
using LangApp.DAL.DAO;
using LangApp.DAL.DTO;
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
        int buttonHeight = 30;
        int buttonSpacing = 10;
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
                    button.Height = 30;
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
            // Handle button click event
            Button clickedButton = (Button)sender;
            MessageBox.Show($"You clicked {clickedButton.Text}!");
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
