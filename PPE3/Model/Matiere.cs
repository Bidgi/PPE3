using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Classe
{
    public class Matiere
    {
        #region Attributs
        public static List<Matiere> CollClasseMatiere = new List<Matiere>();
        private string _nomComplet;
        private string _uij;
        private int _coef;
        #endregion

        #region Constructeur
        public Matiere(string nomComplet, string uij, int coef)
        {
            NomComplet = nomComplet;
            Uij = uij;
            Coef = coef;
            CollClasseMatiere.Add(this);
        }
        #endregion

        #region Getters-Setters
        public string NomComplet { get => _nomComplet; set => _nomComplet = value; }
        public string Uij { get => _uij; set => _uij = value; }
        public int Coef { get => _coef; set => _coef = value; }
        #endregion

        #region Méthodes
        #endregion
    }
}
