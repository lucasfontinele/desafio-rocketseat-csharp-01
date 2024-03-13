Console.WriteLine("Informe a placa do veículo:");

var carPlateEntry = Console.ReadLine()?.Trim();

bool IsValidPlate()
{
    if (string.IsNullOrEmpty(carPlateEntry) || string.IsNullOrWhiteSpace(carPlateEntry) || carPlateEntry.Length != 7)
    {
        return false;
    }
    
    for (var i = 0; i < 3; i++)
    {
        var current = carPlateEntry[i];

        if (!char.IsLetter(current))
        {
            return false;
        }
    }

    for (var i = 3; i < 7; i++)
    {
        var current = carPlateEntry[i];

        if (!char.IsDigit(current))
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine(IsValidPlate());


