namespace Remont_Na_Plo4ki_MVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Кода както сме го правили в 9 клас!!!
            //Console.Write("Enter N= ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Enter W= ");
            //double w=double.Parse(Console.ReadLine());
            //Console.Write("Enter L= ");
            //double l=double.Parse(Console.ReadLine());
            //Console.Write("Enter M= ");
            //int m=int.Parse(Console.ReadLine());
            //Console.Write("Enter O= ");
            //int o=int.Parse(Console.ReadLine());

            //int area = n * n;
            //int benchArea = m * o;
            //int areaToCover=area-benchArea;
            //double tilearea = w * l;
            //double tiles = areaToCover / tilearea;
            //double time=tiles*0.2;
            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Tiles needed= { tiles}");
            //Console.WriteLine($"Time needed= {time}");



            TileActionController controller = new TileActionController();
            controller.Run();




        }
    }
}
