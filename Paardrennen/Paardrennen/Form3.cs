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
            this.Close();
        }

        private void frmPaardenBets_Load(object sender, EventArgs e)
        {
            lblDescP1.Text = "Heeft een hogere " + Environment.NewLine + "topsnelheid.";
            lblDescP2.Text = "Niet de snelste " + Environment.NewLine + "maar een goed " + Environment.NewLine + "uithoudingsvermogen.";
            lblDescP3.Text = "De snelheid hangt af " + Environment.NewLine + "van de dag die hij " + Environment.NewLine + "gehad heeft.";
            pctbP1Select.Image = Properties.Resources.jokky_on_horse;
            pctbP2Select.Image = Properties.Resources.jokky_on_horse_blouw;
            pctbP3Select.Image = Properties.Resources.jokky_on_horse_groen;
            double winst1 = frmPaardrennen.getGokMunz() * 2;
            double winst2 = frmPaardrennen.getGokMunz() * 3;
            double winst3 = frmPaardrennen.getGokMunz() * 5;
            lblWinstP1.Text = "Winst: " + winst1.ToString() + ".";
            lblWinstP2.Text = "Winst: " + winst2.ToString() + ".";
            lblWinstP3.Text = "Winst: " + winst3.ToString() + ".";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
