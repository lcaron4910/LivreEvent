using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivreEventDelegate
{
    public partial class FLIVRE : Form
    {
        Livre livre;
        public FLIVRE(Livre unLivre)
        {
            InitializeComponent();
            this.livre = unLivre;
            this.livre.ChangementPrix += Livre_ChangementPrix;
            this.tbPrix.Text = livre.PrixHt.ToString();
            this.tbPrixTTC.Text = livre.PrixTTC.ToString();
            this.tbTitre.Text = livre.ToString();
            


        }

        private void Livre_ChangementPrix(object o, ChangementPrixEventArgs e)
        {
            this.tbPrix.Text = e.NouveauPrix.ToString();
            this.tbPrixTTC.Text = e.NouveauPrixTTC.ToString();
        }

        private void btnHausseAnnuelle_Click(object sender, EventArgs e)
        {
            this.livre.HausseAnnuelle();
        }

        private void btnModifierPrix_Click(object sender, EventArgs e)
        {
            this.livre.PrixHt = Convert.ToDecimal(this.tbPrix.Text);
        }
    }
}
