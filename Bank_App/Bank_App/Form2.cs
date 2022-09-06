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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        public string _path = Application.StartupPath + "/activities.txt";
        OleDbConnection connection2 = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\Bank_app.accdb");
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button_bringuser_Click(object sender, EventArgs e)
        {
            if (_id == true)
            {
                userinfo();
            }
        }
        private void _button_block_Click(object sender, EventArgs e)
        {
            try
            {
                connection2.Open();
                OleDbCommand blockuser = new OleDbCommand("update user_status set status='BLOCKED' where User_ID_Number =@ID", connection2);
                blockuser.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb2.Text.ToString());
                blockuser.ExecuteNonQuery();
                connection2.Close();
                userinfo();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection2.Close();
                throw;
            }
            getwaitinglist();
        }
        public void userinfo()
        {
            int userid = 0;
            string username = "";
            string adress = "";
            string user_status = "";
            try
            {
                connection2.Open();
                OleDbCommand usercheck = new OleDbCommand("select User_ID_Number from user_info where User_ID_Number =@ID", connection2);
                usercheck.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb1.Text.ToString());
                OleDbDataReader readid = usercheck.ExecuteReader();////////ID
                if (readid.Read() == true)
                {
                    Image image1 = null;
                    using (FileStream stream = new FileStream(@Application.StartupPath + "\\ID_pics\\" + _useridtb1.Text + ".jpeg", FileMode.Open))
                    {
                        image1 = Image.FromStream(stream);
                    }
                    pictureBox.Image = image1;
                    readid.Close();
                    OleDbCommand getid = new OleDbCommand("select User_ID_Number from user_info where User_ID_Number =@ID", connection2);
                    getid.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb1.Text.ToString());
                    OleDbDataReader readid2 = getid.ExecuteReader();
                    while (readid2.Read())
                    {
                        userid = Convert.ToInt32(readid2["User_ID_Number"].ToString());
                    }
                    readid2.Close();
                    OleDbCommand getname = new OleDbCommand("select User_Name from user_info where User_ID_Number =@ID", connection2);
                    getname.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb1.Text.ToString());
                    OleDbDataReader readname = getname.ExecuteReader();
                    while (readname.Read())
                    {
                        username = readname["User_Name"].ToString();
                    }
                    readname.Close();
                    OleDbCommand getadress = new OleDbCommand("select Adress from user_info where User_ID_Number =@ID", connection2);
                    getadress.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb1.Text.ToString());
                    OleDbDataReader readadress = getadress.ExecuteReader();
                    while (readadress.Read())
                    {
                        adress = readadress["Adress"].ToString();
                    }
                    readadress.Close();
                    OleDbCommand getstatus = new OleDbCommand("select status from user_status where User_ID_Number =@ID", connection2);
                    getstatus.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb1.Text.ToString());
                    OleDbDataReader readstatus = getstatus.ExecuteReader();
                    while (readstatus.Read())
                    {
                        user_status = readstatus["status"].ToString();
                    }
                    readstatus.Close();
                    connection2.Close();
                }
                else
                {
                    MessageBox.Show("USER DOES NOT EXSIST", "DATABASE");
                    connection2.Close();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection2.Close();
                throw;
            }
            _usernametb.Text = username;
            _useridtb2.Text = userid.ToString();
            _useradresstb.Text = adress;
            _labelStatus.Text = user_status;
            if (_labelStatus.Text == "ACTIVE")
            {
                _button_unblock.Enabled = false;
                _button_block.Enabled = true;
                _labelStatus.BackColor = Color.Green;
            }
            else if (_labelStatus.Text == "WAITING")
            {
                _button_unblock.Enabled = true;
                _button_block.Enabled = true;
                _labelStatus.BackColor = Color.Yellow;
            }
            else if (_labelStatus.Text == "BLOCKED")
            {
                _button_unblock.Enabled = true;
                _button_block.Enabled = false;
                _labelStatus.BackColor = Color.Red;
            }
            connection2.Close();
        }
        private void _button_unblock_Click(object sender, EventArgs e)
        {
            try
            {
                connection2.Open();
                OleDbCommand unblockuser = new OleDbCommand("update user_status set status='ACTIVE' where User_ID_Number =@ID", connection2);
                unblockuser.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb2.Text.ToString());
                unblockuser.ExecuteNonQuery();
                connection2.Close();
                userinfo();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection2.Close();
                throw;
            }
            getwaitinglist();
        }
        private void _button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection2.Open();
                OleDbCommand deleteuser1 = new OleDbCommand("delete from user_info where User_ID_Number =@ID", connection2);
                deleteuser1.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb2.Text.ToString());
                deleteuser1.ExecuteNonQuery();
                OleDbCommand deleteuser2 = new OleDbCommand("delete from user_password where User_ID_Number =@ID", connection2);
                deleteuser2.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb2.Text.ToString());
                deleteuser2.ExecuteNonQuery();
                OleDbCommand deleteuser3 = new OleDbCommand("delete from user_status where User_ID_Number =@ID", connection2);
                deleteuser3.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb2.Text.ToString());
                deleteuser3.ExecuteNonQuery();
                OleDbCommand deleteuser4 = new OleDbCommand("delete from user_wallet where User_ID_Number =@ID", connection2);
                deleteuser4.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb2.Text.ToString());
                deleteuser4.ExecuteNonQuery();
                OleDbCommand deleteuser5 = new OleDbCommand("delete from user_accounts where User_ID_Number =@ID", connection2);
                deleteuser5.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb2.Text.ToString());
                deleteuser5.ExecuteNonQuery();
                connection2.Close();
                
                System.IO.File.Delete(Application.StartupPath + "\\ID_pics\\" + _useridtb1.Text + ".jpeg");
                pictureBox.Image = null;
                clearinfos();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection2.Close();
                throw;
            }
            getwaitinglist();
        }
        public void clearinfos()
        {
            _usernametb.Text = "";
            _useridtb2.Text = "";
            _useradresstb.Text = "";
            _labelStatus.Text = "";
        }
        public void _get_activities()
        {
            FileStream fs = new FileStream(_path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string _activities = sr.ReadLine();
            while (_activities != null)
            {
                listBox_activities.Items.Add(_activities);
                _activities = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            clearinfos();
            getwaitinglist();
            _get_activities();
        }
        private void getwaitinglist()
        {
            comboreq.Items.Clear();
            try
            {
                connection2.Open();
                OleDbCommand _getwaitinglist = new OleDbCommand("select User_ID_Number from user_status where status = 'WAITING'", connection2);
                OleDbDataReader readwaitinglist = _getwaitinglist.ExecuteReader();
                while(readwaitinglist.Read())
                {
                    comboreq.Items.Add(readwaitinglist["User_ID_Number"].ToString());
                }
                readwaitinglist.Close();
                connection2.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection2.Close();
                throw;
            }
        }
        private void comboreq_SelectedIndexChanged(object sender, EventArgs e)
        {
            _useridtb1.Text = comboreq.Text;
            userinfo();
        }
        private void _buttonacceptrq_Click(object sender, EventArgs e)
        {
            try
            {
                connection2.Open();
                OleDbCommand acceptuser = new OleDbCommand("update user_status set status='ACTIVE' where User_ID_Number =@ID", connection2);
                acceptuser.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb2.Text.ToString());
                acceptuser.ExecuteNonQuery();
                connection2.Close();
                userinfo();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection2.Close();
                throw;
            }
            getwaitinglist();
        }
        private void _button_declinerq_Click(object sender, EventArgs e)
        {
            try
            {
                connection2.Open();
                OleDbCommand declineuser1 = new OleDbCommand("delete from user_info where User_ID_Number =@ID", connection2);
                declineuser1.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb2.Text.ToString());
                declineuser1.ExecuteNonQuery();
                OleDbCommand declineuser2 = new OleDbCommand("delete from user_password where User_ID_Number =@ID", connection2);
                declineuser2.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb2.Text.ToString());
                declineuser2.ExecuteNonQuery();
                OleDbCommand declineuser3 = new OleDbCommand("delete from user_status where User_ID_Number =@ID", connection2);
                declineuser3.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(_useridtb2.Text.ToString());
                declineuser3.ExecuteNonQuery();
                connection2.Close();
                clearinfos();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
                connection2.Close();
                throw;
            }
            getwaitinglist();
        }
        private void _button_logout_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Do you want to logout?", "LOGOUT", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(dresult == DialogResult.OK)
            {
                FormLogin formlogin = new FormLogin();
                formlogin.Show();
                this.Close();
            }
            else
            {
            }
        }
        bool _id = false;
        private void _useridtb1_TextChanged(object sender, EventArgs e)
        {
            if (_useridtb1.TextLength < 9)
            {
                errorProvider1.SetError(_useridtb1, "ID Number shoul be 9 chracter long");
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
