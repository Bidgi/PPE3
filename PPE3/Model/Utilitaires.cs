using ClosedXML.Excel;
using GemBox.Spreadsheet;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PPE3.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3.Classe
{
    public class Utilitaires
    {
        /// <summary>
        /// permet de cree un cellule a fusionner et de definir sa valeur et son style
        /// </summary>
        /// <param name="value"> valuer de la cell </param>
        /// <param name="Cell1"> premiere cell de la fusion </param>
        /// <param name="Cell2"> dersieme cell de la fusion </param>
        /// <param name="worksheet"> la page du excel conserner </param>
        /// <param name="fontsize"> la taille de la police d'écriture </param>
        /// <param name="border"> bool pour activer ou non les bordure </param>
        public static void RangeValue(string value, string Cell1, string Cell2, IXLWorksheet worksheet, int fontsize, bool border)
        {
            IXLRange range = worksheet.Range(Cell1, Cell2);
            range.Merge();
            range.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center).Alignment.SetWrapText();
            if (border) range.Style.Border.SetOutsideBorder(XLBorderStyleValues.Thick).Border.SetOutsideBorderColor(XLColor.Black);
            range.Style.Font.FontSize = fontsize;
            range.Value = value;
            if (value == "Année de") range.Style.Border.SetTopBorder(XLBorderStyleValues.Thick).Border.SetTopBorderColor(XLColor.Black);
        }

        /// <summary>
        /// permet de cree un nouveau livret au format pdf
        /// </summary>
        /// <param name="nom"> le nom de l'etudiant </param>
        /// <param name="prenom"> le prenom de l'etudiant </param>
        /// <returns> un pdf du livret </returns>
        public static PdfDocument NewLivret(string nom, string prenom)
        {
            List<string> InforEtudiant = GestionBDD.InfoEtudiant(nom, prenom);

            // creation du excel recto avec les definition
            #region recto
            var WorkbookRecto = new XLWorkbook();
            var WorksheetRecto = WorkbookRecto.Worksheets.Add("Recto");
            WorksheetRecto.Column("A").Width = 13.71;
            WorksheetRecto.Column("B").Width = 13.71;
            WorksheetRecto.Column("C").Width = 13.71;
            WorksheetRecto.Column("D").Width = 13.71;
            WorksheetRecto.Column("E").Width = 6.27;
            WorksheetRecto.Column("F").Width = 13.71;
            WorksheetRecto.Column("G").Width = 7.14;
            WorksheetRecto.Column("H").Width = 4;
            WorksheetRecto.Column("I").Width = 12.86;
            WorksheetRecto.Column("J").Width = 13.71;
            WorksheetRecto.Column("K").Width = 35.43;
            WorksheetRecto.Row(8).Height = 23.25;
            WorksheetRecto.Row(9).Height = 23.25;
            Utilitaires.RangeValue("Livret scolaire ou de Formation", "A1", "K1", WorksheetRecto, 12, false);
            Utilitaires.RangeValue("EXAMEN : BREVET DE TECHNICIEN SUPÉRIEUR", "A3", "C4", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("Spécialité : SERVICES INFORMATIQUES AUX ORGANISATIONS", "A5", "C5", WorksheetRecto, 8, true);
            Utilitaires.RangeValue(InforEtudiant.ElementAt(0), "A6", "C6", WorksheetRecto, 8, false);
            WorksheetRecto.Range("A6", "C6").Style.Border.SetLeftBorder(XLBorderStyleValues.Thick).Border.SetLeftBorderColor(XLColor.Black);
            WorksheetRecto.Range("A6", "C6").Style.Border.SetRightBorder(XLBorderStyleValues.Thick).Border.SetRightBorderColor(XLColor.Black);
            Utilitaires.RangeValue("Année de", "D3", "D3", WorksheetRecto, 8, false);
            WorksheetRecto.Range("A6", "C6").Style.Border.SetTopBorder(XLBorderStyleValues.Thick).Border.SetTopBorderColor(XLColor.Black);
            Utilitaires.RangeValue("l'examen", "D4", "D4", WorksheetRecto, 8, false);
            Utilitaires.RangeValue(InforEtudiant.ElementAt(2), "D5", "D6", WorksheetRecto, 8, false);
            Utilitaires.RangeValue("NOM(lettres capitales) " + nom, "E3", "G4", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("DATE de NAISSANCE " + InforEtudiant.ElementAt(1), "E5", "G6", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("PRENOM " + prenom, "H3", "J4", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("N° de l'INSEE", "H5", "I5", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("|_|_|_|_|_|_|_|_|_|_|_|", "H6", "I6", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("ÉTABLISSEMENT Lycée Felix Le Dantec - Lannion", "K3", "K3", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("(cachet)", "K4", "K4", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("LANGUE VIVANTE ANGLAIS", "J5", "K6", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("CLASSE DE 2eme année", "A7", "E7", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("Unités constitutives du diplôme correspondant aux épreuves obligatoires dans l'ordre où elles figurent dans le règlement d'examen", "A8", "E8", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("Évaluation du candidat", "F7", "K8", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("Référence de l’unité constitutive", "A9", "A9", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("Uij", "A10", "A10", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("Coef", "B9", "B10", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("Intitulé de l’unité constitutive", "C9", "E10", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("Note obtenue par CCF ou par épreuve ou sous-épreuve ponctuelle passée avant le 16 mars", "F9", "F10", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("ou note obtenue par contrôle continu", "G9", "H10", WorksheetRecto, 8, true);
            Utilitaires.RangeValue("Appréciations", "I9", "K10", WorksheetRecto, 8, true);
            List<List<string>> listeNoteEtudiant = GestionBDD.ListeNoteEtudiant(nom, prenom);
            int x = 0, y = 0;
            for (int i = 0; i < listeNoteEtudiant.Count() * 2; i += 2)
            {
                string[] UniteNom = listeNoteEtudiant.ElementAt(i / 2).ElementAt(0).Split(new char[] { '-' });
                Utilitaires.RangeValue(UniteNom.ElementAt(0), $"A{11 + i}", $"A{12 + i}", WorksheetRecto, 8, true);
                x = 11 + i;
                y = 12 + i;
                Utilitaires.RangeValue(listeNoteEtudiant.ElementAt(i / 2).ElementAt(1), $"B{11 + i}", $"B{12 + i}", WorksheetRecto, 8, true);
                Utilitaires.RangeValue(UniteNom.ElementAt(1), $"C{11 + i}", $"E{12 + i}", WorksheetRecto, 8, true);
                if (listeNoteEtudiant.ElementAt(i / 2).ElementAt(2) == "CCF") Utilitaires.RangeValue(listeNoteEtudiant.ElementAt(i / 2).ElementAt(3), $"F{11 + i}", $"F{12 + i}", WorksheetRecto, 8, true);
                else Utilitaires.RangeValue(listeNoteEtudiant.ElementAt(i / 2).ElementAt(3), $"G{11 + i}", $"H{12 + i}", WorksheetRecto, 8, true);
                Utilitaires.RangeValue(listeNoteEtudiant.ElementAt(i / 2).ElementAt(4), $"I{11 + i}", $"K{12 + i}", WorksheetRecto, 10, true);
            }
            Utilitaires.RangeValue("", "F" + x, "F" + y, WorksheetRecto, 8, false);
            WorksheetRecto.Range("A6", "C6").Style.Border.SetBottomBorder(XLBorderStyleValues.Thick).Border.SetBottomBorderColor(XLColor.Black);
            Utilitaires.RangeValue("Eléments complémentaires portés à la connaissance du jury pour tenir compte de l’assiduité, de la motivation et de l’engagement du candidat", "A" + (x + 3), "C" + (y + 3), WorksheetRecto, 8, true);
            Utilitaires.RangeValue("", "D" + (x + 3), "K" + (y + 3), WorksheetRecto, 8, true);
            #endregion

            // creation du excel verso avec les definition
            #region verso
            var WorkbookVerso = new XLWorkbook();
            var WorksheetVerso = WorkbookVerso.Worksheets.Add("Verso");
            WorksheetVerso.Column("A").Width = 13.71;
            WorksheetVerso.Column("B").Width = 13.71;
            WorksheetVerso.Column("C").Width = 15.43;
            WorksheetVerso.Column("D").Width = 13.71;
            WorksheetVerso.Column("E").Width = 13.71;
            WorksheetVerso.Column("F").Width = 13.71;
            WorksheetVerso.Column("G").Width = 13.71;
            WorksheetVerso.Column("H").Width = 13.71;
            WorksheetVerso.Column("I").Width = 13.71;
            WorksheetVerso.Column("J").Width = 13.71;
            WorksheetVerso.Column("K").Width = 13.71;
            WorksheetVerso.Column("L").Width = 20.30;
            WorksheetVerso.Column("M").Width = 13.71;
            WorksheetVerso.Row(3).Height = 40;
            WorksheetVerso.Row(4).Height = 90;
            WorksheetVerso.Row(5).Height = 90;
            WorksheetVerso.Row(9).Height = 40.5;
            WorksheetVerso.Row(24).Height = 25.5;
            List<List<string>> listStageEtudiant = new List<List<string>>() { new List<string>() { "non renseigné", "non renseigné", "non renseigné", "non renseigné" }, new List<string>() { "non renseigné", "non renseigné", "non renseigné", "non renseigné" } };
            List<List<string>> ListeStageEtudiantBdd = GestionBDD.ListeStageEtudiant(nom, prenom);
            for (int i = 0; i < listStageEtudiant.Count(); i++) for (int n = 0; n < listStageEtudiant[i].Count(); n++) try { listStageEtudiant[i][n] = ListeStageEtudiantBdd[i][n]; } catch { }
            Utilitaires.RangeValue("Récapitulatif des périodes de stages (4 semaines minimum sur la durée de la formation)", "A1", "M1", WorksheetVerso, 12, false);
            Utilitaires.RangeValue("Nom et adresse de l'entreprise ou organisme", "C3", "E3", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Dates", "F3", "F3", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Appréciation des professeurs comprenant, le cass échéant, le dossier professionnel élaboré par le candidat", "G3", "K3", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Remarques", "L3", "M3", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("1ère année", "A4", "B4", WorksheetVerso, 12, true);
            Utilitaires.RangeValue(listStageEtudiant.ElementAt(0).ElementAt(0), "C4", "E4", WorksheetVerso, 12, true);
            Utilitaires.RangeValue(listStageEtudiant.ElementAt(0).ElementAt(1), "F4", "F4", WorksheetVerso, 12, true);
            Utilitaires.RangeValue(listStageEtudiant.ElementAt(0).ElementAt(2), "G4", "K4", WorksheetVerso, 12, true);
            Utilitaires.RangeValue(listStageEtudiant.ElementAt(0).ElementAt(3), "L4", "M4", WorksheetVerso, 12, true);
            Utilitaires.RangeValue("2ème année", "A5", "B5", WorksheetVerso, 12, true);
            Utilitaires.RangeValue(listStageEtudiant.ElementAt(1).ElementAt(0), "C5", "E5", WorksheetVerso, 12, true);
            Utilitaires.RangeValue(listStageEtudiant.ElementAt(1).ElementAt(1), "F5", "F5", WorksheetVerso, 12, true);
            Utilitaires.RangeValue(listStageEtudiant.ElementAt(1).ElementAt(2), "G5", "K5", WorksheetVerso, 12, true);
            Utilitaires.RangeValue(listStageEtudiant.ElementAt(1).ElementAt(3), "L5", "M5", WorksheetVerso, 12, true);
            Utilitaires.RangeValue("AVIES DU CONSEIL DE CLASSE ET OBSERVATIONS EVENTUELLES", "A8", "B9", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("COTATION DE LA CLASSE", "C8", "G9", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("RESULTATS DE LA SECTION", "H8", "K8", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("LES 3 DERNIERES ANNEES", "H9", "K9", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Visa du chef d'établissement et remarques éventuelles", "L8", "L9", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Date et visa du président du jury", "M8", "M9", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Favorable", "A10", "B22", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Répartition en %", "C10", "C14", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("AVIS", "D10", "F10", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Très favorable", "D11", "D14", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Favorable", "E11", "E14", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Doit faire ses preuves", "F11", "F14", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Effectif total de la classe", "G10", "G14", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Années", "H10", "H10", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Preésentés", "I10", "I10", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Reçus", "J10", "J10", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("%", "K10", "K10", WorksheetVerso, 10, true);
            List<List<string>> ListInfo = GestionBDD.ResultDerniereAnnee();
            for (int i = 0; i < 12; i += 4)
            {
                Utilitaires.RangeValue(ListInfo.ElementAt(i / 4).ElementAt(0), "H" + (11 + i), "H" + (14 + i), WorksheetVerso, 10, true);
                Utilitaires.RangeValue(ListInfo.ElementAt(i / 4).ElementAt(1), "I" + (11 + i), "I" + (14 + i), WorksheetVerso, 10, true);
                Utilitaires.RangeValue(ListInfo.ElementAt(i / 4).ElementAt(2), "J" + (11 + i), "J" + (14 + i), WorksheetVerso, 10, true);
                Utilitaires.RangeValue(Convert.ToInt32(ListInfo.ElementAt(i / 4).ElementAt(2)) / Convert.ToInt32(ListInfo.ElementAt(i / 4).ElementAt(1)) * 100 + "%", "K" + (11 + i), "K" + (14 + i), WorksheetVerso, 10, true);
            }
            List<int> nombreEtudiantClasse = GestionBDD.NbEtudiantClasse(nom, prenom);
            int TF = GestionBDD.NbEtudiantClasseAvis("TF", nombreEtudiantClasse.ElementAt(1));
            int F = GestionBDD.NbEtudiantClasseAvis("F", nombreEtudiantClasse.ElementAt(1));
            int DFP = GestionBDD.NbEtudiantClasseAvis("DFP", nombreEtudiantClasse.ElementAt(1));
            Utilitaires.RangeValue("Je certifie sur l'honneur l'exactitude des éléments portés sur le présent livret Date et signature", "L10", "L22", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("% élèves", "C15", "C22", WorksheetVerso, 10, true);
            Utilitaires.RangeValue(TF + " %", "D15", "D22", WorksheetVerso, 10, true);
            Utilitaires.RangeValue(F + " %", "E15", "E22", WorksheetVerso, 10, true);
            Utilitaires.RangeValue(DFP + " %", "F15", "F22", WorksheetVerso, 10, true);
            Utilitaires.RangeValue(nombreEtudiantClasse.ElementAt(0).ToString(), "G15", "G22", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("Date et signature de candidat", "L24", "L24", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("", "L25", "L26", WorksheetVerso, 10, true);
            Utilitaires.RangeValue("", "M10", "M22", WorksheetVerso, 10, true);
            #endregion

            // creation du pdf
            #region PDF
            // enregistrement .xlsx
            WorkbookRecto.SaveAs("LivretRecto.xlsx");
            WorkbookVerso.SaveAs("LivretVerso.xlsx");

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            // open .xlsx avec la librerie gembox.Spreadsheet
            ExcelFile WorkbookRecto_ = ExcelFile.Load("LivretRecto.xlsx");
            ExcelFile WorkbookVeros_ = ExcelFile.Load("LivretVerso.xlsx");

            ExcelWorksheet WorksheetRecto_ = WorkbookRecto_.Worksheets.ElementAt(0);
            ExcelWorksheet WorksheetVerso_ = WorkbookVeros_.Worksheets.ElementAt(0);

            // definition de la zone a "imprimer" 
            WorksheetRecto_.NamedRanges.SetPrintArea(WorksheetRecto_.Cells.GetSubrange("A1", "K32"));
            WorksheetVerso_.NamedRanges.SetPrintArea(WorksheetVerso_.Cells.GetSubrange("A1", "M26"));

            // definition au format paysage
            WorksheetRecto_.PrintOptions.Portrait = false;
            WorksheetVerso_.PrintOptions.Portrait = false;

            // definition pour que la zone a imprimer sois au format de la page
            WorksheetRecto_.PrintOptions.FitWorksheetWidthToPages = 1;
            WorksheetVerso_.PrintOptions.FitWorksheetWidthToPages = 1;

            // enregistrement .pdf
            WorkbookRecto_.Save("LivretRecto.pdf");
            WorkbookVeros_.Save("LivretVerso.pdf");


            // creeation d'un pdf ou l'on copy les recto et verso
            PdfDocument outPdf = new PdfDocument();
            void CopyPages(PdfDocument from, PdfDocument to) { for (int i = 0; i < from.PageCount; i++) to.AddPage(from.Pages[i]); }
            CopyPages(PdfReader.Open("LivretRecto.pdf", PdfDocumentOpenMode.Import), outPdf);
            CopyPages(PdfReader.Open("LivretVerso.pdf", PdfDocumentOpenMode.Import), outPdf);

            return outPdf;
            #endregion
        }

        /// <summary>
        /// permet de saugarder le pdf
        /// </summary>
        /// <param name="pdf"> le pdf a sauvegarder </param>
        /// <param name="filePath"> le lien du repertoire </param>
        /// <param name="nom"> le nom de l'etudiant </param>
        /// <param name="prenom"> le prenom de l'etudiant </param>
        public static void SavePdf(PdfDocument pdf, string filePath, string nom, string prenom)
        {
            // enregistrement .pdf
            try
            {
                pdf.Save(filePath + "\\Livret Schoolaire " + nom + " " + prenom + ".pdf");
                MessageBox.Show("Enregistrement a bien fonctionner");
            }
            catch 
            { 
                MessageBox.Show("Enregistrement n'a pas fonctionner"); 
            }
        }

        /// <summary>
        /// permet de cree et sauvegarder tous les livret d'une classe
        /// </summary>
        /// <param name="pdfs"> list des pdf </param>
        /// <param name="filePath"> lien de dossier </param>
        /// <param name="nomClasse"> le nom de la classe </param>
        public static void SavesPDF(List<PdfDocument> pdfs, string filePath,string nomClasse)
        {
            PdfDocument outPdf = new PdfDocument();
            foreach (PdfDocument pdf in pdfs)
            {
                void CopyPages(PdfDocument from, PdfDocument to) { for (int i = 0; i < from.PageCount; i++) to.AddPage(from.Pages[i]); }
                CopyPages(pdf, outPdf);
            }
            try
            {
                outPdf.Save(filePath + "\\Livret Schoolaire " + nomClasse + ".pdf");
                MessageBox.Show("Enregistrement a bien fonctionner");
            }
            catch
            {
                MessageBox.Show("Enregistrement n'a pas fonctionner");
            }
        }

        /// <summary>
        /// permet de de mettre un antislash devant un caractere ex ' -> \'
        /// </summary>
        public static string ChangeChar(string paragraphe, string charr)
        {
            return paragraphe.Replace(charr, "\\" + charr);
        }
    }
}
