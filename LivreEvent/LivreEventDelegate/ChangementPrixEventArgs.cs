using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivreEventDelegate
{
    public class ChangementPrixEventArgs:EventArgs
    {
        decimal ancienPrix, hausse;
        private decimal nouveauPrix, nouveauPrixTTC;

        public ChangementPrixEventArgs(decimal ancienPrix, decimal nouveauPrix, decimal nouveauPrixTTC, decimal hausse)
        {
            this.ancienPrix = ancienPrix;
            this.nouveauPrix = nouveauPrix;
            this.nouveauPrixTTC = nouveauPrixTTC;
            this.hausse = hausse;
        }
        public decimal AncienPrix
        {
            get { return this.ancienPrix; }
        }
        public decimal NouveauPrix
        {
            get { return this.nouveauPrix; }
        }
        public decimal NouveauPrixTTC
        {
            get { return this.nouveauPrixTTC; }
        }
        public decimal Hausse
        {
            get { return this.hausse; }
        }


    }
}
