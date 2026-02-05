using System;
using System.Collections.Generic;
using System.Text;

namespace ITI_CS_LAB2
{
    // ===================== TASK 1 =====================
    class Date
    {
        public int day, month, year;

        public Date() : this(1, 1, 1990) {}

        public Date(int year) : this(1, 1, year) {}

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void DisplayDate()
        {
            Console.WriteLine("Date: " + day + "/" + month + "/" + year);
        }
    }

    // ===================== TASK 2 =====================
    class Counter
    {
        public static int totalObjectsCreated;
        public int instanceId;

        static Counter()
        {
            totalObjectsCreated = 0;
        }

        public Counter()
        {
            totalObjectsCreated++;
            instanceId = totalObjectsCreated;
        }
    }

    // ===================== TASK 3 =====================
    class Employee
    {
        protected int id;
        protected string name;
        protected int baseSalary;

        public Employee(int id, string name, int baseSalary)
        {
            this.id = id;
            this.name = name;
            this.baseSalary = baseSalary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("ID: " + id + ", Name: " + name + ", BaseSalary: " + baseSalary);
        }

        public virtual int CalculateSalary()
        {
            return baseSalary;
        }
    }

    class Manager : Employee
    {
        private int bonus;
        private int teamSize;

        public Manager(int id, string name, int baseSalary, int bonus, int teamSize) : base(id, name, baseSalary)
        {
            this.bonus = bonus;
            this.teamSize = teamSize;
        }

        public override int CalculateSalary()
        {
            return base.CalculateSalary() + bonus;
        }

        public void DisplayManagerInfo()
        {
            DisplayInfo();
            Console.WriteLine("Bonus: " + bonus + ", Total Salary: " + CalculateSalary());
        }
    }

    class Developer : Employee
    {
        private string language;
        private string projects;

        public Developer(int id, string name, int baseSalary, string language, string projects) : base(id, name, baseSalary)
        {
            this.language = language;
            this.projects = projects;
        }

        public void DisplayDeveloperInfo()
        {
            DisplayInfo();
            Console.WriteLine("Language: " + language + ", Projects: " + projects);
        }
    }

    class Intern : Employee
    {
        private string university;
        private int duration;

        public Intern(int id, string name, int baseSalary, string university, int duration) : base(id, name, baseSalary)
        {
            this.university = university;
            this.duration = duration;
        }

        public void DisplayInternInfo()
        {
            DisplayInfo();
            Console.WriteLine("University: " + university + ", Duration: " + duration);
        }
    }

    // ===================== TASK 4 =====================
    class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual double CalculatePerimeter()
        {
            return 0;
        }
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width, height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (width + height);
        }
    }

    class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CalculatePerimeter()
        {
            return a + b + c;
        }

        public override double CalculateArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }

    // ===================== TASK 5 =====================
    abstract class Animal
    {
        public abstract void MakeSound();
        public abstract void Move();
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public override void Move()
        {
            Console.WriteLine("Running on four legs!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }

        public override void Move()
        {
            Console.WriteLine("Walking on four legs!");
        }
    }

    class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Tweet! Tweet!");
        }

        public override void Move()
        {
            Console.WriteLine("Flying with two wings!");
        }
    }

    // ===================== TASK 6 =====================
    interface IMovable
    {
        void Move();
        void Stop();
        int GetSpeed();
    }

    interface IChargeable {}

    class Car : IMovable
    {
        private int speed;

        public void Move()
        { speed = 60; }

        public void Stop()
        { speed = 0; }

        public int GetSpeed()
        { return speed; }
    }

    class Robot : IMovable, IChargeable
    {
        private int speed;

        public void Move()
        { speed = 6; }

        public void Stop()
        { speed = 0; }

        public int GetSpeed()
        { return speed; }
    }

    // ===================== TASK 7 =====================
    class Student
    {
        private int age;

        public string Name { get; set; }

        public int Id { get; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 16 && value <= 100)
                    age = value;
                else
                    Console.WriteLine("Invalid age!");
            }
        }
    }

    // ===================== TASK 8 =====================
    interface IPrintable
    {
        void PrintDetails();
    }

    interface ITransactable
    {
        void Deposit(double amount);
        void Withdraw(double amount);
    }

    abstract class Account : IPrintable, ITransactable
    {
        public int AccountNumber { get; protected set; }
        public double Balance { get; protected set; }
        public string OwnerName { get; set; }

        public Account(int accountNumber, string ownerName, double Balance)
        {
            this.AccountNumber = accountNumber;
            this.OwnerName = ownerName;
            this.Balance = Balance;
        }

        public abstract double CalculateInterest();

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine("AccNum: " + AccountNumber + ", Owner: " + OwnerName + ", Balance: " + Balance);
        }
    }

    class SavingsAccount : Account
    {
        private double interestRate;
        private double minimumBalance = 1000;

        public SavingsAccount(int accountNumber, string ownerName, double Balance, double interestRate) : base(accountNumber, ownerName, Balance)
        {
            this.interestRate = interestRate;
        }

        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= minimumBalance)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Cannot withdraw, need min balance of " + minimumBalance);
            }
        }
    }

    class CheckingAccount : Account
    {
        private double overdraftLimit = 500;
        private double freeTransactions = 0;

        public CheckingAccount(int accNum, string name, double balance) : base(accNum, name, balance){}

        public override double CalculateInterest()
        {
            return 0;
        }

        public override void Withdraw(double amount)
        {
            if (Balance + overdraftLimit >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Overdraft limit passed.");
            }
        }
    }
}
