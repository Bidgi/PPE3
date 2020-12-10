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
    public partial class ConsultSynthese : Form
    {
        public ConsultSynthese()
        {
            InitializeComponent();
        }

        /// <summary>
        /// permet de charche le combox des nom de classe
        /// </summary>
        private void ConsultSynthese_Load(object sender, EventArgs e)
        {
            foreach (string uneClasse in GestionBDD.CbbNomClasse()) cbbClasse.Items.Add(uneClasse);
        }

        /// <summary>
        /// permet d'afficher dans un datagridview la synthese d'une classe
        /// </summary>
        private void CbbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            GestionBDD.IncrementationSynthese(cbbClasse.Text);
            DataTable dt = new DataTable();
            dt.Columns.Add("Nom", typeof(string));
            dt.Columns.Add("Prenom", typeof(string));
            dt.Columns.Add("E11", typeof(string));
            dt.Columns.Add("E12", typeof(string));
            dt.Columns.Add("E21", typeof(string));
            dt.Columns.Add("E22", typeof(string));
            dt.Columns.Add("E3", typeof(string));
            dt.Columns.Add("E4", typeof(string));
            dt.Columns.Add("E5", typeof(string));
            dt.Columns.Add("E6", typeof(string));
            dt.Columns.Add("Total", typeof(string));
            dt.Columns.Add("Moyenne", typeof(string));
            dt.Columns.Add("Avis", typeof(string));
            dt.Rows.Add(new string[] {});
            dgv.Refresh();
            foreach (List<string> unEtudiant in GestionBDD.TableauNote())
            {
                dt.Rows.Add(new string[]{unEtudiant.ElementAt(0),
                    unEtudiant.ElementAt(1),
                    unEtudiant.ElementAt(2),
                    unEtudiant.ElementAt(3),
                    unEtudiant.ElementAt(4),
                    unEtudiant.ElementAt(5),
                    unEtudiant.ElementAt(6),
                    unEtudiant.ElementAt(7),
                    unEtudiant.ElementAt(8),
                    unEtudiant.ElementAt(9),
                    unEtudiant.ElementAt(10),
                    unEtudiant.ElementAt(11),
                    unEtudiant.ElementAt(12)});
            }
            dgv.DataSource = dt;
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
