namespace Steps
{

    public interface Ishape
    {
        int CalcSquare();
    }
    public class Rect : Ishape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalcSquare()
        {
            return Width * Height;
        }
    }
    public class Square : Ishape
    {
        public int SideLength { get; set; }
        public int CalcSquare()
        {
            return SideLength * SideLength;
        }
    }
    //public static class AreaCalculator
    //{
    //    public static int CalcSquare(Square square)
    //    {
    //        return square.Height * square.Height;
    //    }

    //    public static int CalcSquare(Rect rect)
    //    {
    //        return rect.Width * rect.Height;
    //    }
    //}
}
