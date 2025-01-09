using Dz_Tumak_9;
using System;
using System.Net.Http.Headers;
namespace Tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            Upr_10_1();
            Dz_10_1();
        }
        static void Upr_10_1()
        {
            string input = "Привет мир";
            ACipher stroka1 = new ACipher();
            BCipher stroka2 = new BCipher();
            string encoded1 = stroka1.encode(input);
            string encoded2 = stroka2.encode(input);
            Console.WriteLine(encoded1);
            Console.WriteLine(encoded2);
            string decoded1 = stroka1.decode(encoded1);
            string decoded2 = stroka2.decode(encoded2);
            Console.WriteLine(decoded1);
            Console.WriteLine(decoded2);
        }
        static void Dz_10_1()
        {
            Console.WriteLine("\nТочка:\n");
            Point point = new Point("Синий", true, 15, 12);
            point.Display();
            point.MoveHorizontally(3);
            point.MoveVertically(-2);
            point.Display();
            Console.WriteLine("\nОкружность\n");
            Circle circle = new Circle(12, "Красный", false, 3, 4);
            circle.Display();
            circle.ChangeVisibility(true);
            circle.MoveVertically(10);
            circle.ChangeColour("Фиолетовый");
            circle.Display();
            Console.WriteLine("\nПрямоугольник\n");
            Rectangle rectangle = new Rectangle(7, 8, "Зелёный", true, 5, 9);
            rectangle.Display();
            rectangle.MoveHorizontally(69);
            rectangle.ChangeColour("Розовый");
            rectangle.Display();
        }
    }
}