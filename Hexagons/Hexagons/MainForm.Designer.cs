namespace Hexagons
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panDraw = new System.Windows.Forms.Panel();
            this.panControl = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.labelSlideR = new System.Windows.Forms.Label();
            this.labelSlideG = new System.Windows.Forms.Label();
            this.labelSlideB = new System.Windows.Forms.Label();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panControl);
            this.panel1.Controls.Add(this.panDraw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 379);
            this.panel1.TabIndex = 6;
            // 
            // panDraw
            // 
            this.panDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panDraw.Dock = System.Windows.Forms.DockStyle.Left;
            this.panDraw.Location = new System.Drawing.Point(0, 0);
            this.panDraw.Name = "panDraw";
            this.panDraw.Size = new System.Drawing.Size(457, 379);
            this.panDraw.TabIndex = 8;
            // 
            // panControl
            // 
            this.panControl.BackColor = System.Drawing.Color.Red;
            this.panControl.Controls.Add(this.lbColor);
            this.panControl.Controls.Add(this.textBoxBlue);
            this.panControl.Controls.Add(this.textBoxGreen);
            this.panControl.Controls.Add(this.textBoxRed);
            this.panControl.Controls.Add(this.labelSlideB);
            this.panControl.Controls.Add(this.labelSlideG);
            this.panControl.Controls.Add(this.labelSlideR);
            this.panControl.Controls.Add(this.trackBarG);
            this.panControl.Controls.Add(this.trackBarB);
            this.panControl.Controls.Add(this.trackBarR);
            this.panControl.Controls.Add(this.labelR);
            this.panControl.Controls.Add(this.textBoxR);
            this.panControl.Controls.Add(this.labelQ);
            this.panControl.Controls.Add(this.textBoxQ);
            this.panControl.Controls.Add(this.labelID);
            this.panControl.Controls.Add(this.textBoxID);
            this.panControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panControl.Location = new System.Drawing.Point(457, 0);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(343, 379);
            this.panControl.TabIndex = 9;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(92, 15);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(51, 22);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(51, 48);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(15, 13);
            this.labelQ.TabIndex = 3;
            this.labelQ.Text = "Q";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(92, 41);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 20);
            this.textBoxQ.TabIndex = 2;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(51, 74);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(15, 13);
            this.labelR.TabIndex = 5;
            this.labelR.Text = "R";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(92, 67);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 4;
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(98, 169);
            this.trackBarR.Maximum = 255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarR.Size = new System.Drawing.Size(45, 104);
            this.trackBarR.TabIndex = 6;
            this.trackBarR.TickFrequency = 25;
            this.trackBarR.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(197, 169);
            this.trackBarB.Maximum = 255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarB.Size = new System.Drawing.Size(45, 104);
            this.trackBarB.TabIndex = 7;
            this.trackBarB.TickFrequency = 25;
            this.trackBarB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(147, 169);
            this.trackBarG.Maximum = 255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarG.Size = new System.Drawing.Size(45, 104);
            this.trackBarG.TabIndex = 8;
            this.trackBarG.TickFrequency = 25;
            this.trackBarG.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // labelSlideR
            // 
            this.labelSlideR.AutoSize = true;
            this.labelSlideR.Location = new System.Drawing.Point(111, 276);
            this.labelSlideR.Name = "labelSlideR";
            this.labelSlideR.Size = new System.Drawing.Size(15, 13);
            this.labelSlideR.TabIndex = 9;
            this.labelSlideR.Text = "R";
            // 
            // labelSlideG
            // 
            this.labelSlideG.AutoSize = true;
            this.labelSlideG.Location = new System.Drawing.Point(162, 276);
            this.labelSlideG.Name = "labelSlideG";
            this.labelSlideG.Size = new System.Drawing.Size(15, 13);
            this.labelSlideG.TabIndex = 10;
            this.labelSlideG.Text = "G";
            // 
            // labelSlideB
            // 
            this.labelSlideB.AutoSize = true;
            this.labelSlideB.Location = new System.Drawing.Point(213, 276);
            this.labelSlideB.Name = "labelSlideB";
            this.labelSlideB.Size = new System.Drawing.Size(14, 13);
            this.labelSlideB.TabIndex = 11;
            this.labelSlideB.Text = "B";
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(99, 143);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(42, 20);
            this.textBoxRed.TabIndex = 12;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(148, 143);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(42, 20);
            this.textBoxGreen.TabIndex = 13;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(198, 143);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(42, 20);
            this.textBoxBlue.TabIndex = 14;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.BackColor = System.Drawing.Color.Black;
            this.lbColor.Location = new System.Drawing.Point(95, 299);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(145, 13);
            this.lbColor.TabIndex = 15;
            this.lbColor.Text = "                                              ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Hexagons";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panControl.ResumeLayout(false);
            this.panControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panControl;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Panel panDraw;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.Label labelSlideB;
        private System.Windows.Forms.Label labelSlideG;
        private System.Windows.Forms.Label labelSlideR;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.Label lbColor;
    }
}

