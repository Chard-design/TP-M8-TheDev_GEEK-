/**using System;
using System.Data.Common;
using TP_M8_TheDev_GEEK;
namespace TP_M8_TheDev_GEEK

{
    public class Chambre: Ressource 
    {
        public int Numero {get;}
        public int NombreLits{get;}
        public Chambre(int id,string responsable,string nom,int numero,int nombrelits)
        {
            Numero=numero;
            NombreLits=nombrelits;
        }
        public override string Type()=> "Chambre";
    
        public void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Numero : {Numero}");
            Console.WriteLine($" NombreLits : {NombreLits}");
        }
    }
}
**/