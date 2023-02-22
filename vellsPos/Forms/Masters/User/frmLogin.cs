using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vellsPos.Forms.Layouts;
using vellsPos.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vellsPos.Forms.Masters.user
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txt_username.Focus();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //textBox2.UseSystemPasswordChar = false;
                //String calculationMethod = "SELECT svalue FROM setting WHERE skey= 'SalaryCalculationMethod' ";
                //Int32 CalMethod = Int32.Parse(DBTransactionService.getScalerData(calculationMethod));

                //if (CalMethod == 1)//JeganPharmacy
                //{
                //    this.Text = "Payroll Management System  - Jegan Pharmacy";
                //}
                //else if (CalMethod == 2) //Valampuri / Greengrass
                //{
                //    this.Text = "Payroll Management System ";
                //}
                //else
                //{
                //    this.Text = "Payroll Management System";
                //}
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void getAuth(String userName, String password)
        {
            String uname = "admin";
            String upassword = "1234";

            int authStatus;//User.userAuth(userName, password);

            if (txt_username.Text == uname && txt_password.Text == upassword)
            {
                authStatus = 1;
            }
            else
            {
                authStatus = 0;
            }


            if (authStatus == 1)
            {
                DateTime now = DateTime.Now;//2020-11-18 09:51:09

                SMTPEmailRequest mail = new SMTPEmailRequest();

                String subject = "Login";
                String Body = Session.uname + ' ' + "has login at";
                SMTPEmailRequest.SendEmail(subject, Body);

                frmHome home = new frmHome();
                this.Hide();
                Session.uname = userName;
                home.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_' || c == '@' || c == '#' || c == '$')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String userName = txt_username.Text.Trim();
            String password = txt_password.Text.Trim();
            userName = RemoveSpecialCharacters(userName);
            password = RemoveSpecialCharacters(password);

            if (userName.Equals(""))
            {
                txt_username.Focus();
                MessageBox.Show("Please enter your username", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Equals(""))
            {
                txt_password.Focus();
                MessageBox.Show("Please enter your password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                getAuth(userName, password);
            }
        }
       
    }
}
