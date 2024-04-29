namespace Methods
{
    internal partial class Program
    {
        public class Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void Move(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void Move(Point p)
            {
                this.x = p.x;
                this.y = p.y;
            }
        }
    }
}
