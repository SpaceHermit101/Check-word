using System;

namespace Practice_C_
{
    class Car
  {
    public string model;
    public string colour;
    public int year;

    // Create a class constructor with a parameter
    public Car(string modelName,string modelColour,int modelYear)
    {
      model = modelName;
      colour = modelColour;
      year = modelYear;
    }

    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang","red",1993);
      Console.WriteLine($"this is a {Ford.year} {Ford.model} whis has a bright {Ford.colour} colour");
      Car fiuu = new Car("fiiij","blue",1939);
      Console.WriteLine(fiuu.colour);
    }
  }
}

