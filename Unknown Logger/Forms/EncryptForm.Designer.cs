namespace Unknown_Logger.Forms
{
    partial class EncryptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptForm));
            this.BTN_GetFileLocation = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TB_FileLocation = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BTN_GenerateEncryptionKey = new System.Windows.Forms.Button();
            this.BTN_EncryptionKey = new System.Windows.Forms.TextBox();
            this.BTN_EncryptFile = new System.Windows.Forms.Button();
            this.TB_NewName = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // BTN_GetFileLocation
            // 
            this.BTN_GetFileLocation.Location = new System.Drawing.Point(472, 134);
            this.BTN_GetFileLocation.Name = "BTN_GetFileLocation";
            this.BTN_GetFileLocation.Size = new System.Drawing.Size(52, 23);
            this.BTN_GetFileLocation.TabIndex = 7;
            this.BTN_GetFileLocation.Text = "[...]";
            this.BTN_GetFileLocation.UseVisualStyleBackColor = true;
            this.BTN_GetFileLocation.Click += new System.EventHandler(this.BTN_GetFileLocation_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(29, 134);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 24);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "File:";
            // 
            // TB_FileLocation
            // 
            this.TB_FileLocation.Location = new System.Drawing.Point(243, 134);
            this.TB_FileLocation.Name = "TB_FileLocation";
            this.TB_FileLocation.Size = new System.Drawing.Size(222, 22);
            this.TB_FileLocation.TabIndex = 5;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(33, 182);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(140, 24);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Encryption Key:";
            // 
            // BTN_GenerateEncryptionKey
            // 
            this.BTN_GenerateEncryptionKey.Location = new System.Drawing.Point(472, 179);
            this.BTN_GenerateEncryptionKey.Name = "BTN_GenerateEncryptionKey";
            this.BTN_GenerateEncryptionKey.Size = new System.Drawing.Size(88, 32);
            this.BTN_GenerateEncryptionKey.TabIndex = 10;
            this.BTN_GenerateEncryptionKey.Text = "Generate";
            this.BTN_GenerateEncryptionKey.UseVisualStyleBackColor = true;
            // 
            // BTN_EncryptionKey
            // 
            this.BTN_EncryptionKey.Location = new System.Drawing.Point(243, 184);
            this.BTN_EncryptionKey.Name = "BTN_EncryptionKey";
            this.BTN_EncryptionKey.Size = new System.Drawing.Size(222, 22);
            this.BTN_EncryptionKey.TabIndex = 9;
            // 
            // BTN_EncryptFile
            // 
            this.BTN_EncryptFile.Location = new System.Drawing.Point(416, 270);
            this.BTN_EncryptFile.Name = "BTN_EncryptFile";
            this.BTN_EncryptFile.Size = new System.Drawing.Size(144, 33);
            this.BTN_EncryptFile.TabIndex = 11;
            this.BTN_EncryptFile.Text = "Encrypt";
            this.BTN_EncryptFile.UseVisualStyleBackColor = true;
            // 
            // TB_NewName
            // 
            this.TB_NewName.Location = new System.Drawing.Point(243, 225);
            this.TB_NewName.Name = "TB_NewName";
            this.TB_NewName.Size = new System.Drawing.Size(222, 22);
            this.TB_NewName.TabIndex = 13;
            this.TB_NewName.Text = "Unknown Logger Stub Encrypted";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(33, 223);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(109, 24);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "New Name:";
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 316);
            this.Controls.Add(this.TB_NewName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.BTN_EncryptFile);
            this.Controls.Add(this.BTN_GenerateEncryptionKey);
            this.Controls.Add(this.BTN_EncryptionKey);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.BTN_GetFileLocation);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TB_FileLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximumSize = new System.Drawing.Size(602, 316);
            this.MinimumSize = new System.Drawing.Size(602, 316);
            this.Name = "EncryptForm";
            this.Text = "Encrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_GetFileLocation;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox TB_FileLocation;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button BTN_GenerateEncryptionKey;
        private System.Windows.Forms.TextBox BTN_EncryptionKey;
        private System.Windows.Forms.Button BTN_EncryptFile;
        private System.Windows.Forms.TextBox TB_NewName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}