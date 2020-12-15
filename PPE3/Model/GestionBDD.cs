using MySql.Data.MySqlClient;
using PPE3.Classe;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3.MySql
{
    public class GestionBDD
    {
        #region Attributs
        /// <summary>
        /// creation de la connection a la base de donnee
        /// </summary>
        public static MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;userid=root;database=ppe");
        #endregion

        #region Connection
        /// <summary>
        /// test l'ouverture de la connection a la base et c'est si impossible renvoie un message d'erreur
        /// </summary>
        public static void OpenConnection() { try { mySqlConnection.Open(); } catch { MessageBox.Show("le serveur de donner n'est pas accesible"); } }

        /// <summary>
        /// verifie les identifien et mot de passe pour valider la connection d'un prof
        /// </summary>
        /// <param name="Nom"> nom du prof </param>
        /// <param name="mdp"> mdp du prof </param>
        /// <returns></returns>
        public static bool TestConnection(string Nom, string mdp)
        {
            List<List<string>> result = new List<List<string>>();
            var cmdNomMdpProf = new MySqlCommand("SELECT NOM_PROF, MDP_PROF FROM prof", mySqlConnection);
            using (var reader = cmdNomMdpProf.ExecuteReader()) while (reader.Read()) result.Add(new List<string>() { reader.GetString(0), reader.GetString(1) });
            foreach (List<string> unProf in result) if (unProf.ElementAt(0) == Nom && unProf.ElementAt(1) == mdp) return true;
            return false;
        }
        #endregion

        #region IncrementationComboBox
        /// <summary>
        /// cree la liste des nom des prof qui sont dans la bse de donnee
        /// </summary>
        /// <returns> List<string> des nom des prof </string></returns>
        public static List<string> CbbNomProf()
        {
            List<string> nom = new List<string>();
            var cmdNomProf = new MySqlCommand("SELECT NOM_PROF FROM prof", mySqlConnection);
            using (var reader = cmdNomProf.ExecuteReader()) while (reader.Read()) nom.Add(reader.GetString(0));
            return nom;
        }

        /// <summary>
        /// cree la liste des nom et prenom des etudiant qui sont dans la bse de donnee
        /// </summary>
        /// <returns>List<string> des nom.prenom des etudiant </returns>
        public static List<string> CbbNomPrenomEtudiant(int idClasse)
        {
            List<string> nom = new List<string>();
            var cmdNomPrenomEtudiant = new MySqlCommand("SELECT NOM_ETUDIANT, PRENOM_ETUDIANT FROM etudiant WHERE ID_CLASSE = " + idClasse, mySqlConnection);
            using (var reader = cmdNomPrenomEtudiant.ExecuteReader()) while (reader.Read()) nom.Add(reader.GetString(0) + "." + reader.GetString(1));
            return nom;
        }

        /// <summary>
        /// cree la liste des nom des classe qui sont dans la bse de donnee
        /// </summary>
        /// <returns>List<string> des nom des classe </returns>
        public static List<string> CbbNomClasse()
        {
            List<string> nomClasse = new List<string>(); 
            var cmdNomClasse = new MySqlCommand("SELECT NOM_CLASSE FROM classe", mySqlConnection);
            using (var reader = cmdNomClasse.ExecuteReader()) while (reader.Read()) nomClasse.Add(reader.GetString(0));
            return nomClasse;
        }

        /// <summary>
        /// cree la liste des nom des matiere qui sont dans la bse de donnee
        /// </summary>
        /// <returns>List<string> des nom des matiere </returns>
        public static List<string> CbbNomMatiere(string unNomProf)
        {
            List<string> nomMatiere = new List<string>();
            var cmdNomMatiere = new MySqlCommand("SELECT LIBELLE_MATIERE FROM matiere INNER JOIN fait_cours ON matiere.ID_MATIERE = fait_cours.ID_MATIERE INNER JOIN prof ON fait_cours.ID_PROF = prof.ID_PROF WHERE NOM_PROF = \'" + unNomProf + "\'", mySqlConnection);
            using (var reader = cmdNomMatiere.ExecuteReader()) while (reader.Read()) nomMatiere.Add(reader.GetString(0));
            return nomMatiere;
        }

        /// <summary>
        /// cree la liste des annee qui sont dans la bse de donnee
        /// </summary>
        /// <returns>List<string> des annee </returns>
        public static List<string> CbbAnnnee()
        {
            List<string> annee = new List<string>();
            var cmdAnnee = new MySqlCommand("SELECT ANNEE FROM section", mySqlConnection);
            using (var reader = cmdAnnee.ExecuteReader()) while (reader.Read()) annee.Add(reader.GetString(0));
            return annee;
        }
        #endregion

        #region ChercheID
        public static int ChercheID(string cmdSql)
        {
            List<int> result = new List<int>();
            var cmd = new MySqlCommand(cmdSql, mySqlConnection);
            using (var reader = cmd.ExecuteReader()) while (reader.Read()) result.Add(reader.GetInt32(0));
            if(result.Count == 0) return -1;
            else return result.ElementAt(0);
        }
        /*/// <summary>
        /// cherche l'id de la classe un fonction du nom de la classe
        /// </summary>
        /// <param name="unNomClasse"> nom de la classe </param>
        /// <returns> l'id de la classe</returns>
        public static int ChercheIDClasse(string unNomClasse)
        {
            var commandMoyenne = new MySqlCommand("SELECT ID_CLASSE FROM classe WHERE NOM_CLASSE = \'" + unNomClasse + "\'", mySqlConnection);
            List<string> result = new List<string>();
            using (var reader = commandMoyenne.ExecuteReader()) while (reader.Read()) result.Add(reader.GetString(0));
            return Convert.ToInt32(result.ElementAt(0));
        }

        /// <summary>
        /// cherche l'id de la matiere un fonction du nom de la matiere
        /// </summary>
        /// <param name="unNomMatiere"> nom de la matiere </param>
        /// <returns> l'id de la matiere </returns>
        public static int ChercheIDMatiereNom(string unNomMatiere)
        {
            List<int> listIdMatiere = new List<int>();
            var cmdIdMatiere = new MySqlCommand("SELECT ID_MATIERE FROM matiere WHERE LIBELLE_MATIERE = \'" + unNomMatiere + "\'", mySqlConnection);
            using (var reader = cmdIdMatiere.ExecuteReader()) while (reader.Read()) listIdMatiere.Add(Convert.ToInt32(reader.GetString(0)));
            return listIdMatiere.ElementAt(0);
        }

        /// <summary>
        /// cherche l'id de l'etudiant un fonction de son et de son prenom
        /// </summary>
        /// <param name="unNomEtudiant"> nom de l'etudiant </param>
        /// <param name="unPrenomEtudiant"> prenom de l'etudiant </param>
        /// <returns> l'id de l'etudiant </returns>
        public static int ChercheIDEtudiant(string unNomEtudiant, string unPrenomEtudiant)
        {
            List<int> result = new List<int>();
            var cmdIdEtudiant = new MySqlCommand("SELECT ID_ETUDIANT FROM etudiant WHERE NOM_ETUDIANT = \'" + unNomEtudiant + "\' AND PRENOM_ETUDIANT = \'" + unPrenomEtudiant + "\'", mySqlConnection);
            using (var reader = cmdIdEtudiant.ExecuteReader()) while (reader.Read()) result.Add(Convert.ToInt32(reader.GetString(0)));
            return result.ElementAt(0);
        }

        /// <summary>
        /// cherche l'id de la classe un fonction du nom et prenom d'un etudiant
        /// </summary>
        /// <param name="nom"> nom de l'etudiant </param>
        /// <param name="prenom"> prenom de l'etudiant </param>
        /// <returns> l'id de la classe </returns>
        public static int ChercheIDClasse(string nom, string prenom)
        {
            var commandMoyenne = new MySqlCommand("SELECT ID_CLASSE FROM etudiant WHERE NOM_ETUDIANT = \'" + nom + "\' AND PRENOM_ETUDIANT = \'" + prenom + "\'", mySqlConnection);
            List<string> result = new List<string>();
            using (var reader = commandMoyenne.ExecuteReader()) while (reader.Read()) result.Add(reader.GetString(0));
            return Convert.ToInt32(result.ElementAt(0));
        }*/
        #endregion

        #region AutreMethode

        /// <summary>
        /// cherche le nombre d'etudiant dans la classe d'un etudaint en fonction du nom et prenom d'un etudiant 
        /// </summary>
        /// <param name="nom"> nom de l'etudiant </param>
        /// <param name="prenom"> prenom de l'etudiant </param>
        /// <returns> le nombre d'etudiant et l'id de la classe </returns>
        public static List<int> NbEtudiantClasse(string nom, string prenom)
        {
            List<List<int>> result = new List<List<int>>();
            var cmdNbEtudiantClasse = new MySqlCommand("SELECT count(*), ID_CLASSE FROM etudiant WHERE ID_CLASSE = " + ChercheID("SELECT ID_CLASSE FROM etudiant WHERE NOM_ETUDIANT = \'" + nom + "\' AND PRENOM_ETUDIANT = \'" + prenom + "\'"), mySqlConnection);
            using (var reader = cmdNbEtudiantClasse.ExecuteReader()) while (reader.Read()) result.Add(new List<int>() { reader.GetInt32(0), reader.GetInt32(1) });
            return result.ElementAt(0);
        }

        /// <summary>
        /// permet de retourner la liste des nom et prenom des etudiant d'une classe
        /// </summary>
        /// <param name="idClasse"> la classe des etudiant </param>
        /// <returns> List<List<string>> </returns>
        public static List<List<string>> NomPrenomEtudiant(int idClasse)
        {
            List<List<string>> result = new List<List<string>>();
            var cmdNbEtudiantClasse = new MySqlCommand("SELECT NOM_ETUDIANT, PRENOM_ETUDIANT FROM etudiant WHERE ID_CLASSE = " + idClasse, mySqlConnection);
            using (var reader = cmdNbEtudiantClasse.ExecuteReader()) while (reader.Read()) result.Add(new List<string>() { reader.GetString(0), reader.GetString(1) });
            return result;
        }

        /// <summary>
        /// cherche le nombre d'etudiant en fonction de l'avis (Tres favorable = TF, Favorable = F, Doit faire c'est preveu = DFP)
        /// </summary>
        /// <param name="avis"> l'avis en question (TF, F, DFP) </param>
        /// <param name="id_Classe"> l'id de la classe </param>
        /// <returns> le nombre d'etudiant qui ont l'avis en question </returns>
        public static int NbEtudiantClasseAvis(string avis, int id_Classe)
        {
            List<int> result = new List<int>();
            var cmdNbEtudiantClasse = new MySqlCommand("SELECT count(*) FROM etudiant WHERE AVIS_SYNTHESE = \'" + avis + "\' AND ID_CLASSE = \'" + id_Classe + "\'", mySqlConnection);
            using (var reader = cmdNbEtudiantClasse.ExecuteReader()) while (reader.Read()) result.Add(reader.GetInt32(0));
            return result.ElementAt(0);
        }

        /// <summary>
        /// cherche les resultat des 3 derniere annee pour le livret
        /// </summary>
        /// <returns>une liste de 3 liste contenant dans l'ordre annee presentes recus</returns>
        public static List<List<string>> ResultDerniereAnnee()
        {
            List<List<string>> result = new List<List<string>>();
            var cmdNbEtudiantClasse = new MySqlCommand("SELECT ANNEE, PRESENTES, RECUS FROM section WHERE ANNEE > " + (DateTime.Now.Year - 3), mySqlConnection);
            using (var reader = cmdNbEtudiantClasse.ExecuteReader()) while (reader.Read()) result.Add(new List<string>() { reader.GetString(0), reader.GetString(1), reader.GetString(2) });
            return result;
        }

        /// <summary>
        /// permet d'effectuer des requete insert et update sur la base de donnee
        /// </summary>
        /// <param name="commande"> la commande a effectuer </param>
        public static void InsertUpdate(string commande)
        {
            var command = new MySqlCommand(commande, mySqlConnection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// cherche les information dun etudiant (libelle de l'option, sa date de naissance, l'annee de l'epreve)
        /// </summary>
        /// <param name="nom"> nom de l'etudiant </param>
        /// <param name="prenom"> prenom de l'etudiant </param>
        /// <returns> list<string> des information </string> </returns>
        public static List<string> InfoEtudiant(string nom, string prenom)
        {
            List<List<string>> result = new List<List<string>>();
            var cmdInfoEtudaint = new MySqlCommand("SELECT LIBELLE_OPTION, DATEDENAISSANCE_ETUDIANT, ANNEEEVALUER FROM etudiant INNER JOIN optionclasse ON optionclasse.ID_OPTION = etudiant.ID_OPTION WHERE ID_ETUDIANT = " + ChercheID("SELECT ID_ETUDIANT FROM etudiant WHERE NOM_ETUDIANT = \'" + nom + "\' AND PRENOM_ETUDIANT = \'" + prenom + "\'"), mySqlConnection);
            using (var reader = cmdInfoEtudaint.ExecuteReader()) while (reader.Read()) result.Add(new List<string>() { reader.GetString(0), reader.GetString(1), reader.GetString(2) });
            return result.ElementAt(0);
        }

        /// <summary>
        /// cherche l'information en prametre en fonction de l'etudiant et de la matiere
        /// </summary>
        /// <param name="info"> la moyenne ou l'appreciation </param>
        /// <param name="nom"> nom de l'etudiant </param>
        /// <param name="prenom"> prenom de l'etudiant </param>
        /// <param name="idMatiere"> l'id de la matiere </param>
        /// <returns> l'information demander </returns>
        public static string InfoEtudiantActu(string info, string nom, string prenom, int idMatiere)
        {
            List<string> result = new List<string>();
            var commandMoyenne = new MySqlCommand("SELECT " + info + " FROM participe WHERE ID_ETUDIANT = " + ChercheID("SELECT ID_ETUDIANT FROM etudiant WHERE NOM_ETUDIANT = \'" + nom + "\' AND PRENOM_ETUDIANT = \'" + prenom + "\'") + " AND ID_MATIERE = " + idMatiere, mySqlConnection);
            using (var reader = commandMoyenne.ExecuteReader()) while (reader.Read()) result.Add(reader.GetString(0));
            if (result.Count > 0 && result.ElementAt(0) != "42") return result.ElementAt(0);
            else return "non renseigné";
        }

        /// <summary>
        /// cherche toute les note d'un etudiant
        /// </summary>
        /// <param name="nomEtudiant"> nom de l'etudiant </param>
        /// <param name="PrenomEtudiant"> prenom de l'etudiant </param>
        /// <returns> lite des note sous forme de list (libelle matiere, coefficient, type (cc ou ccf) la moyenne et l'appreciation)</returns>
        public static List<List<string>> ListeNoteEtudiant(string nomEtudiant, string PrenomEtudiant)
        {
            var cmdLNEMatiere = new MySqlCommand("select LIBELLE_MATIERE, COEFFICIENT_MATIERE, TYPE_MATIERE, MOYENNE, APPRECIATION " +
                "from etudiant " +
                "join participe on etudiant.ID_ETUDIANT = participe.ID_ETUDIANT " +
                "inner join matiere on matiere.ID_MATIERE = participe.ID_MATIERE " +
                "WHERE NOM_ETUDIANT = \'" + nomEtudiant + "\'" +
                "AND PRENOM_ETUDIANT = \'" + PrenomEtudiant + "\'", mySqlConnection);
            List<List<string>> result = new List<List<string>>();
            using (var reader = cmdLNEMatiere.ExecuteReader()) while (reader.Read()) result.Add(new List<string>() { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) });
            return result;
        }

        /// <summary>
        /// cherche toute les information sur les de stage
        /// </summary>
        /// <param name="nomEtudiant"></param>
        /// <param name="prenomEtudaint"></param>
        /// <returns> liste des stage sous forme de list (nom de l'entreprise, date de debut et fin de stage , appreciation )</returns>
        public static List<List<string>> ListeStageEtudiant(string nomEtudiant, string prenomEtudaint)
        {
            var cmdListStage = new MySqlCommand("SELECT NOMENTREPRISE_STAGE, DATEDEBUT_PERIODE, DATEFIN_PERIODE, APPRECIATION_STAGE " +
                "FROM stage " +
                "INNER JOIN etudiant ON etudiant.ID_ETUDIANT = stage.ID_ETUDIANT " +
                "INNER JOIN periode ON stage.ID_PERIODE = periode.ID_PERIODE " +
                "WHERE NOM_ETUDIANT = \'" + nomEtudiant + "\' " +
                "AND PRENOM_ETUDIANT = \'" + prenomEtudaint + "\'", mySqlConnection);
            List<List<string>> result = new List<List<string>>();
            using (var reader = cmdListStage.ExecuteReader()) while (reader.Read()) result.Add(new List<string>() { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) });
            return result;
        }

        /// <summary>
        /// verifie si l'annee en cour est resente dans la base de donnee
        /// </summary>
        public static void CheckAnnee()
        {
            var cmdListStage = new MySqlCommand("SELECT ANNEE FROM section ", mySqlConnection);
            List<string> result = new List<string>();
            using (var reader = cmdListStage.ExecuteReader()) while (reader.Read()) result.Add(reader.GetString(0));
            int AnneeMax = Int32.MinValue;
            foreach (string uneAnnee in result) if (Convert.ToInt32(uneAnnee) > AnneeMax) AnneeMax = Convert.ToInt32(uneAnnee);
            if (AnneeMax < DateTime.Now.Year) InsertUpdate("INSERT INTO section (ANNEE) VALUES('" + DateTime.Now.Year + "')");
        }

        /// <summary>
        /// cherche le nombre d'etudiant present et recus en fonction de l'annee
        /// </summary>
        /// <param name="annee"> l'annee </param>
        /// <returns> list (presentes, recus)</returns>
        public static List<string> InfoPresenteRecus(string annee)
        {
            var cmdAnnee = new MySqlCommand("SELECT PRESENTES, RECUS " +
                "FROM section " +
                "WHERE ANNEE = \'" + annee + "\'", mySqlConnection);
            List<List<string>> result = new List<List<string>>();
            using (var reader = cmdAnnee.ExecuteReader()) while (reader.Read()) result.Add(new List<string>() { reader.GetString(0), reader.GetString(1)});
            return result.ElementAt(0);
        }

        /// <summary>
        /// permet de cree tout les etudiant avec leur moyenne et leur matiere
        /// </summary>
        /// <param name="nomClasse"> nom de la classe des etudiant</param>
        public static void IncrementationSynthese(string nomClasse)
        {
            List<List<string>> result = new List<List<string>>();
            var cmdAnnee = new MySqlCommand("Select NOM_ETUDIANT, PRENOM_ETUDIANT, MOYENNE, AVIS_SYNTHESE, LIBELLE_MATIERE, COEFFICIENT_MATIERE, UIJ From etudiant Inner Join classe On classe.ID_CLASSE = etudiant.ID_CLASSE Inner Join participe On participe.ID_ETUDIANT = etudiant.ID_ETUDIANT Inner Join matiere On matiere.ID_MATIERE = participe.ID_MATIERE Where NOM_CLASSE = \"" + nomClasse + "\" Order by NOM_ETUDIANT, PRENOM_ETUDIANT", mySqlConnection);
            using (var reader = cmdAnnee.ExecuteReader()) while (reader.Read()) result.Add(new List<string>() { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6) });
            foreach (List<string> unResult in result)
            {
                Matiere matiere = null;
                if(Matiere.CollClasseMatiere.Exists(x => x.Uij == unResult.ElementAt(6)) == false) matiere = new Matiere(unResult.ElementAt(4), unResult.ElementAt(6), Convert.ToInt32(unResult.ElementAt(5)));
                else  matiere = Matiere.CollClasseMatiere.Find(x => x.Uij.Contains(unResult.ElementAt(6)));
                if (Synthese.CollClasseSynthese.Exists(x => x.Nom == unResult.ElementAt(0)) == false || Synthese.CollClasseSynthese.Exists(x => x.Prenom == unResult.ElementAt(1)) == false) new Synthese(unResult.ElementAt(0), unResult.ElementAt(1), new List<Moyennes>() { new Moyennes(Convert.ToInt32(unResult.ElementAt(2)), matiere) }, unResult.ElementAt(3));
                else Synthese.CollClasseSynthese.FindAll(x=>x.Nom.Contains(unResult.ElementAt(0))).Find(x => x.Prenom.Contains(unResult.ElementAt(1))).AddMoyenne(new Moyennes(Convert.ToInt32(unResult.ElementAt(2)), matiere));
            }
        }

        /// <summary>
        /// permet de cree le tableau de synthese via les donnee des classe (Matiere, Moyennes, Synthese)
        /// </summary>
        /// <returns> une list de list des etudiant avec leurs moyennes </returns>
        public static List<List<string>> TableauNote()
        {
            List<List<string>> result = new List<List<string>>();
            List<string> ListCoef = new List<string>() {"Coeficient", ""};
            foreach (Moyennes uneMoyenne in Synthese.CollClasseSynthese.ElementAt(0).LesMoyenne) if(uneMoyenne.LaMatiere.Uij != "EF2") ListCoef.Add(uneMoyenne.LaMatiere.Coef.ToString());
            for (int i = 0; i < 3; i++) ListCoef.Add("");
            result.Add(ListCoef);
            foreach (Synthese synthese in Synthese.CollClasseSynthese)
            {
                int total = 0;
                List<string> list = new List<string>() { synthese.Nom, synthese.Prenom };
                foreach (Moyennes uneMoyenne in synthese.LesMoyenne)
                {
                    if (uneMoyenne.LaMatiere.Uij != "EF2")
                    {
                        total += uneMoyenne.Moyenne;
                        list.Add(uneMoyenne.Moyenne.ToString());
                    }
                }
                list.Add(total.ToString());
                list.Add((total / synthese.LesMoyenne.Count()).ToString());
                list.Add(synthese.Avis);
                result.Add(list);
            }
            return result;
        }

        /// <summary>
        /// permet de charger les information sur les stgae d'un etudiant avec son id
        /// </summary>
        /// <param name="idEtudiant"> l'id de l'etudiant </param>
        /// <param name="numStage"> le numero du stage demander </param>
        /// <returns> list de list contenant toute les information d'un stage</returns>
        public static List<List<string>> Chargement(string idEtudiant, string numStage)
        {
            List<List<string>> result = new List<List<string>>();
            var cmd = new MySqlCommand("select nomentreprise_stage, datedebut_periode, datefin_periode, appreciation_stage from stage inner join periode on periode.id_periode = stage.id_periode where id_etudiant = " + idEtudiant + " and numero_stage = " + numStage, mySqlConnection);
            using (var reader = cmd.ExecuteReader()) while (reader.Read()) result.Add(new List<string>() { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) });
            return result;
        }

        /// <summary>
        /// permet de cree (ajout a la bdd) un nouveau stage
        /// </summary>
        /// <param name="nomPrenomEtudiant"> le nom et prenom de l'etudiant </param>
        /// <param name="datedebut"> la date de debut du stage </param>
        /// <param name="datefin"> la date de fin de stage </param>
        /// <param name="nomEntreprise"> le nom de l'emtreprise d'accuiel </param>
        /// <param name="appreciation"> l'appreciation </param>
        /// <param name="numeroStage"> le numero du stage (1er ou 2 eme annee) </param>
        public static void NewStage(string nomPrenomEtudiant, string datedebut, string datefin, string nomEntreprise, string appreciation, string numeroStage)
        {
            string[] nomPrenom = nomPrenomEtudiant.Split('.');
            int idPeriode = -1;
            while (idPeriode == -1)
            {
                idPeriode = ChercheID("select id_periode from periode where DATEDEBUT_PERIODE = " + datedebut + " and DATEFIN_PERIODE = " + datefin);
                if (idPeriode == -1) GestionBDD.InsertUpdate("Insert into periode (DATEDEBUT_PERIODE, DATEFIN_PERIODE) VALUES(\'"+ datedebut + "\', \'"+ datefin + "\')");
            }
            int idEtudiant = ChercheID("select id_etudiant from etudiant where nom_etudiant = " + nomPrenom.ElementAt(0) + " and prenom_etudiant = " + nomPrenom.ElementAt(0));
            var test = new MySqlCommand("Insert into stage(id_etudiant, id_periode, nomentreprise_stage, appreciation_stage, numero_stage) Values(\'"+ idEtudiant + "\',\'" + idPeriode+ "\',\'" + nomEntreprise + "\',\'" + appreciation + "\',\'" + numeroStage + "\')", mySqlConnection);
            test.ExecuteNonQuery();
        }

        /// <summary>
        /// permet de recuperer de la bdd les information sur les stage d'un etudiant
        /// </summary>
        /// <param name="nomPrenom"></param>
        /// <returns></returns>
        public static List<List<string>> InfoStage(string nomPrenom)
        {
            List<List<string>> result = new List<List<string>>();
            var cmd = new MySqlCommand("select nomentreprise_stage, datedebut_periode, datefin_periode, appreciation_stage from stage inner join periode on periode.id_periode = stage.id_periode where id_etudiant = " + ChercheID("select id_etudiant from etudiant where nom_etudiant = \'" + nomPrenom.Split('.').ElementAt(0) + "\' and prenom_etudiant = \'" + nomPrenom.Split('.').ElementAt(1) + "\'"), mySqlConnection);
            using (var reader = cmd.ExecuteReader()) while (reader.Read()) result.Add(new List<string>() { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) });
            return result;
        }


        /// <summary>
        /// permet d'avoir la list des synthese des etudiant qui non pas la moyenne
        /// </summary>
        /// <returns> list de synthese </returns>
        public static List<Synthese> EtudiantNonMoyenne()
        {
            List<Synthese> syntheses = new List<Synthese>();
            foreach (Synthese uneSynthese in Synthese.CollClasseSynthese)
            {
                if (uneSynthese.Avis != "DFP")
                {
                    int moyenne = 0;
                    foreach (Moyennes uneMoyenne in uneSynthese.LesMoyenne) moyenne += uneMoyenne.Moyenne;
                    moyenne = moyenne / uneSynthese.LesMoyenne.Count();
                    if (moyenne < 10) syntheses.Add(uneSynthese);
                }
            }
            return syntheses;
        }

        /// <summary>
        /// permet de cree le tableau de synthese via les donnee des classe (Matiere, Moyennes, Synthese)
        /// </summary>
        /// <returns> une list de list des etudiant avec leurs moyennes </returns>
        public static List<List<string>> TableauNoteNonMoyenne()
        {
            List<List<string>> result = new List<List<string>>();
            List<string> ListCoef = new List<string>() { "Coeficient", "" };
            foreach (Moyennes uneMoyenne in Synthese.CollClasseSynthese.ElementAt(0).LesMoyenne) if (uneMoyenne.LaMatiere.Uij != "EF2") ListCoef.Add(uneMoyenne.LaMatiere.Coef.ToString());
            for (int i = 0; i < 3; i++) ListCoef.Add("");
            result.Add(ListCoef);
            foreach (Synthese synthese in EtudiantNonMoyenne())
            {
                int total = 0;
                List<string> list = new List<string>() { synthese.Nom, synthese.Prenom };
                foreach (Moyennes uneMoyenne in synthese.LesMoyenne)
                {
                    if (uneMoyenne.LaMatiere.Uij != "EF2")
                    {
                        total += uneMoyenne.Moyenne;
                        list.Add(uneMoyenne.Moyenne.ToString());
                    }
                }
                list.Add(total.ToString());
                list.Add((total / synthese.LesMoyenne.Count()).ToString());
                list.Insert(2, "" + (220 - total));
                list.Add(synthese.Avis);
                result.Add(list);
            }
            return result;
        }
        #endregion
    }
}