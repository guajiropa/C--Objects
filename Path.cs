/*
**  AUTHOR      :   Robert James Patterson
**  DATE        :   01/07/18
**  FILE        :   TreehouseDefense/Path.cs
**  SYNOPSIS    :   Team Treehouse C# Objects course work files
**
*/
namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;
        
        public int Length => _path.Length;
        
        public Path(MapLocation[] path)
        {
            _path = path;
        }
      
        public MapLocation GetLocationAt(int pathStep)
        {
            // Ternary 'if . . . else' to verify pathStep is not IndexOutOfBounds
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
        
    }
}