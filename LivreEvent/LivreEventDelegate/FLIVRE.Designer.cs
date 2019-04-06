namespace LivreEventDelegate
{
    partial class FLIVRE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.tbPrixTTC = new System.Windows.Forms.TextBox();
            this.btnHausseAnnuelle = new System.Windows.Forms.Button();
            this.btnModifierPrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix TTC :";
            // 
            // tbTitre
            // 
            this.tbTitre.Location = new System.Drawing.Point(163, 72);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.Size = new System.Drawing.Size(100, 20);
            this.tbTitre.TabIndex = 3;
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(163, 111);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(100, 20);
            this.tbPrix.TabIndex = 4;
            // 
            // tbPrixTTC
            // 
            this.tbPrixTTC.Location = new System.Drawing.Point(163, 147);
            this.tbPrixTTC.Name = "tbPrixTTC";
            this.tbPrixTTC.Size = new System.Drawing.Size(100, 20);
            this.tbPrixTTC.TabIndex = 5;
            // 
            // btnHausseAnnuelle
            // 
            this.btnHausseAnnuelle.Location = new System.Drawing.Point(45, 218);
            this.btnHausseAnnuelle.Name = "btnHausseAnnuelle";
            this.btnHausseAnnuelle.Size = new System.Drawing.Size(75, 23);
            this.btnHausseAnnuelle.TabIndex = 6;
            this.btnHausseAnnuelle.Text = "Hausse Annuelle";
            this.btnHausseAnnuelle.UseVisualStyleBackColor = true;
            this.btnHausseAnnuelle.Click += new System.EventHandler(this.btnHausseAnnuelle_Click);
            // 
            // btnModifierPrix
            // 
            this.btnModifierPrix.Location = new System.Drawing.Point(188, 218);
            this.btnModifierPrix.Name = "btnModifierPrix";
            this.btnModifierPrix.Size = new System.Drawing.Size(75, 23);
            this.btnModifierPrix.TabIndex = 7;
            this.btnModifierPrix.Text = "Modifier prix";
            this.btnModifierPrix.UseVisualStyleBackColor = true;
            this.btnModifierPrix.Click += new System.EventHandler(this.btnModifierPrix_Click);
            // 
            // FLIVRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 327);
            this.Controls.Add(this.btnModifierPrix);
            this.Controls.Add(this.btnHausseAnnuelle);
            this.Controls.Add(this.tbPrixTTC);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.tbTitre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FLIVRE";
            this.Text = "Livre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitre;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.TextBox tbPrixTTC;
        private System.Windows.Forms.Button btnHausseAnnuelle;
        private System.Windows.Forms.Button btnModifierPrix;
    }
}