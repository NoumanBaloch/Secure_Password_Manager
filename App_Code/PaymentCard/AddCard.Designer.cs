namespace FYP.App_Code.PaymentCard
{
    partial class AddCard
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
            this.Pannel = new System.Windows.Forms.Panel();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.btnAddPaymentCard = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.Pannel.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pannel
            // 
            this.Pannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Pannel.Controls.Add(this.dtpExpirationDate);
            this.Pannel.Controls.Add(this.dtpStartDate);
            this.Pannel.Controls.Add(this.txtSecurityCode);
            this.Pannel.Controls.Add(this.lblStartDate);
            this.Pannel.Controls.Add(this.lblExpirationDate);
            this.Pannel.Controls.Add(this.lblSecurityCode);
            this.Pannel.Controls.Add(this.btnAddPaymentCard);
            this.Pannel.Controls.Add(this.txtNote);
            this.Pannel.Controls.Add(this.txtType);
            this.Pannel.Controls.Add(this.txtNumber);
            this.Pannel.Controls.Add(this.txtNameOnCard);
            this.Pannel.Controls.Add(this.label5);
            this.Pannel.Controls.Add(this.lblType);
            this.Pannel.Controls.Add(this.lblNumber);
            this.Pannel.Controls.Add(this.lblNameOnCard);
            this.Pannel.Location = new System.Drawing.Point(42, 56);
            this.Pannel.Name = "Pannel";
            this.Pannel.Size = new System.Drawing.Size(973, 499);
            this.Pannel.TabIndex = 44;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.CustomFormat = "MMMM dd, yyyy - dddd";
            this.dtpExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDate.Location = new System.Drawing.Point(19, 341);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(420, 26);
            this.dtpExpirationDate.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMMM dd, yyyy - dddd";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(20, 239);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(420, 26);
            this.dtpStartDate.TabIndex = 3;
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecurityCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityCode.Location = new System.Drawing.Point(530, 145);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.Size = new System.Drawing.Size(420, 26);
            this.txtSecurityCode.TabIndex = 6;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(15, 216);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(93, 20);
            this.lblStartDate.TabIndex = 67;
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.ForeColor = System.Drawing.Color.White;
            this.lblExpirationDate.Location = new System.Drawing.Point(19, 318);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(133, 20);
            this.lblExpirationDate.TabIndex = 66;
            this.lblExpirationDate.Text = "Expiration Date";
            this.lblExpirationDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSecurityCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityCode.ForeColor = System.Drawing.Color.White;
            this.lblSecurityCode.Location = new System.Drawing.Point(526, 122);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(121, 20);
            this.lblSecurityCode.TabIndex = 65;
            this.lblSecurityCode.Text = "Security Code";
            this.lblSecurityCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddPaymentCard
            // 
            this.btnAddPaymentCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPaymentCard.BackColor = System.Drawing.Color.Gray;
            this.btnAddPaymentCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPaymentCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPaymentCard.ForeColor = System.Drawing.Color.White;
            this.btnAddPaymentCard.Location = new System.Drawing.Point(753, 435);
            this.btnAddPaymentCard.Name = "btnAddPaymentCard";
            this.btnAddPaymentCard.Size = new System.Drawing.Size(197, 33);
            this.btnAddPaymentCard.TabIndex = 8;
            this.btnAddPaymentCard.Text = "Add Payment Card";
            this.btnAddPaymentCard.UseVisualStyleBackColor = false;
            this.btnAddPaymentCard.Click += new System.EventHandler(this.btnAddPaymentCard_Click);
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(530, 239);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(420, 153);
            this.txtNote.TabIndex = 7;
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(530, 44);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(420, 26);
            this.txtType.TabIndex = 5;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(23, 145);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(418, 26);
            this.txtNumber.TabIndex = 2;
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOnCard.Location = new System.Drawing.Point(19, 44);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(420, 26);
            this.txtNameOnCard.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(526, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Note";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(526, 11);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 56;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(19, 122);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(71, 20);
            this.lblNumber.TabIndex = 55;
            this.lblNumber.Text = "Number";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.BackColor = System.Drawing.Color.Transparent;
            this.lblNameOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnCard.ForeColor = System.Drawing.Color.White;
            this.lblNameOnCard.Location = new System.Drawing.Point(15, 11);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(123, 20);
            this.lblNameOnCard.TabIndex = 54;
            this.lblNameOnCard.Text = "Name on Card";
            this.lblNameOnCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SideMenu
            // 
            this.SideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SideMenu.BackColor = System.Drawing.Color.DimGray;
            this.SideMenu.Controls.Add(this.btnLogout);
            this.SideMenu.Controls.Add(this.lbluser);
            this.SideMenu.Controls.Add(this.btnHome);
            this.SideMenu.Location = new System.Drawing.Point(-6, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(1087, 37);
            this.SideMenu.TabIndex = 45;
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
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(10, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(197, 33);
            this.btnHome.TabIndex = 44;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.Gray;
            this.lblID.Location = new System.Drawing.Point(1, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 46;
            this.lblID.Visible = false;
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1077, 567);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.Pannel);
            this.MinimumSize = new System.Drawing.Size(1093, 606);
            this.Name = "AddCard";
            this.Text = "Add Card";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Pannel.ResumeLayout(false);
            this.Pannel.PerformLayout();
            this.SideMenu.ResumeLayout(false);
            this.SideMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pannel;
        private System.Windows.Forms.Button btnAddPaymentCard;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblSecurityCode;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtSecurityCode;
    }
}