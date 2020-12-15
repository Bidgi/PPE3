using PPE3.Classe;
using PPE3.Model;
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
    public partial class Modifier_note : Form
    {
        public Modifier_note()
        {
            InitializeComponent();
        }

        private void Modifier_note_Load(object sender, EventArgs e)
        {
            foreach (Synthese uneSynthese in GestionBDD.EtudiantNonMoyenne()) cbbNomEtudiant.Items.Add(uneSynthese.Nom + "." + uneSynthese.Prenom);
            cbbNomEtudiant.SelectedIndex = 0;
            foreach (Matiere uneMatiere in Matiere.CollClasseMatiere) cbbMatiere.Items.Add(uneMatiere.NomComplet);
            cbbMatiere.SelectedIndex = 0;
        }
        private void cbbMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomPrenom = cbbNomEtudiant.Text.Split(new Char[] { '.' });
            txtCoef.Text = Matiere.CollClasseMatiere.Find(x => x.NomComplet == cbbMatiere.Text).Coef.ToString();
            txtMoyenneActu.Text = Synthese.CollClasseSynthese.FindAll(x => x.Nom == nomPrenom.ElementAt(0)).Find(x => x.Prenom == nomPrenom.ElementAt(1)).LesMoyenne.Find(x => x.LaMatiere.NomComplet == cbbMatiere.Text).Moyenne.ToString();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMoyenne.Text, out int i))
            {
                string[] nomPrenom = cbbNomEtudiant.Text.Split(new Char[] { '.' });
                int idEtudiant = GestionBDD.ChercheID("SELECT ID_ETUDIANT FROM etudiant WHERE NOM_ETUDIANT = \'" + nomPrenom.ElementAt(0) + "\' AND PRENOM_ETUDIANT = \'" + nomPrenom.ElementAt(1) + "\'");
                int idMatiere = GestionBDD.ChercheID("SELECT ID_MATIERE FROM matiere WHERE LIBELLE_MATIERE = \'" + cbbMatiere.Text + "\'");
                GestionBDD.InsertUpdate("UPDATE participe SET MOYENNE = " + i + " WHERE ID_ETUDIANT = " + idEtudiant + " and ID_MATIERE = " + idMatiere);
                txtMoyenneActu.Text = GestionBDD.InfoEtudiantActu("MOYENNE", nomPrenom.ElementAt(0), nomPrenom.ElementAt(1), GestionBDD.ChercheID("SELECT ID_MATIERE FROM matiere WHERE LIBELLE_MATIERE = \'" + cbbMatiere.Text + "\'"));
            }
            else
            {
                labelErreur.Text = "La moyenne entre n'est pas valide";
                labelErreur.Visible = true;
            }
        }

        /// <summary>
        /// ferme le form en cour et ouvre un nouveau form ConsultEtudiantNonMoyenne
        /// </summary>
        private void btnFin_Click(object sender, EventArgs e)
        {
            ConsultEtudiantNonMoyenne consultEtudiantNonMoyenne = new ConsultEtudiantNonMoyenne();
            consultEtudiantNonMoyenne.Show();
            this.Close();
        }
    }
}
