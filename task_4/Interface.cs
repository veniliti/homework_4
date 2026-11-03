//using System.Text;

//Console.InputEncoding = Encoding.Unicode;
//Console.OutputEncoding = Encoding.Unicode;

//River river = new River { X = 31, Y = 49, Name = "Дніпро", Description = "Річка", Speed = 50, Length = 2201 };
//Console.WriteLine(river.GetInfo());
//Mountain mountain = new Mountain { X = 24, Y = 48, Name = "Говерла", Description = "Гора", HighestPoint = "2061 м" };
//Console.WriteLine(mountain.GetInfo());

//interface IGeographicObject
//{
//    double X { get; set; }
//    double Y { get; set; }
//    string Name { get; set; }
//    string Description { get; set; }
//    string GetInfo();
//}

//class River : IGeographicObject
//{
//    public double X { get; set; }
//    public double Y { get; set; }
//    public string Name { get; set; }
//    public string Description { get; set; }
//    public double Speed { get; set; }
//    public double Length { get; set; }

//    public string GetInfo() => $"{Name} ({X}; {Y}) - {Description}, течія {Speed} см/с, довжина {Length}";
//}

//class Mountain : IGeographicObject
//{
//    public double X { get; set; }
//    public double Y { get; set; }
//    public string Name { get; set; }
//    public string Description { get; set; }
//    public string HighestPoint { get; set; }

//    public string GetInfo() => $"{Name} ({X}; {Y}) - {Description}, найвища точка {HighestPoint}";
//}