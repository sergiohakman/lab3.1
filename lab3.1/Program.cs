using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._1
{
    internal class Program
    {
    class Person
    {
      private string name;
      private int birthYear;
      private DateTime date = DateTime.Today;

      public string Name
      {
        get { return name; }
      }

      public int BirthYear
      {
        get { return birthYear; }
        set
        {
          if (date.Year - birthYear < 16)
          {
            this.name = "Very Young";
          }
          else
          {
            this.name = this.name;
          }
        }
      }
      public Person() : this("sergio", 2004)
      {
      }
      public Person(string name, int birthYear)
      {
        this.name = name;
        this.birthYear = birthYear;
      }
      public void Age()
      {
        birthYear = date.Year - birthYear;
        Console.WriteLine(birthYear);
      }
      public void Input()
      {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Введіть ім'я:");
        this.name = Console.ReadLine();
        Console.WriteLine("Рік народження:");
        this.birthYear = Convert.ToInt32(Console.ReadLine());
      }

      public void ChangeName(string newName)
      {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        this.name = newName;
        Console.WriteLine($"Ваше ім'я було змінено на: {newName}");
      }
      public void Output()
      {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine($"Ім'я: {this.name}, Вік: {this.birthYear}");
      }
      public override string ToString()
      {
        return $"Ім'я: {this.name}, Вік: {this.birthYear}";
      }
      public static bool operator ==(Person p1, Person p2)
      {
        return (p1.name == p2.name);
      }
      public static bool operator !=(Person p1, Person p2)
      {
        return (p1.name != p2.name);
      }
    }
    static void Main(string[] args)
        {
      Person p1 = new Person("sergio", 2004);
      Person p2 = new Person("nazar", 2005);
      Person p3 = new Person("andrii", 1991);
      Person p4 = new Person("andrii", 1999);
      Person p5 = new Person("anna", 2005);
      Person p6 = new Person("roma", 1890);

      p1.Age();
      p2.Age();
      p3.Age();
      p4.Age();
      p5.Age();
      p6.Age();

      p1.Output();
      p2.Output();
      p3.Output();
      p4.Output();
      p5.Output();
      p6.Output();

      Console.WriteLine(p1 == p6);
      Console.WriteLine(p4 == p6);

      p2.ChangeName("sasha");
      p2.Output();

      Console.ReadKey();
    }
    }
}
