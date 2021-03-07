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
    public partial class frmFinancien : Form
    {
        public frmFinancien()
        {
            InitializeComponent();

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int munz;
        int finState;
        int color;//Variabele voor de kleur
        private void frmFinancien_Activated(object sender, EventArgs e)
        {
            finState = frmPaardrennen.getFinState();
            txtChange.Select();
            // als Finance state (finState) = 0 --> Storten / als finState = 1 --> Afhalen
            if (finState == 0)
            {
                lblState.Text = "Storten:";
                btnChange.Text = "Storten";
            }
            else
            {
                lblState.Text = "Afhalen:";
                btnChange.Text = "Afhalen";
            }
            updateMunz();

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

        private void updateMunz()
        {
            munz = frmPaardrennen.getMunz();
            lblCurrMunz.Text = "€ " + munz;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //filter kijkt of het een int is en zet het dan in een variabele
            int GokMunz;
            if (!int.TryParse(txtChange.Text, out GokMunz))
            {
                txtChange.Select();
                MessageBox.Show("U moet een geldig getal ingeven.", "Fout: geen getal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (GokMunz >=5000)
            {
                txtChange.Select();
                MessageBox.Show("U mag niet meer dan 5.000 euro per keer storten.", "Fout: Te veel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (finState == 0)
            {
                frmPaardrennen.setMunz(munz + GokMunz);
                btnClose.Select();
                frmPaardrennen.addFinArrs(finState, GokMunz);// Geeft de finState en het aantal geld door naar de arrays
            }
            else if(finState == 1)
            {
                if((munz - Convert.ToInt32(txtChange.Text)) >= 0) //Om in het rood te gaan te voorkomen
                {
                    frmPaardrennen.setMunz(munz - GokMunz);
                    btnClose.Select();
                    frmPaardrennen.addFinArrs(finState, GokMunz); //Geeft de finState en het aantal geld door naar de arrays
                }
                else
                {
                    MessageBox.Show("U probeert meer geld af te halen dan u hebt staan.", "Fout: tekort aan geld", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtChange.Select();
                }
            }
            

            txtChange.Text = null;
            updateMunz();
        }
    }
}
