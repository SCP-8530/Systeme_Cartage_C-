namespace Project_Final
{
    partial class AjoutMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutMission));
            this.B_Creation = new System.Windows.Forms.Button();
            this.L_Nom = new System.Windows.Forms.Label();
            this.TB_Matricule = new System.Windows.Forms.TextBox();
            this.L_Matricule = new System.Windows.Forms.Label();
            this.L_Erreur = new System.Windows.Forms.Label();
            this.L_Creation = new System.Windows.Forms.Label();
            this.TB_Description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B_Creation
            // 
            this.B_Creation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Creation.Location = new System.Drawing.Point(263, 93);
            this.B_Creation.Name = "B_Creation";
            this.B_Creation.Size = new System.Drawing.Size(166, 64);
            this.B_Creation.TabIndex = 23;
            this.B_Creation.Text = "Ajout de la mission";
            this.B_Creation.UseVisualStyleBackColor = true;
            this.B_Creation.Click += new System.EventHandler(this.B_Creation_Click);
            // 
            // L_Nom
            // 
            this.L_Nom.AutoSize = true;
            this.L_Nom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Nom.Location = new System.Drawing.Point(32, 131);
            this.L_Nom.Name = "L_Nom";
            this.L_Nom.Size = new System.Drawing.Size(131, 28);
            this.L_Nom.TabIndex = 17;
            this.L_Nom.Text = "Description :";
            // 
            // TB_Matricule
            // 
            this.TB_Matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Matricule.Location = new System.Drawing.Point(150, 93);
            this.TB_Matricule.Name = "TB_Matricule";
            this.TB_Matricule.Size = new System.Drawing.Size(107, 30);
            this.TB_Matricule.TabIndex = 16;
            // 
            // L_Matricule
            // 
            this.L_Matricule.AutoSize = true;
            this.L_Matricule.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Matricule.Location = new System.Drawing.Point(32, 95);
            this.L_Matricule.Name = "L_Matricule";
            this.L_Matricule.Size = new System.Drawing.Size(112, 28);
            this.L_Matricule.TabIndex = 15;
            this.L_Matricule.Text = "Matricule :";
            // 
            // L_Erreur
            // 
            this.L_Erreur.AutoSize = true;
            this.L_Erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Erreur.ForeColor = System.Drawing.Color.Red;
            this.L_Erreur.Location = new System.Drawing.Point(34, 253);
            this.L_Erreur.Name = "L_Erreur";
            this.L_Erreur.Size = new System.Drawing.Size(173, 16);
            this.L_Erreur.TabIndex = 14;
            this.L_Erreur.Text = "L\'utilisateur n\'existe pas";
            // 
            // L_Creation
            // 
            this.L_Creation.AutoSize = true;
            this.L_Creation.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Creation.Location = new System.Drawing.Point(27, 36);
            this.L_Creation.Name = "L_Creation";
            this.L_Creation.Size = new System.Drawing.Size(284, 39);
            this.L_Creation.TabIndex = 13;
            this.L_Creation.Text = "Ajouter une mission:";
            // 
            // TB_Description
            // 
            this.TB_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Description.Location = new System.Drawing.Point(34, 163);
            this.TB_Description.Multiline = true;
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.Size = new System.Drawing.Size(395, 75);
            this.TB_Description.TabIndex = 24;
            // 
            // AjoutMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 296);
            this.Controls.Add(this.TB_Description);
            this.Controls.Add(this.B_Creation);
            this.Controls.Add(this.L_Nom);
            this.Controls.Add(this.TB_Matricule);
            this.Controls.Add(this.L_Matricule);
            this.Controls.Add(this.L_Erreur);
            this.Controls.Add(this.L_Creation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutMission";
            this.Text = "Ajoute une mission";
            this.Load += new System.EventHandler(this.AjoutMission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Creation;
        private System.Windows.Forms.Label L_Nom;
        private System.Windows.Forms.TextBox TB_Matricule;
        private System.Windows.Forms.Label L_Matricule;
        private System.Windows.Forms.Label L_Erreur;
        private System.Windows.Forms.Label L_Creation;
        private System.Windows.Forms.TextBox TB_Description;
    }
}