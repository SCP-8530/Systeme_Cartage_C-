namespace Project_Final
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.L_Login = new System.Windows.Forms.Label();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.B_Login = new System.Windows.Forms.Button();
            this.L_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Login.Location = new System.Drawing.Point(27, 38);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(208, 39);
            this.L_Login.TabIndex = 0;
            this.L_Login.Text = "Se Connecter :";
            // 
            // TB_Login
            // 
            this.TB_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Login.Location = new System.Drawing.Point(34, 80);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(201, 38);
            this.TB_Login.TabIndex = 1;
            // 
            // B_Login
            // 
            this.B_Login.Location = new System.Drawing.Point(34, 124);
            this.B_Login.Name = "B_Login";
            this.B_Login.Size = new System.Drawing.Size(113, 23);
            this.B_Login.TabIndex = 2;
            this.B_Login.Text = "Se Connecter";
            this.B_Login.UseVisualStyleBackColor = true;
            this.B_Login.Click += new System.EventHandler(this.B_Login_Click);
            // 
            // L_Error
            // 
            this.L_Error.AutoSize = true;
            this.L_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Error.ForeColor = System.Drawing.Color.Red;
            this.L_Error.Location = new System.Drawing.Point(31, 150);
            this.L_Error.Name = "L_Error";
            this.L_Error.Size = new System.Drawing.Size(182, 48);
            this.L_Error.TabIndex = 3;
            this.L_Error.Text = "Votre matricule n\'est pas \r\nreferencer dans la \r\nbase de donnee\r\n";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 227);
            this.Controls.Add(this.L_Error);
            this.Controls.Add(this.B_Login);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.L_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionForm";
            this.Text = "Se Connecter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.Button B_Login;
        private System.Windows.Forms.Label L_Error;
    }
}