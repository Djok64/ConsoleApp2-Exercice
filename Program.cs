public class Program
{
  public static void Main(string[] args)
  {
    // Créer un tableau d'objets Journee pour stocker les données
    Journee[] semaine =
    [
            new("lundi", 5),
            new("mardi", 8),
            new("mercredi", 4),
            new("jeudi", 6),
            new("vendredi", 7),
            new("samedi", 9),
            new("dimanche", 10)
    ];

    // Afficher les informations de chaque jour
    foreach (Journee jour in semaine)
    {
      Console.WriteLine(jour);
    }
  }
}
