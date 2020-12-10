namespace PPE3.Page
{
    partial class ConsultSynthese
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
            this.cbbClasse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(545, 414);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(243, 24);
            this.btnFin.TabIndex = 0;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // cbbClasse
            // 
            this.cbbClasse.FormattingEnabled = true;
            this.cbbClasse.Location = new System.Drawing.Point(12, 25);
            this.cbbClasse.Name = "cbbClasse";
            this.cbbClasse.Size = new System.Drawing.Size(170, 21);
            this.cbbClasse.TabIndex = 1;
            this.cbbClasse.SelectedIndexChanged += new System.EventHandler(this.CbbClasse_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Selectionner la classe :";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 52);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 356);
            this.dgv.TabIndex = 29;
            // 
            // ConsultSynthese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbClasse);
            this.Controls.Add(this.btnFin);
            this.Name = "ConsultSynthese";
            this.Text = "ConsultSynthese";
            this.Load += new System.EventHandler(this.ConsultSynthese_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.ComboBox cbbClasse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv;
    }
}