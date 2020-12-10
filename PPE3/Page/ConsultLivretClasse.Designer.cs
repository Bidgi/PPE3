namespace PPE3.Page
{
    partial class ConsultLivretClasse
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbClasse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(12, 72);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(308, 23);
            this.btnValider.TabIndex = 41;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(12, 101);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(308, 23);
            this.btnFin.TabIndex = 40;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Attention cette operation peut prend un moment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Selectionner la classe :";
            // 
            // cbbClasse
            // 
            this.cbbClasse.FormattingEnabled = true;
            this.cbbClasse.Location = new System.Drawing.Point(12, 22);
            this.cbbClasse.Name = "cbbClasse";
            this.cbbClasse.Size = new System.Drawing.Size(308, 21);
            this.cbbClasse.TabIndex = 37;
            // 
            // ConsultLivretClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 136);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbClasse);
            this.Name = "ConsultLivretClasse";
            this.Text = "ConsultLivretClasse";
            this.Load += new System.EventHandler(this.ConsultLivretClasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbClasse;
    }
}