using System;
using TP_M8_TheDev_GEEK;
namespace TP_M8_TheDev_GEEK
{
   public class Reservation 
   {
     public Ressource Ressource{get;}
     public string Utilisateur{get;}
     public DateTime Debut{get;}
     public DateTime Fin{get;}

     public Reservation(Ressource ressource,string utilisateur,DateTime debut,DateTime fin)
     {
     Ressource=ressource;
     Utilisateur=utilisateur;
     Debut=debut;
     Fin=fin;
     }
 
     public void Afficher()
      {
        Console.WriteLine("=====================================");
        Console.WriteLine("L'ensemble des Details de Reservation");
        Console.WriteLine("=====================================");
        Console.WriteLine($"Ressource :  {Ressource.Nom}");
        Console.WriteLine($"Utilisateur: {Utilisateur}");
        Console.WriteLine($"Responsable: {Ressource.Responsable}");
        Console.WriteLine($"Type: {Ressource.Type()}");
        Console.WriteLine($"Debut: {Debut}");
        Console.WriteLine($"Fin:{Fin}");
      }
    }
}