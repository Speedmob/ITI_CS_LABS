using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ITI_CS_LAB3
{
    internal class functions
    {

    }

    // ==================== TASK 1 ====================
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    // ==================== TASK 2 ====================
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string Color { get; set; } = "White";
        public string Unit { get; set; } = "cm";
        public int Id { get; }
        public double Area => Width * Height;

        public string toString()
        {
            return $"Width is: {Width}, Height is: {Height}, Color is: {Color}, Unit is: {Unit}, Id is: {Id}, Area is: {Area}";
        }
    }

    // ==================== TASK 3 ====================
    class Gradebook
    {
        private double[] grades;

        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < grades.Length)
                    return grades[index];
                else
                    throw new IndexOutOfRangeException("Value attempted to access is out of array's boundaries");
            }

            set
            {
                if (index >= 0 && index < grades.Length)
                    grades[index] = value;
                else
                    throw new IndexOutOfRangeException("Attempting to assign a value out of boundaries");
            }
        }

        public Gradebook(int grades)
        {
            this.grades = new double[grades];
        }
    }

    // ==================== TASK 4 ====================
    class Collection
    {
        private string[] names = new string[5];
        private int[] config = new int[5];

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < names.Length)
                    return names[index];
                else
                    throw new IndexOutOfRangeException("Value attempted to access is out of array's boundaries");
            }

            set
            {
                if (index >= 0 && index < names.Length)
                    names[index] = value;
                else
                    throw new IndexOutOfRangeException("Attempting to assign a value out of boundaries");
            }
        }

        public int this[string index]
        {
            get
            {
                switch ((index).ToLower())
                {
                    case "server":
                        return config[0];
                    case "port":
                        return config[1];
                    default:
                        throw new IndexOutOfRangeException("Value attempted to access is out of array's boundaries");
                }
            }

            set
            {
                switch (index)
                {
                    case "server":
                        config[0] = value;
                        break;
                    case "port":
                        config[1] = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Attempting to assign a value out of boundaries");
                }
            }
        }
    }

    // ==================== TASK 7 ====================
    static class calc
    {
        public static int Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Second value cannot be zero");

            return 0;
        }
    }

}
