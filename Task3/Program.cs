using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Требуется: Создать класс, представляющий учебный класс 
    ClassRoom. Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write(), void Relax(). 
    Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, 
    в зависимости от успеваемости ученика.Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 
    учеников.Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.Выведите информацию о том, как все 
    ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.*/
    class Program
    {
        static void Main(string[] args)
        {
            Pupil[] pupils = new Pupil[4];
            Pupil Iryna = new ExelentPupil("Iryna");
            Pupil Artem = new ExelentPupil("Artem");
            Pupil Vira = new GoodPupil("Vira");
            Pupil Ihor = new BadPupil("Ihor");
            pupils[0] = Iryna;
            pupils[1] = Artem;
            pupils[2] = Vira;
            pupils[3] = Ihor;
            
            Classroom classroom = new Classroom(Iryna);
            classroom.classRoomInfo(pupils);

           Console.ReadLine();
        }
    }
    public class Classroom
    {
       public Classroom(params Pupil[]pupils) { }
        public void classRoomInfo(Pupil[]pupils)
        {
            foreach (Pupil item in pupils)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Study());
                Console.WriteLine(item.Read());
                Console.WriteLine(item.Write());
                Console.WriteLine(item.Relax());
                Console.WriteLine();
            }
        }
    }
    public class Pupil
    {
        private string name;
        public string Name { get; set; }
        public Pupil(string name) { Name = name; }
        public virtual string Study() { return "Study"; }
        public virtual string Read() { return "Read"; }
        public virtual string Write() { return "Write"; }
        public virtual string Relax() { return "Relax"; }
    }
    public class ExelentPupil : Pupil
    {
        public ExelentPupil(string name) : base(name) { }
        public override string Study() { return "Excelent in study"; }
        public override string Read() { return "Excelent in reading"; }
        public override string Write() { return "Excelent in writing"; }
        public override string Relax() { return "Should have more rest"; }  
    }
    public class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name) { }
        public override string Study() { return "Good in study"; }
        public override string Read() { return "Good reading skills"; }
        public override string Write() { return "Good writting skills"; }
        public override string Relax() { return "Keep relax/study balance"; }
    }
    public class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name) { }
        public override string Study() { return "Has problems with studying"; }
        public override string Read() { return "Has problems with reading"; }
        public override string Write() { return "Has problems with writting"; }
        public override string Relax() { return "Too much relax"; }
    }
}

