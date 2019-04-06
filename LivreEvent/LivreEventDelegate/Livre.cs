using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivreEventDelegate
{
    public delegate void ChangementPrixPrototype(object o, ChangementPrixEventArgs e);
    public class Livre
    {
        private string titre;
        private decimal prixHt, tauxTva;
        public event ChangementPrixPrototype ChangementPrix;

        public Livre(string titre, decimal prixHt, decimal tauxTva)
        {
            this.titre = titre;
            this.prixHt = prixHt;
            this.tauxTva = tauxTva;
        }

        public decimal PrixHt
        {
            set
            {
                decimal ancienPrix = this.prixHt;
                prixHt = value;
                decimal hausse = ((prixHt - ancienPrix) / ancienPrix) * 100;
                onChangementPrix(ancienPrix, value, this.PrixTTC, hausse);
            }
            get
            {
                return prixHt;
            }
        }

        public void HausseAnnuelle()
        {
            decimal ancienPrix = this.prixHt;
            prixHt = prixHt * (decimal)1.1;
            onChangementPrix(ancienPrix, this.prixHt, this.PrixTTC, (decimal)10);
        }

        private void onChangementPrix(decimal ancienPrix, decimal nouveauPrix, decimal nouveauPrixTTC, decimal hausse)
        {
            if (ChangementPrix != null)
            {
                ChangementPrix(this, new ChangementPrixEventArgs(ancienPrix, nouveauPrix, nouveauPrixTTC, hausse));
            }
        }

        public decimal PrixTTC
        {
            get
            {
                return (1 + this.tauxTva / 100) * this.prixHt;
            }
        }

        public override string ToString()
        {
            return this.titre;
        }
    }
}
