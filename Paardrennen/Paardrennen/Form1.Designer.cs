
namespace Paardrennen
{
    partial class frmPaardrennen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaardrennen));
            this.ctbFinich = new System.Windows.Forms.PictureBox();
            this.paard1 = new System.Windows.Forms.PictureBox();
            this.paard2 = new System.Windows.Forms.PictureBox();
            this.pard3 = new System.Windows.Forms.PictureBox();
            this.btnBieden = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stortenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afhalenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGokMonny = new System.Windows.Forms.TextBox();
            this.tP1 = new System.Windows.Forms.Timer(this.components);
            this.tP2 = new System.Windows.Forms.Timer(this.components);
            this.tP3 = new System.Windows.Forms.Timer(this.components);
            this.informatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achtergrondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ctbFinich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pard3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctbFinich
            // 
            this.ctbFinich.Image = ((System.Drawing.Image)(resources.GetObject("ctbFinich.Image")));
            this.ctbFinich.Location = new System.Drawing.Point(837, 31);
            this.ctbFinich.Name = "ctbFinich";
            this.ctbFinich.Size = new System.Drawing.Size(450, 563);
            this.ctbFinich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ctbFinich.TabIndex = 0;
            this.ctbFinich.TabStop = false;
            // 
            // paard1
            // 
            this.paard1.Image = ((System.Drawing.Image)(resources.GetObject("paard1.Image")));
            this.paard1.Location = new System.Drawing.Point(95, 56);
            this.paard1.Name = "paard1";
            this.paard1.Size = new System.Drawing.Size(136, 137);
            this.paard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paard1.TabIndex = 2;
            this.paard1.TabStop = false;
            // 
            // paard2
            // 
            this.paard2.Image = ((System.Drawing.Image)(resources.GetObject("paard2.Image")));
            this.paard2.Location = new System.Drawing.Point(95, 199);
            this.paard2.Name = "paard2";
            this.paard2.Size = new System.Drawing.Size(136, 137);
            this.paard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paard2.TabIndex = 3;
            this.paard2.TabStop = false;
            // 
            // pard3
            // 
            this.pard3.Image = ((System.Drawing.Image)(resources.GetObject("pard3.Image")));
            this.pard3.Location = new System.Drawing.Point(95, 342);
            this.pard3.Name = "pard3";
            this.pard3.Size = new System.Drawing.Size(136, 137);
            this.pard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pard3.TabIndex = 4;
            this.pard3.TabStop = false;
            // 
            // btnBieden
            // 
            this.btnBieden.Location = new System.Drawing.Point(12, 547);
            this.btnBieden.Name = "btnBieden";
            this.btnBieden.Size = new System.Drawing.Size(142, 73);
            this.btnBieden.TabIndex = 7;
            this.btnBieden.Text = "Geld inzetten";
            this.btnBieden.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stortenToolStripMenuItem,
            this.afhalenToolStripMenuItem,
            this.informatieToolStripMenuItem,
            this.achtergrondToolStripMenuItem,
            this.sluitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stortenToolStripMenuItem
            // 
            this.stortenToolStripMenuItem.Name = "stortenToolStripMenuItem";
            this.stortenToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.stortenToolStripMenuItem.Text = "Storten";
            // 
            // afhalenToolStripMenuItem
            // 
            this.afhalenToolStripMenuItem.Name = "afhalenToolStripMenuItem";
            this.afhalenToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.afhalenToolStripMenuItem.Text = "Afhalen";
            // 
            // txtGokMonny
            // 
            this.txtGokMonny.Location = new System.Drawing.Point(160, 572);
            this.txtGokMonny.Name = "txtGokMonny";
            this.txtGokMonny.Size = new System.Drawing.Size(181, 22);
            this.txtGokMonny.TabIndex = 9;
            // 
            // informatieToolStripMenuItem
            // 
            this.informatieToolStripMenuItem.Name = "informatieToolStripMenuItem";
            this.informatieToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.informatieToolStripMenuItem.Text = "Informatie";
            // 
            // achtergrondToolStripMenuItem
            // 
            this.achtergrondToolStripMenuItem.Name = "achtergrondToolStripMenuItem";
            this.achtergrondToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.achtergrondToolStripMenuItem.Text = "Achtergrond";
            // 
            // sluitenToolStripMenuItem
            // 
            this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
            this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sluitenToolStripMenuItem.Text = "Sluiten";
            // 
            // frmPaardrennen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 641);
            this.Controls.Add(this.txtGokMonny);
            this.Controls.Add(this.btnBieden);
            this.Controls.Add(this.pard3);
            this.Controls.Add(this.paard2);
            this.Controls.Add(this.paard1);
            this.Controls.Add(this.ctbFinich);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPaardrennen";
            this.Text = "Paardrennen";
            ((System.ComponentModel.ISupportInitialize)(this.ctbFinich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pard3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ctbFinich;
        private System.Windows.Forms.PictureBox paard1;
        private System.Windows.Forms.PictureBox paard2;
        private System.Windows.Forms.PictureBox pard3;
        private System.Windows.Forms.Button btnBieden;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stortenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afhalenToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGokMonny;
        private System.Windows.Forms.Timer tP1;
        private System.Windows.Forms.Timer tP2;
        private System.Windows.Forms.Timer tP3;
        private System.Windows.Forms.ToolStripMenuItem informatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem achtergrondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;
    }
}

