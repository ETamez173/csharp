using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    /*
    Properties
    */
    public string Title { get; set; }
    public double Price { get; set; }

    // Constructor method
    public Product(string title, double price)
    {
        this.Title = title;
        this.Price = price;
    }
}