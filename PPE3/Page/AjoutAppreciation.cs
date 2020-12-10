using PPE3.Classe;
using PPE3.MySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3.Page
{
    public partial class AjoutAppreciation : Form
    {
        public string nomPrenomEtudiant = null;
        public AjoutAppreciation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// incremente les combo box des classe et des nom de matiere au chargement du form
        /// </summary>
        private void AjoutAppreciation_Load(object sender, EventArgs e)
        {
            foreach (string nom in GestionBDD.CbbNomMatiere(Connection.nomProf)) cbbMatiere.Items.Add(nom);
            cbbMatiere.SelectedIndex = 0;
            foreach (string nom in GestionBDD.CbbNomClasse()) cbbClasse.Items.Add(nom);
            cbbClasse.SelectedIndex = 0;
        }

        /// <summary>
        /// incremente le combo box avec le nom des etudiant en fonction de la classe selectionner
        /// </summary>
        private void CbbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNomEtudiant.Items.Clear();
            foreach (string nom in GestionBDD.CbbNomPrenomEtudiant(GestionBDD.ChercheID("select ID_CLASSE from classe where NOM_CLASSE = \'" + cbbClasse.Text + "\'"))) cbbNomEtudiant.Items.Add(nom);
            cbbNomEtudiant.SelectedIndex = 0;
        }

        /// <summary>
        /// au changement d'index du combo  box etudiant cherche sa moyenne actuel
        /// </summary>
        private void CbbNomEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomPrenomEtudiant = cbbNomEtudiant.Text;
            string[] nomPrenom = cbbNomEtudiant.Text.Split(new Char[] { '.' });
            txtAppreciationActu.Text = GestionBDD.InfoEtudiantActu("APPRECIATION", nomPrenom[0], nomPrenom[1], GestionBDD.ChercheID("SELECT ID_MATIERE FROM matiere WHERE LIBELLE_MATIERE = \'" + cbbMatiere.Text + "\'"));
        }

        /// <summary>
        /// de modifier l'appreciation d'un etudiant 
        /// </summary>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            string[] nomPrenom = cbbNomEtudiant.Text.Split(new Char[] { '.' });
            int idEtudiant = GestionBDD.ChercheID("SELECT ID_ETUDIANT FROM etudiant WHERE NOM_ETUDIANT = \'" + nomPrenom[0] + "\' AND PRENOM_ETUDIANT = \'" + nomPrenom[1] + "\'");
            int idMatiere = GestionBDD.ChercheID("SELECT ID_MATIERE FROM matiere WHERE LIBELLE_MATIERE = \'" + cbbMatiere.Text + "\'");
            GestionBDD.InsertUpdate("UPDATE participe SET APPRECIATION = " + Utilitaires.ChangeChar(txtAppreciation.Text,"\'") + " WHERE ID_ETUDIANT = " + idEtudiant + " and ID_MATIERE = " + idMatiere);
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
