using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE3.Classe;
using PPE3.Model;
using PPE3.MySql;
using PPE3.Page;

namespace PPE3.Page
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ferme le form en cour et ouvre un nouveau form AjoutMoyenne
        /// </summary>
        private void AjoutMoyenne_Click(object sender, EventArgs e)
        {
            AjoutMoyenne ajoutMoyenne = new AjoutMoyenne();
            ajoutMoyenne.Show();
            this.Close();
        }

        /// <summary>
        /// ferme le form en cour et ouvre un nouveau form ConsultSynthese
        /// </summary>
        private void ConsultSynthese_Click(object sender, EventArgs e)
        {
            ConsultSynthese consultSynthese = new ConsultSynthese();
            consultSynthese.Show();
            this.Close();
        }

        /// <summary>
        /// ferme le form en cour et ouvre un nouveau form AjoutAppreciation
        /// </summary>
        private void AjoutAppreciation_Click(object sender, EventArgs e)
        {
            AjoutAppreciation ajoutAppreciation = new AjoutAppreciation();
            ajoutAppreciation.Show();
            this.Close();
        }

        /// <summary>
        /// ferme le form en cour et ouvre un nouveau form ConsultLivret
        /// </summary>
        private void ConsultLivret_Click(object sender, EventArgs e)
        {
            ConsultLivret consultLivret = new ConsultLivret();
            consultLivret.Show();
            this.Close();
        }

        /// <summary>
        /// ferme le form en cour et ouvre un nouveau form ResultatPasse
        /// </summary>
        private void BtnRAP_Click(object sender, EventArgs e)
        {
            ResultatPasse resultPasse = new ResultatPasse();
            resultPasse.Show();
            this.Close();
        }

        /// <summary>
        /// ferme le form en cour et ouvre un nouveau form ConsultLivretClasse
        /// </summary>
        private void BtnLivretClasse_Click(object sender, EventArgs e)
        {
            ConsultLivretClasse consultLivretClasse = new ConsultLivretClasse();
            consultLivretClasse.Show();
            this.Close();
        }

        /// <summary>
        /// ferme le form en cour et ouvre un nouveau form AjouteStage
        /// </summary>
        private void BtnConsultStage_Click(object sender, EventArgs e)
        {
            AjouteStage ajouteStage = new AjouteStage();
            ajouteStage.Show();
            this.Close();
        }

        /// <summary>
        /// ferme le form en cour et ouvre un nouveau form ConsultStage
        /// </summary>
        private void BtnConsultStages_Click(object sender, EventArgs e)
        {
            ConsultStage consultStage = new ConsultStage();
            consultStage.Show();
            this.Close();
        }

        /// <summary>
        /// ferme le form en cour et ouvre un nouveau form ConsultEtudiantNonMoyenne
        /// </summary>
        private void btnNonMoyenne_Click(object sender, EventArgs e)
        {
            ConsultEtudiantNonMoyenne consultEtudiantNonMoyenne = new ConsultEtudiantNonMoyenne();
            consultEtudiantNonMoyenne.Show();
            this.Close();
        }
    }
}
