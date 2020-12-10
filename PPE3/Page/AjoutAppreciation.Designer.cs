namespace PPE3.Page
{
    partial class AjoutAppreciation
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
            this.txtAppreciationActu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelErreur2 = new System.Windows.Forms.Label();
            this.labelErreur = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtAppreciation = new System.Windows.Forms.TextBox();
            this.cbbNomEtudiant = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbClasse = new System.Windows.Forms.ComboBox();
            this.btnFin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMatiere = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtAppreciationActu
            // 
            this.txtAppreciationActu.Location = new System.Drawing.Point(12, 164);
            this.txtAppreciationActu.Multiline = true;
            this.txtAppreciationActu.Name = "txtAppreciationActu";
            this.txtAppreciationActu.Size = new System.Drawing.Size(308, 107);
            this.txtAppreciationActu.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Appreciation actuel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Saisir son appreciation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Selectionner le nom de l\'etudiant  :";
            // 
            // labelErreur2
            // 
            this.labelErreur2.AutoSize = true;
            this.labelErreur2.ForeColor = System.Drawing.Color.Red;
            this.labelErreur2.Location = new System.Drawing.Point(19, 447);
            this.labelErreur2.Name = "labelErreur2";
            this.labelErreur2.Size = new System.Drawing.Size(35, 13);
            this.labelErreur2.TabIndex = 21;
            this.labelErreur2.Text = "label1";
            this.labelErreur2.Visible = false;
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(19, 434);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(35, 13);
            this.labelErreur.TabIndex = 20;
            this.labelErreur.Text = "label1";
            this.labelErreur.Visible = false;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(148, 405);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(172, 22);
            this.btnValider.TabIndex = 19;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // txtAppreciation
            // 
            this.txtAppreciation.Location = new System.Drawing.Point(12, 296);
            this.txtAppreciation.Multiline = true;
            this.txtAppreciation.Name = "txtAppreciation";
            this.txtAppreciation.Size = new System.Drawing.Size(308, 103);
            this.txtAppreciation.TabIndex = 18;
            // 
            // cbbNomEtudiant
            // 
            this.cbbNomEtudiant.FormattingEnabled = true;
            this.cbbNomEtudiant.Location = new System.Drawing.Point(12, 116);
            this.cbbNomEtudiant.Name = "cbbNomEtudiant";
            this.cbbNomEtudiant.Size = new System.Drawing.Size(308, 21);
            this.cbbNomEtudiant.TabIndex = 17;
            this.cbbNomEtudiant.SelectedIndexChanged += new System.EventHandler(this.CbbNomEtudiant_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Selectionner la classe :";
            // 
            // cbbClasse
            // 
            this.cbbClasse.FormattingEnabled = true;
            this.cbbClasse.Location = new System.Drawing.Point(12, 72);
            this.cbbClasse.Name = "cbbClasse";
            this.cbbClasse.Size = new System.Drawing.Size(308, 21);
            this.cbbClasse.TabIndex = 26;
            this.cbbClasse.SelectedIndexChanged += new System.EventHandler(this.CbbClasse_SelectedIndexChanged);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(12, 477);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(308, 23);
            this.btnFin.TabIndex = 28;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Selectionner la matiere :";
            // 
            // cbbMatiere
            // 
            this.cbbMatiere.FormattingEnabled = true;
            this.cbbMatiere.Location = new System.Drawing.Point(12, 25);
            this.cbbMatiere.Name = "cbbMatiere";
            this.cbbMatiere.Size = new System.Drawing.Size(308, 21);
            this.cbbMatiere.TabIndex = 29;
            // 
            // AjoutAppreciation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 524);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbMatiere);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbClasse);
            this.Controls.Add(this.txtAppreciationActu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelErreur2);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtAppreciation);
            this.Controls.Add(this.cbbNomEtudiant);
            this.Name = "AjoutAppreciation";
            this.Text = "AjoutAppreciation";
            this.Load += new System.EventHandler(this.AjoutAppreciation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppreciationActu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelErreur2;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtAppreciation;
        private System.Windows.Forms.ComboBox cbbNomEtudiant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbClasse;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMatiere;
    }
}