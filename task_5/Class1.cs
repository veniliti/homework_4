using System;
using System.Collections.Generic;
using System.Text;

class Item
{
    public double Price { get; set; }
    public string OriginCountry { get; set; }
    public string Name { get; set; }
    public DateOnly PackageDate { get; set; }
    public string Description { get; set; }
    public string Type => GetType().Name;       
    public virtual string Details => "";           
    public Item(double price, string originCountry, string name, DateOnly packageDate, string description)
    {
        Price = price;
        OriginCountry = originCountry;
        Name = name;
        PackageDate = packageDate;
        Description = description;
    }
}

class Food : Item
{
    public DateOnly ExpirationDate { get; set; }
    public int Count { get; set; }
    public string UnitOfMeasure { get; set; }
    public override string Details =>
    $"Expiration Date: {ExpirationDate}, Count: {Count} {UnitOfMeasure}";

    public Food(double price, string originCountry, string name, DateOnly packageDate, string description,
                DateOnly expirationDate, int count, string unitOfMeasure)
        : base(price, originCountry, name, packageDate, description)
    {
        ExpirationDate = expirationDate;
        Count = count;
        UnitOfMeasure = unitOfMeasure;
    }
}

class Books : Item
{
    public int Pages { get; set; }
    public string Publisher { get; set; }
    public string Author { get; set; }

    public override string Details =>
    $"Pages: {Pages}, Publisher: {Publisher}, Author: {Author}";

    public Books(double price, string originCountry, string name, DateOnly packageDate, string description,
                int pages, string publisher, string author)
        : base(price, originCountry, name, packageDate, description)
    {
        Pages = pages;
        Publisher = publisher;
        Author = author;
    }
}


