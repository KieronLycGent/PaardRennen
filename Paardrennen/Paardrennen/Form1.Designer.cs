
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
            this.btnBieden = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stortenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afhalenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achtergrondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGokMunz = new System.Windows.Forms.TextBox();
            this.tPaard = new System.Windows.Forms.Timer(this.components);
            this.lblMunz = new System.Windows.Forms.Label();
            this.lblInzetStart = new System.Windows.Forms.Label();
            this.lblInzetEnd = new System.Windows.Forms.Label();
            this.tP2 = new System.Windows.Forms.Timer(this.components);
            this.tP3 = new System.Windows.Forms.Timer(this.components);
            this.lblOpEerstePlaats = new System.Windows.Forms.Label();
            this.pctbStart = new System.Windows.Forms.PictureBox();
            this.pctbPaard3 = new System.Windows.Forms.PictureBox();
            this.pctbPaard2 = new System.Windows.Forms.PictureBox();
            this.pctbPaard1 = new System.Windows.Forms.PictureBox();
            this.pctbFinish = new System.Windows.Forms.PictureBox();
            this.pctbArrow2 = new System.Windows.Forms.PictureBox();
            this.pctbArrow3 = new System.Windows.Forms.PictureBox();
            this.pctbArrow1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.standaardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blouwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPaard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPaard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPaard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbArrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbArrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbArrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBieden
            // 
            this.btnBieden.Location = new System.Drawing.Point(27, 596);
            this.btnBieden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBieden.Name = "btnBieden";
            this.btnBieden.Size = new System.Drawing.Size(105, 55);
            this.btnBieden.TabIndex = 7;
            this.btnBieden.Text = "Geld inzetten";
            this.btnBieden.UseVisualStyleBackColor = true;
            this.btnBieden.Click += new System.EventHandler(this.btnBieden_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stortenToolStripMenuItem,
            this.afhalenToolStripMenuItem,
            this.overzichtToolStripMenuItem,
            this.achtergrondToolStripMenuItem,
            this.informatieToolStripMenuItem,
            this.sluitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1157, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stortenToolStripMenuItem
            // 
            this.stortenToolStripMenuItem.Name = "stortenToolStripMenuItem";
            this.stortenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.stortenToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.stortenToolStripMenuItem.Text = "Storten";
            this.stortenToolStripMenuItem.Click += new System.EventHandler(this.stortenToolStripMenuItem_Click);
            // 
            // afhalenToolStripMenuItem
            // 
            this.afhalenToolStripMenuItem.Name = "afhalenToolStripMenuItem";
            this.afhalenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.afhalenToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.afhalenToolStripMenuItem.Text = "Afhalen";
            this.afhalenToolStripMenuItem.Click += new System.EventHandler(this.afhalenToolStripMenuItem_Click);
            // 
            // overzichtToolStripMenuItem
            // 
            this.overzichtToolStripMenuItem.Name = "overzichtToolStripMenuItem";
            this.overzichtToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.overzichtToolStripMenuItem.Text = "Overzicht";
            this.overzichtToolStripMenuItem.Click += new System.EventHandler(this.overzichtToolStripMenuItem_Click);
            // 
            // achtergrondToolStripMenuItem
            // 
            this.achtergrondToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standaardToolStripMenuItem,
            this.blouwToolStripMenuItem,
            this.oranjeToolStripMenuItem,
            this.rozeToolStripMenuItem});
            this.achtergrondToolStripMenuItem.Name = "achtergrondToolStripMenuItem";
            this.achtergrondToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.achtergrondToolStripMenuItem.Text = "Achtergrond";
            this.achtergrondToolStripMenuItem.Click += new System.EventHandler(this.achtergrondToolStripMenuItem_Click);
            // 
            // informatieToolStripMenuItem
            // 
            this.informatieToolStripMenuItem.Name = "informatieToolStripMenuItem";
            this.informatieToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.informatieToolStripMenuItem.Text = "Info";
            this.informatieToolStripMenuItem.Click += new System.EventHandler(this.informatieToolStripMenuItem_Click);
            // 
            // sluitenToolStripMenuItem
            // 
            this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
            this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sluitenToolStripMenuItem.Text = "Sluiten";
            this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.sluitenToolStripMenuItem_Click);
            // 
            // txtGokMunz
            // 
            this.txtGokMunz.Location = new System.Drawing.Point(202, 626);
            this.txtGokMunz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGokMunz.Name = "txtGokMunz";
            this.txtGokMunz.Size = new System.Drawing.Size(55, 22);
            this.txtGokMunz.TabIndex = 9;
            // 
            // tPaard
            // 
            this.tPaard.Tick += new System.EventHandler(this.tPaard_Tick);
            // 
            // lblMunz
            // 
            this.lblMunz.AutoSize = true;
            this.lblMunz.Location = new System.Drawing.Point(139, 596);
            this.lblMunz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMunz.Name = "lblMunz";
            this.lblMunz.Size = new System.Drawing.Size(62, 17);
            this.lblMunz.TabIndex = 10;
            this.lblMunz.Text = "Geld: €0";
            // 
            // lblInzetStart
            // 
            this.lblInzetStart.AutoSize = true;
            this.lblInzetStart.Location = new System.Drawing.Point(139, 630);
            this.lblInzetStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInzetStart.Name = "lblInzetStart";
            this.lblInzetStart.Size = new System.Drawing.Size(53, 17);
            this.lblInzetStart.TabIndex = 11;
            this.lblInzetStart.Text = "Ik zet €";
            // 
            // lblInzetEnd
            // 
            this.lblInzetEnd.AutoSize = true;
            this.lblInzetEnd.Location = new System.Drawing.Point(264, 630);
            this.lblInzetEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInzetEnd.Name = "lblInzetEnd";
            this.lblInzetEnd.Size = new System.Drawing.Size(23, 17);
            this.lblInzetEnd.TabIndex = 12;
            this.lblInzetEnd.Text = "in.";
            // 
            // lblOpEerstePlaats
            // 
            this.lblOpEerstePlaats.AutoSize = true;
            this.lblOpEerstePlaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpEerstePlaats.Location = new System.Drawing.Point(330, 609);
            this.lblOpEerstePlaats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpEerstePlaats.Name = "lblOpEerstePlaats";
            this.lblOpEerstePlaats.Size = new System.Drawing.Size(160, 38);
            this.lblOpEerstePlaats.TabIndex = 15;
            this.lblOpEerstePlaats.Text = "Filler text";
            // 
            // pctbStart
            // 
            this.pctbStart.Image = ((System.Drawing.Image)(resources.GetObject("pctbStart.Image")));
            this.pctbStart.Location = new System.Drawing.Point(898, 493);
            this.pctbStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbStart.Name = "pctbStart";
            this.pctbStart.Size = new System.Drawing.Size(237, 137);
            this.pctbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbStart.TabIndex = 13;
            this.pctbStart.TabStop = false;
            this.pctbStart.Click += new System.EventHandler(this.pctbStart_Click);
            // 
            // pctbPaard3
            // 
            this.pctbPaard3.BackColor = System.Drawing.Color.Transparent;
            this.pctbPaard3.Image = ((System.Drawing.Image)(resources.GetObject("pctbPaard3.Image")));
            this.pctbPaard3.Location = new System.Drawing.Point(40, 356);
            this.pctbPaard3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbPaard3.Name = "pctbPaard3";
            this.pctbPaard3.Size = new System.Drawing.Size(133, 123);
            this.pctbPaard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbPaard3.TabIndex = 4;
            this.pctbPaard3.TabStop = false;
            // 
            // pctbPaard2
            // 
            this.pctbPaard2.BackColor = System.Drawing.Color.Transparent;
            this.pctbPaard2.Image = ((System.Drawing.Image)(resources.GetObject("pctbPaard2.Image")));
            this.pctbPaard2.Location = new System.Drawing.Point(40, 203);
            this.pctbPaard2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbPaard2.Name = "pctbPaard2";
            this.pctbPaard2.Size = new System.Drawing.Size(133, 123);
            this.pctbPaard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbPaard2.TabIndex = 3;
            this.pctbPaard2.TabStop = false;
            // 
            // pctbPaard1
            // 
            this.pctbPaard1.BackColor = System.Drawing.Color.Transparent;
            this.pctbPaard1.Image = ((System.Drawing.Image)(resources.GetObject("pctbPaard1.Image")));
            this.pctbPaard1.Location = new System.Drawing.Point(40, 57);
            this.pctbPaard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbPaard1.Name = "pctbPaard1";
            this.pctbPaard1.Size = new System.Drawing.Size(133, 123);
            this.pctbPaard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbPaard1.TabIndex = 2;
            this.pctbPaard1.TabStop = false;
            // 
            // pctbFinish
            // 
            this.pctbFinish.BackColor = System.Drawing.Color.Transparent;
            this.pctbFinish.BackgroundImage = global::Paardrennen.Properties.Resources.finich;
            this.pctbFinish.Location = new System.Drawing.Point(920, 64);
            this.pctbFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbFinish.Name = "pctbFinish";
            this.pctbFinish.Size = new System.Drawing.Size(60, 450);
            this.pctbFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbFinish.TabIndex = 0;
            this.pctbFinish.TabStop = false;
            // 
            // pctbArrow2
            // 
            this.pctbArrow2.Image = global::Paardrennen.Properties.Resources.Arrow;
            this.pctbArrow2.Location = new System.Drawing.Point(-40, 240);
            this.pctbArrow2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctbArrow2.Name = "pctbArrow2";
            this.pctbArrow2.Size = new System.Drawing.Size(80, 49);
            this.pctbArrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbArrow2.TabIndex = 17;
            this.pctbArrow2.TabStop = false;
            this.pctbArrow2.Visible = false;
            // 
            // pctbArrow3
            // 
            this.pctbArrow3.Image = global::Paardrennen.Properties.Resources.Arrow;
            this.pctbArrow3.Location = new System.Drawing.Point(-40, 393);
            this.pctbArrow3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctbArrow3.Name = "pctbArrow3";
            this.pctbArrow3.Size = new System.Drawing.Size(80, 49);
            this.pctbArrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbArrow3.TabIndex = 18;
            this.pctbArrow3.TabStop = false;
            this.pctbArrow3.Visible = false;
            // 
            // pctbArrow1
            // 
            this.pctbArrow1.Image = global::Paardrennen.Properties.Resources.Arrow;
            this.pctbArrow1.Location = new System.Drawing.Point(-40, 94);
            this.pctbArrow1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctbArrow1.Name = "pctbArrow1";
            this.pctbArrow1.Size = new System.Drawing.Size(80, 49);
            this.pctbArrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbArrow1.TabIndex = 19;
            this.pctbArrow1.TabStop = false;
            this.pctbArrow1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(898, 596);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // standaardToolStripMenuItem
            // 
            this.standaardToolStripMenuItem.Name = "standaardToolStripMenuItem";
            this.standaardToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.standaardToolStripMenuItem.Text = "Gras";
            this.standaardToolStripMenuItem.Click += new System.EventHandler(this.standaardToolStripMenuItem_Click);
            // 
            // blouwToolStripMenuItem
            // 
            this.blouwToolStripMenuItem.Name = "blouwToolStripMenuItem";
            this.blouwToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.blouwToolStripMenuItem.Text = "Lucht";
            this.blouwToolStripMenuItem.Click += new System.EventHandler(this.blouwToolStripMenuItem_Click);
            // 
            // rozeToolStripMenuItem
            // 
            this.rozeToolStripMenuItem.Name = "rozeToolStripMenuItem";
            this.rozeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rozeToolStripMenuItem.Text = "Bubblegum";
            this.rozeToolStripMenuItem.Click += new System.EventHandler(this.rozeToolStripMenuItem_Click);
            // 
            // oranjeToolStripMenuItem
            // 
            this.oranjeToolStripMenuItem.Name = "oranjeToolStripMenuItem";
            this.oranjeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.oranjeToolStripMenuItem.Text = "Herfst";
            this.oranjeToolStripMenuItem.Click += new System.EventHandler(this.oranjeToolStripMenuItem_Click);
            // 
            // frmPaardrennen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1157, 699);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctbArrow1);
            this.Controls.Add(this.pctbArrow3);
            this.Controls.Add(this.pctbArrow2);
            this.Controls.Add(this.lblOpEerstePlaats);
            this.Controls.Add(this.pctbStart);
            this.Controls.Add(this.lblInzetEnd);
            this.Controls.Add(this.lblInzetStart);
            this.Controls.Add(this.lblMunz);
            this.Controls.Add(this.txtGokMunz);
            this.Controls.Add(this.btnBieden);
            this.Controls.Add(this.pctbPaard3);
            this.Controls.Add(this.pctbPaard2);
            this.Controls.Add(this.pctbPaard1);
            this.Controls.Add(this.pctbFinish);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPaardrennen";
            this.Text = "Paardrennen";
            this.Activated += new System.EventHandler(this.frmPaardrennen_Activated);
            this.Load += new System.EventHandler(this.frmPaardrennen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPaard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPaard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPaard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbArrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbArrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbArrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbFinish;
        private System.Windows.Forms.PictureBox pctbPaard1;
        private System.Windows.Forms.PictureBox pctbPaard2;
        private System.Windows.Forms.PictureBox pctbPaard3;
        private System.Windows.Forms.Button btnBieden;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stortenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afhalenToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGokMunz;
        private System.Windows.Forms.Timer tPaard;
        private System.Windows.Forms.ToolStripMenuItem informatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem achtergrondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;
        private System.Windows.Forms.Label lblMunz;
        private System.Windows.Forms.Label lblInzetStart;
        private System.Windows.Forms.Label lblInzetEnd;
        private System.Windows.Forms.Timer tP2;
        private System.Windows.Forms.Timer tP3;
        private System.Windows.Forms.PictureBox pctbStart;
        private System.Windows.Forms.Label lblOpEerstePlaats;
        private System.Windows.Forms.PictureBox pctbArrow2;
        private System.Windows.Forms.PictureBox pctbArrow3;
        private System.Windows.Forms.PictureBox pctbArrow1;
        private System.Windows.Forms.ToolStripMenuItem overzichtToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem standaardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blouwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oranjeToolStripMenuItem;
    }
}

