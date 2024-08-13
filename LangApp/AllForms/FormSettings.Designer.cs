namespace LangApp.AllForms
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.pageProfile = new System.Windows.Forms.TabPage();
            this.pageWordCases = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCases = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtWordCase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCaseSave = new FontAwesome.Sharp.IconButton();
            this.btnDeleteCase = new FontAwesome.Sharp.IconButton();
            this.btnEditCase = new FontAwesome.Sharp.IconButton();
            this.pageWordGroup = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewGroup = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtWordGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditWordGroup = new FontAwesome.Sharp.IconButton();
            this.btnSaveWordGroup = new FontAwesome.Sharp.IconButton();
            this.btnDeleteWordGroup = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPartsOfSpeech = new System.Windows.Forms.ComboBox();
            this.pageColor = new System.Windows.Forms.TabPage();
            this.tabControlSettings.SuspendLayout();
            this.pageWordCases.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCases)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pageWordGroup.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.pageProfile);
            this.tabControlSettings.Controls.Add(this.pageWordCases);
            this.tabControlSettings.Controls.Add(this.pageWordGroup);
            this.tabControlSettings.Controls.Add(this.pageColor);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.Location = new System.Drawing.Point(0, 0);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(731, 472);
            this.tabControlSettings.TabIndex = 0;
            // 
            // pageProfile
            // 
            this.pageProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageProfile.Location = new System.Drawing.Point(4, 22);
            this.pageProfile.Name = "pageProfile";
            this.pageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.pageProfile.Size = new System.Drawing.Size(723, 446);
            this.pageProfile.TabIndex = 0;
            this.pageProfile.Text = "Profile";
            this.pageProfile.UseVisualStyleBackColor = true;
            this.pageProfile.Click += new System.EventHandler(this.pageProfile_Click);
            // 
            // pageWordCases
            // 
            this.pageWordCases.Controls.Add(this.tableLayoutPanel1);
            this.pageWordCases.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageWordCases.Location = new System.Drawing.Point(4, 22);
            this.pageWordCases.Name = "pageWordCases";
            this.pageWordCases.Padding = new System.Windows.Forms.Padding(3);
            this.pageWordCases.Size = new System.Drawing.Size(723, 446);
            this.pageWordCases.TabIndex = 1;
            this.pageWordCases.Text = "Word Cases";
            this.pageWordCases.UseVisualStyleBackColor = true;
            this.pageWordCases.Click += new System.EventHandler(this.pageWordCases_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewCases, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 440);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dataGridViewCases
            // 
            this.dataGridViewCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCases.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCases.Name = "dataGridViewCases";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCases.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCases.RowTemplate.Height = 30;
            this.dataGridViewCases.Size = new System.Drawing.Size(424, 434);
            this.dataGridViewCases.TabIndex = 8;
            this.dataGridViewCases.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCases_RowEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtWordCase, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(433, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 434);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtWordCase
            // 
            this.txtWordCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWordCase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordCase.Location = new System.Drawing.Point(3, 54);
            this.txtWordCase.Name = "txtWordCase";
            this.txtWordCase.Size = new System.Drawing.Size(275, 27);
            this.txtWordCase.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Case";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel3.Controls.Add(this.btnCaseSave, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteCase, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEditCase, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 109);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(275, 37);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // btnCaseSave
            // 
            this.btnCaseSave.BackColor = System.Drawing.Color.Transparent;
            this.btnCaseSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCaseSave.FlatAppearance.BorderSize = 0;
            this.btnCaseSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaseSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaseSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnCaseSave.IconColor = System.Drawing.Color.Black;
            this.btnCaseSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCaseSave.IconSize = 32;
            this.btnCaseSave.Location = new System.Drawing.Point(96, 3);
            this.btnCaseSave.Name = "btnCaseSave";
            this.btnCaseSave.Size = new System.Drawing.Size(82, 31);
            this.btnCaseSave.TabIndex = 14;
            this.btnCaseSave.UseVisualStyleBackColor = false;
            this.btnCaseSave.Click += new System.EventHandler(this.btnCaseSave_Click);
            // 
            // btnDeleteCase
            // 
            this.btnDeleteCase.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteCase.FlatAppearance.BorderSize = 0;
            this.btnDeleteCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCase.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteCase.IconColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteCase.IconSize = 32;
            this.btnDeleteCase.Location = new System.Drawing.Point(189, 3);
            this.btnDeleteCase.Name = "btnDeleteCase";
            this.btnDeleteCase.Size = new System.Drawing.Size(83, 31);
            this.btnDeleteCase.TabIndex = 14;
            this.btnDeleteCase.UseVisualStyleBackColor = false;
            this.btnDeleteCase.Click += new System.EventHandler(this.btnDeleteCase_Click);
            // 
            // btnEditCase
            // 
            this.btnEditCase.BackColor = System.Drawing.Color.Transparent;
            this.btnEditCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditCase.FlatAppearance.BorderSize = 0;
            this.btnEditCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCase.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditCase.IconColor = System.Drawing.Color.Black;
            this.btnEditCase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditCase.IconSize = 32;
            this.btnEditCase.Location = new System.Drawing.Point(3, 3);
            this.btnEditCase.Name = "btnEditCase";
            this.btnEditCase.Size = new System.Drawing.Size(82, 31);
            this.btnEditCase.TabIndex = 14;
            this.btnEditCase.UseVisualStyleBackColor = false;
            this.btnEditCase.Click += new System.EventHandler(this.btnEditCase_Click);
            // 
            // pageWordGroup
            // 
            this.pageWordGroup.Controls.Add(this.tableLayoutPanel4);
            this.pageWordGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageWordGroup.Location = new System.Drawing.Point(4, 22);
            this.pageWordGroup.Name = "pageWordGroup";
            this.pageWordGroup.Size = new System.Drawing.Size(723, 446);
            this.pageWordGroup.TabIndex = 2;
            this.pageWordGroup.Text = "Word Group";
            this.pageWordGroup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridViewGroup, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(723, 446);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // dataGridViewGroup
            // 
            this.dataGridViewGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGroup.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewGroup.Name = "dataGridViewGroup";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewGroup.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGroup.RowTemplate.Height = 30;
            this.dataGridViewGroup.Size = new System.Drawing.Size(427, 440);
            this.dataGridViewGroup.TabIndex = 8;
            this.dataGridViewGroup.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroup_RowEnter);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txtWordGroup, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.cmbPartsOfSpeech, 0, 4);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(436, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(284, 440);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // txtWordGroup
            // 
            this.txtWordGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWordGroup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordGroup.Location = new System.Drawing.Point(3, 55);
            this.txtWordGroup.Name = "txtWordGroup";
            this.txtWordGroup.Size = new System.Drawing.Size(278, 27);
            this.txtWordGroup.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Group";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel6.Controls.Add(this.btnEditWordGroup, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnSaveWordGroup, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnDeleteWordGroup, 4, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 221);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(278, 38);
            this.tableLayoutPanel6.TabIndex = 15;
            // 
            // btnEditWordGroup
            // 
            this.btnEditWordGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnEditWordGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditWordGroup.FlatAppearance.BorderSize = 0;
            this.btnEditWordGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditWordGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditWordGroup.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditWordGroup.IconColor = System.Drawing.Color.Black;
            this.btnEditWordGroup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditWordGroup.IconSize = 32;
            this.btnEditWordGroup.Location = new System.Drawing.Point(3, 3);
            this.btnEditWordGroup.Name = "btnEditWordGroup";
            this.btnEditWordGroup.Size = new System.Drawing.Size(82, 32);
            this.btnEditWordGroup.TabIndex = 14;
            this.btnEditWordGroup.UseVisualStyleBackColor = false;
            this.btnEditWordGroup.Click += new System.EventHandler(this.btnEditWordGroup_Click);
            // 
            // btnSaveWordGroup
            // 
            this.btnSaveWordGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveWordGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveWordGroup.FlatAppearance.BorderSize = 0;
            this.btnSaveWordGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveWordGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWordGroup.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSaveWordGroup.IconColor = System.Drawing.Color.Black;
            this.btnSaveWordGroup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveWordGroup.IconSize = 32;
            this.btnSaveWordGroup.Location = new System.Drawing.Point(96, 3);
            this.btnSaveWordGroup.Name = "btnSaveWordGroup";
            this.btnSaveWordGroup.Size = new System.Drawing.Size(82, 32);
            this.btnSaveWordGroup.TabIndex = 14;
            this.btnSaveWordGroup.UseVisualStyleBackColor = false;
            this.btnSaveWordGroup.Click += new System.EventHandler(this.btnSaveWordGroup_Click);
            // 
            // btnDeleteWordGroup
            // 
            this.btnDeleteWordGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteWordGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteWordGroup.FlatAppearance.BorderSize = 0;
            this.btnDeleteWordGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWordGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWordGroup.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteWordGroup.IconColor = System.Drawing.Color.Maroon;
            this.btnDeleteWordGroup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteWordGroup.IconSize = 32;
            this.btnDeleteWordGroup.Location = new System.Drawing.Point(189, 3);
            this.btnDeleteWordGroup.Name = "btnDeleteWordGroup";
            this.btnDeleteWordGroup.Size = new System.Drawing.Size(86, 32);
            this.btnDeleteWordGroup.TabIndex = 14;
            this.btnDeleteWordGroup.UseVisualStyleBackColor = false;
            this.btnDeleteWordGroup.Click += new System.EventHandler(this.btnDeleteWordGroup_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Part of speech";
            // 
            // cmbPartsOfSpeech
            // 
            this.cmbPartsOfSpeech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPartsOfSpeech.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPartsOfSpeech.FormattingEnabled = true;
            this.cmbPartsOfSpeech.Location = new System.Drawing.Point(3, 120);
            this.cmbPartsOfSpeech.Name = "cmbPartsOfSpeech";
            this.cmbPartsOfSpeech.Size = new System.Drawing.Size(278, 28);
            this.cmbPartsOfSpeech.TabIndex = 16;
            // 
            // pageColor
            // 
            this.pageColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageColor.Location = new System.Drawing.Point(4, 22);
            this.pageColor.Name = "pageColor";
            this.pageColor.Size = new System.Drawing.Size(723, 446);
            this.pageColor.TabIndex = 3;
            this.pageColor.Text = "Colors";
            this.pageColor.UseVisualStyleBackColor = true;
            this.pageColor.Click += new System.EventHandler(this.pageColor_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 472);
            this.Controls.Add(this.tabControlSettings);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.tabControlSettings.ResumeLayout(false);
            this.pageWordCases.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCases)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.pageWordGroup.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage pageProfile;
        private System.Windows.Forms.TabPage pageWordCases;
        private System.Windows.Forms.TabPage pageWordGroup;
        private System.Windows.Forms.TabPage pageColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtWordCase;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnCaseSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton btnEditCase;
        private FontAwesome.Sharp.IconButton btnDeleteCase;
        private System.Windows.Forms.DataGridView dataGridViewCases;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridViewGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtWordGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private FontAwesome.Sharp.IconButton btnEditWordGroup;
        private FontAwesome.Sharp.IconButton btnSaveWordGroup;
        private FontAwesome.Sharp.IconButton btnDeleteWordGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPartsOfSpeech;
    }
}