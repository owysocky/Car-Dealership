using System;
using System.Collections.Generic;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2014 Porsche 911", 114991, 5000);
      Car ford = new Car("2011 Ford F450", 55995, 7000);
      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

      List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

      lexus.SetPrice(2000);

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> PriseMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          PriseMatchingSearch.Add(automobile);
        }
      }

      Console.WriteLine("Enter maximum milage: ");
      int maxMilage = int.Parse(Console.ReadLine());

      List<Car> CarsMatchingSearch = new List<Car>(0);
      foreach (Car automobile in PriseMatchingSearch)
      {
        if(automobile.CheckMilage(maxMilage))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      if(CarsMatchingSearch.Count == 0)
      {
        if(PriseMatchingSearch.Count == 0){
          Console.WriteLine("I'm sorry, looks like you don't have enough funds. Do you want to enter another number? ['Y' for yes, 'Enter' for no]");
          string finishedAnswer = Console.ReadLine();
          if (finishedAnswer == "Y" || finishedAnswer == "y")
          {
            Main();
          }
          else
          {
            Console.WriteLine("Thank you for your time!");
          }
        }
        else
        {
          Console.WriteLine("I'm sorry, looks like we don't have cars with susch milage. Do you want to enter another number? ['Y' for yes, 'Enter' for no]");
          string finishedAnswer = Console.ReadLine();
          if (finishedAnswer == "Y" || finishedAnswer == "y")
          {
            Main();
          }
          else
          {
            Console.WriteLine("Thank you for your time!");
          }
        }
      }
      else
      {
        foreach(Car automobile in CarsMatchingSearch)
        {
          Console.WriteLine("----------------------");
          Console.WriteLine(automobile.GetMakeModel());
          Console.WriteLine(automobile.GetMiles() + " miles");
          Console.WriteLine("$" + automobile.GetPrice());
        }
      }
    }
  }

}
