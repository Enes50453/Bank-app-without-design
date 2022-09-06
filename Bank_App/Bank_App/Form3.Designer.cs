namespace Bank_App
{
    partial class FormUI
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
            this._label_Username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.accounts = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._tbcurrency1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._tbBalance1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this._tbdeposit1 = new System.Windows.Forms.TextBox();
            this._tbBalance2 = new System.Windows.Forms.TextBox();
            this._tbcurrency2 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.withdraw = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this._tbwithraw = new System.Windows.Forms.TextBox();
            this._tbBalance3 = new System.Windows.Forms.TextBox();
            this._tbcurrency3 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.exchange = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._tbexchange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.transfer = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this._tb_transfer_amount = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this._tb_username_transfer = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this._tb_transfer_iban = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this._tbBalance4 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this._labelUserID = new System.Windows.Forms.Label();
            this.button_checkaccount = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.accounts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.deposit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.withdraw.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.exchange.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.transfer.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // _label_Username
            // 
            this._label_Username.AutoSize = true;
            this._label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._label_Username.Location = new System.Drawing.Point(12, 9);
            this._label_Username.Name = "_label_Username";
            this._label_Username.Size = new System.Drawing.Size(97, 18);
            this._label_Username.TabIndex = 0;
            this._label_Username.Text = "USER NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.accounts);
            this.tabControl1.Controls.Add(this.deposit);
            this.tabControl1.Controls.Add(this.withdraw);
            this.tabControl1.Controls.Add(this.exchange);
            this.tabControl1.Controls.Add(this.transfer);
            this.tabControl1.Location = new System.Drawing.Point(15, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 337);
            this.tabControl1.TabIndex = 10;
            // 
            // accounts
            // 
            this.accounts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accounts.Controls.Add(this.groupBox1);
            this.accounts.Location = new System.Drawing.Point(4, 22);
            this.accounts.Name = "accounts";
            this.accounts.Padding = new System.Windows.Forms.Padding(3);
            this.accounts.Size = new System.Drawing.Size(408, 284);
            this.accounts.TabIndex = 0;
            this.accounts.Text = "ACCOUNTS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._tbcurrency1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._tbBalance1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCOUNTS";
            // 
            // _tbcurrency1
            // 
            this._tbcurrency1.Location = new System.Drawing.Point(138, 57);
            this._tbcurrency1.Name = "_tbcurrency1";
            this._tbcurrency1.ReadOnly = true;
            this._tbcurrency1.Size = new System.Drawing.Size(221, 20);
            this._tbcurrency1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CURRENCY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CHOOSE ACCOUNT:";
            // 
            // _tbBalance1
            // 
            this._tbBalance1.Location = new System.Drawing.Point(138, 96);
            this._tbBalance1.Name = "_tbBalance1";
            this._tbBalance1.ReadOnly = true;
            this._tbBalance1.Size = new System.Drawing.Size(221, 20);
            this._tbBalance1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "YOUR BALANCE:";
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deposit.Controls.Add(this.groupBox3);
            this.deposit.Location = new System.Drawing.Point(4, 22);
            this.deposit.Name = "deposit";
            this.deposit.Padding = new System.Windows.Forms.Padding(3);
            this.deposit.Size = new System.Drawing.Size(408, 284);
            this.deposit.TabIndex = 1;
            this.deposit.Text = "DEPOSİT";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this._tbdeposit1);
            this.groupBox3.Controls.Add(this._tbBalance2);
            this.groupBox3.Controls.Add(this._tbcurrency2);
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(17, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 215);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DEPOSIT MONEY";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "DEPOSIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // _tbdeposit1
            // 
            this._tbdeposit1.Location = new System.Drawing.Point(130, 148);
            this._tbdeposit1.Name = "_tbdeposit1";
            this._tbdeposit1.Size = new System.Drawing.Size(229, 20);
            this._tbdeposit1.TabIndex = 5;
            // 
            // _tbBalance2
            // 
            this._tbBalance2.Location = new System.Drawing.Point(130, 101);
            this._tbBalance2.Name = "_tbBalance2";
            this._tbBalance2.ReadOnly = true;
            this._tbBalance2.Size = new System.Drawing.Size(229, 20);
            this._tbBalance2.TabIndex = 4;
            // 
            // _tbcurrency2
            // 
            this._tbcurrency2.Location = new System.Drawing.Point(130, 62);
            this._tbcurrency2.Name = "_tbcurrency2";
            this._tbcurrency2.ReadOnly = true;
            this._tbcurrency2.Size = new System.Drawing.Size(229, 20);
            this._tbcurrency2.TabIndex = 3;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(130, 30);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(229, 21);
            this.comboBox5.TabIndex = 2;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "AMOUNT:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "CHOOSE ACCOUNT:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "CURRENCY:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "YOUR BALLANCE:";
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.withdraw.Controls.Add(this.groupBox4);
            this.withdraw.Location = new System.Drawing.Point(4, 22);
            this.withdraw.Name = "withdraw";
            this.withdraw.Padding = new System.Windows.Forms.Padding(3);
            this.withdraw.Size = new System.Drawing.Size(408, 284);
            this.withdraw.TabIndex = 2;
            this.withdraw.Text = "WİTHDRAW";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this._tbwithraw);
            this.groupBox4.Controls.Add(this._tbBalance3);
            this.groupBox4.Controls.Add(this._tbcurrency3);
            this.groupBox4.Controls.Add(this.comboBox6);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(6, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 215);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "WITHDRAW MONEY";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "WITHDRAW";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // _tbwithraw
            // 
            this._tbwithraw.Location = new System.Drawing.Point(130, 151);
            this._tbwithraw.Name = "_tbwithraw";
            this._tbwithraw.Size = new System.Drawing.Size(229, 20);
            this._tbwithraw.TabIndex = 7;
            // 
            // _tbBalance3
            // 
            this._tbBalance3.Location = new System.Drawing.Point(130, 102);
            this._tbBalance3.Name = "_tbBalance3";
            this._tbBalance3.ReadOnly = true;
            this._tbBalance3.Size = new System.Drawing.Size(229, 20);
            this._tbBalance3.TabIndex = 6;
            // 
            // _tbcurrency3
            // 
            this._tbcurrency3.Location = new System.Drawing.Point(130, 63);
            this._tbcurrency3.Name = "_tbcurrency3";
            this._tbcurrency3.ReadOnly = true;
            this._tbcurrency3.Size = new System.Drawing.Size(229, 20);
            this._tbcurrency3.TabIndex = 5;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(130, 28);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(229, 21);
            this.comboBox6.TabIndex = 4;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "CHOOSE ACCOUNT:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "YOUR BALLANCE:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "CURRENCY:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(6, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "AMOUNT:";
            // 
            // exchange
            // 
            this.exchange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exchange.Controls.Add(this.groupBox2);
            this.exchange.Location = new System.Drawing.Point(4, 22);
            this.exchange.Name = "exchange";
            this.exchange.Size = new System.Drawing.Size(408, 284);
            this.exchange.TabIndex = 3;
            this.exchange.Text = "EXCHANGE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this._tbexchange);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 139);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CURRENCY EXCHANGE";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(6, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "AMOUNT:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "EXCHANGE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _tbexchange
            // 
            this._tbexchange.Location = new System.Drawing.Point(84, 72);
            this._tbexchange.Name = "_tbexchange";
            this._tbexchange.Size = new System.Drawing.Size(100, 20);
            this._tbexchange.TabIndex = 4;
            this._tbexchange.TextChanged += new System.EventHandler(this._tbexchange_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(201, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "EQUAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "equelsto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(156, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "to";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(183, 20);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(141, 21);
            this.comboBox4.TabIndex = 1;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(9, 20);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(141, 21);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // transfer
            // 
            this.transfer.Controls.Add(this.groupBox5);
            this.transfer.Location = new System.Drawing.Point(4, 22);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(408, 311);
            this.transfer.TabIndex = 4;
            this.transfer.Text = "TRANSFER";
            this.transfer.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.button_checkaccount);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this._tb_transfer_amount);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this._tb_username_transfer);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this._tb_transfer_iban);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this._tbBalance4);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.comboBox7);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Location = new System.Drawing.Point(3, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(402, 266);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TRANSFER MONEY";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(69, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 38);
            this.button4.TabIndex = 13;
            this.button4.Text = "TRANSFER MONEY";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // _tb_transfer_amount
            // 
            this._tb_transfer_amount.Location = new System.Drawing.Point(144, 188);
            this._tb_transfer_amount.Name = "_tb_transfer_amount";
            this._tb_transfer_amount.Size = new System.Drawing.Size(100, 20);
            this._tb_transfer_amount.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(66, 188);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 17);
            this.label24.TabIndex = 11;
            this.label24.Text = "AMOUNT:";
            // 
            // _tb_username_transfer
            // 
            this._tb_username_transfer.Location = new System.Drawing.Point(144, 148);
            this._tb_username_transfer.Name = "_tb_username_transfer";
            this._tb_username_transfer.ReadOnly = true;
            this._tb_username_transfer.Size = new System.Drawing.Size(214, 20);
            this._tb_username_transfer.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 151);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "USER NAME:";
            // 
            // _tb_transfer_iban
            // 
            this._tb_transfer_iban.Location = new System.Drawing.Point(144, 113);
            this._tb_transfer_iban.Name = "_tb_transfer_iban";
            this._tb_transfer_iban.Size = new System.Drawing.Size(214, 20);
            this._tb_transfer_iban.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 116);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "ACCOUNT NUMBER:";
            // 
            // _tbBalance4
            // 
            this._tbBalance4.Location = new System.Drawing.Point(144, 78);
            this._tbBalance4.Name = "_tbBalance4";
            this._tbBalance4.ReadOnly = true;
            this._tbBalance4.Size = new System.Drawing.Size(252, 20);
            this._tbBalance4.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(11, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "YOUR BALLANCE:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(144, 42);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(252, 21);
            this.comboBox7.TabIndex = 2;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "CHOOSE CURRENCY:";
            // 
            // _labelUserID
            // 
            this._labelUserID.AutoSize = true;
            this._labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._labelUserID.Location = new System.Drawing.Point(256, 9);
            this._labelUserID.Name = "_labelUserID";
            this._labelUserID.Size = new System.Drawing.Size(80, 18);
            this._labelUserID.TabIndex = 0;
            this._labelUserID.Text = "000000000";
            this._labelUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_checkaccount
            // 
            this.button_checkaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_checkaccount.Location = new System.Drawing.Point(364, 113);
            this.button_checkaccount.Name = "button_checkaccount";
            this.button_checkaccount.Size = new System.Drawing.Size(38, 20);
            this.button_checkaccount.TabIndex = 14;
            this.button_checkaccount.Text = "OK";
            this.button_checkaccount.UseVisualStyleBackColor = true;
            this.button_checkaccount.Click += new System.EventHandler(this.button_checkaccount_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(352, 4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 11;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(259, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "TOTAL BALLANCE:";
            this.label4.Visible = false;
            // 
            // FormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 383);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._labelUserID);
            this.Controls.Add(this._label_Username);
            this.Name = "FormUI";
            this.Text = "USER INTERFACE";
            this.Load += new System.EventHandler(this.FormUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.accounts.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.deposit.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.withdraw.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.exchange.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.transfer.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _label_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage accounts;
        private System.Windows.Forms.TabPage deposit;
        private System.Windows.Forms.TabPage withdraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _tbcurrency1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tbBalance1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox _tbdeposit1;
        private System.Windows.Forms.TextBox _tbBalance2;
        private System.Windows.Forms.TextBox _tbcurrency2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox _tbwithraw;
        private System.Windows.Forms.TextBox _tbBalance3;
        private System.Windows.Forms.TextBox _tbcurrency3;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage exchange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox _tbexchange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabPage transfer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox _tb_username_transfer;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox _tb_transfer_iban;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox _tbBalance4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox _tb_transfer_amount;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.Label _labelUserID;
        private System.Windows.Forms.Button button_checkaccount;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}