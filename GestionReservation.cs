using System;
using TP_M8_TheDev_GEEK;
namespace TP_M8_TheDev_GEEK
{
    class GestionReservation
  
    {
        private List<Ressource> ressources= new();
         private List<Reservation> reservations= new();

         public void AjouterSalle()
        {
            Console.Write("Nom de la salle:");
            string nom=Console.ReadLine();

            Console.Write("Responsable:");
            string responsable=Console.ReadLine();

            Console.Write("Capacite:");
            int capacite=int.Parse(Console.ReadLine());

            var salle = new Salle(ressources.Count + 1,nom,responsable);
            ressources.Add(salle);
            Console.WriteLine("merci d'avoir ajouter la salle");
        }
        public void ListerRessources()
        {
           Console.WriteLine("\n LISTE DES RESSOURCES");
           foreach(var r in ressources) 
           r.Afficher();
        }
        public void CreerReservation()
        {
          if(ressources.Count==0)
            {
                Console.WriteLine("Aucune ressource disponible.");
                return;
            }
            ListerRessources();

            Console.Write("ID de la ressource : ");
            int id=int.Parse(Console.ReadLine());

            var ressource=ressources.Find(r=> r.Id == id);

            Console.Write("Nom de l'utilisateur : ");
            string user= Console.ReadLine();

            DateTime debut = DateTime.Now;
            DateTime fin= DateTime.Now.AddHours(2);

            bool conflit = reservations.Exists(r=> r.Ressource==ressource && debut<r.Fin && fin > r.Debut);

            if (conflit)
            {
                Console.WriteLine("Conflit de reservation !");
                return;
            }
            reservations.Add(new Reservation(ressource,user,debut,fin));
            Console.WriteLine("Reservation creee avec succes");
        }
        public void ListerReservation()
        {
            Console.WriteLine("\n RESERVATION");
            foreach(var r in reservations)
            r.Afficher();

        }
    }
}
