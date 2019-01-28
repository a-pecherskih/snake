using System;

namespace Snake
{
    public class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int width, int height, char sym)
        {
            this.mapWidth = width;
            this.mapHeight = height;
            this.sym = sym;
        }

        internal Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}