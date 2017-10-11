namespace Unknown_Logger.Forms
{
    partial class TermsofServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsofServiceForm));
            this.TB_TermsOfServiceText = new System.Windows.Forms.TextBox();
            this.BTN_Decline = new MetroFramework.Controls.MetroButton();
            this.BTN_Accept = new MetroFramework.Controls.MetroButton();
            this.CB_Agreed = new System.Windows.Forms.CheckBox();
            this.LBL_WaitTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_TermsOfServiceText
            // 
            this.TB_TermsOfServiceText.Location = new System.Drawing.Point(23, 73);
            this.TB_TermsOfServiceText.Multiline = true;
            this.TB_TermsOfServiceText.Name = "TB_TermsOfServiceText";
            this.TB_TermsOfServiceText.ReadOnly = true;
            this.TB_TermsOfServiceText.Size = new System.Drawing.Size(504, 329);
            this.TB_TermsOfServiceText.TabIndex = 0;
            this.TB_TermsOfServiceText.Text = resources.GetString("TB_TermsOfServiceText.Text");
            // 
            // BTN_Decline
            // 
            this.BTN_Decline.Highlight = false;
            this.BTN_Decline.Location = new System.Drawing.Point(402, 408);
            this.BTN_Decline.Name = "BTN_Decline";
            this.BTN_Decline.Size = new System.Drawing.Size(122, 31);
            this.BTN_Decline.Style = MetroFramework.MetroColorStyle.Blue;
            this.BTN_Decline.StyleManager = null;
            this.BTN_Decline.TabIndex = 1;
            this.BTN_Decline.Text = "Decline";
            this.BTN_Decline.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTN_Decline.Click += new System.EventHandler(this.BTN_Decline_Click);
            // 
            // BTN_Accept
            // 
            this.BTN_Accept.Highlight = false;
            this.BTN_Accept.Location = new System.Drawing.Point(274, 408);
            this.BTN_Accept.Name = "BTN_Accept";
            this.BTN_Accept.Size = new System.Drawing.Size(122, 31);
            this.BTN_Accept.Style = MetroFramework.MetroColorStyle.Blue;
            this.BTN_Accept.StyleManager = null;
            this.BTN_Accept.TabIndex = 4;
            this.BTN_Accept.Text = "Accept";
            this.BTN_Accept.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTN_Accept.Click += new System.EventHandler(this.BTN_Accept_Click);
            // 
            // CB_Agreed
            // 
            this.CB_Agreed.AutoSize = true;
            this.CB_Agreed.Location = new System.Drawing.Point(23, 408);
            this.CB_Agreed.Name = "CB_Agreed";
            this.CB_Agreed.Size = new System.Drawing.Size(214, 21);
            this.CB_Agreed.TabIndex = 5;
            this.CB_Agreed.Text = "I accept the Terms of Service";
            this.CB_Agreed.UseVisualStyleBackColor = true;
            // 
            // LBL_WaitTime
            // 
            this.LBL_WaitTime.AutoSize = true;
            this.LBL_WaitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBL_WaitTime.ForeColor = System.Drawing.Color.Red;
            this.LBL_WaitTime.Location = new System.Drawing.Point(41, 408);
            this.LBL_WaitTime.Name = "LBL_WaitTime";
            this.LBL_WaitTime.Size = new System.Drawing.Size(196, 25);
            this.LBL_WaitTime.TabIndex = 6;
            this.LBL_WaitTime.Text = "WAIT 10 SECONDS";
            // 
            // TermsofServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 459);
            this.Controls.Add(this.LBL_WaitTime);
            this.Controls.Add(this.CB_Agreed);
            this.Controls.Add(this.BTN_Accept);
            this.Controls.Add(this.BTN_Decline);
            this.Controls.Add(this.TB_TermsOfServiceText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 459);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 459);
            this.Name = "TermsofServiceForm";
            this.ShowIcon = false;
            this.Text = "Terms of Service ";
            this.Load += new System.EventHandler(this.TermsofService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_TermsOfServiceText;
        private MetroFramework.Controls.MetroButton BTN_Decline;
        private MetroFramework.Controls.MetroButton BTN_Accept;
        private System.Windows.Forms.CheckBox CB_Agreed;
        private System.Windows.Forms.Label LBL_WaitTime;
    }
}