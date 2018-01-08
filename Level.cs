/*
**  AUTHOR      :   Robert James Patterson
**  DATE        :   01/07/18
**  FILE        :   TreehouseDefense/Level.cs
**  SYNOPSIS    :   Team Treehouse C# Objects course work files
**
*/
namespace TreehouseDefense
{
    class Level
    {
        private readonly Invader[] _invaders;
      
        public Tower[] Towers { get; set; }
      
        // Constuctor requires an array of invaders
        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }
      
        // Returns true if player wins, false is otherwise
        public bool Play()
        {
            // Run until all invaders are nutralized or an invader has reached
            // the end of the path.
            int remainingInvaders = _invaders.Length;
            
            while(remainingInvaders > 0)
            {  
                // Each tower has an oppertunity to fire on the invaders
                foreach(Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }
              
                // Count and move the invaders that are still active
                remainingInvaders = 0;
              
                foreach(Invader invader in _invaders)
                {
                    if(invader.IsActive)
                    {
                        invader.Move();
                      
                        if(invader.HasScored)
                        {
                            return false;
                        }
                        remainingInvaders++;
                    }   
                }
            }
            return true;
        }
    }
}