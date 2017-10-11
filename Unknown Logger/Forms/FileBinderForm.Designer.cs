namespace Unknown_Logger.Forms
{
    partial class FileBinderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileBinderForm));
            this.TB_FileOneLocation = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TB_FileTwoLocation = new System.Windows.Forms.TextBox();
            this.BTN_GetFileLocationOne = new System.Windows.Forms.Button();
            this.BTN_GetFileLocationTwo = new System.Windows.Forms.Button();
            this.BTN_GetIconLocation = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TB_IconLocation = new System.Windows.Forms.TextBox();
            this.BTN_BindFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_FileOneLocation
            // 
            this.TB_FileOneLocation.Location = new System.Drawing.Point(237, 129);
            this.TB_FileOneLocation.Name = "TB_FileOneLocation";
            this.TB_FileOneLocation.Size = new System.Drawing.Size(222, 22);
            this.TB_FileOneLocation.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 129);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "File one:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(23, 163);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(82, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "File two:";
            // 
            // TB_FileTwoLocation
            // 
            this.TB_FileTwoLocation.Location = new System.Drawing.Point(237, 163);
            this.TB_FileTwoLocation.Name = "TB_FileTwoLocation";
            this.TB_FileTwoLocation.Size = new System.Drawing.Size(222, 22);
            this.TB_FileTwoLocation.TabIndex = 2;
            // 
            // BTN_GetFileLocationOne
            // 
            this.BTN_GetFileLocationOne.Location = new System.Drawing.Point(466, 129);
            this.BTN_GetFileLocationOne.Name = "BTN_GetFileLocationOne";
            this.BTN_GetFileLocationOne.Size = new System.Drawing.Size(52, 23);
            this.BTN_GetFileLocationOne.TabIndex = 4;
            this.BTN_GetFileLocationOne.Text = "[...]";
            this.BTN_GetFileLocationOne.UseVisualStyleBackColor = true;
            this.BTN_GetFileLocationOne.Click += new System.EventHandler(this.BTN_GetFileLocationOne_Click);
            // 
            // BTN_GetFileLocationTwo
            // 
            this.BTN_GetFileLocationTwo.Location = new System.Drawing.Point(466, 162);
            this.BTN_GetFileLocationTwo.Name = "BTN_GetFileLocationTwo";
            this.BTN_GetFileLocationTwo.Size = new System.Drawing.Size(52, 23);
            this.BTN_GetFileLocationTwo.TabIndex = 5;
            this.BTN_GetFileLocationTwo.Text = "[...]";
            this.BTN_GetFileLocationTwo.UseVisualStyleBackColor = true;
            this.BTN_GetFileLocationTwo.Click += new System.EventHandler(this.BTN_GetFileLocationTwo_Click);
            // 
            // BTN_GetIconLocation
            // 
            this.BTN_GetIconLocation.Location = new System.Drawing.Point(466, 197);
            this.BTN_GetIconLocation.Name = "BTN_GetIconLocation";
            this.BTN_GetIconLocation.Size = new System.Drawing.Size(52, 23);
            this.BTN_GetIconLocation.TabIndex = 8;
            this.BTN_GetIconLocation.Text = "[...]";
            this.BTN_GetIconLocation.UseVisualStyleBackColor = true;
            this.BTN_GetIconLocation.Click += new System.EventHandler(this.BTN_GetIconLocation_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(23, 198);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(87, 24);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "File Icon:";
            // 
            // TB_IconLocation
            // 
            this.TB_IconLocation.Location = new System.Drawing.Point(237, 198);
            this.TB_IconLocation.Name = "TB_IconLocation";
            this.TB_IconLocation.Size = new System.Drawing.Size(222, 22);
            this.TB_IconLocation.TabIndex = 6;
            // 
            // BTN_BindFiles
            // 
            this.BTN_BindFiles.Location = new System.Drawing.Point(423, 251);
            this.BTN_BindFiles.Name = "BTN_BindFiles";
            this.BTN_BindFiles.Size = new System.Drawing.Size(158, 35);
            this.BTN_BindFiles.TabIndex = 9;
            this.BTN_BindFiles.Text = "Bind";
            this.BTN_BindFiles.UseVisualStyleBackColor = true;
            // 
            // FileBinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 309);
            this.Controls.Add(this.BTN_BindFiles);
            this.Controls.Add(this.BTN_GetIconLocation);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.TB_IconLocation);
            this.Controls.Add(this.BTN_GetFileLocationTwo);
            this.Controls.Add(this.BTN_GetFileLocationOne);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.TB_FileTwoLocation);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TB_FileOneLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximumSize = new System.Drawing.Size(604, 309);
            this.MinimumSize = new System.Drawing.Size(604, 309);
            this.Name = "FileBinderForm";
            this.ShowIcon = false;
            this.Text = "File Binder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_FileOneLocation;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox TB_FileTwoLocation;
        private System.Windows.Forms.Button BTN_GetFileLocationOne;
        private System.Windows.Forms.Button BTN_GetFileLocationTwo;
        private System.Windows.Forms.Button BTN_GetIconLocation;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox TB_IconLocation;
        private System.Windows.Forms.Button BTN_BindFiles;
    }
}