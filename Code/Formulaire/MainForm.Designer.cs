namespace Project_Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.M_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.ML_Connecter = new System.Windows.Forms.ToolStripMenuItem();
            this.ML_NewCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.ML_Deconneter = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Outils = new System.Windows.Forms.ToolStripMenuItem();
            this.ML_listCrystalien = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Fenetre = new System.Windows.Forms.ToolStripMenuItem();
            this.ML_listMission = new System.Windows.Forms.ToolStripMenuItem();
            this.ML_AjoutMission = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_Login,
            this.M_Outils,
            this.M_Fenetre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.M_Fenetre;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // M_Login
            // 
            this.M_Login.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ML_Connecter,
            this.ML_NewCompte,
            this.ML_Deconneter});
            this.M_Login.Name = "M_Login";
            this.M_Login.Size = new System.Drawing.Size(60, 24);
            this.M_Login.Text = "Login";
            // 
            // ML_Connecter
            // 
            this.ML_Connecter.Name = "ML_Connecter";
            this.ML_Connecter.Size = new System.Drawing.Size(224, 26);
            this.ML_Connecter.Text = "Se connecter";
            this.ML_Connecter.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);
            // 
            // ML_NewCompte
            // 
            this.ML_NewCompte.Name = "ML_NewCompte";
            this.ML_NewCompte.Size = new System.Drawing.Size(224, 26);
            this.ML_NewCompte.Text = "Creer un compte";
            this.ML_NewCompte.Click += new System.EventHandler(this.ML_NewCompte_Click);
            // 
            // ML_Deconneter
            // 
            this.ML_Deconneter.Name = "ML_Deconneter";
            this.ML_Deconneter.Size = new System.Drawing.Size(224, 26);
            this.ML_Deconneter.Text = "Se deconnecter";
            this.ML_Deconneter.Click += new System.EventHandler(this.ML_Deconneter_Click);
            // 
            // M_Outils
            // 
            this.M_Outils.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ML_listCrystalien,
            this.ML_listMission,
            this.ML_AjoutMission});
            this.M_Outils.Name = "M_Outils";
            this.M_Outils.Size = new System.Drawing.Size(61, 24);
            this.M_Outils.Text = "Outils";
            // 
            // ML_listCrystalien
            // 
            this.ML_listCrystalien.Name = "ML_listCrystalien";
            this.ML_listCrystalien.Size = new System.Drawing.Size(224, 26);
            this.ML_listCrystalien.Text = "Liste des crystaliens";
            this.ML_listCrystalien.Click += new System.EventHandler(this.listeDesCrystaliensToolStripMenuItem_Click);
            // 
            // M_Fenetre
            // 
            this.M_Fenetre.Name = "M_Fenetre";
            this.M_Fenetre.Size = new System.Drawing.Size(72, 24);
            this.M_Fenetre.Text = "Fenetre";
            // 
            // ML_listMission
            // 
            this.ML_listMission.Name = "ML_listMission";
            this.ML_listMission.Size = new System.Drawing.Size(224, 26);
            this.ML_listMission.Text = "Liste des missions";
            this.ML_listMission.Click += new System.EventHandler(this.ML_listMission_Click);
            // 
            // ML_AjoutMission
            // 
            this.ML_AjoutMission.Name = "ML_AjoutMission";
            this.ML_AjoutMission.Size = new System.Drawing.Size(224, 26);
            this.ML_AjoutMission.Text = "Ajoute une mission";
            this.ML_AjoutMission.Click += new System.EventHandler(this.ajouteUneMissionToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Systeme Cartage";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem M_Login;
        private System.Windows.Forms.ToolStripMenuItem ML_Connecter;
        private System.Windows.Forms.ToolStripMenuItem ML_NewCompte;
        private System.Windows.Forms.ToolStripMenuItem ML_Deconneter;
        private System.Windows.Forms.ToolStripMenuItem M_Outils;
        private System.Windows.Forms.ToolStripMenuItem ML_listCrystalien;
        private System.Windows.Forms.ToolStripMenuItem M_Fenetre;
        private System.Windows.Forms.ToolStripMenuItem ML_listMission;
        private System.Windows.Forms.ToolStripMenuItem ML_AjoutMission;
    }
}

