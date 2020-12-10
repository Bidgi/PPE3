namespace PPE3.Classe
{
    partial class ConsultStage
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
            this.btnFin = new System.Windows.Forms.Button();
            this.txtNomEnp1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDds1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDfs1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAppreciation1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAppreciation2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDfs2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDds2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomEnp2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Selectionner la classe :";
            // 
            // cbbClasse
            // 
            this.cbbClasse.FormattingEnabled = true;
            this.cbbClasse.Location = new System.Drawing.Point(15, 25);
            this.cbbClasse.Name = "cbbClasse";
            this.cbbClasse.Size = new System.Drawing.Size(308, 21);
            this.cbbClasse.TabIndex = 30;
            this.cbbClasse.SelectedIndexChanged += new System.EventHandler(this.CbbClasse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Selectionner le nom de l\'etudiant  :";
            // 
            // cbbNomEtudiant
            // 
            this.cbbNomEtudiant.FormattingEnabled = true;
            this.cbbNomEtudiant.Location = new System.Drawing.Point(329, 25);
            this.cbbNomEtudiant.Name = "cbbNomEtudiant";
            this.cbbNomEtudiant.Size = new System.Drawing.Size(308, 21);
            this.cbbNomEtudiant.TabIndex = 28;
            this.cbbNomEtudiant.SelectedIndexChanged += new System.EventHandler(this.CbbNomEtudiant_SelectedIndexChanged);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(329, 334);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(308, 23);
            this.btnFin.TabIndex = 32;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // txtNomEnp1
            // 
            this.txtNomEnp1.Location = new System.Drawing.Point(15, 97);
            this.txtNomEnp1.Name = "txtNomEnp1";
            this.txtNomEnp1.Size = new System.Drawing.Size(136, 20);
            this.txtNomEnp1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nom entreprise :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Date de debut de stage :";
            // 
            // txtDds1
            // 
            this.txtDds1.Location = new System.Drawing.Point(15, 136);
            this.txtDds1.Name = "txtDds1";
            this.txtDds1.Size = new System.Drawing.Size(136, 20);
            this.txtDds1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Date de fin de stage :";
            // 
            // txtDfs1
            // 
            this.txtDfs1.Location = new System.Drawing.Point(15, 179);
            this.txtDfs1.Name = "txtDfs1";
            this.txtDfs1.Size = new System.Drawing.Size(136, 20);
            this.txtDfs1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Appreciation :";
            // 
            // txtAppreciation1
            // 
            this.txtAppreciation1.Location = new System.Drawing.Point(15, 218);
            this.txtAppreciation1.Multiline = true;
            this.txtAppreciation1.Name = "txtAppreciation1";
            this.txtAppreciation1.Size = new System.Drawing.Size(308, 110);
            this.txtAppreciation1.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Appreciation :";
            // 
            // txtAppreciation2
            // 
            this.txtAppreciation2.Location = new System.Drawing.Point(329, 218);
            this.txtAppreciation2.Multiline = true;
            this.txtAppreciation2.Name = "txtAppreciation2";
            this.txtAppreciation2.Size = new System.Drawing.Size(308, 110);
            this.txtAppreciation2.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Date de fin de stage :";
            // 
            // txtDfs2
            // 
            this.txtDfs2.Location = new System.Drawing.Point(329, 179);
            this.txtDfs2.Name = "txtDfs2";
            this.txtDfs2.Size = new System.Drawing.Size(136, 20);
            this.txtDfs2.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Date de debut de stage :";
            // 
            // txtDds2
            // 
            this.txtDds2.Location = new System.Drawing.Point(329, 136);
            this.txtDds2.Name = "txtDds2";
            this.txtDds2.Size = new System.Drawing.Size(136, 20);
            this.txtDds2.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Nom entreprise :";
            // 
            // txtNomEnp2
            // 
            this.txtNomEnp2.Location = new System.Drawing.Point(329, 97);
            this.txtNomEnp2.Name = "txtNomEnp2";
            this.txtNomEnp2.Size = new System.Drawing.Size(136, 20);
            this.txtNomEnp2.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "Premier stage :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(325, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 24);
            this.label12.TabIndex = 50;
            this.label12.Text = "Deuxieme stage :";
            // 
            // ConsultStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 378);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAppreciation2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDfs2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDds2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomEnp2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAppreciation1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDfs1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDds1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomEnp1);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbClasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbNomEtudiant);
            this.Name = "ConsultStage";
            this.Text = "ConsultStage";
            this.Load += new System.EventHandler(this.ConsultStage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbClasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNomEtudiant;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.TextBox txtNomEnp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDds1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDfs1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAppreciation1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAppreciation2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDfs2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDds2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomEnp2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}