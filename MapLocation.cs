/*
**  AUTHOR      :   Robert James Patterson
**  DATE        :   01/07/18
**  FILE        :   TreehouseDefense/MapLocation.cs
**  SYNOPSIS    :   Team Treehouse C# Objects course work files
**
*/
namespace TreehouseDefense
{
    class MapLocation : Point
    {
        // MapLocation() constructor
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if(!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + " is outside the boundries of the map.");
            }
        }
        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}