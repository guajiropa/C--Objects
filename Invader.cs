/*
**  AUTHOR      :   Robert James Patterson
**  DATE        :   01/07/18
**  FILE        :   TreehouseDefense/Invader.cs
**  SYNOPSIS    :   Team Treehouse C# Objects course work files
**
*/
namespace TreehouseDefense
{
    class Invader
    {
        // Private member fields
        private readonly Path _path;
        private int _pathStep = 0;
        
        // Computed property 
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        
        // Invader object's health (initilized to 2)
        public int Health { get; private set; } = 2;
        
        // Invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }
      
        // Invader has used up their hitpoints
        public bool IsNeutralized => Health <= 0;  
      
        // Invader is active
        public bool IsActive => !(IsNeutralized || HasScored);
      
        // Invader consturctor  
        public Invader(Path path) { _path = path; } 
        
        // Method to advance the Invader one path step 
        public void Move() => _pathStep += 1;
        
        // Method to decrease the Invader's health
        public void DecreaseHealth(int value) => Health -= value;
            
    }
}