using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bloc2SlamProj1
{
 
        public class Matiere
        {
            string _nomMatiere;
            double _coefficientMatiere;
            public Matiere(string matiere, double coefficient)
            {
                _nomMatiere = matiere;
                _coefficientMatiere = coefficient;
            }
        public string getMatiere()
        {
            return _nomMatiere;
        }
        public double getCoefficient()
        {
            return _coefficientMatiere;
        }
        public void AfficherMatiere()
        {
            Console.WriteLine("La matière est " + _nomMatiere);
            Console.WriteLine("Le coefficient est " + _coefficientMatiere);
            Console.WriteLine("--------------------");
        }
        }
        public class Eleve
        {
            string _nomEleve;
            string _prenomEleve;
            string _nomSection;

            public Eleve(string nom, string prenom, string section)
            {
                _nomEleve = nom;
                _prenomEleve = prenom;
                _nomSection = section;
        }
        public string getNom()
        {
            return _nomEleve;
        }
        public string getPrenom()
        {
            return _prenomEleve;
        }
        public string getSection()
        {
            return _nomSection;
        }
        public void AfficherEleve()
        {
            Console.WriteLine("Le nom de l'évève est " + _nomEleve);
            Console.WriteLine("Le prénom de l'évève est " + _prenomEleve);
            Console.WriteLine("L'élève est dans la section " + _nomSection);
            Console.WriteLine("-------------------------------");
        }
        }
        public class Section
        {
            string _nomSection;
            List<Matiere> _mesMatieres = new List<Matiere>();
        public Section(string section)
        {
            _nomSection = section;
        }
        public string getSection()
        {
            return _nomSection;
        }
        public void AfficherSection()
        {
            Console.WriteLine("La section " + _nomSection + " est disponible ");
            Console.WriteLine("------------------------------");

            foreach (Matiere matiere in _mesMatieres)
            {
                matiere.AfficherMatiere();
            }

        }
        public void ajouterMatiere(Matiere matieres)
        {
            _mesMatieres.Add(matieres);
        }
        }
}