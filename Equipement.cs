using System;
using System.ComponentModel;
using TP_M8_TheDev_GEEK;
namespace TP_M8_TheDev_GEEK
{
    public class Equipement: Ressource
    {
        public string Categorie{get;}
        public string Etat{get;}

        public Equipement(int id,string nom,string categorie,string responsable,string etat)
        :base(id,nom,responsable)
        {
            Categorie =categorie;
            Etat=etat;
        }
        public override string Type()=>"Equipement";
    }
}  