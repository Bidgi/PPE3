using PPE3.MySql;
using PPE3.Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3.Classe
{
    public partial class ConsultStage : Form
    {
        public ConsultStage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// permet de charger les combobox avec le nom des classe
        /// </summary>
        private void ConsultStage_Load(object sender, EventArgs e)
        {
            foreach (string nom in GestionBDD.CbbNomClasse()) cbbClasse.Items.Add(nom);
            cbbClasse.SelectedIndex = 0;
        }

        /// <summary>
        /// permet de charger le combobox des etudiant en fonction de la classe
        /// </summary>
        private void CbbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string nom in GestionBDD.CbbNomPrenomEtudiant(GestionBDD.ChercheID("select ID_CLASSE from classe where NOM_CLASSE = \'" + cbbClasse.Text + "\'"))) cbbNomEtudiant.Items.Add(nom);
            cbbNomEtudiant.SelectedIndex = 0;
        }

        /// <summary>
        /// permet d'affiche les information des stage d'un etudiant 
        /// </summary>
        private void CbbNomEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<List<string>> stages = GestionBDD.InfoStage(cbbNomEtudiant.Text);
                txtNomEnp1.Text = stages.ElementAt(0).ElementAt(0);
                txtDds1.Text = stages.ElementAt(0).ElementAt(1);
                txtDfs1.Text = stages.ElementAt(0).ElementAt(2);
                txtAppreciation1.Text = stages.ElementAt(0).ElementAt(3);

                txtNomEnp2.Text = stages.ElementAt(1).ElementAt(0);
                txtDds2.Text = stages.ElementAt(1).ElementAt(1);
                txtDfs2.Text = stages.ElementAt(1).ElementAt(2);
                txtAppreciation2.Text = stages.ElementAt(1).ElementAt(3);
            }
            catch { }
        }

        /// <summary>
        /// ferme le form en cour et ouvre un nouveau form accueil
        /// </summary>
        private void BtnFin_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }
    }
}
