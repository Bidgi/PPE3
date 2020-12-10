namespace PPE3.Classe
{
    partial class AjouteStage
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbbClasse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNomEtudiant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomEntreprise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbNumStage = new System.Windows.Forms.ComboBox();
            this.txtAppreciation = new System.Windows.Forms.TextBox();
            this.dtpDebutStage = new System.Windows.Forms.DateTimePicker();
            this.dtpFinStage = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Selectionner la classe :";
            // 
            // cbbClasse
            // 
            this.cbbClasse.FormattingEnabled = true;
            this.cbbClasse.Location = new System.Drawing.Point(12, 26);
            this.cbbClasse.Name = "cbbClasse";
            this.cbbClasse.Size = new System.Drawing.Size(308, 21);
            this.cbbClasse.TabIndex = 30;
            this.cbbClasse.SelectedIndexChanged += new System.EventHandler(this.CbbClasse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Selectionner le nom de l\'etudiant  :";
            // 
            // cbbNomEtudiant
            // 
            this.cbbNomEtudiant.FormattingEnabled = true;
            this.cbbNomEtudiant.Location = new System.Drawing.Point(12, 66);
            this.cbbNomEtudiant.Name = "cbbNomEtudiant";
            this.cbbNomEtudiant.Size = new System.Drawing.Size(308, 21);
            this.cbbNomEtudiant.TabIndex = 28;
            this.cbbNomEtudiant.SelectedIndexChanged += new System.EventHandler(this.CbbNomEtudiant_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Numero du stage  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nom entreprise  :";
            // 
            // txtNomEntreprise
            // 
            this.txtNomEntreprise.Location = new System.Drawing.Point(12, 146);
            this.txtNomEntreprise.Name = "txtNomEntreprise";
            this.txtNomEntreprise.Size = new System.Drawing.Size(308, 20);
            this.txtNomEntreprise.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Appreciation  :";
            // 
            // cbbNumStage
            // 
            this.cbbNumStage.FormattingEnabled = true;
            this.cbbNumStage.Location = new System.Drawing.Point(12, 106);
            this.cbbNumStage.Name = "cbbNumStage";
            this.cbbNumStage.Size = new System.Drawing.Size(308, 21);
            this.cbbNumStage.TabIndex = 32;
            this.cbbNumStage.SelectedIndexChanged += new System.EventHandler(this.CbbNumStage_SelectedIndexChanged);
            // 
            // txtAppreciation
            // 
            this.txtAppreciation.Location = new System.Drawing.Point(12, 263);
            this.txtAppreciation.Multiline = true;
            this.txtAppreciation.Name = "txtAppreciation";
            this.txtAppreciation.Size = new System.Drawing.Size(308, 88);
            this.txtAppreciation.TabIndex = 40;
            // 
            // dtpDebutStage
            // 
            this.dtpDebutStage.Location = new System.Drawing.Point(12, 185);
            this.dtpDebutStage.Name = "dtpDebutStage";
            this.dtpDebutStage.Size = new System.Drawing.Size(200, 20);
            this.dtpDebutStage.TabIndex = 41;
            // 
            // dtpFinStage
            // 
            this.dtpFinStage.Location = new System.Drawing.Point(12, 224);
            this.dtpFinStage.Name = "dtpFinStage";
            this.dtpFinStage.Size = new System.Drawing.Size(200, 20);
            this.dtpFinStage.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Date de debut du stage :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Date de fin de stage :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(12, 360);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(308, 26);
            this.btnValider.TabIndex = 45;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(12, 392);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(308, 23);
            this.btnFin.TabIndex = 46;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // AjouteStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 428);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFinStage);
            this.Controls.Add(this.dtpDebutStage);
            this.Controls.Add(this.txtAppreciation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomEntreprise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbNumStage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbClasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbNomEtudiant);
            this.Name = "AjouteStage";
            this.Text = "²";
            this.Load += new System.EventHandler(this.AjouteStage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbClasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNomEtudiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomEntreprise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbNumStage;
        private System.Windows.Forms.TextBox txtAppreciation;
        private System.Windows.Forms.DateTimePicker dtpDebutStage;
        private System.Windows.Forms.DateTimePicker dtpFinStage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFin;
    }
}