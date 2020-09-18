namespace JStudy.WaniKani
{
    partial class frmWKSettings
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
            this.lblStudyType = new System.Windows.Forms.Label();
            this.clbStudyTypes = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.lblAPIKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudyType
            // 
            this.lblStudyType.AutoSize = true;
            this.lblStudyType.Location = new System.Drawing.Point(12, 9);
            this.lblStudyType.Name = "lblStudyType";
            this.lblStudyType.Size = new System.Drawing.Size(66, 13);
            this.lblStudyType.TabIndex = 0;
            this.lblStudyType.Text = "Study Types";
            // 
            // clbStudyTypes
            // 
            this.clbStudyTypes.FormattingEnabled = true;
            this.clbStudyTypes.Items.AddRange(new object[] {
            "Radical",
            "Kanji",
            "Vocabulary"});
            this.clbStudyTypes.Location = new System.Drawing.Point(12, 25);
            this.clbStudyTypes.Name = "clbStudyTypes";
            this.clbStudyTypes.Size = new System.Drawing.Size(182, 49);
            this.clbStudyTypes.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(12, 93);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(182, 20);
            this.txtAPIKey.TabIndex = 3;
            // 
            // lblAPIKey
            // 
            this.lblAPIKey.AutoSize = true;
            this.lblAPIKey.Location = new System.Drawing.Point(12, 77);
            this.lblAPIKey.Name = "lblAPIKey";
            this.lblAPIKey.Size = new System.Drawing.Size(45, 13);
            this.lblAPIKey.TabIndex = 4;
            this.lblAPIKey.Text = "API Key";
            // 
            // frmWKSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 148);
            this.Controls.Add(this.lblAPIKey);
            this.Controls.Add(this.txtAPIKey);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.clbStudyTypes);
            this.Controls.Add(this.lblStudyType);
            this.Name = "frmWKSettings";
            this.Text = "WK Settings";
            this.Load += new System.EventHandler(this.frmWKSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudyType;
        private System.Windows.Forms.CheckedListBox clbStudyTypes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Label lblAPIKey;
    }
}