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
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        bool actie; // kijkt of de paarden actief zijn of niet.
        static int paard = 0; // 0 is een NULLvalue --> als 0 is dan mag code NIET runnen
        static int munz = 0;
        static int finState = 0; // als Finance state (finState) = 0 --> Storten / als finState = 1 --> Afhalen
        private Random rng = new Random();
        private int winnaar = 0; //0 is NULLvalue --> dus het mag niet nul zijn op het ezind van het spel
        private int gok = 0;
        static int gokMunz = 0;
        static int[] finMunz = new int[900];
        static int[] finStates = new int[900];
        static int arrayTeller = 0;
        private bool isTestRun = false;

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
            if (paard != 0)
            {
                //btnBieden.Enabled = false;
                //txtGokMunz.Enabled = false;
            }
            else
            {
                btnBieden.Enabled = true;
                txtGokMunz.Enabled = true;
            }
        }

        public static void setPaard(int newPaard)
        {
            paard = newPaard;
        }

        private void btnBieden_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtGokMunz.Text, out gokMunz))
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
                if (munz < gokMunz)
                {
                    MessageBox.Show("U hebt te weinig geld. Gelieve meer te storten als u nog wilt spelen.", "Fout: tekort aan geld", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtGokMunz.Select();
                }
                else 
                {
                    frmPaardenBets frmPB = new frmPaardenBets();
                    frmPB.Show();
                    actie = true;
                    
                }
            }
        }

        private void paardActie()
        {
            if (paard != 0 && paard != 99)
            {
                gok = Convert.ToInt32(txtGokMunz.Text);
                munz = munz - Convert.ToInt32(txtGokMunz.Text);
                updateMunz();
                txtGokMunz.Text = null;
                tPaard.Interval = 100;
                tPaard.Enabled = true;
              
            }
            else if(paard == 99)
            {
                gok = 0;
                tPaard.Interval = 100;
                tPaard.Enabled = true;
            }
            else
            {
                //STOP! Hammer time!
                pctbPaard1.Image = Properties.Resources.jokky_on_horse1;
                pctbPaard2.Image = Properties.Resources.jokky_on_horse_blouw1;
                pctbPaard3.Image = Properties.Resources.jokky_on_horse_groen1;
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
            pctbPaard1.BackColor = Color.Transparent;
            pctbPaard2.Image = Properties.Resources.jokky_on_horse_blouw1;
            pctbPaard2.BackColor = Color.Transparent;
            pctbPaard3.Image = Properties.Resources.jokky_on_horse_groen1;
            pctbPaard3.BackColor = Color.Transparent;
            lblOpEerstePlaats.Visible = false;
        }

        private void informatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gemaakt door Sepp Degroote, Rein Goossens en Kieron Parmentier","Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pctbStart_Click(object sender, EventArgs e)
        {
            updateMunz();
            if (actie)
            {
                //They like to move it move it (Jpeg--> GIF)
                pctbPaard1.Image = Properties.Resources.jokky_on_horse;
                pctbPaard2.Image = Properties.Resources.jokky_on_horse_blouw;
                pctbPaard3.Image = Properties.Resources.jokky_on_horse_groen;
                paardActie();
                lblOpEerstePlaats.Visible = true;
                if (paard == 1) //If ladder die kiest welke arrow zichtbaar moet zijn
                {
                    pctbArrow1.Visible = true;
                }
                else if (paard == 2)
                {
                    pctbArrow2.Visible = true;
                }
                else if (paard == 3)
                {
                    pctbArrow3.Visible = true;
                }
                //Er zijn 3 arrows omdat dit makkelijker is + zetten pos hier al omdat dit er beter uitziet.
                pctbArrow1.Left = -30; 
                pctbArrow2.Left = -30;
                pctbArrow3.Left = -30;
            }
            else
            {
                MessageBox.Show("U moet eerst een paard selecteren om te kunnen starten.","Fout: geen paard",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void tPaard_Tick(object sender, EventArgs e)
        {
            //30 is startpos 650 is finshpos en 1000 is uitloop.

            p1Adv();
            p2Adv();
            p3Adv();
            arrowAdv();
            if (pctbPaard1.Left >= pctbPaard2.Left && pctbPaard1.Left >= pctbPaard3.Left)
            {
                lblOpEerstePlaats.Text = "Jozef staat voorop!";
            }
            else if (pctbPaard2.Left >= pctbPaard1.Left && pctbPaard2.Left >= pctbPaard3.Left)
            {
                lblOpEerstePlaats.Text = "Buttercup staat voorop!";
            }
            else if (pctbPaard3.Left >= pctbPaard1.Left && pctbPaard3.Left >= pctbPaard2.Left)
            {
                lblOpEerstePlaats.Text = "Bob staat voorop!";
            }
            if (pctbPaard1.Left >= 800 && pctbPaard2.Left >= 800 && pctbPaard3.Left >= 800)
            {
                int temp = int.MinValue;
                if(pctbPaard1.Left > temp)
                {
                    winnaar = 1;
                    temp = pctbPaard1.Left;
                    if(pctbPaard2.Left > temp)
                    {
                        winnaar = 2;
                        temp = pctbPaard2.Left;
                        if(pctbPaard3.Left > temp)
                        {
                            winnaar = 3;
                        }
                    }
                    else if(pctbPaard3.Left > temp)
                    {
                        winnaar = 3;
                    }
                }
                //STOP! Hammer time!
                pctbPaard1.Image = Properties.Resources.jokky_on_horse1;
                pctbPaard2.Image = Properties.Resources.jokky_on_horse_blouw1;
                pctbPaard3.Image = Properties.Resources.jokky_on_horse_groen1;
                pctbPaard1.Left = 30;
                pctbPaard2.Left = 30;
                pctbPaard3.Left = 30;
                tPaard.Enabled = false;
                btnBieden.Enabled = true;
                txtGokMunz.Enabled = true;
                if(paard != 99)
                {
                    if (winnaar == paard)
                    {
                        MessageBox.Show("Gefeliciteerd u hebt gewonnen!", "Gewonnen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        switch (paard)
                        {
                            case 1:
                                munz = munz + (gok * 2);
                                break;
                            case 2:
                                munz = munz + (gok * 3);
                                break;
                            case 3:
                                munz = munz + (gok * 5);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Helaas, u hebt verloren, probeer het nog een keer.", "Verloren...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Race is over","Testrace over",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                lblOpEerstePlaats.Visible = false;
                pctbArrow1.Visible = false;
                pctbArrow2.Visible = false;
                pctbArrow3.Visible = false;
                paard = 0;
                updateMunz();
                winnaar = 0;
            }
        }

        private void p1Adv()
        {
            //De snelste
            if (pctbPaard1.Left < 650)
            {
                pctbPaard1.Left = pctbPaard1.Left + Convert.ToInt32(rng.Next(1250, 3750)/100);
            }
            else if (pctbPaard1.Left >= 650 && pctbPaard1.Left < 1000)
            {
                pctbPaard1.Left = pctbPaard1.Left + 10;
            }
        }

        private void p2Adv()
        {
            //heel consequente snelheid
            if (pctbPaard2.Left < 650)
            {
                pctbPaard2.Left = pctbPaard2.Left + Convert.ToInt32(rng.Next(2000, 3250) / 100);
            }
            else if (pctbPaard2.Left >= 650 && pctbPaard1.Left < 1000)
            {
                pctbPaard2.Left = pctbPaard2.Left + 10;
            }
        }

        private void p3Adv()
        {
            //erratic
            if (pctbPaard3.Left < 650)
            {
                pctbPaard3.Left = pctbPaard3.Left + Convert.ToInt32(rng.Next(750, 4250) / 100);
            }
            else if (pctbPaard3.Left >= 650 && pctbPaard1.Left < 1000)
            {
                pctbPaard3.Left = pctbPaard3.Left + 10;
            }
        }

        private void arrowAdv()
        {
            pctbArrow1.Left = pctbPaard1.Left-60;
            pctbArrow2.Left = pctbPaard2.Left-60;
            pctbArrow3.Left = pctbPaard3.Left-60;
        }

        private void achtergrondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public static int getGokMunz() //functie voor winst berekenen in form3
        {
            return gokMunz;
        }

        public static void addFinArrs(int newFinState, int amount)
        {
            if(newFinState == 0) // als Finance state (finState) = 0 --> Storten / als finState = 1 --> Afhalen
            {
                finStates[arrayTeller] = newFinState;
                finMunz[arrayTeller] = amount;
                arrayTeller++;
            }
            else
            {
                finStates[arrayTeller] = newFinState;
                finMunz[arrayTeller] = 0 - amount;
                arrayTeller++;
            }
        }

        public static int[] getFinMunz()
        {
            return finMunz;
        }

        public static int[] getFinStates()
        {
            return finStates;
        }

        public static int getArrayTeller()
        {
            return arrayTeller;
        }

        private void overzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOverzichtFin frmOverzicht = new frmOverzichtFin();
            frmOverzicht.Show();
        }

        private void btnTestRace_Click(object sender, EventArgs e)
        {
            actie = true;
            isTestRun = true;
            paard = 99;
            //They like to move it move it (Jpeg--> GIF)
            pctbPaard1.Image = Properties.Resources.jokky_on_horse;
            pctbPaard2.Image = Properties.Resources.jokky_on_horse_blouw;
            pctbPaard3.Image = Properties.Resources.jokky_on_horse_groen;
            paardActie();
            lblOpEerstePlaats.Visible = true;
        }
    }
}
