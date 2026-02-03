using ITI_CS_LAB3;
using System;
using System.Collections;
using System.ComponentModel;
using System.Text;
using System.Threading;

// ==================== TASK 1 ====================

Person p1 = new Person { FirstName = "Abdelrahim", LastName = "Elzagh", Age = 22 };

Console.WriteLine(p1.FirstName);

// ==================== TASK 2 ====================

Rectangle r =  new Rectangle {  
    Width = 10,
    Height = 10,
};
Console.WriteLine(r.toString());

// ==================== TASK 3 ====================

Gradebook grades = new Gradebook(5);

grades[0] = 3.56;
grades[1] = 7.88;

Console.WriteLine("----");
Console.WriteLine(grades[1]);
try
{
    Console.WriteLine(grades[7]);
} catch (IndexOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}

// ==================== TASK 4 ====================

Console.WriteLine("----");

Collection c = new Collection();
c[0] = "Ahmed";
c["server"] = 5;
c["port"] = 8000;

Console.WriteLine(c[0]);
Console.WriteLine(c["server"]);
Console.WriteLine(c["port"]);

// ==================== TASK 5 ====================

Console.WriteLine("----");

ArrayList cart = new ArrayList();
// Can add ANY type (not type-safe!)
cart.Add(42); // int
cart.Add("Hello"); // string
cart.Add(3.14); // double
cart.Add(DateTime.Now); // DateTime
// cart.Sort(); // Sort items
cart.Reverse(); // Reverse order
cart.Remove(42); // Remove item

Console.WriteLine(cart[1]); // 3.14 since 42 is removed

// ==================== TASK 6 ====================

Console.WriteLine("----");

var people = new List<Person>
{
    new Person { FirstName = "Abdelrahim", LastName = "Elzagh", Age = 23 },
    new Person { FirstName = "Ahmed", LastName = "Elzagh", Age = 25 },
    new Person { FirstName = "Mohmaed", LastName = "Elzagh", Age = 22 }
};

Person found = people.Find(s => s.Age > 22);
List<Person> honors = people.FindAll(s => s.Age >= 23);
people.Sort((a, b) => b.Age.CompareTo(a.Age));

// ==================== TASK 7 ====================

Console.WriteLine("----");

try
{
    double result = calc.Divide(10, 0);
}
catch (DivideByZeroException ex) // 
{
    Console.WriteLine("Cannot divide by zero!");
}
catch (FormatException ex)
{
    Console.WriteLine("Invalid number format!");
}
catch (Exception ex) // General catch - MUST be last! (due to the fact that it WILL catch any given exception regardless of type)
// so it's better for it to be last IN CASE the exception type could not be identified (not one of the top written catches), usually done for
// 1- The program to not crash due to an unhandled exception.
// 2- The exception to be logged in a log file for later maintenance.
{
    Console.WriteLine("Unknown error!");
}

// ==================== TASK 8 ====================

Console.WriteLine("----");

FileStream? fs = null;

try
{
    fs = new FileStream("C:\\Users\\oooam\\source\\repos\\ITI_CS_LAB3\\ITI_CS_LAB3\\testDataForThisLab.txt", FileMode.Open, FileAccess.Read);

    byte[] buffer = new byte[1024];
    int bytesRead = fs.Read(buffer, 0, buffer.Length);
    string text = Encoding.UTF8.GetString(buffer, 0, bytesRead);

    Console.WriteLine(text);
} catch (Exception e)
{
    Console.WriteLine(e.Message);
} finally
{
    fs?.Dispose();
}