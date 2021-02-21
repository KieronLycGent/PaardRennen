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
        

        private void stortenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finState = 0;
            frmFinancien frmFin = new frmFinancien();
            frmFin.Show();
        }

        private void afhalenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finState = 1;
            frmFinancien frmFin = new frmFinancien();
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

            int GokMunz;
            if (!int.TryParse(txtGokMunz.Text, out GokMunz))
            {
                MessageBox.Show("U moet een geldig getal ingeven.", "Fout: geen getal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGokMunz.Select();
            }
            else if (txtGokMunz.Text == "")
            {
                MessageBox.Show("U moet een bedrag invullen om te kunnen bieden.", "Fout: geen input", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtGokMunz.Select();
            }
            else
            {
                if (munz < GokMunz)
                {
                    MessageBox.Show("U hebt te weinig geld. Gelieve meer te storten als u nog wilt spelen.", "Fout: tekort aan geld", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtGokMunz.Select();
                }
                else 
                {
                    frmPaardenBets frmPB = new frmPaardenBets();
                    frmPB.Show();
                    actie = true;
                    //Dit moet verplaatst worden naar waar de race echt start---------------
                    pctbPaard1.Image = Properties.Resources.jokky_on_horse;
                    pctbPaard2.Image = Properties.Resources.jokky_on_horse_blouw;
                    pctbPaard3.Image = Properties.Resources.jokky_on_horse_groen;
                    //Dit moet verplaatst worden naar waar de race echt start---------------
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

        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPaardrennen_Load(object sender, EventArgs e)
        {
            pctbFinish.Image = Properties.Resources.finich;
            pctbPaard1.Image = Properties.Resources.jokky_on_horse1;
            pctbPaard2.Image = Properties.Resources.jokky_on_horse_blouw1;
            pctbPaard3.Image = Properties.Resources.jokky_on_horse_groen1;
        }

        private void informatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gemaakt door Sepp Degroote en Kieron Parmentier","Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
