namespace Paardrennen
{
    partial class frmFinancien
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCurrMunz = new System.Windows.Forms.Label();
            this.lblTitelMunzIguess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(133, 34);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 63);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "PH_+/-";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(133, 105);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 51);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Sluiten";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(16, 37);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(108, 22);
            this.txtChange.TabIndex = 2;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(16, 17);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(89, 17);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "ERR_NotDef";
            // 
            // lblCurrMunz
            // 
            this.lblCurrMunz.AutoSize = true;
            this.lblCurrMunz.Location = new System.Drawing.Point(16, 86);
            this.lblCurrMunz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrMunz.Name = "lblCurrMunz";
            this.lblCurrMunz.Size = new System.Drawing.Size(52, 17);
            this.lblCurrMunz.TabIndex = 4;
            this.lblCurrMunz.Text = "€NULL";
            // 
            // lblTitelMunzIguess
            // 
            this.lblTitelMunzIguess.AutoSize = true;
            this.lblTitelMunzIguess.Location = new System.Drawing.Point(12, 70);
            this.lblTitelMunzIguess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitelMunzIguess.Name = "lblTitelMunzIguess";
            this.lblTitelMunzIguess.Size = new System.Drawing.Size(107, 17);
            this.lblTitelMunzIguess.TabIndex = 5;
            this.lblTitelMunzIguess.Text = "Aantal geld nu: ";
            // 
            // frmFinancien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 171);
            this.Controls.Add(this.lblTitelMunzIguess);
            this.Controls.Add(this.lblCurrMunz);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFinancien";
            this.Text = "Financiën";
            this.Activated += new System.EventHandler(this.frmFinancien_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCurrMunz;
        private System.Windows.Forms.Label lblTitelMunzIguess;
    }
}