namespace FYP.App_Code
{
    partial class PatternLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternLogin));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.blueColor = new System.Windows.Forms.PictureBox();
            this.greenColor = new System.Windows.Forms.PictureBox();
            this.redColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blueColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Location = new System.Drawing.Point(477, 366);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(195, 33);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "Verify";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            this.btnSubmit.MouseHover += new System.EventHandler(this.btnSubmit_MouseHover);
            // 
            // blueColor
            // 
            this.blueColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blueColor.BackColor = System.Drawing.Color.Blue;
            this.blueColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blueColor.Location = new System.Drawing.Point(683, 199);
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(108, 59);
            this.blueColor.TabIndex = 30;
            this.blueColor.TabStop = false;
            this.blueColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BlueColor_MouseClick);
            // 
            // greenColor
            // 
            this.greenColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.greenColor.BackColor = System.Drawing.Color.Green;
            this.greenColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.greenColor.Location = new System.Drawing.Point(516, 199);
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(108, 59);
            this.greenColor.TabIndex = 29;
            this.greenColor.TabStop = false;
            this.greenColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GreenColor_MouseClick);
            // 
            // redColor
            // 
            this.redColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.redColor.BackColor = System.Drawing.Color.Red;
            this.redColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.redColor.Location = new System.Drawing.Point(347, 199);
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(108, 59);
            this.redColor.TabIndex = 28;
            this.redColor.TabStop = false;
            this.redColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RedColor_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(470, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 57);
            this.label1.TabIndex = 32;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView.Location = new System.Drawing.Point(347, 294);
            this.listView.Name = "listView";
            this.listView.Scrollable = false;
            this.listView.Size = new System.Drawing.Size(444, 34);
            this.listView.TabIndex = 34;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset.Location = new System.Drawing.Point(477, 405);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(195, 33);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReg.BackColor = System.Drawing.Color.Transparent;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnReg.Location = new System.Drawing.Point(580, 522);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(105, 34);
            this.btnReg.TabIndex = 39;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Location = new System.Drawing.Point(463, 521);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 34);
            this.btnLogin.TabIndex = 38;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // PatternLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1077, 567);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.blueColor);
            this.Controls.Add(this.greenColor);
            this.Controls.Add(this.redColor);
            this.MinimumSize = new System.Drawing.Size(1093, 606);
            this.Name = "PatternLogin";
            this.Text = "Pattern Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.blueColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox blueColor;
        private System.Windows.Forms.PictureBox greenColor;
        private System.Windows.Forms.PictureBox redColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnLogin;
    }
}