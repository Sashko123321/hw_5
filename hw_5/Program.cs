namespace hw_5;
internal class Program
{
    static void Main(string[] args)
    {
        Figure circle = new Circle(5d);
        Figure rec = new Rectangle(5d, 5d);
        Figure tri = new Triangle(5d, 5d, 5d);

        Figure[] figure = new Figure[] { circle, rec, tri };
        for (int i = 0; i < figure.Length; i++) {
            Console.WriteLine($"=========> { figure[i]} <========= ");
            Console.WriteLine($"Area: {figure[i].GetArea()}");
            Console.WriteLine($"Perimeter: {figure[i].GetPerimeter()}");
            Console.WriteLine();

        }
    }
}
