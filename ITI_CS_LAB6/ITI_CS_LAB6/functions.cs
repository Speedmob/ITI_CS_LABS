using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ITI_CS_LAB6
{
    internal class functions
    {
        public delegate bool IntFilter(int value);

        public static int[] FilterArray(int[] array, IntFilter filter)
        {
            int[] filteredArr = array.Where(num => filter(num)).ToArray();
            return filteredArr;
        }
        public static void PrintArray(int[] array)
        {
            Console.Write("{");
            foreach (int i in array)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("end}");
        }

        public static bool IsEven(int a) => a % 2 == 0;
        public static bool IsOdd(int a) => a % 2 != 0;
        public static bool IsGreaterThan5(int a) => a > 5;
    }

    static class Calculator
    {
        public static double Add(double a, double b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
        public static double Divide(double a, double b)
        {
            Console.WriteLine(a / b);
            return a / b;
        }
        public static double Multiply(double a, double b)
        {
            Console.WriteLine(a * b);
            return a * b;
        }
    }

    public delegate void TemperatureHandler(string message, double temperature);
    public class TemperatureSensor
    {
        public event TemperatureHandler TemperatureHigh;

        public void SetTemperature(double temp)
        {
            Console.WriteLine($"Current Temperature: {temp}°C");

            if (temp > 30)
            {
                if (TemperatureHigh != null)
                {
                    TemperatureHigh("Warning! High Heat Detected.", temp);
                }
            }
        }
    }
    public class TemperatureMonitor
    {
        public void OnHighTemperature(string msg, double temp)
        {
            Console.WriteLine($"Alert: {temp}°C - {msg}");
        }
    }

    public delegate void ClickHandler(Object sender, string buttonName);
    public class Button
    {
        public event ClickHandler Click;
        public string buttonName { get; set; }
        
        public Button (string buttonName)
        {
            this.buttonName = buttonName;
        }
        public Button()
        {
            buttonName = "Default";
        }

        public void performClick()
        {
            if (Click != null)
                Click(this, buttonName);
        }
    }
    public class Handler
    {
        public void OnClick(object sender, string name)
        {
            Console.WriteLine($"Button clicked by {name}");
        }
    }
    public class Logger
    {
        public void LogClick (object sender, string name)
        {
            Console.WriteLine($"Logging button click by {name}");
        }
    }
}
