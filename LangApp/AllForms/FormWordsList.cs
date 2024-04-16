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

        private void FormWords_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormWord open = new FormWord();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }
        private void ClearFilters()
        {

        }
    }
}
