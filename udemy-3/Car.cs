namespace udemy_3;

public class Car
{
    private string _model = "";
    private string _brand = "";
    public Car(string model, string brand)
    {
        _model = model;
        _brand = brand;
        Console.WriteLine($"A car brand {_brand} with {_model} model has been created.");
    }
}