using ClosedXML.Excel;
using GemBox.Spreadsheet;
using Google.Protobuf.WellKnownTypes;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PPE3.Classe;
using PPE3.MySql;
using Renci.SshNet.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3.Page
{
    public partial class ConsultLivret : Form
    {
        public ConsultLivret()
        {
            InitializeComponent();
        }

        /// <summary>
        /// incrementation du combo box des classe au chargement du form
        /// </summary>
        private void ConsultLivret_Load(object sender, EventArgs e)
        {
            foreach (string nom in GestionBDD.CbbNomClasse()) cbbClasse.Items.Add(nom);
            cbbClasse.SelectedIndex = 0;
        }

        /// <summary>
        /// incrementation du combo box des etudiant au changement d'index du combo box de la classe
        /// </summary>
        private void CbbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string nom in GestionBDD.CbbNomPrenomEtudiant(GestionBDD.ChercheID("select ID_CLASSE from classe where NOM_CLASSE = \'" + cbbClasse.Text + "\'"))) cbbNomEtudiant.Items.Add(nom);
        }

        /// <summary>
        /// creation du pdf du livret
        /// </summary>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            openFolder.Description = "Enregistrer sous : ";
            if (openFolder.ShowDialog() == DialogResult.OK) filePath = openFolder.SelectedPath;
            string[] NomPrenom = cbbNomEtudiant.Text.Split(new Char[] { '.' });
            PdfDocument pdf = Utilitaires.NewLivret(NomPrenom.ElementAt(0), NomPrenom.ElementAt(1));
            Utilitaires.SavePdf(pdf, filePath, NomPrenom.ElementAt(0), NomPrenom.ElementAt(1));
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
