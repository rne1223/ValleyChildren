using System;

namespace CHET
{
    public enum Direction
    {
        UP, DOWN, LEFT, RIGHT
    }
    
    //Class to get a random Direction UP,DOWN,LEFT,RIGHT
    public static class RandomDirection 
    {
        private static Direction PrevDirection;
        private static Direction NewDirection;
        private static Random rnd = new Random();

        public static Direction GetDirection ()
        {
            NewDirection = (Direction) rnd.Next(Enum.GetNames(typeof(Direction)).Length);

            while(NewDirection == PrevDirection)
            {
                NewDirection = (Direction) rnd.Next(Enum.GetNames(typeof(Direction)).Length);
            }

            PrevDirection = NewDirection;
            return NewDirection;
        }
    }
}
