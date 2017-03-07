// Street is an abstract class
// OneWayStreet and TwoWayStreet derive from Street
// On a OneWayStreet, it is illegal to make a U turn
// On a TwoWayStreet, a U Turn reverses the travelling direction

// Main program creates two Street child objects - one OneWay and one TwoWay
// and demonstrates what happens when you make a U Turn
// on a OneWayStreet and a TwoWayStreet

using System;
using static System.Console;
class DebugTen02
{
    static void Main()
    {
        OneWayStreet oak = new OneWayStreet("Oak Avenue", "east");
        TwoWayStreet elm = new TwoWayStreet("Elm Street", "south");
        WriteLine("On " + oak.Name + " " + oak.MakeUTurn());
        WriteLine("On " + oak.Name + " " + oak.MakeUTurn());
        WriteLine("On " + elm.Name + " " + elm.MakeUTurn());
        WriteLine("On " + elm.Name + " " + elm.MakeUTurn());
    }
}
abstract class Street
{
    protected string name;
    public string direction;
    public Street(string n, string travelDirection)
    {
        name = n;
        direction = travelDirection;
    }

    protected Street()
    {
        name = "Main";
        direction = "south";
    }

    public string Name
    {
        get
        {
            return name;
        }
    }
    public abstract string MakeUTurn();
}
class OneWayStreet : Street
{
    public OneWayStreet(string n, string travelDirection)
    {
        name = n;
        direction = travelDirection;
    }

    public override string MakeUTurn()
    {
        string temp = "U Turn is illegal! Was going and still going " + direction;
        return temp;
    }
}
class TwoWayStreet : Street
{

    public TwoWayStreet(string name, string direction) : base(name, direction)
    {
    }

    public override string MakeUTurn()
    {
        string wasGoing = direction;
        string[] directions = {"north", "south", "east", "west"};
        string[] oppDirections = {"south", "north", "west", "east"};
        for (int x = 0; x < directions.Length; ++x)
        {
            if (direction.Equals(directions[x]))
            {
                direction = oppDirections[x];
                x = directions.Length;
            }
        }


        string temp = "U Turn successful. Was going " + wasGoing +
                      ". Now going " + direction;
        return temp;
    }

    
}

