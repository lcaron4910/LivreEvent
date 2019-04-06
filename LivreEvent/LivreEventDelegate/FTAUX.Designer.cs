namespace LivreEventDelegate
{
    partial class FTAUX
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
            this.lbTaux = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTaux
            // 
            this.lbTaux.AutoSize = true;
            this.lbTaux.Location = new System.Drawing.Point(148, 130);
            this.lbTaux.Name = "lbTaux";
            this.lbTaux.Size = new System.Drawing.Size(35, 13);
            this.lbTaux.TabIndex = 0;
            this.lbTaux.Text = "label1";
            // 
            // FTAUX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 340);
            this.Controls.Add(this.lbTaux);
            this.Name = "FTAUX";
            this.Text = "Taux de Hausse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaux;
    }
}