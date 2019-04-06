namespace LivreEventDelegate
{
    partial class FHISTORIQUE
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
            this.lbHistoriquePrix = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbHistoriquePrix
            // 
            this.lbHistoriquePrix.FormattingEnabled = true;
            this.lbHistoriquePrix.Location = new System.Drawing.Point(46, 36);
            this.lbHistoriquePrix.Name = "lbHistoriquePrix";
            this.lbHistoriquePrix.Size = new System.Drawing.Size(231, 251);
            this.lbHistoriquePrix.TabIndex = 1;
            // 
            // FHISTORIQUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 351);
            this.Controls.Add(this.lbHistoriquePrix);
            this.Name = "FHISTORIQUE";
            this.Text = "Historique des Prix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbHistoriquePrix;
    }
}