namespace udemy_3;

public class Car
{
    private string _model = "";
    private string _brand = "";
    private bool _isLuxury = false;

    public string Model { get => _model; set =>  _model = value; }

    public string Brand
    {
        get
        {
            if (_isLuxury)
            {
                return _brand + " - Luxury Edition";
            }
            else
            {
                return _brand;
            }
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {   
                Console.WriteLine("A car brand is required.");
                throw new ArgumentException("Brand name cannot be empty");
            }
            else
            {
                _brand = value;
            }
        }
    }

    public bool IsLuxury
    {
        get => _isLuxury;
        set => _isLuxury = value;
    }

    public Car(string model, string brand, bool isLuxury)
    {
        Model = model;
        Brand = brand;
        Console.WriteLine($"A car brand {_brand} with {Model} model has been created.");
        IsLuxury = isLuxury;
    }
}