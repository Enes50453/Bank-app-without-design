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
using System.IO;

namespace Bank_App
{
    public partial class FormSI : Form
    {
        public FormSI()
        {
            InitializeComponent();
        }
        OleDbConnection connection3 = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\Bank_app.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            if (_name == true && _pasw == true && _adress == true && _id == true && _idpic == true)
            {
                _addnewuser();
            }
            else
            {
                MessageBox.Show("Please check the informations you had enter", "SIGNIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void _addnewuser()
        {
            try
            {
                connection3.Open();
                OleDbCommand usercheck = new OleDbCommand("select User_ID_Number from user_info where User_ID_Number =@ID", connection3);
                usercheck.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_tbuserid.Text.ToString());
                OleDbDataReader readid = usercheck.ExecuteReader();
                if (readid.Read() == true)
                {
                    MessageBox.Show("THIS ID NUMBER HAS ALREADY REGISTERED TO OUR DATABASE", "SIGN IN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection3.Close();
                }
                else if(readid.Read() == false)
                {
                    try
                    {
                        OleDbCommand _Addline_ui = new OleDbCommand("insert into user_info(User_ID_Number,User_Name,Adress) values('" + _tbuserid.Text + "','" + _tbusername.Text + "','" +_tbuseradress.Text + "')", connection3);
                        _Addline_ui.ExecuteNonQuery();
                        OleDbCommand _Addline_up = new OleDbCommand("insert into user_password(User_ID_Number,User_Password) values('" + _tbuserid.Text + "','" + _tbuserpassw.Text + "')", connection3);
                        _Addline_up.ExecuteNonQuery();
                        OleDbCommand _Addline_us = new OleDbCommand("insert into user_status(User_ID_Number,status) values('" + _tbuserid.Text + "','WAITING')", connection3);
                        _Addline_us.ExecuteNonQuery();
                        ///////////////////////////WALLET
                        string usd = "USD 7001 " + _tbuserid.Text;
                        string eur = "EUR 7002 " + _tbuserid.Text;
                        string gbp = "GBP 7003 " + _tbuserid.Text;
                        string chf = "CHF 7004 " + _tbuserid.Text;
                        string trlira = "TRY 7005 " + _tbuserid.Text;
                        string pln = "PLN 7006 " + _tbuserid.Text;
                        string aud = "AUD 7007 " + _tbuserid.Text;
                        string cad = "CAD 7008 " + _tbuserid.Text;
                        OleDbCommand _AddWallet_USD = new OleDbCommand("insert into user_wallet(IBAN,User_ID_Number,User_Name,[Currency],Amount) values('" + usd + "','" + _tbuserid.Text + "','" + _tbusername.Text + "','US Dollar','0')", connection3);
                        _AddWallet_USD.ExecuteNonQuery();
                        OleDbCommand _AddWallet_EUR = new OleDbCommand("insert into user_wallet(IBAN,User_ID_Number,User_Name,[Currency],Amount) values('" + eur + "','" + _tbuserid.Text + "','" + _tbusername.Text + "','Euro','0')", connection3);
                        _AddWallet_EUR.ExecuteNonQuery();
                        OleDbCommand _AddWallet_GBP = new OleDbCommand("insert into user_wallet(IBAN,User_ID_Number,User_Name,[Currency],Amount) values('" +gbp + "','" + _tbuserid.Text + "','" + _tbusername.Text + "','British Pound','0')", connection3);
                        _AddWallet_GBP.ExecuteNonQuery();
                        OleDbCommand _AddWallet_CHF = new OleDbCommand("insert into user_wallet(IBAN,User_ID_Number,User_Name,[Currency],Amount) values('" + chf + "','" + _tbuserid.Text + "','" + _tbusername.Text + "','Swiss Franc','0')", connection3);
                        _AddWallet_CHF.ExecuteNonQuery();
                        OleDbCommand _AddWallet_TRY = new OleDbCommand("insert into user_wallet(IBAN,User_ID_Number,User_Name,[Currency],Amount) values('" + trlira + "','" + _tbuserid.Text + "','" + _tbusername.Text + "','Turkish Lira','0')", connection3);
                        _AddWallet_TRY.ExecuteNonQuery();
                        OleDbCommand _AddWallet_PLN = new OleDbCommand("insert into user_wallet(IBAN,User_ID_Number,User_Name,[Currency],Amount) values('" + pln + "','" + _tbuserid.Text + "','" + _tbusername.Text + "','Polish Zloty','0')", connection3);
                        _AddWallet_PLN.ExecuteNonQuery();
                        OleDbCommand _AddWallet_AUD = new OleDbCommand("insert into user_wallet(IBAN,User_ID_Number,User_Name,[Currency],Amount) values('" + aud + "','" + _tbuserid.Text + "','" + _tbusername.Text + "','Avustralian Dollar','0')", connection3);
                        _AddWallet_AUD.ExecuteNonQuery();
                        OleDbCommand _AddWallet_CAD = new OleDbCommand("insert into user_wallet(IBAN,User_ID_Number,User_Name,[Currency],Amount) values('" + cad + "','" + _tbuserid.Text + "','" + _tbusername.Text + "','Canadian Dollar','0')", connection3);
                        _AddWallet_CAD.ExecuteNonQuery();
                        OleDbCommand _AddAccounts = new OleDbCommand("insert into user_accounts(User_ID_Number,USD,EUR,GBP,CHF,TRY,PLN,AUD,CAD) values('" + _tbuserid.Text + "','" + usd + "','" + eur + "','" + gbp + "','" + chf + "','" + trlira + "','" + pln + "','" + aud + "','" + cad + "')", connection3);
                        _AddAccounts.ExecuteNonQuery();
                        _saveID();
                        //////////////////////////////WALLET
                        connection3.Close();
                        DialogResult dresult =  MessageBox.Show("USER HAS SUCCESSFULLY ADDET TO WAITING LIST", "SIGN IN",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        if(dresult == DialogResult.OK)
                        {
                            FormLogin formlogin = new FormLogin();
                            formlogin.Show();
                            this.Close();
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "ERROR");
                        connection3.Close();
                        throw;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection3.Close();
                throw;
            }

        }
        public void _saveID()
        {
            pictureBox1.Image.Save(Application.StartupPath + "\\ID_pics\\" + _tbuserid.Text +".jpeg");
            
        }
        private void button_addID_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Upload ID Photo";
            openFileDialog1.Filter = "JPEG Files(*.jpeg)|*.jpeg";
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.OpenFile());
                _idpic = true;
            }
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Do you want to quit?", "CANCEL", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dresult == DialogResult.OK)
            {
                FormLogin formlogin = new FormLogin();
                formlogin.Show();
                this.Close();
            }
            else
            {
            }
        }
        bool _name = false;
        bool _pasw = false;
        bool _adress = false;
        bool _id = false;
        bool _idpic = false;
        private void _tbuserid_TextChanged(object sender, EventArgs e)
        {
            if (_tbuserid.TextLength < 9)
            {
                errorProvider1.SetError(_tbuserid, "ID Number shoul be 9 chracter long");
                _id = false;
            }
            else
            {
                errorProvider1.Clear();
                _id = true;
            }
        }
        private void _tbuserid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; 
            }
        }
        private void _tbusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || Char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void _tbuseradress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || Char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void _tbuserpassw_TextChanged(object sender, EventArgs e)
        {
            if (_tbuserpassw.TextLength < 8)
            {
                errorProvider1.SetError(_tbuserpassw, "ID Number shoul be 8 chracter long");
                _pasw = false;
            }
            else
            {
                errorProvider1.Clear();
                _pasw = true;
            }
        }
        private void _tbusername_TextChanged(object sender, EventArgs e)
        {
            if (_tbusername.TextLength < 1)
            {
                errorProvider1.SetError(_tbusername, "Please enter full name");
                _name = false;
            }
            else
            {
                errorProvider1.Clear();
                _name = true;
            }
        }
        private void _tbuseradress_TextChanged(object sender, EventArgs e)
        {
            if (_tbuseradress.TextLength < 1)
            {
                errorProvider1.SetError(_tbuseradress, "Please enter full name");
                _adress = false;
            }
            else
            {
                errorProvider1.Clear();
                _adress = true;
            }
        }
    }
}
