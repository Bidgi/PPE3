using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Classe
{
    public class Synthese
    {
        #region Attributs
        public static List<Synthese> CollClasseSynthese = new List<Synthese>();
        private string nom;
        private string prenom;
        private List<Moyennes> lesMoyenne;
        private string avis;
        #endregion

        #region Constructeur        
        public Synthese(string nom, string prenom, List<Moyennes> lesMoyenne, string avis)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.LesMoyenne = lesMoyenne;
            this.Avis = avis;
            CollClasseSynthese.Add(this);
        }
        #endregion

        #region Getters-Setters        
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Avis { get => avis; set => avis = value; }
        internal List<Moyennes> LesMoyenne { get => lesMoyenne; set => lesMoyenne = value; }
        #endregion

        #region Méthodes
        /// <summary>
        /// permet d'ajoute une moyenne a la list des moyenne
        /// </summary>
        /// <param name="uneMoyenne"></param>
        public void AddMoyenne(Moyennes uneMoyenne)
        {
            this.LesMoyenne.Add(uneMoyenne);
        }
        #endregion
    }
}
