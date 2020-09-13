namespace JStudy.WaniKani
{
    partial class frmWaniKani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWaniKani));
            this.lblReviewsAvailable = new System.Windows.Forms.Label();
            this.lblSlug = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.txtReading = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.lblReviews = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReviewsAvailable
            // 
            resources.ApplyResources(this.lblReviewsAvailable, "lblReviewsAvailable");
            this.lblReviewsAvailable.Name = "lblReviewsAvailable";
            // 
            // lblSlug
            // 
            resources.ApplyResources(this.lblSlug, "lblSlug");
            this.lblSlug.Name = "lblSlug";
            // 
            // txtMeaning
            // 
            resources.ApplyResources(this.txtMeaning, "txtMeaning");
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Enter += new System.EventHandler(this.txtMeaning_Enter);
            // 
            // txtReading
            // 
            resources.ApplyResources(this.txtReading, "txtReading");
            this.txtReading.Name = "txtReading";
            this.txtReading.Enter += new System.EventHandler(this.txtReading_Enter);
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnShowAnswer
            // 
            resources.ApplyResources(this.btnShowAnswer, "btnShowAnswer");
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // lblReviews
            // 
            resources.ApplyResources(this.lblReviews, "lblReviews");
            this.lblReviews.Name = "lblReviews";
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmWaniKani
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblReviews);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReading);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.lblSlug);
            this.Controls.Add(this.lblReviewsAvailable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmWaniKani";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWaniKani_FormClosing);
            this.Load += new System.EventHandler(this.frmWaniKani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReviewsAvailable;
        private System.Windows.Forms.Label lblSlug;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.TextBox txtReading;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Label lblReviews;
        private System.Windows.Forms.Button btnSettings;
    }
}