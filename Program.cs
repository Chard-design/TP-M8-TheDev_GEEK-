using System;

namespace TP_M8_TheDev_GEEK;

class program
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
            
            Console.Clear();

           
           
            
        }while (choix !=0);

    }
}
