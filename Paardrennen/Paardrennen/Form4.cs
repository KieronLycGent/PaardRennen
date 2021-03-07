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
    public partial class frmOverzichtFin : Form
    {
        public frmOverzichtFin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int[] finMunz;
        private int[] finStates;
        int arrayTeller;
        int totaal = 0;
        int color;//Variabele voor de kleur
        private void frmOverzichtFin_Load(object sender, EventArgs e)
        {
            finMunz = frmPaardrennen.getFinMunz();
            finStates = frmPaardrennen.getFinStates();
            arrayTeller = frmPaardrennen.getArrayTeller();
            for(int i = 0; i < arrayTeller; i++)
            {
                if (finStates[i] == 0)// als Finance state (finState) = 0 --> Storten / als finState = 1 --> Afhalen
                {
                    lbxFinState.Items.Add("Gestort");

                }
                else if(finStates[i] == 1)
                {
                    lbxFinState.Items.Add("Afgehaald");

                }
                lbxAantal.Items.Add(finMunz[i]);
                totaal = totaal + finMunz[i];
            }
        }
        
        private void frmOverzichtFin_Activated(object sender, EventArgs e)
        {
            lblTotaal.Text = "Totaal gespendeerd: "+Environment.NewLine+"€"+totaal;
            color = frmPaardrennen.getColor();
            switch (color)
            {
                case 1:
                    BackColor = Color.Green;
                    break;
                case 2:
                    BackColor = Color.LightBlue;
                    break;
                case 3:
                    BackColor = Color.HotPink;
                    break;
                case 4:
                    BackColor = Color.DarkOrange;
                    break;
            }
        }
    }
}
