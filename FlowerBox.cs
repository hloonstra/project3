public class FlowerBox
{

    private int length;
    private int width;
    private int height;
    private int diameter;
    private int flank;
    private Enum_form form;

    public FlowerBox(int _length, int _width, int _height)
    {
        if (_length > 0 && _width > 0 && _height > 0)
        {
            if (_length < 101 && _width < 101 && _height < 101)
            {
                this.length = _length;
                this.width = _width;
                this.height = _height;
                form = Enum_form.Balk;
            }
            else
            {
                throw new ArgumentException("Een getal moet minder dan 100");
            }

        }
        else
        {
            throw new ArgumentException("Moet een positief getal zijn");
        }

    }

    public FlowerBox(int _flank)
    {
        if (_flank > 0)
        {
            if (_flank < 101)
            {
                this.flank = _flank;
                form = Enum_form.Kubus;
            }
            else
            {
                throw new ArgumentException("Een getal moet minder dan 100");
            }
        }
        else
        {
            throw new ArgumentException("Moet een positief getal zijn");
        }
    }

    public FlowerBox(int _diameter, int _height)
    {
        if (_diameter > 0 && _height > 0)
            if (_diameter < 101 && _height < 101)
            {
                this.diameter = _diameter;
                this.height = _height;
                form = Enum_form.Cilinder;
            }
            else
            {
                throw new ArgumentException("Een getal moet 100 of minder dan 100");
            }
        else
        {
            throw new ArgumentException("Moet een positief getal zijn");
        }
    }
    public enum Enum_form
    {
        Balk,
        Kubus,
        Cilinder
    }
    /// <summary>
    /// Deze methode print alle info die ik heb.
    /// </summary>
    /// <returns></returns>
    public string PrintFlowerBox()
    {
        if (form == Enum_form.Balk)
        {
            return ($"Lengte: {length} \nBreedte: {width} \nHoogte: {height}");

        }
        else if (form == Enum_form.Kubus)
        {
            return (@$"Zijde: {flank}");
        }
        else
        {
            return ($"Hoogte: {height}\nDiameter: {diameter}");
        }

    }
    public int Volume()
    {

        if (form == Enum_form.Balk)
        {
            return length * width * height;
        }
        else if (form == Enum_form.Kubus)
        {
            return flank * flank * flank;
        }
        else
        {
            // Ik heb meneer Lijten gevraagd en hij zij dat wij moeten int maken en de verlies acceptern.
            int straal = diameter / 2;
            return (int)Math.Round(Math.PI * (straal * straal) * height, 0);
        }
    }

    public double Surface()
    {
        if (form == Enum_form.Balk)
        {
            return length * width;
        }
        else if (form == Enum_form.Kubus)
        {
            return flank * flank;
        }
        else
        {
            // Ik heb meneer Lijten gevraagd en hij zij dat wij moeten int maken en de verlies acceptern.
            int straal = diameter / 2;
            return (int)Math.Round(Math.PI * (straal * straal), 0);
        }
    }

    public float Price(bool pottingSoil)
    {
        float potgrond = 0;
        float normalePrijs = (float)(Volume() * 0.002);

        if (pottingSoil == true) {
            potgrond = (float)(Volume() * 0.0002);
        }
        normalePrijs = (float)(Volume() * 0.002);
        return potgrond + normalePrijs;
    }
}