namespace JStudy.WaniKani
{
    partial class WaniKaniLesson
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
            this.lblSlug = new System.Windows.Forms.Label();
            this.lblLessons = new System.Windows.Forms.Label();
            this.lblReading = new System.Windows.Forms.Label();
            this.lblSubjectType = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.rtbMeaningMneumonic = new System.Windows.Forms.RichTextBox();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblSlug
            // 
            this.lblSlug.AutoSize = true;
            this.lblSlug.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlug.Location = new System.Drawing.Point(12, 9);
            this.lblSlug.Name = "lblSlug";
            this.lblSlug.Size = new System.Drawing.Size(81, 37);
            this.lblSlug.TabIndex = 0;
            this.lblSlug.Text = "Slug";
            // 
            // lblLessons
            // 
            this.lblLessons.AutoSize = true;
            this.lblLessons.Location = new System.Drawing.Point(261, 33);
            this.lblLessons.Name = "lblLessons";
            this.lblLessons.Size = new System.Drawing.Size(46, 13);
            this.lblLessons.TabIndex = 1;
            this.lblLessons.Text = "Lessons";
            // 
            // lblReading
            // 
            this.lblReading.AutoSize = true;
            this.lblReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReading.Location = new System.Drawing.Point(12, 139);
            this.lblReading.Name = "lblReading";
            this.lblReading.Size = new System.Drawing.Size(171, 37);
            this.lblReading.TabIndex = 4;
            this.lblReading.Text = "lblMeaning";
            // 
            // lblSubjectType
            // 
            this.lblSubjectType.AutoSize = true;
            this.lblSubjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectType.Location = new System.Drawing.Point(240, 9);
            this.lblSubjectType.Name = "lblSubjectType";
            this.lblSubjectType.Size = new System.Drawing.Size(67, 13);
            this.lblSubjectType.TabIndex = 5;
            this.lblSubjectType.Text = "SubjectType";
            this.lblSubjectType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(12, 272);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(295, 23);
            this.Next.TabIndex = 6;
            this.Next.Text = "btnNext";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // rtbMeaningMneumonic
            // 
            this.rtbMeaningMneumonic.Location = new System.Drawing.Point(12, 49);
            this.rtbMeaningMneumonic.Name = "rtbMeaningMneumonic";
            this.rtbMeaningMneumonic.Size = new System.Drawing.Size(295, 87);
            this.rtbMeaningMneumonic.TabIndex = 7;
            this.rtbMeaningMneumonic.Text = "";
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(12, 179);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(295, 87);
            this.rtb.TabIndex = 8;
            this.rtb.Text = "";
            // 
            // WaniKaniLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 304);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.rtbMeaningMneumonic);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.lblSubjectType);
            this.Controls.Add(this.lblReading);
            this.Controls.Add(this.lblLessons);
            this.Controls.Add(this.lblSlug);
            this.Name = "WaniKaniLesson";
            this.Text = "WaniKani Lesson";
            this.Load += new System.EventHandler(this.frmWKLesson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSlug;
        private System.Windows.Forms.Label lblLessons;
        private System.Windows.Forms.Label lblReading;
        private System.Windows.Forms.Label lblSubjectType;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.RichTextBox rtbMeaningMneumonic;
        private System.Windows.Forms.RichTextBox rtb;
    }
}