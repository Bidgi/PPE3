using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Classe
{
    public class Moyennes
    {
        #region Attributs
        private int _moyenne;
        private Matiere _laMatiere;
        #endregion

        #region Constructeur
        public Moyennes(int moyenne, Matiere matiere)
        {
            this.Moyenne = moyenne;
            this.LaMatiere = matiere;
        }
        #endregion

        #region Getters-Setters
        public int Moyenne { get => _moyenne; set => _moyenne = value; }
        public Matiere LaMatiere { get => _laMatiere; set => _laMatiere = value; }
        #endregion

        #region Méthodes
        #endregion
    }
}
