/*
**  AUTHOR      :   Robert James Patterson
**  DATE        :   01/07/18
**  FILE        :   TreehouseDefense/Exceptions.cs
**  SYNOPSIS    :   Team Treehouse C# Objects course work files
**
*/
namespace TreehouseDefense
{
    class TreehouseDefenseException : System.Exception
    {   
        // Default Constructor
        public TreehouseDefenseException()
        {
        
        }
      
        // Constructor that takes a string (and passes it to the base class)
        public TreehouseDefenseException(string message) : base(message)
        {
            
        }
    }
  
    class OutOfBoundsException : TreehouseDefenseException
    {
        // Default Constructor
        public OutOfBoundsException()
        {
        
        }
      
        // Constructor that takes a string (and passes it to the base class)
        public OutOfBoundsException(string message) : base(message)
        {
            
        }
    }
}