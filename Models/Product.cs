namespace AccessModifiers.Models;

public class Product
{
	const decimal MIN_PRICE = 0.0m;

	private int _count;

	public int Count
	{
		get => _count;
		set => _count = value;
	}

	private decimal _price;

	public decimal Price
	{
		get => _price;
		set => _price = IsValidPrice(value) ? value : _price;
	}

    public Product(int count, decimal price)
    {
        Price = price;
		Count = count;
    }

    public bool IsValidPrice(decimal price)
    {
        bool check = price >= MIN_PRICE;
        if (!check)
            Console.WriteLine("Price is not valid!");
        return check;
    }
}