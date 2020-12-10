using ClosedXML.Excel;
using GemBox.Spreadsheet;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
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
    public partial class ConsultLivretClasse : Form
    {
        public ConsultLivretClasse()
        {
            InitializeComponent();
        }

        private void ConsultLivretClasse_Load(object sender, EventArgs e)
        {
            foreach (string nom in GestionBDD.CbbNomClasse()) cbbClasse.Items.Add(nom);
            cbbClasse.SelectedIndex = 0;
        }

        /// <summary>
        /// permet de cree tous les livret scolaires d'une classe
        /// </summary>
        private void btnValider_Click(object sender, EventArgs e)
        {
            // ouverture du selecteur windows
            #region selecteur
            var filePath = string.Empty;
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            openFolder.Description = "Enregistrer sous : ";
            if (openFolder.ShowDialog() == DialogResult.OK) filePath = openFolder.SelectedPath;
            #endregion
            List<PdfDocument> lesPdf = new List<PdfDocument>();
            List<List<string>> ListNomPrenom = GestionBDD.NomPrenomEtudiant(GestionBDD.ChercheID("select ID_CLASSE from classe where NOM_CLASSE = \'" + cbbClasse.Text + "\'"));
            foreach (List<string> unNomPrenom in ListNomPrenom) lesPdf.Add(Utilitaires.NewLivret(unNomPrenom.ElementAt(0), unNomPrenom.ElementAt(1)));
            Utilitaires.SavesPDF(lesPdf, filePath, cbbClasse.Text);
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
