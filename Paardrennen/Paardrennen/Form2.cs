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
            this.Hide();
        }

        int munz;
        int finState;

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
        }

        private void updateMunz()
        {
            munz = frmPaardrennen.getMunz();
            lblCurrMunz.Text = "€ " + munz;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //TODO: filter op dees --> moet int zijn.
            //Begin filter---------------------

            //Einde filter---------------------
            if(finState == 0)
            {
                frmPaardrennen.setMunz(munz + Convert.ToInt32(txtChange.Text));
                btnClose.Select();//miss moet ik automatisch hiden? --> need feedback ~Kieron
            }
            else if(finState == 1)
            {
                if((munz - Convert.ToInt32(txtChange.Text)) >= 0) //Om in het rood te gaan te voorkomen
                {
                    frmPaardrennen.setMunz(munz - Convert.ToInt32(txtChange.Text));
                    btnClose.Select();//Zie line63
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
