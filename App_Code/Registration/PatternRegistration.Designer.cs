namespace FYP.App_Code
{
    partial class PatternRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternRegistration));
            this.prgRedColor = new System.Windows.Forms.PictureBox();
            this.prgGreenColor = new System.Windows.Forms.PictureBox();
            this.prgBlueColor = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lvwListView = new System.Windows.Forms.ListView();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSalt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prgRedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgGreenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgBlueColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prgRedColor
            // 
            this.prgRedColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prgRedColor.BackColor = System.Drawing.Color.Red;
            this.prgRedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prgRedColor.Location = new System.Drawing.Point(343, 202);
            this.prgRedColor.Name = "prgRedColor";
            this.prgRedColor.Size = new System.Drawing.Size(108, 59);
            this.prgRedColor.TabIndex = 0;
            this.prgRedColor.TabStop = false;
            this.prgRedColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.redColor_MouseClick);
            // 
            // prgGreenColor
            // 
            this.prgGreenColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prgGreenColor.BackColor = System.Drawing.Color.Green;
            this.prgGreenColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prgGreenColor.Location = new System.Drawing.Point(504, 202);
            this.prgGreenColor.Name = "prgGreenColor";
            this.prgGreenColor.Size = new System.Drawing.Size(108, 59);
            this.prgGreenColor.TabIndex = 1;
            this.prgGreenColor.TabStop = false;
            this.prgGreenColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.greenColor_MouseClick);
            // 
            // prgBlueColor
            // 
            this.prgBlueColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prgBlueColor.BackColor = System.Drawing.Color.Blue;
            this.prgBlueColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prgBlueColor.Location = new System.Drawing.Point(679, 202);
            this.prgBlueColor.Name = "prgBlueColor";
            this.prgBlueColor.Size = new System.Drawing.Size(108, 59);
            this.prgBlueColor.TabIndex = 2;
            this.prgBlueColor.TabStop = false;
            this.prgBlueColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.blueColor_MouseClick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Location = new System.Drawing.Point(472, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(195, 33);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            this.btnSubmit.MouseHover += new System.EventHandler(this.btnSubmit_MouseHover);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblUsername.Location = new System.Drawing.Point(470, 107);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(202, 57);
            this.lblUsername.TabIndex = 26;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 53);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password";
            this.lblPassword.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(25, 79);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 29;
            this.lblX.Text = "X";
            this.lblX.Visible = false;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(25, 107);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 30;
            this.lblY.Text = "Y";
            this.lblY.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(28, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 108);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset.Location = new System.Drawing.Point(471, 422);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(195, 33);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lvwListView
            // 
            this.lvwListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwListView.Location = new System.Drawing.Point(343, 300);
            this.lvwListView.Margin = new System.Windows.Forms.Padding(0);
            this.lvwListView.Name = "lvwListView";
            this.lvwListView.Scrollable = false;
            this.lvwListView.Size = new System.Drawing.Size(444, 33);
            this.lvwListView.TabIndex = 33;
            this.lvwListView.Tag = "";
            this.lvwListView.TileSize = new System.Drawing.Size(448, 30);
            this.lvwListView.UseCompatibleStateImageBehavior = false;
            this.lvwListView.View = System.Windows.Forms.View.List;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistration.Location = new System.Drawing.Point(577, 510);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(105, 34);
            this.btnRegistration.TabIndex = 39;
            this.btnRegistration.Text = "Register";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Location = new System.Drawing.Point(460, 509);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 34);
            this.btnLogin.TabIndex = 38;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Location = new System.Drawing.Point(25, 28);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(25, 13);
            this.lblSalt.TabIndex = 40;
            this.lblSalt.Text = "Salt";
            this.lblSalt.Visible = false;
            // 
            // PatternRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1077, 567);
            this.Controls.Add(this.lblSalt);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lvwListView);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.prgBlueColor);
            this.Controls.Add(this.prgGreenColor);
            this.Controls.Add(this.prgRedColor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(1093, 606);
            this.Name = "PatternRegistration";
            this.Text = "Pattern Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.prgRedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgGreenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgBlueColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox prgRedColor;
        private System.Windows.Forms.PictureBox prgGreenColor;
        private System.Windows.Forms.PictureBox prgBlueColor;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView lvwListView;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSalt;
    }
}