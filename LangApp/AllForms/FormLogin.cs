using LangApp.BLL;
using LangApp.DAL;
using LangApp.Forms;
using LangApp.General_Classes;
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

namespace LangApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void FormLogin_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label3.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label4.Font = new Font("Segoe UI", 11, FontStyle.Italic);
            txtUsername.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtPassword.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnClose.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnEnter.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            linkRegister.Font = new Font("Segoe UI", 11, FontStyle.Italic);
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        UserBLL bll = new UserBLL();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" || txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Enter password and username");
            }
            else
            {
                List<REGISTER> userList = bll.CheckUser(txtPassword.Text, txtUsername.Text);
                if (userList.Count == 0)
                {
                    MessageBox.Show("Invalid user!");
                }
                else
                {
                    REGISTER user = new REGISTER();
                    user = userList.First();
                    StaticUser.UserID = user.userID;
                    StaticUser.Username = user.username;
                    StaticUser.Password = user.password;

                    FormLanguageList open = new FormLanguageList();
                    txtPassword.Clear();
                    txtUsername.Clear();
                    this.Hide();
                    open.ShowDialog();
                    this.Visible = true;
                }                
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister open = new FormRegister();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
