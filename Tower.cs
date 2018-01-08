/*
**  AUTHOR      :   Robert James Patterson
**  DATE        :   01/07/18
**  FILE        :   TreehouseDefense/Tower.cs
**  SYNOPSIS    :   Team Treehouse C# Objects course work files
**
*/
using System;

namespace TreehouseDefense
{
    class Tower
    {
        // Private member fields for the 'Tower' class 
        private readonly MapLocation _location;
        private static readonly Random _random = new Random();
      
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;  
      
        public Tower(MapLocation location)
        {
            _location = location;
        }
      
        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }
      
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit an invader!");
                        
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized and invader!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader!");
                    }
                    break;
                }
            }
          
        }
    }
}