namespace Project_Final
{
    partial class CreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationForm));
            this.L_Creation = new System.Windows.Forms.Label();
            this.L_Erreur = new System.Windows.Forms.Label();
            this.L_Matricule = new System.Windows.Forms.Label();
            this.TB_Matricule = new System.Windows.Forms.TextBox();
            this.L_Nom = new System.Windows.Forms.Label();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.CB_Droit = new System.Windows.Forms.ComboBox();
            this.L_Droit = new System.Windows.Forms.Label();
            this.L_Habitant = new System.Windows.Forms.Label();
            this.CB_Habitant = new System.Windows.Forms.ComboBox();
            this.B_Creation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Creation
            // 
            this.L_Creation.AutoSize = true;
            this.L_Creation.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Creation.Location = new System.Drawing.Point(31, 21);
            this.L_Creation.Name = "L_Creation";
            this.L_Creation.Size = new System.Drawing.Size(240, 39);
            this.L_Creation.TabIndex = 1;
            this.L_Creation.Text = "Creer un compte:";
            // 
            // L_Erreur
            // 
            this.L_Erreur.AutoSize = true;
            this.L_Erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Erreur.ForeColor = System.Drawing.Color.Red;
            this.L_Erreur.Location = new System.Drawing.Point(38, 262);
            this.L_Erreur.Name = "L_Erreur";
            this.L_Erreur.Size = new System.Drawing.Size(49, 16);
            this.L_Erreur.TabIndex = 2;
            this.L_Erreur.Text = "Erreur";
            // 
            // L_Matricule
            // 
            this.L_Matricule.AutoSize = true;
            this.L_Matricule.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Matricule.Location = new System.Drawing.Point(36, 80);
            this.L_Matricule.Name = "L_Matricule";
            this.L_Matricule.Size = new System.Drawing.Size(112, 28);
            this.L_Matricule.TabIndex = 3;
            this.L_Matricule.Text = "Matricule :";
            // 
            // TB_Matricule
            // 
            this.TB_Matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Matricule.Location = new System.Drawing.Point(230, 78);
            this.TB_Matricule.Name = "TB_Matricule";
            this.TB_Matricule.Size = new System.Drawing.Size(203, 30);
            this.TB_Matricule.TabIndex = 4;
            // 
            // L_Nom
            // 
            this.L_Nom.AutoSize = true;
            this.L_Nom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Nom.Location = new System.Drawing.Point(36, 116);
            this.L_Nom.Name = "L_Nom";
            this.L_Nom.Size = new System.Drawing.Size(66, 28);
            this.L_Nom.TabIndex = 5;
            this.L_Nom.Text = "Nom :";
            // 
            // TB_Nom
            // 
            this.TB_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nom.Location = new System.Drawing.Point(230, 114);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(203, 30);
            this.TB_Nom.TabIndex = 6;
            // 
            // CB_Droit
            // 
            this.CB_Droit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Droit.FormattingEnabled = true;
            this.CB_Droit.Items.AddRange(new object[] {
            "Voyageur",
            "Archiviste"});
            this.CB_Droit.Location = new System.Drawing.Point(230, 150);
            this.CB_Droit.Name = "CB_Droit";
            this.CB_Droit.Size = new System.Drawing.Size(203, 33);
            this.CB_Droit.TabIndex = 8;
            // 
            // L_Droit
            // 
            this.L_Droit.AutoSize = true;
            this.L_Droit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Droit.Location = new System.Drawing.Point(36, 155);
            this.L_Droit.Name = "L_Droit";
            this.L_Droit.Size = new System.Drawing.Size(131, 28);
            this.L_Droit.TabIndex = 9;
            this.L_Droit.Text = "Habilitation :";
            // 
            // L_Habitant
            // 
            this.L_Habitant.AutoSize = true;
            this.L_Habitant.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Habitant.Location = new System.Drawing.Point(36, 190);
            this.L_Habitant.Name = "L_Habitant";
            this.L_Habitant.Size = new System.Drawing.Size(188, 28);
            this.L_Habitant.TabIndex = 10;
            this.L_Habitant.Text = "Lieu de residence :";
            // 
            // CB_Habitant
            // 
            this.CB_Habitant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Habitant.FormattingEnabled = true;
            this.CB_Habitant.Items.AddRange(new object[] {
            "Langitia",
            "Lurminia",
            "Vierde",
            "Technoria",
            "Cartage"});
            this.CB_Habitant.Location = new System.Drawing.Point(230, 190);
            this.CB_Habitant.Name = "CB_Habitant";
            this.CB_Habitant.Size = new System.Drawing.Size(203, 33);
            this.CB_Habitant.TabIndex = 11;
            // 
            // B_Creation
            // 
            this.B_Creation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Creation.Location = new System.Drawing.Point(230, 229);
            this.B_Creation.Name = "B_Creation";
            this.B_Creation.Size = new System.Drawing.Size(203, 30);
            this.B_Creation.TabIndex = 12;
            this.B_Creation.Text = "Creation du compte";
            this.B_Creation.UseVisualStyleBackColor = true;
            this.B_Creation.Click += new System.EventHandler(this.B_Creation_Click);
            // 
            // CreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 315);
            this.Controls.Add(this.B_Creation);
            this.Controls.Add(this.CB_Habitant);
            this.Controls.Add(this.L_Habitant);
            this.Controls.Add(this.L_Droit);
            this.Controls.Add(this.CB_Droit);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.L_Nom);
            this.Controls.Add(this.TB_Matricule);
            this.Controls.Add(this.L_Matricule);
            this.Controls.Add(this.L_Erreur);
            this.Controls.Add(this.L_Creation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreationForm";
            this.Text = "Creer un compte";
            this.Load += new System.EventHandler(this.CreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Creation;
        private System.Windows.Forms.Label L_Erreur;
        private System.Windows.Forms.Label L_Matricule;
        private System.Windows.Forms.TextBox TB_Matricule;
        private System.Windows.Forms.Label L_Nom;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.ComboBox CB_Droit;
        private System.Windows.Forms.Label L_Droit;
        private System.Windows.Forms.Label L_Habitant;
        private System.Windows.Forms.ComboBox CB_Habitant;
        private System.Windows.Forms.Button B_Creation;
    }
}