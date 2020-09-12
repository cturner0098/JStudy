namespace JStudy
{
    partial class frmMain
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
            this.btnWaniKani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWaniKani
            // 
            this.btnWaniKani.Location = new System.Drawing.Point(12, 12);
            this.btnWaniKani.Name = "btnWaniKani";
            this.btnWaniKani.Size = new System.Drawing.Size(162, 23);
            this.btnWaniKani.TabIndex = 0;
            this.btnWaniKani.Text = "WaniKani";
            this.btnWaniKani.UseVisualStyleBackColor = true;
            this.btnWaniKani.Click += new System.EventHandler(this.btnWaniKani_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 45);
            this.Controls.Add(this.btnWaniKani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "JLearn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWaniKani;
    }
}

