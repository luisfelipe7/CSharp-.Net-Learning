using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using MySecondApplication.Entity;

namespace MySecondApplication.Applications
{
  public class Relation
  {
    static void Main(string[] args)
    {
      try
      {
        // Inheritance
        Text text = new Text();
        text.Width = 10;
        text.Copy();
        text.AddHyperLink("ibm-learning.udemy.com");

        // Composition
        DbMigrator dbMigrator = new DbMigrator(new Logger());
        dbMigrator.Migrate();

        // Inheratince with Constructor
        Motorcycle motorcycle = new Motorcycle("1234");

        // Upcasting/Downcasting
        Text2 text2 = new Text2();
        Shape shape = text2;

        text2.Width = 200;
        shape.Width = 100;

        // It will display 100 because both objects are pointing to the same
        Console.WriteLine(text2.Width);

        // StreamReader
        StreamReader reader = new StreamReader(new MemoryStream());
        // ArrayList
        var arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Felipe");
        arrayList.Add(new Text());
        // List
        var anotherList = new List<Shape>();

        // Downcasting
        Shape shape2 = new Text2();
        Text2 text3 = (Text2)shape;

        // Overriding
        List<Figure> figures = new List<Figure>();
        figures.Add(new Triangle(1, 7));
        figures.Add(new Rectangle(9, 6));
        figures.Add(new Figure(3, 3));

        foreach (var figure in figures)
        {
          figure.Draw();
        }

        // Using Abstract Clasess
        List<Animal> animals = new List<Animal>();
        animals.Add(new Dog());
        animals.Add(new Cat());
        animals.Add(new Dog());

        foreach (var animal in animals)
        {
          animal.MakeSound();
          animal.Eat();
        }



      }
      catch (Exception e)
      {
        Console.WriteLine("An unexpected error occurred, message " + e.Message);
      }

    }
  }
}
