namespace JStudy.WaniKani
{
    partial class WaniKaniSetting
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
            this.components = new System.ComponentModel.Container();
            this.lblStudyType = new System.Windows.Forms.Label();
            this.clbStudyTypes = new System.Windows.Forms.CheckedListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.lblAPIKey = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rdbReviews = new System.Windows.Forms.RadioButton();
            this.rdbLessons = new System.Windows.Forms.RadioButton();
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
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 142);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(182, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(12, 116);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(182, 20);
            this.txtAPIKey.TabIndex = 3;
            // 
            // lblAPIKey
            // 
            this.lblAPIKey.AutoSize = true;
            this.lblAPIKey.Location = new System.Drawing.Point(12, 100);
            this.lblAPIKey.Name = "lblAPIKey";
            this.lblAPIKey.Size = new System.Drawing.Size(45, 13);
            this.lblAPIKey.TabIndex = 4;
            this.lblAPIKey.Text = "API Key";
            // 
            // rdbReviews
            // 
            this.rdbReviews.AutoSize = true;
            this.rdbReviews.Location = new System.Drawing.Point(15, 80);
            this.rdbReviews.Name = "rdbReviews";
            this.rdbReviews.Size = new System.Drawing.Size(66, 17);
            this.rdbReviews.TabIndex = 5;
            this.rdbReviews.TabStop = true;
            this.rdbReviews.Text = "Reviews";
            this.rdbReviews.UseVisualStyleBackColor = true;
            // 
            // rdbLessons
            // 
            this.rdbLessons.AutoSize = true;
            this.rdbLessons.Location = new System.Drawing.Point(130, 80);
            this.rdbLessons.Name = "rdbLessons";
            this.rdbLessons.Size = new System.Drawing.Size(64, 17);
            this.rdbLessons.TabIndex = 6;
            this.rdbLessons.TabStop = true;
            this.rdbLessons.Text = "Lessons";
            this.rdbLessons.UseVisualStyleBackColor = true;
            // 
            // WaniKaniSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 173);
            this.Controls.Add(this.rdbLessons);
            this.Controls.Add(this.rdbReviews);
            this.Controls.Add(this.lblAPIKey);
            this.Controls.Add(this.txtAPIKey);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.clbStudyTypes);
            this.Controls.Add(this.lblStudyType);
            this.Name = "WaniKaniSetting";
            this.Text = "WK Settings";
            this.Load += new System.EventHandler(this.frmWKSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudyType;
        private System.Windows.Forms.CheckedListBox clbStudyTypes;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Label lblAPIKey;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rdbReviews;
        private System.Windows.Forms.RadioButton rdbLessons;
    }
}