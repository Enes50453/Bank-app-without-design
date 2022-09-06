namespace Bank_App
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._labelStatus = new System.Windows.Forms.Label();
            this._button_delete = new System.Windows.Forms.Button();
            this._button_unblock = new System.Windows.Forms.Button();
            this._button_block = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this._useradresstb = new System.Windows.Forms.TextBox();
            this._useridtb2 = new System.Windows.Forms.TextBox();
            this._usernametb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._useridtb1 = new System.Windows.Forms.TextBox();
            this._button_bringuser = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._button_declinerq = new System.Windows.Forms.Button();
            this._buttonacceptrq = new System.Windows.Forms.Button();
            this.comboreq = new System.Windows.Forms.ComboBox();
            this.listBox_activities = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this._button_logout = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGER ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._labelStatus);
            this.groupBox1.Controls.Add(this._button_delete);
            this.groupBox1.Controls.Add(this._button_unblock);
            this.groupBox1.Controls.Add(this._button_block);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this._useradresstb);
            this.groupBox1.Controls.Add(this._useridtb2);
            this.groupBox1.Controls.Add(this._usernametb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 458);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // _labelStatus
            // 
            this._labelStatus.AutoSize = true;
            this._labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._labelStatus.Location = new System.Drawing.Point(442, 440);
            this._labelStatus.Name = "_labelStatus";
            this._labelStatus.Size = new System.Drawing.Size(53, 15);
            this._labelStatus.TabIndex = 8;
            this._labelStatus.Text = "STATUS";
            // 
            // _button_delete
            // 
            this._button_delete.Location = new System.Drawing.Point(11, 412);
            this._button_delete.Name = "_button_delete";
            this._button_delete.Size = new System.Drawing.Size(148, 23);
            this._button_delete.TabIndex = 7;
            this._button_delete.Text = "Delete This Account";
            this._button_delete.UseVisualStyleBackColor = true;
            this._button_delete.Click += new System.EventHandler(this._button_delete_Click);
            // 
            // _button_unblock
            // 
            this._button_unblock.Location = new System.Drawing.Point(11, 383);
            this._button_unblock.Name = "_button_unblock";
            this._button_unblock.Size = new System.Drawing.Size(148, 23);
            this._button_unblock.TabIndex = 6;
            this._button_unblock.Text = "Unblock This Account";
            this._button_unblock.UseVisualStyleBackColor = true;
            this._button_unblock.Click += new System.EventHandler(this._button_unblock_Click);
            // 
            // _button_block
            // 
            this._button_block.Location = new System.Drawing.Point(11, 354);
            this._button_block.Name = "_button_block";
            this._button_block.Size = new System.Drawing.Size(148, 23);
            this._button_block.TabIndex = 5;
            this._button_block.Text = "Block This Account";
            this._button_block.UseVisualStyleBackColor = true;
            this._button_block.Click += new System.EventHandler(this._button_block_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(67, 96);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(402, 252);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // _useradresstb
            // 
            this._useradresstb.Location = new System.Drawing.Point(57, 62);
            this._useradresstb.Name = "_useradresstb";
            this._useradresstb.ReadOnly = true;
            this._useradresstb.Size = new System.Drawing.Size(448, 20);
            this._useradresstb.TabIndex = 3;
            // 
            // _useridtb2
            // 
            this._useridtb2.Location = new System.Drawing.Point(308, 28);
            this._useridtb2.Name = "_useridtb2";
            this._useridtb2.ReadOnly = true;
            this._useridtb2.Size = new System.Drawing.Size(197, 20);
            this._useridtb2.TabIndex = 2;
            // 
            // _usernametb
            // 
            this._usernametb.Location = new System.Drawing.Point(53, 28);
            this._usernametb.Name = "_usernametb";
            this._usernametb.ReadOnly = true;
            this._usernametb.Size = new System.Drawing.Size(168, 20);
            this._usernametb.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID Photo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adress :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User ID Number :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // _useridtb1
            // 
            this._useridtb1.Location = new System.Drawing.Point(105, 49);
            this._useridtb1.MaxLength = 9;
            this._useridtb1.Name = "_useridtb1";
            this._useridtb1.Size = new System.Drawing.Size(192, 20);
            this._useridtb1.TabIndex = 4;
            this._useridtb1.TextChanged += new System.EventHandler(this._useridtb1_TextChanged);
            // 
            // _button_bringuser
            // 
            this._button_bringuser.Location = new System.Drawing.Point(304, 49);
            this._button_bringuser.Name = "_button_bringuser";
            this._button_bringuser.Size = new System.Drawing.Size(75, 23);
            this._button_bringuser.TabIndex = 5;
            this._button_bringuser.Text = "Bring User";
            this._button_bringuser.UseVisualStyleBackColor = true;
            this._button_bringuser.Click += new System.EventHandler(this.button_bringuser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._button_declinerq);
            this.groupBox2.Controls.Add(this._buttonacceptrq);
            this.groupBox2.Controls.Add(this.comboreq);
            this.groupBox2.Location = new System.Drawing.Point(535, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 135);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New User Requests";
            // 
            // _button_declinerq
            // 
            this._button_declinerq.Location = new System.Drawing.Point(6, 84);
            this._button_declinerq.Name = "_button_declinerq";
            this._button_declinerq.Size = new System.Drawing.Size(209, 32);
            this._button_declinerq.TabIndex = 2;
            this._button_declinerq.Text = "Decline";
            this._button_declinerq.UseVisualStyleBackColor = true;
            this._button_declinerq.Click += new System.EventHandler(this._button_declinerq_Click);
            // 
            // _buttonacceptrq
            // 
            this._buttonacceptrq.Location = new System.Drawing.Point(6, 46);
            this._buttonacceptrq.Name = "_buttonacceptrq";
            this._buttonacceptrq.Size = new System.Drawing.Size(209, 32);
            this._buttonacceptrq.TabIndex = 1;
            this._buttonacceptrq.Text = "Accept";
            this._buttonacceptrq.UseVisualStyleBackColor = true;
            this._buttonacceptrq.Click += new System.EventHandler(this._buttonacceptrq_Click);
            // 
            // comboreq
            // 
            this.comboreq.FormattingEnabled = true;
            this.comboreq.Location = new System.Drawing.Point(6, 19);
            this.comboreq.Name = "comboreq";
            this.comboreq.Size = new System.Drawing.Size(209, 21);
            this.comboreq.TabIndex = 0;
            this.comboreq.SelectedIndexChanged += new System.EventHandler(this.comboreq_SelectedIndexChanged);
            // 
            // listBox_activities
            // 
            this.listBox_activities.FormattingEnabled = true;
            this.listBox_activities.Location = new System.Drawing.Point(541, 253);
            this.listBox_activities.Name = "listBox_activities";
            this.listBox_activities.Size = new System.Drawing.Size(223, 290);
            this.listBox_activities.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(599, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "ACTIVITIES";
            // 
            // _button_logout
            // 
            this._button_logout.Location = new System.Drawing.Point(689, 9);
            this._button_logout.Name = "_button_logout";
            this._button_logout.Size = new System.Drawing.Size(75, 23);
            this._button_logout.TabIndex = 9;
            this._button_logout.Text = "Logout";
            this._button_logout.UseVisualStyleBackColor = true;
            this._button_logout.Click += new System.EventHandler(this._button_logout_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 573);
            this.Controls.Add(this._button_logout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox_activities);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._button_bringuser);
            this.Controls.Add(this._useridtb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmin";
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _useridtb1;
        private System.Windows.Forms.Button _button_bringuser;
        private System.Windows.Forms.Button _button_delete;
        private System.Windows.Forms.Button _button_unblock;
        private System.Windows.Forms.Button _button_block;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox _useradresstb;
        private System.Windows.Forms.TextBox _useridtb2;
        private System.Windows.Forms.TextBox _usernametb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboreq;
        private System.Windows.Forms.Label _labelStatus;
        private System.Windows.Forms.Button _button_declinerq;
        private System.Windows.Forms.Button _buttonacceptrq;
        private System.Windows.Forms.ListBox listBox_activities;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button _button_logout;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}