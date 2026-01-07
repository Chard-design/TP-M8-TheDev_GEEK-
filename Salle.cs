

class Salle : Ressource
{
    public int Capacite {get;}

    public Salle(int id,string responsable,string nom)
    :base(id,nom,responsable)
    {
    Capacite= Capacite;
    }
    public override string Type()=> "Salle";

    public override void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Capacite : {Capacite}personnes");
        Console.WriteLine("----------------------");
    }
        

}