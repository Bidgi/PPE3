using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using PPE3.MySql;
using PPE3.Page;

namespace PPE3
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// permet d'avoir acces au nom du prof pendant toute la vie du programme
        /// </summary>
        internal static string nomProf;

        /// <summary>
        /// verifi et ouvre la connection a la base de donnee
        /// verifi l'annee actuel pour ajoute l'annee en cour si elle ni est pas
        /// incremente le combo box avec le nom des prof 
        /// </summary>
        private void Connection_Load(object sender, EventArgs e)
        {
            GestionBDD.OpenConnection();
            GestionBDD.CheckAnnee();
            foreach (string nom in GestionBDD.CbbNomProf()) cbbNomConnection.Items.Add(nom);
            cbbNomConnection.SelectedIndex = 0;
        }

        /// <summary>
        /// test le mots de passe et la connection du prof au programe
        /// </summary>
        private void BtnConnection_Click(object sender, EventArgs e)
        {
            if (GestionBDD.TestConnection(cbbNomConnection.Text, txtBmdp.Text))
            {
                nomProf = cbbNomConnection.Text;
                this.Visible = false;
                Accueil accueil = new Accueil();
                accueil.Show();
            }
            else
            {
                labelErreur.Text = "Votre mot de passe est incorrect.";
                labelErreur.Visible = true;
                labelErreur2.Text = "Veuille vérifier votre mot de passe.";
                labelErreur2.Visible = true;
            }
        }
    }
}