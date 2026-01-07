using System.Data.Common;


abstract class Ressource
{
    public int Id{get;}
    public string Nom {get;}
    public string Responsable {get;} 

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