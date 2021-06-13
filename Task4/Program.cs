using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте базовый класс Person (человек), в классе создайте поле типа int с именем BirthYear (год рождения), 
    поле типа string с именем Name и поле типа string с именем Surname. Далее создайте классы Student (студент), Teacher (преподаватель).
    В классе Student добавьте поле типа string[] с именем Study Courses (изучаемые курсы), свойство (не авто свойство) для добавления(set)
    и получения(get) изучаемых курсов и метод DisplayStudyСourses() с возвращаемым значением void который будет выводить на консоль все 
    предметы, максимальное количество изучаемых курсов = 3. В классе преподаватель создать поле типа Student[] с именем StudentsArray, и 
    свойство(не авто свойство) для добавления(set) и получения(get) студентов.Создайте 5 экземпляров класса типа Student и инициализируйте
    их произвольными значениями, и 2 экземпляра класса типа Teacher, инициализируйте их произвольными значениями(для инициализации поля 
    StudentsArray используйте уже созданные экземпляры Student). Далее создайте класс PeopleInfo, в нем создайте поле типа Person[] 
    с именем PeopleArray и свойство(не авто свойство) для добавления(set) и получения(get) людей и метод который будет выводить всех 
    людей который есть в поле PeopleInfo в порядке возрастания возраста*/

    class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student(1992,"Iryna","Zaec");
            Student secondStudent = new Student(1995, "Ivan", "Levc");
            Student thirdStudent = new Student(1989, "Inna", "Omar");
            Student fourthStudent = new Student(1980, "Ihor", "Dayneko");
            Student fifthStudent = new Student(2000, "Vira", "Horbal");

            firstStudent.StudyCourses[0] = "Math";
            firstStudent.StudyCourses[1] = "English";
            firstStudent.StudyCourses[2] = "Chemistry";
            
            firstStudent.GetStudyCourses();

            Teacher firstTeacher = new Teacher(1988, "Olena", "Dmytruk");
            Teacher secondTeacher = new Teacher(1989, "Oleh", "Leta");

            firstTeacher.StudentsArray[0] = firstStudent;
            firstTeacher.StudentsArray[1] = secondStudent;
            firstTeacher.StudentsArray[2] = thirdStudent;
            firstTeacher.StudentsArray[3] = fourthStudent;
            firstTeacher.StudentsArray[4] = fifthStudent;

            secondTeacher.StudentsArray = new Student[2];
            secondTeacher.StudentsArray[0] = firstStudent;
            secondTeacher.StudentsArray[1] = secondStudent;

            Console.WriteLine();
            firstTeacher.dispalyStudents();
            Console.WriteLine();
            secondTeacher.dispalyStudents();

            PeopleInfo info = new PeopleInfo();
            info.PeopleArray[0] = firstStudent;
            info.PeopleArray[1] = secondStudent;
            info.PeopleArray[2] = thirdStudent;
            info.PeopleArray[3] = fourthStudent;
            info.PeopleArray[4] = fifthStudent;
            info.PeopleArray[5] = firstTeacher;
            info.PeopleArray[6] = secondTeacher;

            Console.WriteLine();
            info.SortedByAge();

            Console.ReadLine();
        }
    }
    public class Person
    {
        private int birthYear;
        private string name;
        private string surname;
        public int BirthYear { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(int birthYear,string name,string surname)
        {
            BirthYear = birthYear;
            Name = name;
            Surname = surname;
        }
    }
    public class Student:Person
    {
        private string[] studyCourses=new string[3];
        public string[] StudyCourses
        {
            get { return studyCourses; }
            set 
            {
                if (value.Count() < 3)
                {
                    studyCourses = value;
                }
            }
        }
        public Student(int birthYear,string name,string surname) : base(birthYear, name, surname)
        {

        }
       public void GetStudyCourses()
        {
            Console.WriteLine("The student {0} {1} studies: ",Name,Surname);
            foreach (string item in studyCourses)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Teacher:Person
    {
        private Student[] studentsArray = new Student[5];
        public Student[] StudentsArray
        {
            get { return studentsArray; }
            set
            { 
                if(value.Count() < 5)
                {
                    studentsArray = value;
                }
            }
        }
        public Teacher(int birthYear,string name,string surname) : base(birthYear, name, surname)
        {
           
        }
        public void dispalyStudents()
        {
            foreach (var item in studentsArray)
            {
                Console.WriteLine(item.Name+" "+item.Surname);
            }
        }
    }
    public class PeopleInfo
    {
        private Person[] peopleArray=new Person[7];
        public Person[] PeopleArray
        {
            get { return peopleArray; }
            set { peopleArray = value; }
        }
        public void SortedByAge()
        {
            for (int i = 0; i < peopleArray.Length-1; i++)
             {
                 for (int j = 0; j < peopleArray.Length-1; j++)
                 {
                     if (peopleArray[j].BirthYear < peopleArray[j + 1].BirthYear)
                     {
                         var holdItem = peopleArray[j];
                         peopleArray[j] = peopleArray[j + 1];
                         peopleArray[j + 1] = holdItem;
                     }
                }
             }
            foreach (var item in peopleArray)
            {
                Console.WriteLine(item.Surname+" "+item.Name+" "+item.BirthYear);
            }
        }
    }
}
