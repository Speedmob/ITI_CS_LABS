using ITI_CS_LAB6;
using System.Reflection;

// ====================== TASK 1 ======================

MathOperation operation = Calculator.Add;
double result = operation(10, 5);

operation = Calculator.Multiply;
result = operation(10, 5);

// ====================== TASK 2 ======================

operation += Calculator.Add;
operation += Calculator.Multiply;
operation += Calculator.Divide;

Console.WriteLine("\n=========");
result = operation(10, 5); // Multiply result printed twice due to adding it again after first assignment at line 7
Console.WriteLine("\n=========");
operation -= Calculator.Multiply;
result = operation(10, 5); // Only subtracts last occurence of given method, not all occurences
Console.WriteLine("\n=========");
operation -= Calculator.Add;
operation -= Calculator.Add;
operation -= Calculator.Add; // Doesn't throw an error if the method is not added to the delegate
result = operation(10, 5);
Console.WriteLine(operation.Method); // Prints last Method in the Methods added to the delegate

// ====================== TASK 3 ======================

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int[] evens = functions.FilterArray(numbers, functions.IsEven);
int[] odds = functions.FilterArray(numbers, functions.IsOdd);
int[] big = functions.FilterArray(numbers, functions.IsGreaterThan5);

Console.WriteLine("\n=========");
functions.PrintArray(evens);
functions.PrintArray(odds);
functions.PrintArray(big);

// ====================== TASK 4 ======================

NumberFilter filter = delegate (int n)
{
    return n % 2 == 0;
};

Console.WriteLine("\n=========");
Console.WriteLine(filter.Method); // Can see that the return value is Boolean (bool in C#) and param is Int32 (int in C#), but the name is auto-generated

evens = [];
int zero = 0;

evens = functions.FilterArray(numbers, 
    delegate (int n)
        {
            return n % 2 == zero; // Can access outer variables :D
        });
functions.PrintArray(evens);

// ====================== TASK 5 ======================

odds = [];

filter = n => n % 2 == zero;
Console.WriteLine("\n=========");
Console.WriteLine(filter.Method); // Exact same output as assignment above in this case

odds = functions.FilterArray(numbers,
    n => n % 2 != zero); // Can access outer variables too :D

List<int> numbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
List<int> oddsList = numbersList.FindAll(n => n % 2 != zero);

functions.PrintArray(odds);
functions.PrintArray(oddsList.ToArray());

// ====================== TASK 6 ======================

Console.WriteLine("\n=========");

List<int> numbersListToSort = new List<int> { 5, 2, 7, 10, 1, 3 };
numbersListToSort.Sort((a, b) => b - a); // b - a means that 2 (b) - 5 (a) = -3 (negative) so 5 (a) will be first then 2 (b) will be 2nd,
                                         // if it's the other way around, 5 (b) - 2 (a) = 3 (positive) so 5 (b) will be first then 2 (a) will be 2nd, 
                                         // resulting in a descending order sorting
functions.PrintArray(numbersListToSort.ToArray());

// ====================== TASK 7 ======================

TemperatureSensor sensor = new TemperatureSensor();
TemperatureMonitor monitor = new TemperatureMonitor();

sensor.TemperatureHigh += monitor.OnHighTemperature;

sensor.SetTemperature(25); // No event fired since temperature is normal (if condition not triggered)

sensor.SetTemperature(35); // Event that is hooked (OnHighTemperature) is fired since it does trigger the if condition

sensor.SetTemperature(40); // Same thing as above

Console.WriteLine("\n-- Unsubscribing Monitor --");
sensor.TemperatureHigh -= monitor.OnHighTemperature;
sensor.SetTemperature(40); // Event fires internally, but no listener receives it since it was removed above and is currently empty.

// ====================== TASK 8 ======================

Button btn = new() { buttonName = "Submit button" };
Logger log = new();
Handler handler = new();

btn.Click += handler.OnClick;
btn.Click += log.LogClick;
btn.Click += (s, n) => Console.WriteLine($"Lambda expression handling {n}");

Console.WriteLine("\n=========");
btn.performClick();


// Declarations needed for tasks above
public delegate double MathOperation(double a, double b);
public delegate bool NumberFilter(int n);


