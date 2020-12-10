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
    public partial class AjouteStage : Form
    {
        public AjouteStage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// permet d'incrementer les combobox cbbClasse et cbbNumStage
        /// </summary>
        private void AjouteStage_Load(object sender, EventArgs e)
        {
            foreach (string nom in GestionBDD.CbbNomClasse()) cbbClasse.Items.Add(nom);
            cbbClasse.SelectedIndex = 0;
            cbbNumStage.Items.Add("1er stage");
            cbbNumStage.Items.Add("2eme stage");
            cbbNumStage.SelectedIndex = 0;
        }

        /// <summary>
        /// permet d'incrementer le combobox cbbNomEtudiant
        /// </summary>
        private void CbbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string nom in GestionBDD.CbbNomPrenomEtudiant(GestionBDD.ChercheID("Select id_classe from classe where nom_classe = \'" + cbbClasse.Text + "\'"))) cbbNomEtudiant.Items.Add(nom);
            cbbNomEtudiant.SelectedIndex = 0;
        }

        /// <summary>
        /// permet de modifier les information affiche au changement d'index du cbbNomEtudiant
        /// </summary>
        private void CbbNomEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Actualisation();
            }
            catch { }
        }

        /// <summary>
        /// permet de modifier les information affiche au changement d'index du cbbNumStage
        /// </summary>
        private void CbbNumStage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Actualisation();
            }
            catch { }
        }

        /// <summary>
        /// permet d'affiche les information d'un stage d'un etudiant
        /// </summary>
        public void Actualisation()
        {
            List<List<string>> stages = GestionBDD.Chargement(cbbNomEtudiant.Text, NumStage(cbbNumStage.Text));
            foreach (List<string> unStage in stages)
            {
                try
                {
                    txtNomEntreprise.Text = unStage.ElementAt(0);
                    string[] datedebut = unStage.ElementAt(1).Split('-');
                    dtpDebutStage.Value = new DateTime(Convert.ToInt32(datedebut.ElementAt(2)), Convert.ToInt32(datedebut.ElementAt(1)), Convert.ToInt32(datedebut.ElementAt(0)));
                    string[] datefin = unStage.ElementAt(2).Split('-');
                    dtpDebutStage.Value = new DateTime(Convert.ToInt32(datedebut.ElementAt(2)), Convert.ToInt32(datedebut.ElementAt(1)), Convert.ToInt32(datedebut.ElementAt(0)));
                    txtAppreciation.Text = unStage.ElementAt(3);
                }
                catch { }
            }
        }

        /// <summary>
        /// permet de savoir le numero du stage
        /// </summary>
        /// <param name="num"> la value (1er stage ou 2eme stage)</param>
        /// <returns> int 1 ou 2 </returns>
        public string NumStage(string num)
        {
            if (num == "1er stage") return "1";
            else return "2";
        }

        /// <summary>
        /// permet de cree un nouveau stage dans la bdd
        /// </summary>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            GestionBDD.NewStage(cbbNomEtudiant.Text, dtpDebutStage.Value.Date.ToString().Split(' ').ElementAt(0), dtpFinStage.Value.Date.ToString().Split(' ').ElementAt(0), Utilitaires.ChangeChar(txtNomEntreprise.Text,"\'"), Utilitaires.ChangeChar(txtAppreciation.Text,"\'"), NumStage(cbbNumStage.Text));
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
