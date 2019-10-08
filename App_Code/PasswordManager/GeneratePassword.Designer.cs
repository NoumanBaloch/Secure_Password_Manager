namespace FYP.App_Code.PasswordManager
{
    partial class GeneratePassword
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
            this.passwordLength = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sixteenDigit = new System.Windows.Forms.RadioButton();
            this.twelveDigit = new System.Windows.Forms.RadioButton();
            this.eightDigit = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mixCase = new System.Windows.Forms.RadioButton();
            this.uperCase = new System.Windows.Forms.RadioButton();
            this.lowerCase = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.specialNo = new System.Windows.Forms.RadioButton();
            this.specialYes = new System.Windows.Forms.RadioButton();
            this.btnCopyToClip = new System.Windows.Forms.Button();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnHomee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordLength
            // 
            this.passwordLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLength.AutoSize = true;
            this.passwordLength.BackColor = System.Drawing.Color.Transparent;
            this.passwordLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLength.ForeColor = System.Drawing.Color.White;
            this.passwordLength.Location = new System.Drawing.Point(55, 120);
            this.passwordLength.Name = "passwordLength";
            this.passwordLength.Size = new System.Drawing.Size(147, 20);
            this.passwordLength.TabIndex = 42;
            this.passwordLength.Text = "Password Length";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(463, 366);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(195, 33);
            this.btnGenerate.TabIndex = 38;
            this.btnGenerate.Text = "Generate and Fill";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(378, 417);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(351, 29);
            this.txtPassword.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Select The Case";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Special Characters";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.sixteenDigit);
            this.panel1.Controls.Add(this.twelveDigit);
            this.panel1.Controls.Add(this.eightDigit);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(310, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 65);
            this.panel1.TabIndex = 58;
            // 
            // sixteenDigit
            // 
            this.sixteenDigit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sixteenDigit.AutoSize = true;
            this.sixteenDigit.BackColor = System.Drawing.Color.Transparent;
            this.sixteenDigit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixteenDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixteenDigit.ForeColor = System.Drawing.Color.Black;
            this.sixteenDigit.Location = new System.Drawing.Point(329, 16);
            this.sixteenDigit.Name = "sixteenDigit";
            this.sixteenDigit.Size = new System.Drawing.Size(88, 24);
            this.sixteenDigit.TabIndex = 44;
            this.sixteenDigit.TabStop = true;
            this.sixteenDigit.Text = "16 Digit";
            this.sixteenDigit.UseVisualStyleBackColor = false;
            // 
            // twelveDigit
            // 
            this.twelveDigit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twelveDigit.AutoSize = true;
            this.twelveDigit.BackColor = System.Drawing.Color.Transparent;
            this.twelveDigit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twelveDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twelveDigit.ForeColor = System.Drawing.Color.Black;
            this.twelveDigit.Location = new System.Drawing.Point(199, 16);
            this.twelveDigit.Name = "twelveDigit";
            this.twelveDigit.Size = new System.Drawing.Size(88, 24);
            this.twelveDigit.TabIndex = 43;
            this.twelveDigit.TabStop = true;
            this.twelveDigit.Text = "12 Digit";
            this.twelveDigit.UseVisualStyleBackColor = false;
            // 
            // eightDigit
            // 
            this.eightDigit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eightDigit.AutoSize = true;
            this.eightDigit.BackColor = System.Drawing.Color.Transparent;
            this.eightDigit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightDigit.ForeColor = System.Drawing.Color.Black;
            this.eightDigit.Location = new System.Drawing.Point(40, 16);
            this.eightDigit.Name = "eightDigit";
            this.eightDigit.Size = new System.Drawing.Size(78, 24);
            this.eightDigit.TabIndex = 42;
            this.eightDigit.TabStop = true;
            this.eightDigit.Text = "8 Digit";
            this.eightDigit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.mixCase);
            this.panel2.Controls.Add(this.uperCase);
            this.panel2.Controls.Add(this.lowerCase);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(311, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 65);
            this.panel2.TabIndex = 45;
            // 
            // mixCase
            // 
            this.mixCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mixCase.AutoSize = true;
            this.mixCase.BackColor = System.Drawing.Color.Transparent;
            this.mixCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mixCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mixCase.ForeColor = System.Drawing.Color.Black;
            this.mixCase.Location = new System.Drawing.Point(198, 16);
            this.mixCase.Name = "mixCase";
            this.mixCase.Size = new System.Drawing.Size(52, 24);
            this.mixCase.TabIndex = 51;
            this.mixCase.TabStop = true;
            this.mixCase.Text = "Mix";
            this.mixCase.UseVisualStyleBackColor = false;
            // 
            // uperCase
            // 
            this.uperCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uperCase.AutoSize = true;
            this.uperCase.BackColor = System.Drawing.Color.Transparent;
            this.uperCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uperCase.ForeColor = System.Drawing.Color.Black;
            this.uperCase.Location = new System.Drawing.Point(328, 16);
            this.uperCase.Name = "uperCase";
            this.uperCase.Size = new System.Drawing.Size(106, 24);
            this.uperCase.TabIndex = 50;
            this.uperCase.TabStop = true;
            this.uperCase.Text = "UperCase";
            this.uperCase.UseVisualStyleBackColor = false;
            // 
            // lowerCase
            // 
            this.lowerCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lowerCase.AutoSize = true;
            this.lowerCase.BackColor = System.Drawing.Color.Transparent;
            this.lowerCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerCase.ForeColor = System.Drawing.Color.Black;
            this.lowerCase.Location = new System.Drawing.Point(39, 16);
            this.lowerCase.Name = "lowerCase";
            this.lowerCase.Size = new System.Drawing.Size(115, 24);
            this.lowerCase.TabIndex = 49;
            this.lowerCase.TabStop = true;
            this.lowerCase.Text = "LowerCase";
            this.lowerCase.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.specialNo);
            this.panel3.Controls.Add(this.specialYes);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(311, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 65);
            this.panel3.TabIndex = 46;
            // 
            // specialNo
            // 
            this.specialNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialNo.AutoSize = true;
            this.specialNo.BackColor = System.Drawing.Color.Transparent;
            this.specialNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialNo.ForeColor = System.Drawing.Color.Black;
            this.specialNo.Location = new System.Drawing.Point(328, 16);
            this.specialNo.Name = "specialNo";
            this.specialNo.Size = new System.Drawing.Size(48, 24);
            this.specialNo.TabIndex = 54;
            this.specialNo.TabStop = true;
            this.specialNo.Text = "No";
            this.specialNo.UseVisualStyleBackColor = false;
            // 
            // specialYes
            // 
            this.specialYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialYes.AutoSize = true;
            this.specialYes.BackColor = System.Drawing.Color.Transparent;
            this.specialYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialYes.ForeColor = System.Drawing.Color.Black;
            this.specialYes.Location = new System.Drawing.Point(39, 16);
            this.specialYes.Name = "specialYes";
            this.specialYes.Size = new System.Drawing.Size(57, 24);
            this.specialYes.TabIndex = 53;
            this.specialYes.TabStop = true;
            this.specialYes.Text = "Yes";
            this.specialYes.UseVisualStyleBackColor = false;
            // 
            // btnCopyToClip
            // 
            this.btnCopyToClip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyToClip.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyToClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyToClip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyToClip.ForeColor = System.Drawing.Color.White;
            this.btnCopyToClip.Location = new System.Drawing.Point(463, 466);
            this.btnCopyToClip.Name = "btnCopyToClip";
            this.btnCopyToClip.Size = new System.Drawing.Size(195, 33);
            this.btnCopyToClip.TabIndex = 60;
            this.btnCopyToClip.Text = "Copy Password";
            this.btnCopyToClip.UseVisualStyleBackColor = false;
            this.btnCopyToClip.Click += new System.EventHandler(this.CopyToClip_Click);
            // 
            // SideMenu
            // 
            this.SideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SideMenu.BackColor = System.Drawing.Color.DimGray;
            this.SideMenu.Controls.Add(this.btnLogout);
            this.SideMenu.Controls.Add(this.lbluser);
            this.SideMenu.Controls.Add(this.btnHomee);
            this.SideMenu.Location = new System.Drawing.Point(-1, 1);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(1087, 37);
            this.SideMenu.TabIndex = 61;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(871, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(197, 33);
            this.btnLogout.TabIndex = 48;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbluser
            // 
            this.lbluser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(483, 9);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(91, 20);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Username";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHomee
            // 
            this.btnHomee.BackColor = System.Drawing.Color.Transparent;
            this.btnHomee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomee.ForeColor = System.Drawing.Color.White;
            this.btnHomee.Location = new System.Drawing.Point(10, 1);
            this.btnHomee.Name = "btnHomee";
            this.btnHomee.Size = new System.Drawing.Size(197, 33);
            this.btnHomee.TabIndex = 44;
            this.btnHomee.Text = "Home";
            this.btnHomee.UseVisualStyleBackColor = false;
            this.btnHomee.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // GeneratePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1077, 567);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.btnCopyToClip);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLength);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPassword);
            this.MinimumSize = new System.Drawing.Size(1093, 606);
            this.Name = "GeneratePassword";
            this.Text = "Generate Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.SideMenu.ResumeLayout(false);
            this.SideMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLength;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton sixteenDigit;
        private System.Windows.Forms.RadioButton twelveDigit;
        private System.Windows.Forms.RadioButton eightDigit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton uperCase;
        private System.Windows.Forms.RadioButton lowerCase;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton specialNo;
        private System.Windows.Forms.RadioButton specialYes;
        private System.Windows.Forms.Button btnCopyToClip;
        private System.Windows.Forms.RadioButton mixCase;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHomee;
    }
}