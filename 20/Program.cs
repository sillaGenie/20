namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        delegate double Mydelegate(double r);
        public static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            Mydelegate mydelegate = Length;
            if (mydelegate != null)
            { 
                double L =mydelegate(r);
                Console.WriteLine(L);
            }
            mydelegate = Area;
            if (mydelegate != null)
            {
                double A = mydelegate(r);
                Console.WriteLine(A);
            }
            mydelegate = Volume;
            if (mydelegate != null)
            {
                double V = mydelegate(r);
                Console.WriteLine(V);
            }
        }
        static double Length (double r)
            { 
            return 2 * Math.PI * r; }
        static double Area(double r)
        {
            return Math.PI * r * r; }
        static double Volume(double r)
        {
            return Math.PI * r * r * r*4/3; }


    }
}