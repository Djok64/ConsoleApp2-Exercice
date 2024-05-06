public class Journee
{
  public string NomJour { get; set; }
  public int CigarettesFumees { get; set; }

  public Journee(string nomJour, int cigarettesFumees)
  {
    NomJour = nomJour;
    CigarettesFumees = cigarettesFumees;
  }

  public override string ToString()
  {
    return NomJour + " " + CigarettesFumees + " cigarettes";
  }

}