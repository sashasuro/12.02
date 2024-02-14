using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Employee
    {

        private string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Surname
        {
            get { return Surname; }
            set { Surname = value; }
        }
        private DateTime Bday;

        private double P //минимальная зарплата
        {
            get { return P; }
            set { P = value; }
        }
        //public Employee()
        //{
        //    Name = "";
        //    Surname = "";
        //    Bday = new DateTime();
        //    P = 0;
        //}
        public Employee(string Name, string Surname, DateTime Bday, double P)
        {
            Name = "Андрей";
            Surname = "Владимирович";
            Bday = new DateTime(1900, 1, 1);
            P = 1000;
        }
        public double Coeff(double k) //повышающий коэффициент
        {
            return P * k;
        }

        public void Info()
        {
            Console.WriteLine($"Имя/Фамилия: {Name} {Surname}\tДата рождения: {Bday.ToShortDateString()}\tМинимальная зарплата: {P}");
        }

        class Program
        {
            static void Main()
            {
                Employee[] employees = new Employee[5];
                employees[0] = new Employee("Александр", "Воронов", new DateTime(1980, 5, 10), 2000);
                employees[1] = new Employee("Демьян", "Ратинский", new DateTime(1990, 9, 15), 1800);
                employees[2] = new Employee("Владислав", "Кушнёв", new DateTime(1975, 3, 25), 2200);
                employees[3] = new Employee("Поликарп", "Медников", new DateTime(1985, 7, 5), 1900);
                employees[4] = new Employee("Егения", "Тченко", new DateTime(1995, 11, 20), 2100);

                foreach (Employee emp in employees)
                {
                    emp.Info();
                    Console.WriteLine($"Income: {emp.Coeff(1.2)}");
                }
                Console.ReadKey();
            }
        }
    }
}    
