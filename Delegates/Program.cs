using System;
using System.Drawing;

public class Program
{
    public static void Main(string[] args)
    {
        Point[] points = { new Point(100, 200),
                           new Point(150, 250),
                           new Point(150, 350),
                           new Point(250, 375),
                           new Point(295, 450),
        };

        Predicate<Point> predicate = FindPoints; // Chama a referência com predicate 
        Point fisrt = Array.Find(points, predicate); // Cria uma instância do Objeto Point e executa uma função Find() com as condições determinadas em predicate 

    }

    private static bool FindPoints(Point obj)
    {
        return obj.X * obj.Y > 100000;
    }

}
