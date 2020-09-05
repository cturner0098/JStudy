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
            this.lblReviewsAvailable = new System.Windows.Forms.Label();
            this.rtbSubjectIDs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblReviewsAvailable
            // 
            this.lblReviewsAvailable.AutoSize = true;
            this.lblReviewsAvailable.Location = new System.Drawing.Point(12, 9);
            this.lblReviewsAvailable.Name = "lblReviewsAvailable";
            this.lblReviewsAvailable.Size = new System.Drawing.Size(100, 13);
            this.lblReviewsAvailable.TabIndex = 0;
            this.lblReviewsAvailable.Text = "Reviews Available: ";
            // 
            // rtbSubjectIDs
            // 
            this.rtbSubjectIDs.Location = new System.Drawing.Point(12, 25);
            this.rtbSubjectIDs.Name = "rtbSubjectIDs";
            this.rtbSubjectIDs.Size = new System.Drawing.Size(776, 413);
            this.rtbSubjectIDs.TabIndex = 1;
            this.rtbSubjectIDs.Text = "";
            // 
            // frmWaniKani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSubjectIDs);
            this.Controls.Add(this.lblReviewsAvailable);
            this.Name = "frmWaniKani";
            this.Text = "WaniKani";
            this.Load += new System.EventHandler(this.frmWaniKani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReviewsAvailable;
        private System.Windows.Forms.RichTextBox rtbSubjectIDs;
    }
}