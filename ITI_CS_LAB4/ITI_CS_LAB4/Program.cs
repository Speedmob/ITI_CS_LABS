using ITI_CS_LAB2;

// ===================== TASK 1 =====================

Date d1 = new Date();
Date d2 = new Date(2024);
Date d3 = new Date(15, 6, 2024);

d1.DisplayDate();
d2.DisplayDate();
d3.DisplayDate();

Console.WriteLine("=======================================================");


// ===================== TASK 2 =====================

Counter c1 = new Counter();
Counter c2 = new Counter();
Counter c3 = new Counter();

Console.WriteLine("Total Objects: " + Counter.totalObjectsCreated);
Console.WriteLine("C1 ID: " + c1.instanceId);
Console.WriteLine("C2 ID: " + c2.instanceId);
Console.WriteLine("C3 ID: " + c3.instanceId);

Console.WriteLine("=======================================================");

// ===================== TASK 3 =====================

Manager mgr = new Manager(101, "Ahmed", 8000, 2000, 3);
mgr.DisplayManagerInfo();

Developer dev = new Developer(102, "Sara", 6000, "C#", "Bank system");
dev.DisplayDeveloperInfo();

Intern intern = new Intern(103, "Ali", 2000, "Cairo Univ", 100);
intern.DisplayInternInfo();

Console.WriteLine("=======================================================");

// ===================== TASK 4 =====================

Shape[] shapes = new Shape[3];
shapes[0] = new Circle(5);
shapes[1] = new Rectangle(4, 6);
shapes[2] = new Triangle(3, 4, 5);

foreach (Shape sh in shapes)
{
    Console.WriteLine("Area: " + sh.CalculateArea());
    Console.WriteLine("Perimeter: " + sh.CalculatePerimeter());
    Console.WriteLine("---");
}

Console.WriteLine("=======================================================");

// ===================== TASK 5 =====================

Animal d = new Dog();
d.MakeSound();
d.Move();

Animal c = new Cat();
c.MakeSound();
c.Move();

Animal b = new Bird();
b.MakeSound();
b.Move();

Console.WriteLine("=======================================================");

// ===================== TASK 6 =====================

IMovable car = new Car();
car.Move();
Console.WriteLine("Car Speed: " + car.GetSpeed());
car.Stop();

Robot rob = new Robot();
rob.Move();
rob.Stop();

Console.WriteLine("=======================================================");

// ===================== TASK 7 =====================

Student s = new Student();
s.Name = "Mona";

s.Age = 20; 
Console.WriteLine("Student: " + s.Name + ", Age: " + s.Age);

s.Age = 10;
Console.WriteLine("Age after invalid set: " + s.Age);

Console.WriteLine("=======================================================");

// ===================== TASK 8 =====================

SavingsAccount savings = new SavingsAccount(1, "Ahmed", 1000, 5);
savings.Deposit(500);
savings.Withdraw(1600);
savings.PrintDetails();

Console.WriteLine("---");

CheckingAccount checking = new CheckingAccount(2, "Sara", 500);
checking.Withdraw(800);
checking.PrintDetails();