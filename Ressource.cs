using System.Data.Common;
using TP_M8_TheDev_GEEK;
namespace TP_M8_TheDev_GEEK
{
    public abstract class Ressource
  {
    public int Id{get;}
    public string Nom {get;}
    public string Responsable {get;} 
    public int Numero{get;}

    protected Ressource( int id, string nom,string responsable)
    {
        Id=id;
        Nom=nom;
        Responsable= responsable;
    }
    public abstract string Type();
    public virtual void Afficher()
    {
        Console.WriteLine("=============");
        Console.WriteLine($"ID  : {Id}");
        Console.WriteLine($"Nom     : {Nom}");
        Console.WriteLine($"Type  :{Type()}");
        Console.WriteLine($"Responsable  : {Responsable}");
    }
  }
}