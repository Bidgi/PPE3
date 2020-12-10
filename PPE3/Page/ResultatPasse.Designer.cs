namespace PPE3.Page
{
    partial class ResultatPasse
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
            this.btnFin = new System.Windows.Forms.Button();
            this.cbbAnnee = new System.Windows.Forms.ComboBox();
            this.TxtR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.TxtP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(12, 61);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(414, 23);
            this.btnFin.TabIndex = 35;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // cbbAnnee
            // 
            this.cbbAnnee.FormattingEnabled = true;
            this.cbbAnnee.Location = new System.Drawing.Point(101, 8);
            this.cbbAnnee.Name = "cbbAnnee";
            this.cbbAnnee.Size = new System.Drawing.Size(106, 21);
            this.cbbAnnee.TabIndex = 33;
            this.cbbAnnee.SelectedIndexChanged += new System.EventHandler(this.CbbAnnee_SelectedIndexChanged);
            // 
            // TxtR
            // 
            this.TxtR.Location = new System.Drawing.Point(101, 35);
            this.TxtR.Name = "TxtR";
            this.TxtR.Size = new System.Drawing.Size(106, 20);
            this.TxtR.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Etudiants reçus :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(216, 33);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(210, 22);
            this.btnValider.TabIndex = 24;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // TxtP
            // 
            this.TxtP.Location = new System.Drawing.Point(320, 8);
            this.TxtP.Name = "TxtP";
            this.TxtP.Size = new System.Drawing.Size(106, 20);
            this.TxtP.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Etudiant présentés :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Année :";
            // 
            // ResultatPasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 114);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.cbbAnnee);
            this.Controls.Add(this.TxtR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValider);
            this.Name = "ResultatPasse";
            this.Text = "ResultatPasse";
            this.Load += new System.EventHandler(this.ResultatPasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.ComboBox cbbAnnee;
        private System.Windows.Forms.TextBox TxtR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox TxtP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}