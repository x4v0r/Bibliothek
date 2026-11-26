class Rechteck
{
    private double _breite;
    private double _hoehe;
        
        
    //Properties
    public double Breite
    {
            
        // get => _breite;  (Kürzere Schreibweise für siehe unten)
        get
        {
            return _breite;
        }
        set
        {
            if (value > 0)
            {
                _breite = value;
            }
            else
            {
                Console.WriteLine("Breite muss größer 0 sein!");
            }
        }
    }

    public double Hoehe
    {
        get
        {
            return _hoehe;
        }

        set
        {
            if (value > 0)
            {
                _hoehe = value;
            }
            else
            {
                Console.WriteLine("Höhe muss größer 0 sein");
            }
        }
    }

    public double Flaeche
    {
        get
        {
            return _hoehe * _breite;
        }
    }

    public double Umfang
    {
        get
        {
            return (_hoehe + _breite) * 2;
        }
    }
        
    public bool IstQuadrat
    {
        get
        {
            return _hoehe == _breite;
        }
    }
        
    public string Beschreibung
    {
        get
        {
            string form = IstQuadrat ? "Quadrat" : "asdasdasd";
            return $"{form}: {_breite} x {_hoehe}: Fläche {Flaeche}, Umfang {Umfang}";
        }
    }
        
        
    //Konstruktor
    public Rechteck(double EingabeBreite, double EingabeHoehe)
    {
        if (EingabeBreite <= 0 || EingabeHoehe <= 0)
        {
            throw new ArgumentException("Breite und Höhe müssen größer als 0 sein!");
        }

        _breite = EingabeBreite;
        _hoehe = EingabeHoehe;
    }
    
}