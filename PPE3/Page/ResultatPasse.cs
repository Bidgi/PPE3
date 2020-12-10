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
    public partial class ResultatPasse : Form
    {
        internal static string _TxtR;
        internal static string _TxtP;
        public ResultatPasse()
        {
            InitializeComponent();
        }

        /// <summary>
        /// incremente les combo box annee au chargement de la page
        /// et cree un place holder sur les text box etudiant present et recus
        /// </summary>
        private void ResultatPasse_Load(object sender, EventArgs e)
        {
            foreach (string uneAnnee in GestionBDD.CbbAnnnee()) cbbAnnee.Items.Add(uneAnnee);
            cbbAnnee.SelectedIndex = 0;
            TxtP.LostFocus += TxtP_LostFocus;
            TxtR.LostFocus += TxtR_LostFocus;
            TxtP.GotFocus += TxtP_GotFocus;
            TxtR.GotFocus += TxtR_GotFocus;
        }
        #region PlaceHolder
        private void TxtR_GotFocus(object sender, EventArgs e)
        {
            TxtR.ForeColor = Color.Gray;
            TxtR.Text = "";
        }
        private void TxtP_GotFocus(object sender, EventArgs e)
        {
            TxtP.ForeColor = Color.Gray;
            TxtP.Text = "";
        }
        private void TxtR_LostFocus(object sender, EventArgs e)
        {
            TxtR.ForeColor = Color.Gray;
            TxtR.Text = _TxtR;
        }
        private void TxtP_LostFocus(object sender, EventArgs e)
        {
            TxtP.ForeColor = Color.Gray;
            TxtP.Text = _TxtP;
        }
        #endregion

        /// <summary>
        /// permet d'afficher le nombre d'etudiant present et recus a l'epreve en fonction de l'annee
        /// </summary>
        private void CbbAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> InfoPresenteRecus = new List<string>() { "non renseigné", "non renseigné" };
            try { InfoPresenteRecus = GestionBDD.InfoPresenteRecus(cbbAnnee.Text); }
            catch { }
            TxtP.Text = InfoPresenteRecus.ElementAt(0);
            _TxtP = InfoPresenteRecus.ElementAt(0);
            TxtR.Text = InfoPresenteRecus.ElementAt(1);
            _TxtR = InfoPresenteRecus.ElementAt(1);
        }

        /// <summary>
        /// permet de modifier le nombre d'etudiant present et recus 
        /// </summary>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            GestionBDD.InsertUpdate("UPDATE section SET PRESENTES = " + TxtP.Text + ", RECUS = " + TxtR.Text + " WHERE ANNEE = " + cbbAnnee.Text) ;
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
