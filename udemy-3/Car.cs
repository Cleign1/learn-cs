namespace udemy_3;

public class Car
{
    // private string _model = "";
    private string _brand = "";
    // private bool _isLuxury;

    public string Model { get; set; }

    public string Brand
    {
        get
        {
            if (IsLuxury)
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

    public bool IsLuxury { get; set; }

    public Car(string model, string brand, bool isLuxury)
    {
        Model = model;
        Brand = brand;
        Console.WriteLine($"A car brand {_brand} with {Model} model has been created.");
        IsLuxury = isLuxury;
    }

    public void Drive()
    {
        Console.WriteLine($"I'm a {Model} and i'm Driving this car");
    }
}