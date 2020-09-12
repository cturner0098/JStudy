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
            this.lblSlug = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.txtReading = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReviewsAvailable
            // 
            this.lblReviewsAvailable.AutoSize = true;
            this.lblReviewsAvailable.Location = new System.Drawing.Point(20, 152);
            this.lblReviewsAvailable.Name = "lblReviewsAvailable";
            this.lblReviewsAvailable.Size = new System.Drawing.Size(135, 13);
            this.lblReviewsAvailable.TabIndex = 0;
            this.lblReviewsAvailable.Text = "Reviews Available (Kanji):  ";
            // 
            // lblSlug
            // 
            this.lblSlug.AutoSize = true;
            this.lblSlug.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlug.Location = new System.Drawing.Point(12, 9);
            this.lblSlug.Name = "lblSlug";
            this.lblSlug.Size = new System.Drawing.Size(186, 62);
            this.lblSlug.TabIndex = 1;
            this.lblSlug.Text = "lblSlug";
            this.lblSlug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMeaning
            // 
            this.txtMeaning.Location = new System.Drawing.Point(23, 74);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(175, 20);
            this.txtMeaning.TabIndex = 2;
            // 
            // txtReading
            // 
            this.txtReading.Location = new System.Drawing.Point(23, 100);
            this.txtReading.Name = "txtReading";
            this.txtReading.Size = new System.Drawing.Size(175, 20);
            this.txtReading.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(23, 126);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(175, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmWaniKani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 176);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReading);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.lblSlug);
            this.Controls.Add(this.lblReviewsAvailable);
            this.Name = "frmWaniKani";
            this.Text = "WaniKani";
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
    }
}