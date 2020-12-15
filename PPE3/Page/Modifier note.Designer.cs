namespace PPE3.Page
{
    partial class Modifier_note
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
            this.label11 = new System.Windows.Forms.Label();
            this.btnFin = new System.Windows.Forms.Button();
            this.txtMoyenneActu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelErreur2 = new System.Windows.Forms.Label();
            this.labelErreur = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtMoyenne = new System.Windows.Forms.TextBox();
            this.cbbMatiere = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCoef = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNomEtudiant = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 24);
            this.label11.TabIndex = 50;
            this.label11.Text = "Modifier note :";
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(16, 310);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(308, 23);
            this.btnFin.TabIndex = 58;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // txtMoyenneActu
            // 
            this.txtMoyenneActu.Enabled = false;
            this.txtMoyenneActu.Location = new System.Drawing.Point(224, 174);
            this.txtMoyenneActu.Name = "txtMoyenneActu";
            this.txtMoyenneActu.Size = new System.Drawing.Size(100, 20);
            this.txtMoyenneActu.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Moyenne actuel :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Saisir sa moyenne :";
            // 
            // labelErreur2
            // 
            this.labelErreur2.AutoSize = true;
            this.labelErreur2.ForeColor = System.Drawing.Color.Red;
            this.labelErreur2.Location = new System.Drawing.Point(13, 282);
            this.labelErreur2.Name = "labelErreur2";
            this.labelErreur2.Size = new System.Drawing.Size(35, 13);
            this.labelErreur2.TabIndex = 54;
            this.labelErreur2.Text = "label1";
            this.labelErreur2.Visible = false;
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(13, 269);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(35, 13);
            this.labelErreur.TabIndex = 53;
            this.labelErreur.Text = "label1";
            this.labelErreur.Visible = false;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(152, 240);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(172, 22);
            this.btnValider.TabIndex = 52;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtMoyenne
            // 
            this.txtMoyenne.Location = new System.Drawing.Point(16, 214);
            this.txtMoyenne.Name = "txtMoyenne";
            this.txtMoyenne.Size = new System.Drawing.Size(308, 20);
            this.txtMoyenne.TabIndex = 51;
            // 
            // cbbMatiere
            // 
            this.cbbMatiere.FormattingEnabled = true;
            this.cbbMatiere.Location = new System.Drawing.Point(16, 115);
            this.cbbMatiere.Name = "cbbMatiere";
            this.cbbMatiere.Size = new System.Drawing.Size(309, 21);
            this.cbbMatiere.TabIndex = 59;
            this.cbbMatiere.SelectedIndexChanged += new System.EventHandler(this.cbbMatiere_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Selection matiere :";
            // 
            // txtCoef
            // 
            this.txtCoef.Enabled = false;
            this.txtCoef.Location = new System.Drawing.Point(224, 142);
            this.txtCoef.Name = "txtCoef";
            this.txtCoef.Size = new System.Drawing.Size(100, 20);
            this.txtCoef.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Coefficient de la matiere selection  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Selectionner le nom de l\'etudiant  :";
            // 
            // cbbNomEtudiant
            // 
            this.cbbNomEtudiant.FormattingEnabled = true;
            this.cbbNomEtudiant.Location = new System.Drawing.Point(16, 67);
            this.cbbNomEtudiant.Name = "cbbNomEtudiant";
            this.cbbNomEtudiant.Size = new System.Drawing.Size(308, 21);
            this.cbbNomEtudiant.TabIndex = 63;
            // 
            // Modifier_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbNomEtudiant);
            this.Controls.Add(this.txtCoef);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbMatiere);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.txtMoyenneActu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelErreur2);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtMoyenne);
            this.Controls.Add(this.label11);
            this.Name = "Modifier_note";
            this.Text = "Modifier_note";
            this.Load += new System.EventHandler(this.Modifier_note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.TextBox txtMoyenneActu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelErreur2;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtMoyenne;
        private System.Windows.Forms.ComboBox cbbMatiere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCoef;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNomEtudiant;
    }
}