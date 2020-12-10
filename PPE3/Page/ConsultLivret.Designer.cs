namespace PPE3.Page
{
    partial class ConsultLivret
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
            this.btnFin = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Selectionner la classe :";
            // 
            // cbbClasse
            // 
            this.cbbClasse.FormattingEnabled = true;
            this.cbbClasse.Location = new System.Drawing.Point(12, 24);
            this.cbbClasse.Name = "cbbClasse";
            this.cbbClasse.Size = new System.Drawing.Size(308, 21);
            this.cbbClasse.TabIndex = 30;
            this.cbbClasse.SelectedIndexChanged += new System.EventHandler(this.CbbClasse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Selectionner le nom de l\'etudiant  :";
            // 
            // cbbNomEtudiant
            // 
            this.cbbNomEtudiant.FormattingEnabled = true;
            this.cbbNomEtudiant.Location = new System.Drawing.Point(12, 68);
            this.cbbNomEtudiant.Name = "cbbNomEtudiant";
            this.cbbNomEtudiant.Size = new System.Drawing.Size(308, 21);
            this.cbbNomEtudiant.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Attention cette operation peut prend quelque seconde";
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(12, 149);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(308, 23);
            this.btnFin.TabIndex = 33;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(12, 120);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(308, 23);
            this.btnValider.TabIndex = 34;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // ConsultLivret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 234);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbClasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbNomEtudiant);
            this.Name = "ConsultLivret";
            this.Text = "ConsultLivret";
            this.Load += new System.EventHandler(this.ConsultLivret_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbClasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNomEtudiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Button btnValider;
    }
}