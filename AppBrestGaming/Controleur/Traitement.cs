using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppBrestGaming.Controleur
{
    public class Traitement
    {
        private FichierLog ficLog;
        private Modele.JeuDAO gestionDesJeux;
        private Modele.EquipeDAO monDAO = new Modele.EquipeDAO();
        private Modele.PersonneDAO persDao = new Modele.PersonneDAO();
        private Modele.PlateformeDAO platDao = new Modele.PlateformeDAO();
        private Modele.JeuDAO jeuDao = new Modele.JeuDAO();

        public Traitement()
        {
            ficLog = new FichierLog("connexions.log");
            Initialisation();
            gestionDesJeux = new Modele.JeuDAO();
        }

        void Initialisation()
        {
            ficLog.EcrireLog("admin\tConnexion réussie.");
        }

        public void AfficherLogs()
        {
            if (ficLog!= null)
            {
                List<string> lignesFichier = ficLog.AfficherFichier();
                foreach (string ligne in lignesFichier)
                {
                    Console.WriteLine(ligne);
                }
            }
            else
            {
                Console.WriteLine("Le fichier de logs n'est pas définit");
            }
        }

        public void CompterOccurrences()
        {
            if(ficLog != null)
            {
                string user = "admin";
                int nbAdmin = ficLog.OccurencesLogin(user);
                Console.WriteLine($"Nombre d'occurrences de {user} : {nbAdmin}");
            }
            else
            {
                Console.WriteLine("Le fichier de logs n'est pas définit");
            }
        }

        public void SupprimerLogs()
        {
            if(ficLog != null)
            {
                bool supOK = ficLog.SuppressionFichier();
                if (supOK)
                {
                    Console.WriteLine("Fichier supprimé");
                }
                else
                {
                    Console.WriteLine("Fichier non supprimé");
                }
            }
            else
            {
                Console.WriteLine("Le fichier de logs n'est pas définit");
            }
        }
        // Jeu
        public void AfficherJeux()
        {
            int nbJeu = 1;
            foreach (Modele.Jeu monJeu in jeuDao.GetListe())
            {
                Console.WriteLine($"{nbJeu} {monJeu.ToString()}");
                nbJeu++;
            }
        }

        public void SupprimerJeu()
        {
            Console.WriteLine("Saisir l'identifiant du jeux à supprimer : ");
            int idJeu = int.Parse(Console.ReadLine());
            if (jeuDao.Supression(idJeu))
            {
                Console.WriteLine("Jeu supprimé ! ");
            }
            else
            {
                Console.WriteLine("Erreur de la suppression :/");
            }
        }

        public void AjouterJeu()
        {
            Console.WriteLine("Saisissez le identifiant du jeu à insérer : ");
            int nouveauJeuId = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez le nom du jeu à insérer : ");
            string nouveauJeuNom = Console.ReadLine();
            Console.WriteLine("Saissiez le type de jeu : ");
            string nouveauJeuGenre = Console.ReadLine();
            Console.WriteLine("Saissiez le nom d'editeur : ");
            string nouveauJeuEditeur = Console.ReadLine();
            Console.WriteLine("Saissiez le lien vers le logo : ");
            string nouveauJeuLogo = Console.ReadLine();
            // Créer un nouveau jeu et l'ajouter à la liste
            Modele.Jeu nouveauJeu = new Modele.Jeu(nouveauJeuId, nouveauJeuNom, nouveauJeuGenre, nouveauJeuEditeur, nouveauJeuLogo, null);
            if (jeuDao.Ajout(nouveauJeu))
            {
                Console.WriteLine("Jeu ajouté ! ");
            }
            else
            {
                Console.WriteLine("Erreur dans la suppression :/");
            }
        }
        public void AfficherJeu()
        {
            Console.WriteLine("Veuillez saisir l'identifiant du jeu : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(jeuDao.GetById(id).ToString());
        }
        public void ModificationJeu()
        {
            Console.WriteLine("Modification d'un jeu");
            Console.WriteLine("Saisir l'id du jeu à modifier : ");
            int idJeu = int.Parse(Console.ReadLine());
            Console.WriteLine(jeuDao.GetById(idJeu).ToString());
            Console.WriteLine("Saisissez le nom du jeu à insérer : ");
            string nouveauJeuNom = Console.ReadLine();
            Console.WriteLine("Saissiez le type de jeu : ");
            string nouveauJeuGenre = Console.ReadLine();
            Console.WriteLine("Saissiez le nom d'editeur : ");
            string nouveauJeuEditeur = Console.ReadLine();
            Console.WriteLine("Saissiez le lien vers le logo : ");
            string nouveauJeuLogo = Console.ReadLine();
            Modele.Jeu nouveauJeu = new Modele.Jeu(idJeu, nouveauJeuNom, nouveauJeuGenre, nouveauJeuEditeur, nouveauJeuLogo, null);
            if (jeuDao.Modification(idJeu, nouveauJeu))
            {
                Console.WriteLine("Jeu modifié !");
            }
            else
            {
                Console.WriteLine("Erreur lors de la modification");
            }
        }
        // Equipes
        public void AfficherEquipes()
        {
            Console.WriteLine("Liste des équipes :");
            List<Modele.Equipe> listeEquipe = monDAO.GetListeEquipes();
            if (listeEquipe != null)
            {
                foreach (Modele.Equipe equipe in listeEquipe)
                {
                    Console.WriteLine($"ID: {equipe.Id}, Nom: {equipe.Nom}");
                }
            }
            else
            {
                Console.WriteLine("Aucune équipe trouvée.");
            }
        }
        public void AjouterEquipe()
        {
            Console.WriteLine("Insérer le nom de l'équipe : ");
            string nomEquipe = Console.ReadLine();
            Console.WriteLine("Insérer le site web : ");
            string webSite = Console.ReadLine();
            Modele.Equipe nouvelleEquipe = new Modele.Equipe(1, $"{nomEquipe}", $"{webSite}", $"logo.png", null);

            bool ajoutReussi = monDAO.AjoutEquipe(nouvelleEquipe);
            if (ajoutReussi)
            {
                Console.WriteLine("Nouvelle équipe ajoutée avec succès.");
            }
            else
            {
                Console.WriteLine("Erreur lors de l'ajout de la nouvelle équipe.");
            }
        }
        public void AfficherEquipeSolo()
        {
            Console.WriteLine("Veuillez entrer l'ID ou le nom de l'équipe que vous souhaitez afficher : ");
            string input = Console.ReadLine();
            int id;
            if (int.TryParse(input, out id))
            {
                // Afficher l'équipe par son ID
                Modele.Equipe equipe = monDAO.GetEquipeById(id);
                if (equipe != null)
                {
                    Console.WriteLine($"ID: {equipe.Id}, \nNom: {equipe.Nom}, \nSite Web: {equipe.SiteWeb}, \nImage: {equipe.ImageEquipe}, \nNb personnes: { equipe.ListeJoueurs.Count}");
                    Console.WriteLine($"--- Liste des joueurs de {equipe.Nom} ---");
                    foreach (Modele.Personne Joueur in equipe.ListeJoueurs)
                    {
                        Console.WriteLine($"{Joueur.Pseudo} - {Joueur.Nomjoueur} - {Joueur.Role}");
                    }
                }
                else
                {
                    Console.WriteLine("Aucune équipe trouvée avec cet ID.");
                }
            }
            else
            {
                // Afficher l'équipe par son nom
                Modele.Equipe equipe = monDAO.GetEquipeByNom(input);
                if (equipe != null)
                {
                    Console.WriteLine($"ID: {equipe.Id}, \nNom: {equipe.Nom}, \nSite Web: {equipe.SiteWeb}, \nImage: {equipe.ImageEquipe}");
                    Console.WriteLine($"--- Liste des joueurs de {equipe.Nom} ---");
                    foreach (Modele.Personne Joueur in equipe.ListeJoueurs)
                    {
                        Console.WriteLine($"{Joueur.Pseudo} - {Joueur.Nomjoueur} - {Joueur.Role}");
                    }
                }
                else
                {
                    Console.WriteLine("Aucune équipe trouvée avec ce nom.");
                }
            }
        }
        // Joueurs
        public void AfficherJoueur()
        {
            Console.WriteLine("Veuillez saisir l'identifiant du joueur : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(persDao.GetById(id).ToString());
        }
        public void AfficherListeJoueurs()
        {
            List<Modele.Personne> listePers = persDao.GetListe();
            Console.WriteLine($"Nb personnes : {listePers.Count}");
        }
        public void AjouterJoueur()
        {

            Console.WriteLine("Insérer le numéro de la chambre : ");
            int numChambre = int.Parse(Console.ReadLine());
            Console.WriteLine("Insérer l'ID équipe : ");
            int idEquipe = int.Parse(Console.ReadLine());
            Console.WriteLine("Insérer son pseudo : ");
            string pseudo = Console.ReadLine();
            Console.WriteLine("Insérer son nom : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Insérer son pays : ");
            string pays = Console.ReadLine();
            Console.WriteLine("Insérer son rôle : ");
            string role = Console.ReadLine().ToLower();
            Modele.Personne personneCreer = new Modele.Personne(0, numChambre, idEquipe, pseudo, nom, pays, role);
            if (persDao.Ajout(personneCreer))
            {
                Console.WriteLine("Ajout réussi ! ");
            }
            else
            {
                Console.WriteLine("Ajout dans l'ajout :/");
            }
        }
        public void ModificationJoueur()
        {
            Console.WriteLine("Modification d'un joueurs");
            Console.WriteLine("Saisir l'id du joueur à modifier : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(persDao.GetById(id).ToString());
            Console.WriteLine("Insérer le numéro de la chambre : ");
            int numChambre = int.Parse(Console.ReadLine());
            Console.WriteLine("Insérer l'ID équipe : ");
            int idEquipe = int.Parse(Console.ReadLine());
            Console.WriteLine("Insérer son pseudo : ");
            string pseudo = Console.ReadLine();
            Console.WriteLine("Insérer son nom : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Insérer son pays : ");
            string pays = Console.ReadLine();
            Console.WriteLine("Insérer son rôle : ");
            string role = Console.ReadLine().ToLower();
            Modele.Personne personneModifier = new Modele.Personne(0, numChambre, idEquipe, pseudo, nom, pays, role);
            if(persDao.Modification(id, personneModifier))
            {
                Console.WriteLine("Personne modifié !");
            }
            else
            {
                Console.WriteLine("Erreur lors de la modification");
            }
        }
        public void SupprimerJoueur()
        {
            Console.WriteLine("Veuillez saisir l'identifiant du joueur : ");
            int id = int.Parse(Console.ReadLine());
            if (persDao.Supression(id))
            {
                Console.WriteLine("Personne supprimé !");
            }
            else
            {
                Console.WriteLine("Erreur lors de la suppresion :/");
            }
        }
        // Plateformes
        public void AfficherListePlateformes()
        {
            Console.WriteLine("Liste des plateformes");
            List<Modele.Plateforme> listePlateformes = platDao.GetListe();
            foreach(Modele.Plateforme plat in listePlateformes)
            {
                Console.WriteLine($"{plat.IdPlateforme} - {plat.NomPlateforme}");
            }
        }
        public void AfficherListePlateformesJeu()
        {
            Console.WriteLine("Liste en fonction d'un jeu");
            Console.WriteLine("Insérer l'identifiant du jeu : ");
            int idJeu = int.Parse(Console.ReadLine());
            List<Modele.Plateforme> listePlateformes = platDao.GetListeFromJeu(idJeu);
            if(listePlateformes != null)
            {
                foreach (Modele.Plateforme plat in listePlateformes)
                {
                    Console.WriteLine($"{plat.IdPlateforme} - {plat.NomPlateforme}");
                }
            }
            else
            {
                Console.WriteLine("La liste est vide");
            }
        }
        public void AfficherPlateforme()
        {
            Console.WriteLine("Veuillez saisir l'identifiant de la plateforme : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(platDao.GetById(id).ToString());
        }
        public void AjouterPlateforme()
        {

            Console.WriteLine("Insérer l'identifiant de la plateforme : ");
            int idPlateforme = int.Parse(Console.ReadLine());
            Console.WriteLine("Insérer le nom de la plateforme : ");
            string nomPlateforme = Console.ReadLine();
            Modele.Plateforme plateformeCreer = new Modele.Plateforme(idPlateforme, nomPlateforme);
            if (platDao.Ajout(plateformeCreer))
            {
                Console.WriteLine("Ajout réussi ! ");
            }
            else
            {
                Console.WriteLine("Erreur dans l'ajout :/");
            }
        }
        public void ModificationPlateforme()
        {
            Console.WriteLine("Modification d'une plateforme");
            Console.WriteLine("Saisir l'id de la plateforme à modifier : ");
            int idPlateforme = int.Parse(Console.ReadLine());
            Console.WriteLine(platDao.GetById(idPlateforme).ToString());
            Console.WriteLine("Insérer son nom : ");
            string nomPlateforme = Console.ReadLine();
            Modele.Plateforme plateformeModifier = new Modele.Plateforme(idPlateforme, nomPlateforme);
            if (platDao.Modification(idPlateforme, plateformeModifier))
            {
                Console.WriteLine("Personne modifié !");
            }
            else
            {
                Console.WriteLine("Erreur lors de la modification");
            }
        }
        public void SupprimerPlateforme()
        {
            Console.WriteLine("Veuillez saisir l'identifiant de la plateforme : ");
            int idPlateforme = int.Parse(Console.ReadLine());
            if (platDao.Supression(idPlateforme))
            {
                Console.WriteLine("Plateforme supprimé !");
            }
            else
            {
                Console.WriteLine("Erreur lors de la suppresion :/");
            }
        }
    }
}