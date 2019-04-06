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
    public partial class FTAUX : Form
    {
        public FTAUX(Livre unLivre)
        {
            InitializeComponent();
            unLivre.ChangementPrix += UnLivre_ChangementPrix;
        }

        private void UnLivre_ChangementPrix(object o, ChangementPrixEventArgs e)
        {
            lbTaux.Text = Convert.ToString(e.Hausse);
        }
    }
}
