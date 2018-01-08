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