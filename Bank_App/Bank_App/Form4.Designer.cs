namespace Bank_App
{
    partial class FormSI
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tbusername = new System.Windows.Forms.TextBox();
            this._tbuserid = new System.Windows.Forms.TextBox();
            this._tbuseradress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._tbuserpassw = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_addID = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID NUMBER :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID Photo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ADRESS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NAME :";
            // 
            // _tbusername
            // 
            this._tbusername.Location = new System.Drawing.Point(98, 63);
            this._tbusername.Name = "_tbusername";
            this._tbusername.Size = new System.Drawing.Size(151, 20);
            this._tbusername.TabIndex = 5;
            this._tbusername.TextChanged += new System.EventHandler(this._tbusername_TextChanged);
            this._tbusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbusername_KeyPress);
            // 
            // _tbuserid
            // 
            this._tbuserid.Location = new System.Drawing.Point(359, 63);
            this._tbuserid.MaxLength = 9;
            this._tbuserid.Name = "_tbuserid";
            this._tbuserid.Size = new System.Drawing.Size(132, 20);
            this._tbuserid.TabIndex = 6;
            this._tbuserid.TextChanged += new System.EventHandler(this._tbuserid_TextChanged);
            this._tbuserid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbuserid_KeyPress);
            // 
            // _tbuseradress
            // 
            this._tbuseradress.Location = new System.Drawing.Point(98, 97);
            this._tbuseradress.Name = "_tbuseradress";
            this._tbuseradress.Size = new System.Drawing.Size(393, 20);
            this._tbuseradress.TabIndex = 7;
            this._tbuseradress.TextChanged += new System.EventHandler(this._tbuseradress_TextChanged);
            this._tbuseradress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbuseradress_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "PASSWORD:";
            // 
            // _tbuserpassw
            // 
            this._tbuserpassw.Location = new System.Drawing.Point(98, 130);
            this._tbuserpassw.MaxLength = 8;
            this._tbuserpassw.Name = "_tbuserpassw";
            this._tbuserpassw.PasswordChar = '*';
            this._tbuserpassw.Size = new System.Drawing.Size(118, 20);
            this._tbuserpassw.TabIndex = 9;
            this._tbuserpassw.TextChanged += new System.EventHandler(this._tbuserpassw_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(89, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(15, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(476, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "SIGN IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_addID
            // 
            this.button_addID.Location = new System.Drawing.Point(8, 181);
            this.button_addID.Name = "button_addID";
            this.button_addID.Size = new System.Drawing.Size(75, 44);
            this.button_addID.TabIndex = 12;
            this.button_addID.Text = "Add ID Photo";
            this.button_addID.UseVisualStyleBackColor = true;
            this.button_addID.Click += new System.EventHandler(this.button_addID_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(431, 12);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 481);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_addID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._tbuserpassw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._tbuseradress);
            this.Controls.Add(this._tbuserid);
            this.Controls.Add(this._tbusername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "FormSI";
            this.Text = "SIGN IN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbusername;
        private System.Windows.Forms.TextBox _tbuserid;
        private System.Windows.Forms.TextBox _tbuseradress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbuserpassw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_addID;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}