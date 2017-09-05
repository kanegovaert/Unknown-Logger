namespace UnknownLibrary.StubSource
{
    partial class SourceCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SourceCodeForm));
            this.TB_Programcs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_Programcs
            // 
            this.TB_Programcs.Location = new System.Drawing.Point(12, 12);
            this.TB_Programcs.Multiline = true;
            this.TB_Programcs.Name = "TB_Programcs";
            this.TB_Programcs.Size = new System.Drawing.Size(773, 440);
            this.TB_Programcs.TabIndex = 0;
            this.TB_Programcs.Text = resources.GetString("TB_Programcs.Text");
            // 
            // SourceCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 464);
            this.Controls.Add(this.TB_Programcs);
            this.Name = "SourceCodeForm";
            this.ShowIcon = false;
            this.Text = "SourceCodeForm";
            this.Load += new System.EventHandler(this.SourceCodeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Programcs;
    }
}