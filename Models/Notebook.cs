using System.ComponentModel;

namespace AccessModifiers.Models;

public class Notebook : Product
{
    const int MIN_BRANDNAME_LENGTH = 3;
    const int MAX_BRANDNAME_LENGTH = 30;

    const int MIN_RAM_CAPACITY = 1;
    const int MAX_RAM_CAPACITY = 128;

    const int MIN_Storage = 1;

    private string _brand;

	public string Brand
	{
		get => _brand;
		set => _brand = IsValidBrandName(value) ? value : _brand;
	}

	private string _model;

	public string Model
	{
		get => _model;
		set => _model = value;
	}

	private int _ram;
	public int Ram
	{
		get => _ram;
		set => _ram = IsValidRam(value) ? value : _ram;
	}

	private int _storage;
	public int Storage
	{
		get => _storage;
		set => _storage = IsValidStorage(value) ? value : _storage;
	}

    public Notebook(int count, decimal price,string model) : base(count,price)
    {
        Model = model;
    }



	public bool IsValidBrandName(string brandName)
	{
		bool check = brandName.Length >= MIN_BRANDNAME_LENGTH && brandName.Length <= MAX_BRANDNAME_LENGTH;
		if(!check)
			Console.WriteLine("Brand name is not valid!");
        return check;
	}

    public bool IsValidRam(int ram)
    {
		bool check = ram >= MIN_RAM_CAPACITY && ram <= MAX_RAM_CAPACITY;
        if (!check)
            Console.WriteLine("Ram is not valid!");
        return check;
    }

    public bool IsValidStorage(int storage)
    {
		bool check = storage >= MIN_Storage;
        if (!check)
            Console.WriteLine("Storage is not valid!");
        return check;
    }

    public override string ToString()
    {
		return $"{Count}X {Brand}-{Model} {Storage}GB/{Ram}GB is listed for {Price} azn";
    }
}