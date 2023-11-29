using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace Bloc2SlamProj1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string newSection, newEleveNom, newElevePrenom, newEleveSection, newMatiere;
            int newCoefficient;
            
            Section section1 = new Section("SIO");
            section1.AfficherSection();
            Section section2 = new Section("MCO");
            section2.AfficherSection();
            Section section3 = new Section("ESF");
            section3.AfficherSection();
            Section section4 = new Section("CI");
            section4.AfficherSection();

            Console.WriteLine("Entrez le nom de la nouvelle section ?");
            newSection = Console.ReadLine();

            Eleve eleve1 = new Eleve("Dupont", "Toto", "SIO");
            eleve1.AfficherEleve();
            Eleve eleve2 = new Eleve("Durant", "Jean", "MCO");
            eleve2.AfficherEleve();
            Eleve eleve3 = new Eleve("Delarue", "Mickael", "SIO");
            eleve3.AfficherEleve();

            Console.WriteLine("Entrez le nom de l'élève ?");
             newEleveNom = Console.ReadLine();
             Console.WriteLine("Entrez le prénom de l'élève ?");
             newElevePrenom = Console.ReadLine();
             Console.WriteLine("Entrez la section de l'élève ?");
             newEleveSection = Console.ReadLine(); 

            Matiere matiere1 = new Matiere("Bloc1", 5);
            matiere1.AfficherMatiere();
            Matiere matiere2 = new Matiere("Bloc2", 8);
            matiere2.AfficherMatiere();
            Matiere matiere3 = new Matiere("Bloc3", 6);
            matiere3.AfficherMatiere();
            
            Console.WriteLine("Entrez le nom de la matière ?");
            newMatiere = Console.ReadLine();
            Console.WriteLine("Entrez le coefficient de la matière ?");
            newCoefficient = Int32.Parse(Console.ReadLine());
            
            Matiere matieres1 = new Matiere("Bloc2", 8);
            Matiere matieres2 = new Matiere("Francais", 3);
            Matiere matieres3 = new Matiere("Bloc 1", 4);
            Matiere matieres4 = new Matiere("Bloc 3", 6);
            Matiere matieres5 = new Matiere("CEJM", 4);
            Matiere matieres6 = new Matiere("Math", 7);
            Matiere matieres7 = new Matiere(newMatiere, newCoefficient);
            Section sections1 = new Section("SIO1");
            sections1.ajouterMatiere(matieres1);
            sections1.ajouterMatiere(matieres2);
            Eleve eleves1 = new Eleve("Dupont", "Durant", "SIO");
            
            Section sections2 = new Section("MCO2");
            sections2.ajouterMatiere(matieres3);
            sections2.ajouterMatiere(matieres4);
            Eleve eleves2 = new Eleve("Adret", "Jean", "MCO");

            Section sections3 = new Section("SIO1");
            sections3.ajouterMatiere(matieres5);
            sections3.ajouterMatiere(matieres6);
            Eleve eleves3 = new Eleve("Delarue", "Mickael", "SIO");

            Section sections4 = new Section(newSection);
            sections4.ajouterMatiere(matieres7);
            Eleve eleves4 = new Eleve(newEleveNom, newElevePrenom, newEleveSection);

            matieres1.AfficherMatiere();
            matieres2.AfficherMatiere();
            matieres3.AfficherMatiere();
            matieres4.AfficherMatiere();

            sections1.AfficherSection();
            sections2.AfficherSection();
            sections3.AfficherSection();
            sections4.AfficherSection();

            eleves1.AfficherEleve();
            eleves2.AfficherEleve();
            eleves3.AfficherEleve();
            eleves4.AfficherEleve();
           
            Console.ReadLine();
        }
    }
}