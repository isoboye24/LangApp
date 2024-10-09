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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void pageColor_Click(object sender, EventArgs e)
        {

        }

        private void pageProfile_Click(object sender, EventArgs e)
        {

        }

        private void pageWordCases_Click(object sender, EventArgs e)
        {

        }
        private void pageWordCases_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
        private void pageProfile_Load(object sender, EventArgs e)
        {
            pageProfile.BackColor = Color.Green;
        }
        private void pageColor_Load(object sender, EventArgs e)
        {
            pageColor.BackColor = Color.Green;
        }
        WordCaseBLL caseBLL = new WordCaseBLL();
        WordCaseDTO caseDTO = new WordCaseDTO();
        WordGroupBLL groupBLL = new WordGroupBLL();
        WordGroupDTO groupDTO = new WordGroupDTO();
        PartOfSpeechBLL partsOfSpeechBLL = new PartOfSpeechBLL();
        PartOfSpeechDTO partOfSpeechDTO = new PartOfSpeechDTO();
        private bool isCaseUpdate = false;
        private bool isCaseDelete = false;
        private bool isGroupUpdate = false;
        private bool isGroupDelete = false;
        private bool isPartOfSpeechUpdate = false;
        private bool isPartOfSpeechDelete = false;

        private void FormSettings_Load(object sender, EventArgs e)
        {
            caseDTO = caseBLL.Select(StaticUser.LanguageID);
            dataGridViewCases.DataSource = caseDTO.WordCases;
            dataGridViewCases.Columns[0].Visible = false;
            dataGridViewCases.Columns[1].HeaderText = "Cases";
            dataGridViewCases.Columns[2].Visible = false;
            foreach (DataGridViewColumn column in dataGridViewCases.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }

            groupDTO = groupBLL.Select(StaticUser.LanguageID);
            cmbPartsOfSpeech.DataSource = groupDTO.PartsOfSpeech;
            General.ComboBoxProps(cmbPartsOfSpeech, "PartOfSpeechName", "PartOfSpeechID");
            dataGridViewGroup.DataSource = groupDTO.WordGroups;
            dataGridViewGroup.Columns[0].Visible = false;
            dataGridViewGroup.Columns[1].HeaderText = "Groups";
            dataGridViewGroup.Columns[2].Visible = false;
            dataGridViewGroup.Columns[3].Visible = false;
            dataGridViewGroup.Columns[4].Visible = false;
            foreach (DataGridViewColumn column in dataGridViewGroup.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }

            partOfSpeechDTO = partsOfSpeechBLL.Select();
            dataGridViewPartsOfSpeech.DataSource = partOfSpeechDTO.PartsOfSpeech;
            dataGridViewPartsOfSpeech.Columns[0].Visible = false;
            dataGridViewPartsOfSpeech.Columns[1].HeaderText = "Parts of Speech";
            dataGridViewPartsOfSpeech.Columns[2].Visible = false;
            foreach (DataGridViewColumn column in dataGridViewPartsOfSpeech.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
        }
        private void FillCaseGrid()
        {
            txtWordCase.Clear();
            caseDTO = caseBLL.Select(StaticUser.LanguageID);
            dataGridViewCases.DataSource = caseDTO.WordCases;
        }        
        private void btnEditCase_Click(object sender, EventArgs e)
        {
            isCaseUpdate = true;            
            OnLoad(EventArgs.Empty);
            if (isCaseUpdate)
            {
                label2.Text = "Edit Case";
            }
        }
        WordCaseDetailDTO detail = new WordCaseDetailDTO();
        private void dataGridViewCases_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (isCaseUpdate || isCaseDelete)
            {
                detail = new WordCaseDetailDTO();
                detail.WordCaseID = Convert.ToInt32(dataGridViewCases.Rows[e.RowIndex].Cells[0].Value);
                detail.WordCaseName = dataGridViewCases.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (isCaseUpdate)
                {
                    txtWordCase.Text = dataGridViewCases.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                detail.LanguageID = Convert.ToInt32(dataGridViewCases.Rows[e.RowIndex].Cells[2].Value);
            }            
        }

        private void btnCaseSave_Click(object sender, EventArgs e)
        {
            int checkThisWord = caseBLL.checkWord(txtWordCase.Text.Trim(), StaticUser.LanguageID);
            if (txtWordCase.Text.Trim() == "")
            {
                MessageBox.Show("Word case is empty");
            }
            else if (checkThisWord > 0)
            {
                MessageBox.Show("This Word case already exists");
            }
            else
            {
                if (!isCaseUpdate && !isCaseDelete)
                {
                    WordCaseDetailDTO wordCase = new WordCaseDetailDTO();
                    wordCase.LanguageID = StaticUser.LanguageID;
                    wordCase.WordCaseName = txtWordCase.Text.Trim();
                    if (caseBLL.Insert(wordCase))
                    {
                        MessageBox.Show("Word case added successfully!");
                        FillCaseGrid();
                    }
                }
                else if (isCaseUpdate)
                {
                    if (detail.WordCaseName == txtWordCase.Text.Trim())
                    {
                        MessageBox.Show("No change");
                    }
                    else
                    {
                        detail.WordCaseName = txtWordCase.Text.Trim();
                        detail.LanguageID = StaticUser.LanguageID;
                        if (caseBLL.Update(detail))
                        {
                            MessageBox.Show("Word case was updated!");
                            isCaseUpdate = false;
                            FillCaseGrid();
                            label2.Text = "Add Case";
                        }
                    }
                }
            }
        }
        private void btnDeleteCase_Click(object sender, EventArgs e)
        {
            isCaseDelete = true;
            DialogResult result = MessageBox.Show("Delete now?","Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (caseBLL.Delete(detail))
                {
                    MessageBox.Show("Word case was deleted!");
                    isCaseDelete = false;
                    FillCaseGrid();                    
                }
            }
        }

        private void FillGroupGrid()
        {
            txtWordGroup.Clear();
            cmbPartsOfSpeech.SelectedIndex = -1;
            groupDTO = groupBLL.Select(StaticUser.LanguageID);
            dataGridViewGroup.DataSource = groupDTO.WordGroups;
        }
        private void btnSaveWordGroup_Click(object sender, EventArgs e)
        {
            int checkThisGroup = groupBLL.checkGroup(txtWordGroup.Text.Trim(), StaticUser.LanguageID);
            if (txtWordGroup.Text.Trim() == "")
            {
                MessageBox.Show("Word group is empty");
            }
            else if (cmbPartsOfSpeech.SelectedIndex == -1)
            {
                MessageBox.Show("Part of speech is empty");
            }
            else if (checkThisGroup > 0)
            {
                MessageBox.Show("This Word group already exists");
            }
            else
            {
                if (!isGroupUpdate && !isGroupDelete)
                {
                    WordGroupDetailDTO wordGroup = new WordGroupDetailDTO();
                    wordGroup.LanguageID = StaticUser.LanguageID;
                    wordGroup.PartOfSpeechID = Convert.ToInt32(cmbPartsOfSpeech.SelectedValue);
                    wordGroup.WordGroupName = txtWordGroup.Text.Trim();
                    if (groupBLL.Insert(wordGroup))
                    {
                        MessageBox.Show("Word group added successfully!");
                        FillGroupGrid();
                    }
                }
                else if (isGroupUpdate)
                {
                    if (groupDetail.WordGroupName == txtWordGroup.Text.Trim() && groupDetail.PartOfSpeechID == Convert.ToInt32(cmbPartsOfSpeech.SelectedValue))
                    {
                        MessageBox.Show("No change");
                    }
                    else
                    {
                        groupDetail.WordGroupName = txtWordGroup.Text.Trim();
                        groupDetail.LanguageID = StaticUser.LanguageID;
                        groupDetail.PartOfSpeechID = Convert.ToInt32(cmbPartsOfSpeech.SelectedValue);
                        if (groupBLL.Update(groupDetail))
                        {
                            MessageBox.Show("Word group was updated!");
                            isGroupUpdate = false;
                            FillGroupGrid();
                            label1.Text = "Add Group";
                            label3.Text = "Select Part of speech";
                        }
                    }
                }
            }
        }
        private void btnEditWordGroup_Click(object sender, EventArgs e)
        {
            isGroupUpdate = true;
            OnLoad(EventArgs.Empty);
            if (isGroupUpdate)
            {
                label2.Text = "Edit Case";
                label3.Text = "Re-select Part of speech";
            }
        }
        WordGroupDetailDTO groupDetail = new WordGroupDetailDTO();
        private void dataGridViewGroup_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (isGroupUpdate || isGroupDelete)
            {
                groupDetail = new WordGroupDetailDTO();
                groupDetail.WordGroupID = Convert.ToInt32(dataGridViewGroup.Rows[e.RowIndex].Cells[0].Value);
                groupDetail.WordGroupName = dataGridViewGroup.Rows[e.RowIndex].Cells[1].Value.ToString();
                groupDetail.PartOfSpeechID = Convert.ToInt32(dataGridViewGroup.Rows[e.RowIndex].Cells[2].Value);
                groupDetail.PartOfSpeechName = dataGridViewGroup.Rows[e.RowIndex].Cells[3].Value.ToString();
                groupDetail.LanguageID = Convert.ToInt32(dataGridViewGroup.Rows[e.RowIndex].Cells[4].Value);
                if (isGroupUpdate)
                {
                    txtWordGroup.Text = groupDetail.WordGroupName;
                    cmbPartsOfSpeech.SelectedValue = groupDetail.PartOfSpeechID;
                }
            }
        }
        private void btnDeleteWordGroup_Click(object sender, EventArgs e)
        {
            isGroupDelete = true;
            DialogResult result = MessageBox.Show("Delete now?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (groupBLL.Delete(groupDetail))
                {
                    MessageBox.Show("Word group was deleted!");
                    isGroupDelete = false;
                    FillGroupGrid();
                }
            }
        }

        private void FillPartOfSpeechGrid()
        {
            txtWordPartsOfSpeech.Clear();
            partOfSpeechDTO = partsOfSpeechBLL.Select();
            dataGridViewPartsOfSpeech.DataSource = partOfSpeechDTO.PartsOfSpeech;
        }
        private void btnSavePartsOfSpeech_Click(object sender, EventArgs e)
        {
            int checkThisPartOfSpeech = groupBLL.checkGroup(txtWordGroup.Text.Trim(), StaticUser.LanguageID);
            if (txtWordPartsOfSpeech.Text.Trim() == "")
            {
                MessageBox.Show("Enter part of speech");
            }            
            else if (checkThisPartOfSpeech > 0)
            {
                MessageBox.Show("This part of speech already exists");
            }
            else
            {
                if (!isPartOfSpeechUpdate && !isPartOfSpeechDelete)
                {
                    PartOfSpeechDetailDTO partOfspeech = new PartOfSpeechDetailDTO();
                    partOfspeech.LanguageID = StaticUser.LanguageID;
                    partOfspeech.PartOfSpeechName = txtWordPartsOfSpeech.Text.Trim();
                    if (partsOfSpeechBLL.Insert(partOfspeech))
                    {
                        MessageBox.Show("Parts of speech was added successfully!");
                        FillPartOfSpeechGrid();
                    }
                }
                else if (isPartOfSpeechUpdate)
                {
                    if (partOfSpeechDetail.PartOfSpeechName == txtWordPartsOfSpeech.Text.Trim())
                    {
                        MessageBox.Show("No change");
                    }
                    else
                    {
                        partOfSpeechDetail.PartOfSpeechName = txtWordPartsOfSpeech.Text.Trim();
                        partOfSpeechDetail.LanguageID = StaticUser.LanguageID;
                        if (partsOfSpeechBLL.Update(partOfSpeechDetail))
                        {
                            MessageBox.Show("Part of speech was updated!");
                            isPartOfSpeechUpdate = false;
                            FillPartOfSpeechGrid();
                            label4.Text = "Add Part of speech";
                        }
                    }
                }
            }
        }
        PartOfSpeechDetailDTO partOfSpeechDetail = new PartOfSpeechDetailDTO();
        private void dataGridViewPartsOfSpeech_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if (isPartOfSpeechUpdate || isPartOfSpeechDelete)
            {
                partOfSpeechDetail = new PartOfSpeechDetailDTO();
                partOfSpeechDetail.PartOfSpeechID = Convert.ToInt32(dataGridViewPartsOfSpeech.Rows[e.RowIndex].Cells[0].Value);
                partOfSpeechDetail.PartOfSpeechName = dataGridViewPartsOfSpeech.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (isPartOfSpeechUpdate)
                {
                    txtWordPartsOfSpeech.Text = dataGridViewPartsOfSpeech.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                detail.LanguageID = Convert.ToInt32(dataGridViewPartsOfSpeech.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        private void btnEditPartsOfSpeech_Click(object sender, EventArgs e)
        {
            isPartOfSpeechUpdate = true;
            OnLoad(EventArgs.Empty);
            if (isGroupUpdate)
            {
                label4.Text = "Edit Part of Speech";
            }
        }

        private void btnDeletePartsOfSpeech_Click(object sender, EventArgs e)
        {
            isPartOfSpeechDelete = true;
            DialogResult result = MessageBox.Show("Delete now?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (partsOfSpeechBLL.Delete(partOfSpeechDetail))
                {
                    MessageBox.Show("Part of speech was deleted!");
                    isPartOfSpeechDelete = false;
                    FillPartOfSpeechGrid();
                }
            }
        }
    }
}
