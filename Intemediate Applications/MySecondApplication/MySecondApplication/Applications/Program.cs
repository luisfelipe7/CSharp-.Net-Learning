using System;
using MySecondApplication.Entity;

namespace MySecondApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      try {
        Person person1 = new Person("Luis");
        person1.Introduce();

        Person person2 = Person.CreatePerson("Felipe");
        person2.Introduce();

        Customer customer1 = new Customer(1, "Yenifer");
        customer1.displayInformation();

        Order order1 = new Order();
        customer1.addOrder(order1);

        Point point1 = new Point(10, 20);
        point1.Move(new Point(40, 60));
        point1.displayInformation();

        Calculator calculator1 = new Calculator();
        Console.WriteLine("The value of the sum is " + calculator1.Sum(1, 2, 3, 4));
        Console.WriteLine("The value of the sum is " + calculator1.Sum(new int[] { 1, 2, 3, 4 }));

        int number;
        var result = int.TryParse("abc", out number);
        if (result) {
          Console.WriteLine(number);
        } else {
          Console.WriteLine("Conversion failed");
        }

        Employee employee1 = new Employee(2, "Maui");
        employee1.addOrder(order1);
        employee1.displayInformation();

        Car car1 = new Car("BMW");
        car1.SetLaunchDate(new DateTime(1982, 1, 1));
        car1.Color = "Blue";
        car1.displayInformation();

        HttpCookie cookie1 = new HttpCookie();
        cookie1["name"] = "Luis";
        Console.WriteLine(cookie1["name"]);


      } catch (Exception e) {
        Console.WriteLine("An unexpected error occurr, message " + e.Message);
      }

    }
  }
}
