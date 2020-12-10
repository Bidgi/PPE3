namespace PPE3
{
    partial class Connection
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
            this.cbbNomConnection = new System.Windows.Forms.ComboBox();
            this.txtBmdp = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.labelErreur = new System.Windows.Forms.Label();
            this.labelErreur2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbNomConnection
            // 
            this.cbbNomConnection.FormattingEnabled = true;
            this.cbbNomConnection.Location = new System.Drawing.Point(12, 31);
            this.cbbNomConnection.Name = "cbbNomConnection";
            this.cbbNomConnection.Size = new System.Drawing.Size(308, 21);
            this.cbbNomConnection.TabIndex = 0;
            // 
            // txtBmdp
            // 
            this.txtBmdp.Location = new System.Drawing.Point(12, 77);
            this.txtBmdp.Name = "txtBmdp";
            this.txtBmdp.Size = new System.Drawing.Size(308, 20);
            this.txtBmdp.TabIndex = 1;
            this.txtBmdp.UseSystemPasswordChar = true;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(148, 103);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(172, 22);
            this.btnConnection.TabIndex = 2;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(9, 134);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(35, 13);
            this.labelErreur.TabIndex = 3;
            this.labelErreur.Text = "label1";
            this.labelErreur.Visible = false;
            // 
            // labelErreur2
            // 
            this.labelErreur2.AutoSize = true;
            this.labelErreur2.ForeColor = System.Drawing.Color.Red;
            this.labelErreur2.Location = new System.Drawing.Point(9, 147);
            this.labelErreur2.Name = "labelErreur2";
            this.labelErreur2.Size = new System.Drawing.Size(35, 13);
            this.labelErreur2.TabIndex = 4;
            this.labelErreur2.Text = "label1";
            this.labelErreur2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selectionner votre nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saisir votre Mot de passe :";
            // 
            // Connection
            // 
            this.AcceptButton = this.btnConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelErreur2);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.txtBmdp);
            this.Controls.Add(this.cbbNomConnection);
            this.Name = "Connection";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbNomConnection;
        private System.Windows.Forms.TextBox txtBmdp;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Label labelErreur2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

