namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pointA=new Point(1,2);
            Point pointB =new Point(3,4);
            pointA.DisplayMethod();


            Enums exampleEnum=new Enums();
            exampleEnum.DisplayEnums();

            Console.ReadKey();
        }
    }
}
