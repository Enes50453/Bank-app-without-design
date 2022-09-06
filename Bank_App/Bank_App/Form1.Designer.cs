namespace Bank_App
{
    partial class FormLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this._usernametb = new System.Windows.Forms.TextBox();
            this._pwtb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD:";
            // 
            // _usernametb
            // 
            this._usernametb.Location = new System.Drawing.Point(108, 6);
            this._usernametb.MaxLength = 9;
            this._usernametb.Name = "_usernametb";
            this._usernametb.Size = new System.Drawing.Size(100, 20);
            this._usernametb.TabIndex = 2;
            this._usernametb.TextChanged += new System.EventHandler(this._usernametb_TextChanged);
            // 
            // _pwtb
            // 
            this._pwtb.Location = new System.Drawing.Point(108, 50);
            this._pwtb.Name = "_pwtb";
            this._pwtb.PasswordChar = '*';
            this._pwtb.Size = new System.Drawing.Size(100, 20);
            this._pwtb.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "SIGN IN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 162);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._pwtb);
            this.Controls.Add(this._usernametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _usernametb;
        private System.Windows.Forms.TextBox _pwtb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

