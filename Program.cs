namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Point pointA=new Point(1,2);
           // Point pointB =new Point(3,4);
           // pointA.DisplayMethod();

           ////Enumerators
           // Enums exampleEnum=new Enums();
           // exampleEnum.DisplayEnums();

            DateTime time=new DateTime(2004,02,15);
            Console.WriteLine(time.Minute);

            DateTime now=DateTime.Now;
            Console.WriteLine(now);

            Console.ReadKey();
        }
    }
}
