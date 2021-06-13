using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask1
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
   Создайте программу, в которой создайте класс Car (машина) который содержит в себе полями с название, цвет, цена, const полем 
    CompanyName. Создать два конструктора – по умолчанию и с параметрами.Создать свойство доступа к полю цвет. Определить методы 
    Input () - для ввода данных о машине с консоли , Print () - для вывода данных о машине на консоль и ChangePrice (double x) -
    для изменения цены на х%. Ввести данные о 3 авто.Уменьшить их цену на 10%, вывести данные об авто. Ввести новый цвет и покрасить 
    авто с цветом white в указанный цвет.*/

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Yaris","Black",7000);
            Car car2 = new Car("Сamry","Red",7500);
            Car car3 = new Car("Corolla","White",8000);
            car1.Print();
            car2.Print();
            car3.Print();
            car3.Color = "Blue";
            
            car1.ChangePrice(-10);
            car2.ChangePrice(-10);
            car3.ChangePrice(-10);
           
            car1.Print();
            car2.Print();
            car3.Print();
            
            Console.ReadLine();
        }
    }
    public class Car
    {
        private const string companyName = "Toyota";
        private string name;
        private string color;
        private double cost;
        public string Name { get; set; }
        public string CompanyName { get { return companyName; } }
        public string Color { get; set; }
        public double Cost { get;  set ;  }
        public Car() { }
        public Car(string name,string color,double cost) {Color = color; Cost = cost; Name = name; }
        public void Input()
        {
            Console.Write("Choose car name: ");
            Name = Console.ReadLine();
            Console.Write("Choose car color: ");
            Color = Console.ReadLine();
            Console.Write("Choose car price: ");
            Cost = double.Parse(Console.ReadLine());
        }
        public double ChangePrice(double interest)
        {
            Cost = interest / 100 * Cost + Cost;
            return Cost;
        }
        public void Print()
        {
            Console.WriteLine(CompanyName+": "+Name);
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("Price: "+Cost);
            Console.WriteLine();
        }
    }
}
