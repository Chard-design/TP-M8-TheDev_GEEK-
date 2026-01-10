using System;
using TP_M8_TheDev_GEEK;
namespace TP_M8_TheDev_GEEK;

class Program
{
    static void Main()
    {
           var gestion= new GestionReservation();
        int choix;

        do
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine("SYSTEME DE GESTION DES RESERVATIONS");
            Console.WriteLine("1- Ajouter une salle");
            Console.WriteLine("2- Lister les ressources ");
            Console.WriteLine("3- Creer une reservation ");
            Console.WriteLine("4- Consulter les reservations");
            Console.WriteLine("0. Quitter");
            Console.Write("\n Votre choix : ");

            choix=int.Parse(Console.ReadLine());
            
    
            

            switch (choix)
            {
                case 1: gestion.AjouterSalle();
                break;
                case 2: gestion.ListerRessources();
                break;
                case 3: gestion.CreerReservation();
                break;
                case 4: gestion.ListerReservation();
                break;
            
            }
           
         
        }while (choix !=0);
        Console.WriteLine("\n Appuyer sur enter pour revenir au menu");
    }
}
