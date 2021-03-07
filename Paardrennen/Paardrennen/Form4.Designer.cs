
namespace Paardrennen
{
    partial class frmOverzichtFin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxFinState = new System.Windows.Forms.ListBox();
            this.lbxAantal = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxFinState
            // 
            this.lbxFinState.Enabled = false;
            this.lbxFinState.FormattingEnabled = true;
            this.lbxFinState.Location = new System.Drawing.Point(12, 44);
            this.lbxFinState.Name = "lbxFinState";
            this.lbxFinState.Size = new System.Drawing.Size(141, 537);
            this.lbxFinState.TabIndex = 0;
            // 
            // lbxAantal
            // 
            this.lbxAantal.Enabled = false;
            this.lbxAantal.FormattingEnabled = true;
            this.lbxAantal.Location = new System.Drawing.Point(159, 44);
            this.lbxAantal.Name = "lbxAantal";
            this.lbxAantal.Size = new System.Drawing.Size(146, 537);
            this.lbxAantal.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(11, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(408, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Sluiten";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(311, 44);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(55, 13);
            this.lblTotaal.TabIndex = 3;
            this.lblTotaal.Text = "Totaal: €0";
            // 
            // frmOverzichtFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 592);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbxAantal);
            this.Controls.Add(this.lbxFinState);
            this.Name = "frmOverzichtFin";
            this.Text = "Overzicht financiën";
            this.Activated += new System.EventHandler(this.frmOverzichtFin_Activated);
            this.Load += new System.EventHandler(this.frmOverzichtFin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFinState;
        private System.Windows.Forms.ListBox lbxAantal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotaal;
    }
}