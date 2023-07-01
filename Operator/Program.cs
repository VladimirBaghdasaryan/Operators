namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(16, 14);
            Point b = new Point(8, 7);

            Point c = a + b;
            c.Print();

            Point d = a - b;
            d.Print();

            Point e = a / b;
            e.Print();

            Point f = a * b;
            f.Print();

            int[] arr = { 5, 6, 7, 8, 9 };
            int[] arr1 = { 5, 6, 8, 90, 0 };


            SumArray a1 = new SumArray(arr);
            SumArray b1 = new SumArray(arr1);
            SumArray c1 = a1 + b1;

            c1.PrintArray(c1.Array);
        }
    }
}