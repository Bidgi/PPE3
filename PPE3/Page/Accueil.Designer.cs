namespace PPE3.Page
{
    partial class Accueil
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
            this.AjoutMoyenne = new System.Windows.Forms.Button();
            this.AjoutAppreciation = new System.Windows.Forms.Button();
            this.ConsultSynthese = new System.Windows.Forms.Button();
            this.ConsultLivret = new System.Windows.Forms.Button();
            this.btnRAP = new System.Windows.Forms.Button();
            this.BtnLivretClasse = new System.Windows.Forms.Button();
            this.btnConsultStage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AjoutMoyenne
            // 
            this.AjoutMoyenne.Location = new System.Drawing.Point(12, 12);
            this.AjoutMoyenne.Name = "AjoutMoyenne";
            this.AjoutMoyenne.Size = new System.Drawing.Size(243, 35);
            this.AjoutMoyenne.TabIndex = 0;
            this.AjoutMoyenne.Text = "Ajouter une moyenne";
            this.AjoutMoyenne.UseVisualStyleBackColor = true;
            this.AjoutMoyenne.Click += new System.EventHandler(this.AjoutMoyenne_Click);
            // 
            // AjoutAppreciation
            // 
            this.AjoutAppreciation.Location = new System.Drawing.Point(12, 53);
            this.AjoutAppreciation.Name = "AjoutAppreciation";
            this.AjoutAppreciation.Size = new System.Drawing.Size(243, 35);
            this.AjoutAppreciation.TabIndex = 1;
            this.AjoutAppreciation.Text = "Ajouter une appreciation";
            this.AjoutAppreciation.UseVisualStyleBackColor = true;
            this.AjoutAppreciation.Click += new System.EventHandler(this.AjoutAppreciation_Click);
            // 
            // ConsultSynthese
            // 
            this.ConsultSynthese.Location = new System.Drawing.Point(12, 94);
            this.ConsultSynthese.Name = "ConsultSynthese";
            this.ConsultSynthese.Size = new System.Drawing.Size(243, 35);
            this.ConsultSynthese.TabIndex = 2;
            this.ConsultSynthese.Text = "Consulter une synthese";
            this.ConsultSynthese.UseVisualStyleBackColor = true;
            this.ConsultSynthese.Click += new System.EventHandler(this.ConsultSynthese_Click);
            // 
            // ConsultLivret
            // 
            this.ConsultLivret.Location = new System.Drawing.Point(12, 135);
            this.ConsultLivret.Name = "ConsultLivret";
            this.ConsultLivret.Size = new System.Drawing.Size(243, 35);
            this.ConsultLivret.TabIndex = 3;
            this.ConsultLivret.Text = "Crée un livret";
            this.ConsultLivret.UseVisualStyleBackColor = true;
            this.ConsultLivret.Click += new System.EventHandler(this.ConsultLivret_Click);
            // 
            // btnRAP
            // 
            this.btnRAP.Location = new System.Drawing.Point(12, 176);
            this.btnRAP.Name = "btnRAP";
            this.btnRAP.Size = new System.Drawing.Size(243, 35);
            this.btnRAP.TabIndex = 4;
            this.btnRAP.Text = "Résultat Année passer";
            this.btnRAP.UseVisualStyleBackColor = true;
            this.btnRAP.Click += new System.EventHandler(this.BtnRAP_Click);
            // 
            // BtnLivretClasse
            // 
            this.BtnLivretClasse.Location = new System.Drawing.Point(12, 217);
            this.BtnLivretClasse.Name = "BtnLivretClasse";
            this.BtnLivretClasse.Size = new System.Drawing.Size(243, 35);
            this.BtnLivretClasse.TabIndex = 5;
            this.BtnLivretClasse.Text = "Crées tous les livrets d\'une classe";
            this.BtnLivretClasse.UseVisualStyleBackColor = true;
            this.BtnLivretClasse.Click += new System.EventHandler(this.BtnLivretClasse_Click);
            // 
            // btnConsultStage
            // 
            this.btnConsultStage.Location = new System.Drawing.Point(12, 258);
            this.btnConsultStage.Name = "btnConsultStage";
            this.btnConsultStage.Size = new System.Drawing.Size(243, 35);
            this.btnConsultStage.TabIndex = 6;
            this.btnConsultStage.Text = "Ajoute un stage";
            this.btnConsultStage.UseVisualStyleBackColor = true;
            this.btnConsultStage.Click += new System.EventHandler(this.BtnConsultStage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Consulter les stage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnConsultStages_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConsultStage);
            this.Controls.Add(this.BtnLivretClasse);
            this.Controls.Add(this.btnRAP);
            this.Controls.Add(this.ConsultLivret);
            this.Controls.Add(this.ConsultSynthese);
            this.Controls.Add(this.AjoutAppreciation);
            this.Controls.Add(this.AjoutMoyenne);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AjoutMoyenne;
        private System.Windows.Forms.Button AjoutAppreciation;
        private System.Windows.Forms.Button ConsultSynthese;
        private System.Windows.Forms.Button ConsultLivret;
        private System.Windows.Forms.Button btnRAP;
        private System.Windows.Forms.Button BtnLivretClasse;
        private System.Windows.Forms.Button btnConsultStage;
        private System.Windows.Forms.Button button1;
    }
}