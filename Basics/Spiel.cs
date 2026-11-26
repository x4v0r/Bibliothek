namespace Basics;

public class Spiel
{
    public int Bewertung { get; set; } // Property
    // public bool IstEmpfehlung() => Bewertung >= 8; 
    
    public bool IstEmpfehlung()
    {
        return Bewertung >= 8;
    }
}

