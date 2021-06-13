using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson8
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте класс хвост, который содержит в себе поля длину хвоста типа int и вид хвоста типа string, 
    создать свойства доступа и конструктор пользовательский класса.Создать класс хвостатое животное, содержащий хвост, цвет(строка), 
    возраст.Определить public - производный класс собака, имеющий дополнительный параметр-кличку(строка). 
В классе собака создать метод для отображения полной информации о собаке.*/

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Red",5,"Marta");
            dog.Info();
            Console.ReadLine();
        }
    }

    public class Tail
    {
        private int tailLength;
        private string tailType;
        public int TailLength { get; set; }
        public string TailType { get; set; }
        public Tail(int length,string type)
        {
            TailLength = length;
            TailType = type;
        }
    }

    public class TailedAnimal
    {
        public Tail tail = new Tail(40, "fluffy");
        private string color;
        private int age;
        public string Color { get; set; }
        public int Age { get; set; }
    }
    public class Dog : TailedAnimal
    {
        private string name;
        public string Name { get; set; }
        public Dog(string color, int age, string name)
        {
            Color = color;
            Name = name;
            Age = age;
        }
        public void Info()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("Tail length: "+tail.TailLength);
            Console.WriteLine("Tail type: "+tail.TailType);
        }
    }
}
