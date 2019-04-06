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
    public partial class FMAIN : Form
    {
        FLIVRE maFenetreLivre;
        FHISTORIQUE maFenetreHistorique;
        FTAUX maFenetreTaux;
        public FMAIN()
        {
            InitializeComponent();
            btnNouveauLivre.Click += btnNouveauLivre_Click;
            Livre unLivre = new Livre("Death Note", 20, 4);
            maFenetreLivre = new FLIVRE(unLivre);
            maFenetreHistorique = new FHISTORIQUE(unLivre);
            maFenetreTaux = new FTAUX(unLivre);
        }

        private void btnNouveauLivre_Click(object sender, EventArgs e)
        {
            maFenetreLivre.Show();
            maFenetreHistorique.Show();
            maFenetreTaux.Show();
        }
    }
}
