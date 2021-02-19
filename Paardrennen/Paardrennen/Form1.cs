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
    public partial class frmPaardrennen : Form
    {
        public frmPaardrennen()
        {
            InitializeComponent();
        }
        bool actie; // kijkt of de paarden actief zijn of niet.
        static int paard = 0; // 0 is een NULLvalue --> als 0 is dan mag code NIET runnen
        static int munz = 0;
        static int finState = 0; // als Finance state (finState) = 0 --> Storten / als finState = 1 --> Afhalen
        frmFinancien frmFin = new frmFinancien();
        frmPaardenBets frmPB = new frmPaardenBets();

        private void stortenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finState = 0;
            frmFin.Show();
        }

        private void afhalenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finState = 1;
            frmFin.Show();
        }

        public static int getFinState()
        {
            return finState;
        }

        public static int getMunz()
        {
            return munz;
        }

        public static void setMunz(int newMunz)
        {
            munz = newMunz;
        }

        private void updateMunz()
        {
            lblMunz.Text = "Geld: €" + munz;
        }

        private void frmPaardrennen_Activated(object sender, EventArgs e)
        {
            updateMunz();
            if (actie)
            {
                paardActie();
            }
        }

        public static void setPaard(int newPaard)
        {
            paard = newPaard;
        }

        private void btnBieden_Click(object sender, EventArgs e)
        {
            if(txtGokMunz.Text == "")
            {
                MessageBox.Show("U moet een bedrag invullen om te kunnen bieden.", "Fout: geen input", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (munz < Convert.ToInt32(txtGokMunz.Text))
                {
                    MessageBox.Show("U hebt te weinig geld. Gelieve meer te storten als u nog wilt spelen.", "Fout: tekort aan geld", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else 
                {
                    frmPB.Show();
                    actie = true;
                }
            }
        }

        private void paardActie()
        {
            if (paard != 0)
            { 
                //CODE VOOR PAARDEN---------
                munz = munz - Convert.ToInt32(txtGokMunz.Text);
                //PH:
                    MessageBox.Show(paard + "e selectie, nu de code klaarzetten hier e, anders is't fucked");
                //EIND CODE PAARDEN---------
            }
            actie = false;
        }
    }
}
