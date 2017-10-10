namespace Unknown_Logger
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.BTN_OpenKeyloggerForm = new MetroFramework.Controls.MetroButton();
            this.BTN_OpenFileBinderForm = new MetroFramework.Controls.MetroButton();
            this.BTN_OpenChangeLogForm = new MetroFramework.Controls.MetroButton();
            this.BTN_OpenSpooferForm = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LL_LinkToGithub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_OpenKeyloggerForm
            // 
            this.BTN_OpenKeyloggerForm.Highlight = false;
            this.BTN_OpenKeyloggerForm.Location = new System.Drawing.Point(60, 112);
            this.BTN_OpenKeyloggerForm.Name = "BTN_OpenKeyloggerForm";
            this.BTN_OpenKeyloggerForm.Size = new System.Drawing.Size(245, 59);
            this.BTN_OpenKeyloggerForm.Style = MetroFramework.MetroColorStyle.Blue;
            this.BTN_OpenKeyloggerForm.StyleManager = null;
            this.BTN_OpenKeyloggerForm.TabIndex = 0;
            this.BTN_OpenKeyloggerForm.Text = "Keylogger";
            this.BTN_OpenKeyloggerForm.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTN_OpenKeyloggerForm.Click += new System.EventHandler(this.BTN_OpenKeyloggerForm_Click);
            // 
            // BTN_OpenFileBinderForm
            // 
            this.BTN_OpenFileBinderForm.Highlight = false;
            this.BTN_OpenFileBinderForm.Location = new System.Drawing.Point(60, 186);
            this.BTN_OpenFileBinderForm.Name = "BTN_OpenFileBinderForm";
            this.BTN_OpenFileBinderForm.Size = new System.Drawing.Size(245, 59);
            this.BTN_OpenFileBinderForm.Style = MetroFramework.MetroColorStyle.Blue;
            this.BTN_OpenFileBinderForm.StyleManager = null;
            this.BTN_OpenFileBinderForm.TabIndex = 1;
            this.BTN_OpenFileBinderForm.Text = "File Binder";
            this.BTN_OpenFileBinderForm.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // BTN_OpenChangeLogForm
            // 
            this.BTN_OpenChangeLogForm.Highlight = false;
            this.BTN_OpenChangeLogForm.Location = new System.Drawing.Point(60, 334);
            this.BTN_OpenChangeLogForm.Name = "BTN_OpenChangeLogForm";
            this.BTN_OpenChangeLogForm.Size = new System.Drawing.Size(245, 59);
            this.BTN_OpenChangeLogForm.Style = MetroFramework.MetroColorStyle.Blue;
            this.BTN_OpenChangeLogForm.StyleManager = null;
            this.BTN_OpenChangeLogForm.TabIndex = 3;
            this.BTN_OpenChangeLogForm.Text = "Changelog";
            this.BTN_OpenChangeLogForm.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // BTN_OpenSpooferForm
            // 
            this.BTN_OpenSpooferForm.Highlight = false;
            this.BTN_OpenSpooferForm.Location = new System.Drawing.Point(60, 260);
            this.BTN_OpenSpooferForm.Name = "BTN_OpenSpooferForm";
            this.BTN_OpenSpooferForm.Size = new System.Drawing.Size(245, 59);
            this.BTN_OpenSpooferForm.Style = MetroFramework.MetroColorStyle.Blue;
            this.BTN_OpenSpooferForm.StyleManager = null;
            this.BTN_OpenSpooferForm.TabIndex = 2;
            this.BTN_OpenSpooferForm.Text = "Spoofer";
            this.BTN_OpenSpooferForm.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 281);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(335, 260);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "A project by: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // LL_LinkToGithub
            // 
            this.LL_LinkToGithub.AutoSize = true;
            this.LL_LinkToGithub.LinkColor = System.Drawing.Color.Gray;
            this.LL_LinkToGithub.Location = new System.Drawing.Point(456, 263);
            this.LL_LinkToGithub.Name = "LL_LinkToGithub";
            this.LL_LinkToGithub.Size = new System.Drawing.Size(96, 17);
            this.LL_LinkToGithub.TabIndex = 6;
            this.LL_LinkToGithub.TabStop = true;
            this.LL_LinkToGithub.Text = "Kane Govaert";
            this.LL_LinkToGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_LinkToGithub_LinkClicked);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 463);
            this.Controls.Add(this.LL_LinkToGithub);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_OpenChangeLogForm);
            this.Controls.Add(this.BTN_OpenSpooferForm);
            this.Controls.Add(this.BTN_OpenFileBinderForm);
            this.Controls.Add(this.BTN_OpenKeyloggerForm);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "HomeForm";
            this.Text = "Unknown Logger";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BTN_OpenKeyloggerForm;
        private MetroFramework.Controls.MetroButton BTN_OpenFileBinderForm;
        private MetroFramework.Controls.MetroButton BTN_OpenChangeLogForm;
        private MetroFramework.Controls.MetroButton BTN_OpenSpooferForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.LinkLabel LL_LinkToGithub;
    }
}

