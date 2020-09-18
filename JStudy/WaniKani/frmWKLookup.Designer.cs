namespace JStudy.WaniKani
{
    partial class frmWKLookup
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
            this.lblCharacter = new System.Windows.Forms.Label();
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblCharacterSlug = new System.Windows.Forms.Label();
            this.lblMeanings = new System.Windows.Forms.Label();
            this.rtbJson = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Location = new System.Drawing.Point(13, 13);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(72, 13);
            this.lblCharacter.TabIndex = 0;
            this.lblCharacter.Text = "Character/ID:";
            // 
            // txtCharacter
            // 
            this.txtCharacter.Location = new System.Drawing.Point(91, 10);
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.Size = new System.Drawing.Size(195, 20);
            this.txtCharacter.TabIndex = 1;
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(211, 36);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(75, 23);
            this.btnLookup.TabIndex = 2;
            this.btnLookup.Text = "Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 71);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID: ";
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(13, 94);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(41, 13);
            this.lblObject.TabIndex = 4;
            this.lblObject.Text = "Object:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(13, 117);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(36, 13);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Level:";
            // 
            // lblCharacterSlug
            // 
            this.lblCharacterSlug.AutoSize = true;
            this.lblCharacterSlug.Location = new System.Drawing.Point(13, 140);
            this.lblCharacterSlug.Name = "lblCharacterSlug";
            this.lblCharacterSlug.Size = new System.Drawing.Size(56, 13);
            this.lblCharacterSlug.TabIndex = 6;
            this.lblCharacterSlug.Text = "Character:";
            // 
            // lblMeanings
            // 
            this.lblMeanings.AutoSize = true;
            this.lblMeanings.Location = new System.Drawing.Point(13, 163);
            this.lblMeanings.Name = "lblMeanings";
            this.lblMeanings.Size = new System.Drawing.Size(56, 13);
            this.lblMeanings.TabIndex = 7;
            this.lblMeanings.Text = "Meanings:";
            // 
            // rtbJson
            // 
            this.rtbJson.Location = new System.Drawing.Point(16, 179);
            this.rtbJson.Name = "rtbJson";
            this.rtbJson.Size = new System.Drawing.Size(270, 259);
            this.rtbJson.TabIndex = 8;
            this.rtbJson.Text = "";
            // 
            // frmWKLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.rtbJson);
            this.Controls.Add(this.lblMeanings);
            this.Controls.Add(this.lblCharacterSlug);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblObject);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.txtCharacter);
            this.Controls.Add(this.lblCharacter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmWKLookup";
            this.Text = "frmWKLookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblCharacterSlug;
        private System.Windows.Forms.Label lblMeanings;
        private System.Windows.Forms.RichTextBox rtbJson;
    }
}