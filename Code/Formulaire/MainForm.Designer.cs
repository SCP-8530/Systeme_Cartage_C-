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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_Login});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
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
    }
}

