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
    public partial class FHISTORIQUE : Form
    {
        public FHISTORIQUE(Livre unLivre)
        {
            InitializeComponent();
            unLivre.ChangementPrix += UnLivre_ChangementPrix;
        }

        private void UnLivre_ChangementPrix(object o, ChangementPrixEventArgs e)
        {
            lbHistoriquePrix.Items.Add(e.NouveauPrix);
        }
    }
}
