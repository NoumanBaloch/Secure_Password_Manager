namespace FYP
{
    partial class Form2
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
            this.drpCountries = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // drpCountries
            // 
            this.drpCountries.FormattingEnabled = true;
            this.drpCountries.Location = new System.Drawing.Point(32, 58);
            this.drpCountries.Name = "drpCountries";
            this.drpCountries.Size = new System.Drawing.Size(121, 21);
            this.drpCountries.TabIndex = 0;
            this.drpCountries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.drpCountries_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.drpCountries);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox drpCountries;
    }
}