namespace TreehouseDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;
      
        // This is the constructor for the Map() class
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
      
        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width && point.Y >=0 && point.Y < Height; 
        }
    }
}