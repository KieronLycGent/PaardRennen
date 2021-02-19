using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paardrennen
{
    public partial class frmPaardenBets : Form
    {
        public frmPaardenBets()
        {
            InitializeComponent();
        }

        int paard;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            paard = 0;
            select();
        }

        private void pctbP1Select_Click(object sender, EventArgs e)
        {
            paard = 1;
            select();
        }

        private void pctbP2Select_Click(object sender, EventArgs e)
        {
            paard = 2;
            select();
        }

        private void pctbP3Select_Click(object sender, EventArgs e)
        {
            paard = 3;
            select();
        }

        private void select()
        {
            frmPaardrennen.setPaard(paard);
            this.Hide();
        }
    }
}
