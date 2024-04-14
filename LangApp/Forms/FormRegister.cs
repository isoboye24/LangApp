﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangApp
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void FormRegister_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label3.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label4.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label5.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label6.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label8.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            txtEmail.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtImagePath.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtName.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtPassword.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtSurname.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtUsername.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            btnBrowse.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnClose.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnSave.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormLogin open = new FormLogin();
            this.Hide();
            open.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormLogin open = new FormLogin();
            this.Hide();
            open.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormRegister_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
