using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank_App
{
    public partial class FormLogin : Form
    {
        OleDbConnection connection1 = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\Bank_app.accdb");
        public FormLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_id == true)
            {
                string passwordd = "";
                string status = "";
                try
                {
                    connection1.Open();
                    OleDbCommand usercheck = new OleDbCommand("select User_ID_Number from user_info where User_ID_Number =@ID", connection1);
                    usercheck.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_usernametb.Text.ToString());
                    OleDbDataReader readid = usercheck.ExecuteReader();////////ID
                    if (readid.Read() == true)
                    {
                        OleDbCommand passwordcheck = new OleDbCommand("select User_Password from user_password where User_ID_Number =@ID", connection1);
                        passwordcheck.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_usernametb.Text.ToString());
                        OleDbDataReader readpass = passwordcheck.ExecuteReader();
                        while (readpass.Read())
                        {
                            passwordd = readpass["User_Password"].ToString();
                        }
                        if (_pwtb.Text == passwordd.ToString())
                        {
                            OleDbCommand statuscheck = new OleDbCommand("select status from user_status where User_ID_Number =@ID", connection1);
                            statuscheck.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_usernametb.Text.ToString());
                            OleDbDataReader readstatus = statuscheck.ExecuteReader();
                            while (readstatus.Read())
                            {
                                status = readstatus["status"].ToString();
                            }
                            if (status == "ADMIN")
                            {
                                FormAdmin frmadmin = new FormAdmin();
                                frmadmin.Show();
                                this.Hide();
                            }
                            else if (status == "ACTIVE")
                            {
                                FormUI formui = new FormUI();
                                formui._UserID = Convert.ToInt32(_usernametb.Text);
                                formui.Show();
                                this.Hide();
                            }
                            else if (status == "BLOCKED")
                            {
                                MessageBox.Show("ACCAUNT HAS BLOCKED", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (status == "WAITING")
                            {
                                MessageBox.Show("THIS ACCAUNT IS NOT REACHABLE YET", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            connection1.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);///////////////////////
                            connection1.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("USER DOES NOT EXSIST", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection1.Close();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR");
                    connection1.Close();
                    throw;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormSI formsi = new FormSI();
            formsi.Show();
            this.Hide();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        bool _id = false;
        private void _usernametb_TextChanged(object sender, EventArgs e)
        {
            if (_usernametb.TextLength < 9)
            {
                errorProvider1.SetError(_usernametb, "ID Number shoul be 9 chracter long");
                _id = false;
            }
            else
            {
                errorProvider1.Clear();
                _id = true;
            }
        }
    }
}
