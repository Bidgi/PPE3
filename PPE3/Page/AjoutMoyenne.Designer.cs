namespace PPE3.Page
{
    partial class AjoutMoyenne
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelErreur2 = new System.Windows.Forms.Label();
            this.labelErreur = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtMoyenne = new System.Windows.Forms.TextBox();
            this.cbbNomEtudiant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoyenneActu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbClasse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMatiere = new System.Windows.Forms.ComboBox();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Saisir sa moyenne :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Selectionner le nom de l\'etudiant  :";
            // 
            // labelErreur2
            // 
            this.labelErreur2.AutoSize = true;
            this.labelErreur2.ForeColor = System.Drawing.Color.Red;
            this.labelErreur2.Location = new System.Drawing.Point(20, 257);
            this.labelErreur2.Name = "labelErreur2";
            this.labelErreur2.Size = new System.Drawing.Size(35, 13);
            this.labelErreur2.TabIndex = 12;
            this.labelErreur2.Text = "label1";
            this.labelErreur2.Visible = false;
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(20, 244);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(35, 13);
            this.labelErreur.TabIndex = 11;
            this.labelErreur.Text = "label1";
            this.labelErreur.Visible = false;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(159, 215);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(172, 22);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // txtMoyenne
            // 
            this.txtMoyenne.Location = new System.Drawing.Point(23, 189);
            this.txtMoyenne.Name = "txtMoyenne";
            this.txtMoyenne.Size = new System.Drawing.Size(308, 20);
            this.txtMoyenne.TabIndex = 9;
            // 
            // cbbNomEtudiant
            // 
            this.cbbNomEtudiant.FormattingEnabled = true;
            this.cbbNomEtudiant.Location = new System.Drawing.Point(23, 122);
            this.cbbNomEtudiant.Name = "cbbNomEtudiant";
            this.cbbNomEtudiant.Size = new System.Drawing.Size(308, 21);
            this.cbbNomEtudiant.TabIndex = 8;
            this.cbbNomEtudiant.SelectedIndexChanged += new System.EventHandler(this.CbbNomEtudiant_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Moyenne actuel :";
            // 
            // txtMoyenneActu
            // 
            this.txtMoyenneActu.Enabled = false;
            this.txtMoyenneActu.Location = new System.Drawing.Point(231, 149);
            this.txtMoyenneActu.Name = "txtMoyenneActu";
            this.txtMoyenneActu.Size = new System.Drawing.Size(100, 20);
            this.txtMoyenneActu.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Selectionner la classe :";
            // 
            // cbbClasse
            // 
            this.cbbClasse.FormattingEnabled = true;
            this.cbbClasse.Location = new System.Drawing.Point(23, 78);
            this.cbbClasse.Name = "cbbClasse";
            this.cbbClasse.Size = new System.Drawing.Size(308, 21);
            this.cbbClasse.TabIndex = 17;
            this.cbbClasse.SelectedIndexChanged += new System.EventHandler(this.CbbClasse_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Selectionner la matiere :";
            // 
            // cbbMatiere
            // 
            this.cbbMatiere.FormattingEnabled = true;
            this.cbbMatiere.Location = new System.Drawing.Point(23, 34);
            this.cbbMatiere.Name = "cbbMatiere";
            this.cbbMatiere.Size = new System.Drawing.Size(308, 21);
            this.cbbMatiere.TabIndex = 19;
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(23, 285);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(308, 23);
            this.btnFin.TabIndex = 21;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // AjoutMoyenne
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbMatiere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbClasse);
            this.Controls.Add(this.txtMoyenneActu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelErreur2);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtMoyenne);
            this.Controls.Add(this.cbbNomEtudiant);
            this.Name = "AjoutMoyenne";
            this.Text = "AjoutMoyenne";
            this.Load += new System.EventHandler(this.AjoutMoyenne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelErreur2;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtMoyenne;
        private System.Windows.Forms.ComboBox cbbNomEtudiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoyenneActu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbClasse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMatiere;
        private System.Windows.Forms.Button btnFin;
    }
}