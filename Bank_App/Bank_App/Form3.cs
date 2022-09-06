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
    public partial class FormUI : Form
    {
        public FormUI()
        {
            InitializeComponent();
        }
        public int _UserID = 0;
        string _username = "";
        string _iban_usd = "";
        string _iban_eur = "";
        string _iban_gbp = "";
        string _iban_chf = "";
        string _iban_trlira = "";
        string _iban_pln = "";
        string _iban_aud = "";
        string _iban_cad = "";
        double _withdrawAmount = 0;
        double _depositAmount = 0;
        double _transferAmount = 0;//
        double _amount = 0;
        string _iban_transfer = "";//
        string _username_transfer = "";//
        string _iban_selected = "";
        string _currency_transfer = "";//
        string _currency = "";
        bool _transfer_user_exist;//
        double _exchange_rate = 0;
        string _exchange_currency1 = "RUS Dollar";
        string _exchange_currency2 = "RUS Dollar";
        string _exchange_iban1 = "";
        string _exchange_iban2 = "";
        double _exchange_amount1 = 0;
        double _exchange_amount2 = 0;
        public string _path = Application.StartupPath + "/activities.txt";
        OleDbConnection connection4 = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\Bank_app.accdb");
        DateTime _now = DateTime.Now;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void label20_Click(object sender, EventArgs e)
        {

        }
        private void FormUI_Load(object sender, EventArgs e)
        {
            _labelUserID.Text = _UserID.ToString();
            getuserdata();
            fillcomboBox();
            _label_Username.Text = _username.ToString();
            button4.Enabled = false;//transfer button
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            label10.Text = "";
        }
        public void getuserdata()
        {
            try
            {
                connection4.Open();
                OleDbCommand _getname = new OleDbCommand("select User_Name from user_info where User_ID_Number =@ID", connection4);
                _getname.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_labelUserID.Text.ToString());
                OleDbDataReader readname = _getname.ExecuteReader();
                while (readname.Read())
                {
                    _username = readname["User_Name"].ToString();
                }
                readname.Close();
                ////////////GET IBAN
                OleDbCommand get_iban_USD = new OleDbCommand("select USD from user_accounts where User_ID_Number =@ID", connection4);
                get_iban_USD.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_labelUserID.Text.ToString());
                OleDbDataReader read_iban_USD = get_iban_USD.ExecuteReader();
                while (read_iban_USD.Read())
                {
                    _iban_usd = read_iban_USD["USD"].ToString();
                }
                read_iban_USD.Close();
                OleDbCommand get_iban_EUR = new OleDbCommand("select EUR from user_accounts where User_ID_Number =@ID", connection4);
                get_iban_EUR.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_labelUserID.Text.ToString());
                OleDbDataReader read_iban_EUR = get_iban_EUR.ExecuteReader();
                while (read_iban_EUR.Read())
                {
                    _iban_eur = read_iban_EUR["EUR"].ToString();
                }
                read_iban_EUR.Close();
                OleDbCommand get_iban_GBP = new OleDbCommand("select GBP from user_accounts where User_ID_Number =@ID", connection4);
                get_iban_GBP.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_labelUserID.Text.ToString());
                OleDbDataReader read_iban_GBP = get_iban_GBP.ExecuteReader();
                while (read_iban_GBP.Read())
                {
                    _iban_gbp = read_iban_GBP["GBP"].ToString();
                }
                read_iban_GBP.Close();
                OleDbCommand get_iban_CHF = new OleDbCommand("select CHF from user_accounts where User_ID_Number =@ID", connection4);
                get_iban_CHF.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_labelUserID.Text.ToString());
                OleDbDataReader read_iban_CHF = get_iban_CHF.ExecuteReader();
                while (read_iban_CHF.Read())
                {
                    _iban_chf = read_iban_CHF["CHF"].ToString();
                }
                read_iban_CHF.Close();
                OleDbCommand get_iban_TRY = new OleDbCommand("select TRY from user_accounts where User_ID_Number =@ID", connection4);
                get_iban_TRY.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_labelUserID.Text.ToString());
                OleDbDataReader read_iban_TRY = get_iban_TRY.ExecuteReader();
                while (read_iban_TRY.Read())
                {
                    _iban_trlira = read_iban_TRY["TRY"].ToString();
                }
                read_iban_TRY.Close();
                OleDbCommand get_iban_PLN = new OleDbCommand("select PLN from user_accounts where User_ID_Number =@ID", connection4);
                get_iban_PLN.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_labelUserID.Text.ToString());
                OleDbDataReader read_iban_PLN = get_iban_PLN.ExecuteReader();
                while (read_iban_PLN.Read())
                {
                    _iban_pln = read_iban_PLN["PLN"].ToString();
                }
                read_iban_PLN.Close();
                OleDbCommand get_iban_AUD = new OleDbCommand("select AUD from user_accounts where User_ID_Number =@ID", connection4);
                get_iban_AUD.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_labelUserID.Text.ToString());
                OleDbDataReader read_iban_AUD = get_iban_AUD.ExecuteReader();
                while (read_iban_AUD.Read())
                {
                    _iban_aud = read_iban_AUD["AUD"].ToString();
                }
                read_iban_AUD.Close();
                OleDbCommand get_iban_CAD = new OleDbCommand("select CAD from user_accounts where User_ID_Number =@ID", connection4);
                get_iban_CAD.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_labelUserID.Text.ToString());
                OleDbDataReader read_iban_CAD = get_iban_CAD.ExecuteReader();
                while (read_iban_CAD.Read())
                {
                    _iban_cad = read_iban_CAD["CAD"].ToString();
                }
                read_iban_CAD.Close();

                ////////////////GET BALLANCE

                OleDbCommand get_balance = new OleDbCommand("select Amount from user_wallet where IBAN = '" + _iban_selected + "'", connection4);
                OleDbDataReader read_balance = get_balance.ExecuteReader();
                while (read_balance.Read())
                {
                    _amount = Convert.ToDouble(read_balance["Amount"].ToString());
                }
                read_balance.Close();

                //////////////////////GET CURRENCY
                OleDbCommand get_currency = new OleDbCommand("select Currency from user_wallet where IBAN = '" + _iban_selected + "'", connection4);
                OleDbDataReader read_currency = get_currency.ExecuteReader();
                while (read_currency.Read())
                {
                    _currency = read_currency["Currency"].ToString();
                }
                read_currency.Close();
                connection4.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection4.Close();
                throw;
            }
        }
        public void filltextbox()
        {
            _tbcurrency1.Text = _currency;
            _tbcurrency2.Text = _currency;
            _tbcurrency3.Text = _currency;
            _tbBalance1.Text = _amount.ToString();
            _tbBalance2.Text = _amount.ToString();
            _tbBalance3.Text = _amount.ToString();
            _tbBalance4.Text = _amount.ToString();
        }
        public void fillcomboBox()
        {
            comboBox1.Items.Add(_iban_usd);
            comboBox1.Items.Add(_iban_eur);
            comboBox1.Items.Add(_iban_gbp);
            comboBox1.Items.Add(_iban_chf);
            comboBox1.Items.Add(_iban_trlira);
            comboBox1.Items.Add(_iban_pln);
            comboBox1.Items.Add(_iban_aud);
            comboBox1.Items.Add(_iban_cad);

            comboBox5.Items.Add(_iban_usd);
            comboBox5.Items.Add(_iban_eur);
            comboBox5.Items.Add(_iban_gbp);
            comboBox5.Items.Add(_iban_chf);
            comboBox5.Items.Add(_iban_trlira);
            comboBox5.Items.Add(_iban_pln);
            comboBox5.Items.Add(_iban_aud);
            comboBox5.Items.Add(_iban_cad);

            comboBox6.Items.Add(_iban_usd);
            comboBox6.Items.Add(_iban_eur);
            comboBox6.Items.Add(_iban_gbp);
            comboBox6.Items.Add(_iban_chf);
            comboBox6.Items.Add(_iban_trlira);
            comboBox6.Items.Add(_iban_pln);
            comboBox6.Items.Add(_iban_aud);
            comboBox6.Items.Add(_iban_cad);

            comboBox7.Items.Add(_iban_usd);
            comboBox7.Items.Add(_iban_eur);
            comboBox7.Items.Add(_iban_gbp);
            comboBox7.Items.Add(_iban_chf);
            comboBox7.Items.Add(_iban_trlira);
            comboBox7.Items.Add(_iban_pln);
            comboBox7.Items.Add(_iban_aud);
            comboBox7.Items.Add(_iban_cad);

            comboBox2.Items.Add("US Dollar");
            comboBox2.Items.Add("Euro");
            comboBox2.Items.Add("British Pound");
            comboBox2.Items.Add("Swiss Franc");
            comboBox2.Items.Add("Turkish Lira");
            comboBox2.Items.Add("Polish Zloty");
            comboBox2.Items.Add("Avustralian Dollar");
            comboBox2.Items.Add("Canadian Dollar");

            comboBox3.Items.Add("US Dollar");
            comboBox3.Items.Add("Euro");
            comboBox3.Items.Add("British Pound");
            comboBox3.Items.Add("Swiss Franc");
            comboBox3.Items.Add("Turkish Lira");
            comboBox3.Items.Add("Polish Zloty");
            comboBox3.Items.Add("Avustralian Dollar");
            comboBox3.Items.Add("Canadian Dollar");

            comboBox4.Items.Add("US Dollar");
            comboBox4.Items.Add("Euro");
            comboBox4.Items.Add("British Pound");
            comboBox4.Items.Add("Swiss Franc");
            comboBox4.Items.Add("Turkish Lira");
            comboBox4.Items.Add("Polish Zloty");
            comboBox4.Items.Add("Avustralian Dollar");
            comboBox4.Items.Add("Canadian Dollar");
        }
        public void _deposit()
        {
            try
            {
                connection4.Open();
                OleDbCommand deposit_cmd = new OleDbCommand("update user_wallet set Amount = '" + _depositAmount + "' where IBAN = '" + _iban_selected + "'",connection4);
                deposit_cmd.ExecuteNonQuery();
                _depositAmount = 0;
                connection4.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection4.Close();
                throw;
            }
        }
        public void _withdraw()
        {
            try
            {
                connection4.Open();
                OleDbCommand withdraw_cmd = new OleDbCommand("update user_wallet set Amount = '" + _withdrawAmount + "' where IBAN = '" + _iban_selected + "'", connection4);
                withdraw_cmd.ExecuteNonQuery();
                _withdrawAmount = 0;////////////////////////
                connection4.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection4.Close();
                throw;
            }
        }
        public void _get_transfer_user()
        {
            try
            {
                connection4.Open();
                OleDbCommand user_check = new OleDbCommand("select IBAN from user_wallet where IBAN ='" + _iban_transfer + "'", connection4);
                OleDbDataReader read_iban = user_check.ExecuteReader();////////ID
                if (read_iban.Read() == true)
                {
                    read_iban.Close();
                    _transfer_user_exist = true;
                    OleDbCommand get_name = new OleDbCommand("select User_Name from user_wallet where IBAN ='" + _iban_transfer + "'", connection4);
                    OleDbDataReader read_name = get_name.ExecuteReader();
                    while (read_name.Read())
                    {
                        _username_transfer = read_name["User_Name"].ToString();
                    }
                    read_name.Close();
                    OleDbCommand get_transfer_balance = new OleDbCommand("select Amount from user_wallet where IBAN = '" + _iban_transfer + "'", connection4);
                    OleDbDataReader read_transfer_balance = get_transfer_balance.ExecuteReader();
                    while (read_transfer_balance.Read())
                    {
                        _transferAmount = Convert.ToDouble(read_transfer_balance["Amount"].ToString());
                    }
                    read_transfer_balance.Close();
                    //////////////////////GET CURRENCY
                    OleDbCommand get_currency_transfer = new OleDbCommand("select Currency from user_wallet where IBAN = '" + _iban_transfer + "'", connection4);
                    OleDbDataReader read_currency_transfer = get_currency_transfer.ExecuteReader();
                    while (read_currency_transfer.Read())
                    {
                        _currency_transfer = read_currency_transfer["Currency"].ToString();
                    }
                    read_currency_transfer.Close();
                    connection4.Close();
                }
                else
                {
                    _transfer_user_exist = false;
                    MessageBox.Show("User has not found. Please check the Account Number","TRANSFER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connection4.Close();
                }
                }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection4.Close();
                throw;
            }
        }
        public void _get_exchange_rate()
        {
            try
            {
                connection4.Open();
                OleDbCommand get_exc_rate = new OleDbCommand("select [" + _exchange_currency2 + "] from currency_rates where Currency ='" + _exchange_currency1 + "'", connection4);
                OleDbDataReader read_exc_rate = get_exc_rate.ExecuteReader();
                while (read_exc_rate.Read())
                {
                    _exchange_rate = Convert.ToDouble(read_exc_rate[ _exchange_currency2 ].ToString());
                }
                read_exc_rate.Close();
                connection4.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection4.Close();
                throw;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cmb1index;
            cmb1index = comboBox1.SelectedIndex;
            comboBox5.Text = comboBox1.Items[cmb1index].ToString();
            comboBox6.Text = comboBox1.Items[cmb1index].ToString();
            comboBox7.Text = comboBox1.Items[cmb1index].ToString();
            _iban_selected = comboBox1.Text;
            getuserdata();
            filltextbox();
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cmb5index;
            cmb5index = comboBox5.SelectedIndex;
            comboBox1.Text = comboBox5.Items[cmb5index].ToString();
            comboBox6.Text = comboBox5.Items[cmb5index].ToString();
            comboBox7.Text = comboBox5.Items[cmb5index].ToString();
            _iban_selected = comboBox5.Text;
            getuserdata();
            filltextbox();
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cmb6index;
            cmb6index = comboBox6.SelectedIndex;
            comboBox5.Text = comboBox6.Items[cmb6index].ToString();
            comboBox1.Text = comboBox6.Items[cmb6index].ToString();
            comboBox7.Text = comboBox6.Items[cmb6index].ToString();
            _iban_selected = comboBox6.Text;
            getuserdata();
            filltextbox();
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cmb7index;
            cmb7index = comboBox7.SelectedIndex;
            comboBox5.Text = comboBox7.Items[cmb7index].ToString();
            comboBox6.Text = comboBox7.Items[cmb7index].ToString();
            comboBox1.Text = comboBox7.Items[cmb7index].ToString();
            _iban_selected = comboBox7.Text;
            getuserdata();
            filltextbox();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //////////deposit
            _depositAmount = Convert.ToDouble(_tbdeposit1.Text);
            getuserdata();
            _depositAmount = _amount + _depositAmount;
            _deposit();
            MessageBox.Show("DEPOSIT SUCCESS", "DEPOSIT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            FileStream fs = new FileStream(_path, FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw2 = new StreamWriter(fs);
            sw2.Write("\r\nDEPOSİT \r\nFROM " + _iban_selected + "\r\n" + _now.ToString() + "\r\n");
            sw2.Close();
            fs.Close();
            _tbdeposit1.Clear();
            getuserdata();
            filltextbox();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ////////withdraw
            _withdrawAmount = Convert.ToDouble(_tbwithraw.Text);
            getuserdata();
            if (_withdrawAmount <= _amount)
            {
                _withdrawAmount = _amount - _withdrawAmount;
                _withdraw();
                MessageBox.Show("WITHDRAW SUCCESS", "WITHDRAW", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                FileStream fs = new FileStream(_path, FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw3 = new StreamWriter(fs);
                sw3.Write("\r\nWITHDRAW \r\nFROM " + _iban_selected + "\r\n" + _now.ToString() + "\r\n");
                sw3.Close();
                fs.Close();
                getuserdata();
                filltextbox();
            }
            else
            {
                MessageBox.Show("You don't have enought balance", "WITHDRAW", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _tbwithraw.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ///check currency before transfer!!!!!!!!
            ////////withdraw
            _withdrawAmount = Convert.ToDouble(_tb_transfer_amount.Text);
            getuserdata();
            if (_withdrawAmount <= _amount)
            {
                _withdrawAmount = _amount - _withdrawAmount;
                _withdraw();
                getuserdata();
                filltextbox();

                _depositAmount = Convert.ToDouble(_tb_transfer_amount.Text);
                _get_transfer_user();
                _depositAmount = _transferAmount + _depositAmount;
                _iban_selected = _iban_transfer;
                _deposit();
                MessageBox.Show("TRANSFER SUCCESS", "TRANSFER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _iban_selected = comboBox7.Text;
                FileStream fs = new FileStream(_path, FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw1 = new StreamWriter(fs);
                sw1.Write("\r\nTRANSFER \r\nFROM " + _iban_selected + "\r\nTO " + _iban_transfer + "\r\n" + _now.ToString() + "\r\n");
                sw1.Close();
                fs.Close();
                
                
            }
            else
            {
                MessageBox.Show("You don't have enought balance", "TRANSFER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            _tb_transfer_amount.Clear();
            _tb_username_transfer.Clear();
            button4.Enabled = false;

        }
        private void button_checkaccount_Click(object sender, EventArgs e)
        {
            _iban_transfer = _tb_transfer_iban.Text;
            _get_transfer_user();
            if(_transfer_user_exist == true)
            {
                _tb_username_transfer.Text = _username_transfer;
                if(_currency == _currency_transfer)
                {
                    button4.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Currency does not matcah. Please try anoughter account number", "ACCOUNTS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("User has not found.", "TRANSFER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            _exchange_currency1 = comboBox3.Text;
            _get_exchange_rate();
            label8.Text = "1 " + comboBox3.Text + " = " + _exchange_rate + " " + comboBox4.Text + "";
            if(comboBox3.Text == "US Dollar")
            {
                _exchange_iban1 = _iban_usd;
            }
            else if (comboBox3.Text == "Euro")
            {
                _exchange_iban1 = _iban_eur;
            }
            else if (comboBox3.Text == "British Pound")
            {
                _exchange_iban1 = _iban_gbp;
            }
            else if (comboBox3.Text == "Swiss Franc")
            {
                _exchange_iban1 = _iban_chf;
            }
            else if (comboBox3.Text == "Turkish Lira")
            {
                _exchange_iban1 = _iban_trlira;
            }
            else if (comboBox3.Text == "Polish Zloty")
            {
                _exchange_iban1 = _iban_pln;
            }
            else if (comboBox3.Text == "Avustralian Dollar")
            {
                _exchange_iban1 = _iban_aud;
            }
            else if (comboBox3.Text == "Canadian Dollar")
            {
                _exchange_iban1 = _iban_cad;
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            _exchange_currency2 = "R" + comboBox4.Text;
            _get_exchange_rate();
            label8.Text = "1 " + comboBox3.Text + " = " + _exchange_rate + " " + comboBox4.Text + "";
            if (comboBox4.Text == "US Dollar")
            {
                _exchange_iban2 = _iban_usd;
            }
            else if (comboBox4.Text == "Euro")
            {
                _exchange_iban2 = _iban_eur;
            }
            else if (comboBox4.Text == "British Pound")
            {
                _exchange_iban2 = _iban_gbp;
            }
            else if (comboBox4.Text == "Swiss Franc")
            {
                _exchange_iban2 = _iban_chf;
            }
            else if (comboBox4.Text == "Turkish Lira")
            {
                _exchange_iban2 = _iban_trlira;
            }
            else if (comboBox4.Text == "Polish Zloty")
            {
                _exchange_iban2 = _iban_pln;
            }
            else if (comboBox4.Text == "Avustralian Dollar")
            {
                _exchange_iban2 = _iban_aud;
            }
            else if (comboBox4.Text == "Canadian Dollar")
            {
                _exchange_iban2 = _iban_cad;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _exchange_amount1 = Convert.ToDouble(_tbexchange.Text.ToString());
            _exchange_amount2 = _exchange_amount1 * _exchange_rate;
            _withdrawAmount = _exchange_amount1;
            _iban_selected = _exchange_iban1;
            getuserdata();
            _iban_selected = "";
            if (_withdrawAmount <= _amount)
            {
                _withdrawAmount = _amount - _withdrawAmount;
                _iban_selected = _exchange_iban1;
                _withdraw();
                _iban_selected = "";
                

                _depositAmount = _exchange_amount2;
                _iban_transfer = _exchange_iban2;
                _get_transfer_user();
                _iban_transfer = "";
                _depositAmount = _transferAmount + _depositAmount;
                _iban_selected = _exchange_iban2;
                _deposit();
                _iban_selected = "";
                MessageBox.Show("EXCHANGE SUCCESS", "EXCHANGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FileStream fs = new FileStream(_path, FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw1 = new StreamWriter(fs);
                sw1.Write("\r\nEXCHANGE \r\nFROM " + _exchange_iban1+ "\r\nTO " + _exchange_iban2 + "\r\n" + _now.ToString() + "\r\n");
                sw1.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("You don't have enought balance", "TRANSFER", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _tbexchange.Clear();
        }
        private void _tbexchange_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(_tbexchange.Text))
            {
                _exchange_amount1 = Convert.ToDouble(_tbexchange.Text.ToString());
                _exchange_amount2 = _exchange_amount1 * _exchange_rate;
                label10.Text = _exchange_amount2.ToString();
            }
            else
            {
                label10.Text = "";
            }
        }
        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Do you want to logout?", "LOGOUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
    }
}
