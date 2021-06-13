using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте базовый класс Shape (фигура), который содержит в себе поле типа double c именем Volume и метод 
    типа double GetVolume() который должен вернуть объём фигуры.  Далее создайте классы: Pyramid  (пирамида), Cylinder (цилиндр), Ball 
    (шар), которые будут наследоваться от класса Shape, реализуйте в каждом из них метод для нахождения объёма.Создайте класс Box (ящик) 
    – он является контейнером, может содержать в себе другие фигуры.  В классе Box создайте поле типа  double с именем DrawerVolume 
    (Объем ящика), поле должно хранить в себе объём ящика.Далее в классе Box  создайте метод Аdd(), который принимает на вход объекты 
    типа Shape, и возвращает значение типа boll.В классе Box реализуйте логику для добавления новых фигуры до тех пор, пока для них 
    хватает места в Box (будем считать только объём, игнорируя форму, например, мы переливаем жидкость). Если места для добавления 
    новой фигуры не хватает, то метод должен вернуть false. */

    class Program
    {
        static void Main(string[] args)
        { 
            Shape UpcastedPyramid = new Pyramid(2,30);
            Shape Upcastedcylinder = new Cylinder(2,3);
            Shape UpcastedBall = new Ball(2);
            
            Box box = new Box(100);
            Console.WriteLine(box.Add(UpcastedPyramid));

            box.DraverVolume = 200;
            Console.WriteLine(box.Add(Upcastedcylinder));

            box.DraverVolume = 300;
            Console.WriteLine(box.Add(UpcastedBall));
            Console.ReadLine();
        }
    }
    public class Shape
    {
        public const double Pi = 3.14;
        private double areaOrRadius;
        private double volume;
        public double Volume { get; set; }
        public double AreaOrRadius { get; set; }
        public Shape(double radiusArea)
        {
            AreaOrRadius = radiusArea;
        }
        public virtual double GetVolume()
        {
            return Volume;
        }
    }
    public class Pyramid : Shape
    {
        private double height;
        public double Height { get; set; }
        
        public Pyramid(double radiusArea,double height):base(radiusArea)
        {
            Height = height;
        }
        public override double GetVolume()
        {
            double Volume = 0.33 * AreaOrRadius * Height;
            return Volume;
        }
    }
    public class Cylinder : Shape
    {
        private double height;
        public double Height { get; set; }
        public Cylinder(double radiusArea,double height):base(radiusArea)
        {
            Height = height;
        }
        public override double GetVolume()
        {
            double Volume = Pi * Math.Pow(AreaOrRadius, 2) * Height;
            return Volume;
        }
    }
    public class Ball : Shape
    {
        public Ball(double radiusArea):base(radiusArea)
        {

        }
        public override double GetVolume()
        {
            double Volume = 1.33 * Pi * Math.Pow(AreaOrRadius, 3);
            return Volume;
        }
    }
    public class Box
    {
        private double draverVolume;
        public double DraverVolume { get; set; }
        public Box(double volume)
        {
            DraverVolume = volume;
        }
        public bool Add(Shape figure)
        {
            while (DraverVolume > figure.GetVolume())
                {
                    DraverVolume = DraverVolume - figure.GetVolume();
                    Console.WriteLine("The figure can be passed into the box, {0} is lost", Math.Round(DraverVolume,2));
                    Add(figure);
                }
           return false;
            }
    }
}