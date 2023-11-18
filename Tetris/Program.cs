using System;

namespace Tetris
{

    class Point
    {
    
        private int x;
        private int y;
        private char c;

        public Point(int x, int y, char c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine(c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 40);
            Console.SetBufferSize(30, 40);


            Point p1 = new Point(7, 3, '*');
            p1.Draw();

            Console.WriteLine("Hello World!");
        }
    }
}
