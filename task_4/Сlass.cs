using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

River river = new River { X = 31, Y = 49, Name = "Дніпро", Description = "Річка", Speed = 50, Length = 2201 };
Console.WriteLine(river.GetInfo());
Mountain mountain = new Mountain { X = 24, Y = 48, Name = "Говерла", Description = "Гора", HighestPoint = "2061 м" };
Console.WriteLine(mountain.GetInfo());

abstract class GeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual string GetInfo() => $"{Name} ({X}; {Y}) - {Description}";
}

class River : GeographicObject
{
    public double Speed { get; set; }
    public double Length { get; set; }

    public override string GetInfo() => base.GetInfo() + $", течія {Speed} см/с, довжина {Length}";
}

class Mountain : GeographicObject
{
    public string HighestPoint { get; set; }

    public override string GetInfo() => base.GetInfo() + $", найвища точка {HighestPoint}";
}